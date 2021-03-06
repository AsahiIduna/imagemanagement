﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Text.RegularExpressions;

using CefSharp;
using CefSharp.WinForms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ImageManagement
{
    /// <summary>
    /// Main Form
    /// </summary>
    /// <todo>
    /// + Disable everything that should not be enabled if no project is opened
    /// + Make Visible that a project is opened
    /// ++ Add Form for Characters
    /// ++ Add Edit Page For Tags and Characters
    /// ++ Complete the TODO list (Find More Bugs)
    /// </todo>
    public partial class Form1 : Form
    {
        bool debug = false;
        bool ProjectOpened = false;
        string ProjectPath = "";
        string ProjectDataPath = "";

        List<string> ImportingFileNames;

        JObject Project;

        IMImage SelectedImage;

        Dictionary<string, IMImage> Images = new Dictionary<string, IMImage>();
        Dictionary<string, IMTag> Tags = new Dictionary<string, IMTag>();
        Dictionary<string, IMCharacter> Characters = new Dictionary<string, IMCharacter>();


        Dictionary<string, string> localPaths = new Dictionary<string, string>()
        {
            { "imjson", Environment.CurrentDirectory + "\\Data\\Presets\\imjson.json" },
            { "help", Environment.CurrentDirectory + "\\Data\\HelpEN\\help.html" }
        };

        ChromiumWebBrowser Previewer;

        public Form1()
        {
            Cef.Initialize();
            InitializeComponent();

            Previewer = new ChromiumWebBrowser("about:blank");
            Previewer.Dock = DockStyle.Fill;

            PreviewTabPage.Controls.Add(Previewer);

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1Closing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        public void Log(string text)
        {
            if (debug)
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        debugLog.Text += text;
                    }));
                    return;
                }
                debugLog.Text += text;
            }
        }

        private void ShowHelp()
        {
            var HelpForm = new HelpForm(Helper.PathToUrl(localPaths["help"]));
            HelpForm.Show();
        }

        private void CreateNew()
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "ImageManagement JSON File (*.im.json)|*.im.json|All Files (*.*)|*.*";
            var result = sfd.ShowDialog();
            var path = "";
            switch (result)
            {
                default:
                    break;
                case DialogResult.OK:
                    path = sfd.FileName;
                    break;
                case DialogResult.Yes:
                    goto case DialogResult.OK;
            }

            if (path != "" && !File.Exists(path))
            {
                var s = File.CreateText(path);
                s.WriteLine(File.ReadAllText(localPaths["imjson"]));
                s.Close();
            }
            else
            {
                if (path != "")
                {
                    var msgresult = MessageBox.Show("The File you want to create already exists. \nDou you want to overwrite it?", "File Exists", MessageBoxButtons.YesNoCancel);
                    switch (msgresult)
                    {
                        default:
                            break;
                        case DialogResult.Yes:
                            File.WriteAllText(path, File.ReadAllText(localPaths["imjson"]));
                            break;
                    }
                }
            }

            var npl = path.Split('\\').ToList();
            npl.RemoveAt(npl.Count - 1);
            var np = Helper.StrArrayToStr(npl, "\\") + "\\" + path.Split('\\').Last().Replace(".im.json", "");

            Directory.CreateDirectory(np);
            Directory.CreateDirectory(np + "\\thumb");

            ProjectOpened = true;
            ProjectPath = path;
            ProjectDataPath = np;
            Project = JObject.Parse(File.ReadAllText(ProjectPath));
        }

        private void ReopenThis()
        {
            if (ProjectOpened)
            {
                Images = new Dictionary<string, IMImage>();
                Tags = new Dictionary<string, IMTag>();
                Characters = new Dictionary<string, IMCharacter>();
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        LVImages.Items.Clear();
                        LVTags.Items.Clear();
                        LVCharacters.Items.Clear();
                    }));
                }
                ProjectOpened = true;
                Project = JObject.Parse(File.ReadAllText(ProjectPath));
                LoadProject();
            }
        }

        private void Open()
        {


            var of = new OpenFileDialog();
            of.Filter = "ImageManager JSON files (*.im.json)|*.im.json";
            of.Multiselect = false;
            var res = of.ShowDialog();
            switch (res)
            {
                default:
                    break;
                case DialogResult.OK:
                    Images = new Dictionary<string, IMImage>();
                    Tags = new Dictionary<string, IMTag>();
                    Characters = new Dictionary<string, IMCharacter>();
                    LVImages.Items.Clear();
                    LVTags.Items.Clear();
                    LVCharacters.Items.Clear();
                    ProjectOpened = true;
                    ProjectPath = of.FileName;
                    var npl = of.FileName.Split('\\').ToList();
                    npl.RemoveAt(npl.Count - 1);
                    var np = Helper.StrArrayToStr(npl, "\\") + "\\" + ProjectPath.Split('\\').Last().Replace(".im.json", "");
                    Project = JObject.Parse(File.ReadAllText(ProjectPath));
                    ProjectDataPath = np;

                    new Thread(LoadProject).Start();

                    break;
                case DialogResult.Yes:
                    goto case DialogResult.OK;
            }
        }

        private void LoadProject()
        {
            var JImages = Project["Images"] as JArray;
            var JTags = (Project["Tags"]).Children();
            var JCharacters = (Project["Characters"]).Children();
            var max = JImages.Count();
            var LVImagesCollection = new List<ListViewItem>();
            var LVTagsCollection = new List<ListViewItem>();
            var LVCharactersCollection = new List<ListViewItem>();
            var LVSmallImageList = new ImageList()
            {
                ImageSize = new Size(32, 32),
            };
            var LVLargeImageList = new ImageList()
            {
                ImageSize = new Size(80, 80)
            };
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate
                {
                    statusLabel.Text = "Loading Images: (0/" + max + ")";
                    statusProgressBar.Maximum = max;
                    statusProgressBar.Minimum = 1;
                }));
            }
            var somecounter = 1;
            foreach (var v in JImages)
            {
                var newImg = IMImage.FromJObject(v as JObject, ProjectDataPath);
                Images.Add(newImg.Path.Split('\\').Last(), newImg);
                LVImagesCollection.Add(Images.Last().Value.ToListViewItem());
                var p = Images.Last().Value.Path.Split('\\').Last();
                var thumbpath = ProjectDataPath + "\\thumb\\" + Helper.StrArrayToStr((from x in p.Split('.').ToList() where x != p.Split('.').Last() select x).ToList(), ".") + ".png";
                Image img;
                if (!File.Exists(thumbpath))
                {
                    img = Image.FromFile(Images.Last().Value.Path);
                    double factor = (double)img.Width / (double)img.Height;
                    img = img.GetThumbnailImage((int)Math.Truncate(Convert.ToDecimal(100 * factor)), 100, () => false, IntPtr.Zero);
                    img.Save(thumbpath);
                } else
                {
                    img = Image.FromFile(thumbpath);
                }
                LVSmallImageList.Images.Add(p, img);
                LVLargeImageList.Images.Add(p, img);
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        statusLabel.Text = "Loading Images: (" + somecounter + "/" + max + ")";
                        statusProgressBar.Value = somecounter;
                    }));
                }

                somecounter++;


            }
            if (JTags.Count() > 0)
            {
                max = JTags.Count();
                if(InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        statusProgressBar.Maximum = max;
                    }));
                }
                var counter = 1;
                foreach (var v in JTags)
                {
                    var x = JObject.Parse("{" + v.ToString() + "}");
                    var current = counter;
                    if (InvokeRequired)
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            statusLabel.Text = "Loading Tags: (" + current + "/" + max + ")";
                            statusProgressBar.Value = current;
                        }));
                    }
                    counter++;
                    Tags.Add((v as JProperty).Name, IMTag.FromJObject(x, (v as JProperty).Name));
                    LVTagsCollection.Add(Tags.Last().Value.ToListViewItem());
                }
            }
            if (JCharacters.Count() > 0)
            {
                var counter = 1;
                max = JCharacters.Count();
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        statusProgressBar.Maximum = max;
                    }));
                }
                foreach (var v in JCharacters)
                {
                    var x = JObject.Parse("{" + v.ToString() + "}");
                    var current = counter;
                    if (InvokeRequired)
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            statusLabel.Text = "Loading Characters: (" + current + "/" + max + ")";
                            statusProgressBar.Value = current;
                        }));
                    }
                    counter++;
                    Characters.Add((v as JProperty).Name, IMCharacter.FromJObject(x, (v as JProperty).Name));
                    LVCharactersCollection.Add(Characters.Last().Value.ToListViewItem());
                }
            }
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate
                {
                    statusLabel.Text = "Building Lists ...";

                    LVImages.SmallImageList = LVSmallImageList;
                    LVImages.LargeImageList = LVLargeImageList;
                    var counter = 1;
                    var buildmax = LVImagesCollection.Count();
                    foreach (var v in LVImagesCollection)
                    {
                        LVImages.Items.Add(v);
                        statusLabel.Text = "Building Images List (" + counter + " / " + buildmax + ")";
                        counter++;
                    }
                    counter = 1;
                    buildmax = LVTagsCollection.Count();
                    foreach (var v in LVTagsCollection)
                    {
                        LVTags.Items.Add(v);
                        statusLabel.Text = "Building Tags List (" + counter + " / " + buildmax + ")";
                        counter++;
                    }
                    counter = 1;
                    buildmax = LVCharactersCollection.Count();
                    foreach (var v in LVCharactersCollection)
                    {
                        LVCharacters.Items.Add(v);
                        statusLabel.Text = "Building Characters List (" + counter + " / " + buildmax + ")";
                        counter++;
                    }
                    UpdateEditLists();
                    statusLabel.Text = "Done Loading";
                }));
            }
        }

        private void ImportImages()
        {
            var result = DialogResult.Cancel;
            var of = new OpenFileDialog();
            of.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            of.Multiselect = true;
            result = of.ShowDialog();

            switch (result)
            {
                default:
                    break;
                case DialogResult.OK:
                    ImportingFileNames = of.FileNames.ToList();
                    new Thread(ImportImagesSeperately).Start();
                    break;
                case DialogResult.Yes:
                    goto case DialogResult.OK;
            }
        }

        private void ImportImagesSeperately()
        {
            var counter = 1;
            var max = ImportingFileNames.Count;
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    statusProgressBar.Minimum = 1;
                    statusProgressBar.Value = 1;
                    statusProgressBar.Maximum = max;
                }));
            }
            foreach (var f in ImportingFileNames)
            {
                var projectPath = ProjectDataPath + "\\" + f.Split('\\').Last();
                if (!File.Exists(projectPath))
                {
                    File.Copy(f, projectPath);
                }
                else
                {
                    /*var msres = MessageBox.Show("The File " + f.Split('\\').Last() + " already exists in " + ProjectDataPath + ". \nDo you wish to replace it", "File already exists", MessageBoxButtons.YesNo);
                    switch(msres)
                    {
                        case DialogResult.Yes:
                            File.Replace(f, ProjectDataPath + "\\" + f.Split('\\').Last(), ProjectDataPath + "\\##backup" + f.Split('\\').Last());
                            break;
                        case DialogResult.No:
                            break;
                    }*/
                }
                var img = Image.FromFile(projectPath);
                var imimage = new IMImage()
                {
                    Path = projectPath,
                    Width = img.Width,
                    Height = img.Height,

                };

                try
                {
                    Images.Add(imimage.Path.Split('\\').Last(), imimage);
                    (Project["Images"] as JArray).Add(imimage.ToJObject(ProjectDataPath));
                } catch (Exception ex)
                {
                    Console.WriteLine(ex + "\n\n" + ex.StackTrace);
                }
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        statusProgressBar.Value = counter;
                        statusLabel.Text = "Importing (" + counter + " / " + max + ") [" + f + "]";
                    }));
                }
                counter++;

            }
            File.WriteAllText(ProjectPath, Project.ToString());
            new Thread(ReopenThis).Start();
        }

        private void UpdateProject()
        {
            try
            {
                foreach (var t in Tags)
                {
                    if (Project["Tags"][t.Key] == null)
                    {
                        (Project["Tags"] as JObject).Add(t.Key, t.Value.ToJObject());
                    }
                    else
                    {
                        Project["Tags"][t.Key] = t.Value.ToJObject();
                    }
                }
                foreach (var c in Characters)
                {
                    if (Project["Characters"][c.Key] == null)
                    {
                        (Project["Characters"] as JObject).Add(c.Key, c.Value.ToJObject());
                    }
                    else
                    {
                        Project["Characters"][c.Key] = c.Value.ToJObject();
                    }
                }
                var jArr = Project["Images"] as JArray;
                var addList = new List<JObject>();
                Log("Saving images\n");
                foreach(var i in Images)
                {
                    Log(i.Key + ": ");
                    var matches = (from x in jArr where (x as JObject)["path"].ToString().Split('/').Last() == i.Key select x);
                    Log(matches.Count() + " Matches Found");
                    if(matches.Count() <= 0)
                    {
                        addList.Add(i.Value.ToJObject(ProjectDataPath));
                        Log(" -- Queueing to add -- " + addList.Count() + " already queued\n"); 
                    } else if(matches.Count() == 1)
                    {
                        var x = jArr.IndexOf(matches.First());
                        jArr[x] = i.Value.ToJObject(ProjectDataPath);
                        Log(" -- Modified \n");
                    }
                }
                foreach(var v in addList)
                {
                    jArr.Add(v);
                    Log("Added " + v["path"].ToString() + "\n");
                }
                Log("jArr is: \n " + jArr.ToString() + "\n");
            } catch (Exception ex)
            {
                Log(ex.Message + "\n\n" + ex.StackTrace);
                Console.WriteLine(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void Save()
        {
            UpdateProject();
            File.WriteAllText(ProjectPath, Project.ToString());
        }

        private string BuildTitle()
        {
            return string.Format("Image Manager @[{0}] --> {1}", (ProjectOpened) ? ProjectPath : "no project opened", (SelectedImage != null) ? SelectedImage.Path.Split('\\').Last() : "none selected");
        }

        private void UpdateEditLists()
        {
            try
            {
                if (SelectedImage != null) {
                    var clb = editImageTagsCheckedListBox;
                    clb.Items.Clear();
                    foreach (var v in Tags)
                    {
                        clb.Items.Add(v.Key, SelectedImage.Tags.Contains(v.Key));
                    }
                    clb = editImageCharactersCheckedListBox;
                    clb.Items.Clear();
                    foreach (var v in Characters)
                    {
                        clb.Items.Add(v.Key, SelectedImage.Characters.Contains(v.Key));
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void UpdateSelectedImage()
        {
            if (SelectedImage != null) {
                var res = (from img in Images where img.Key == SelectedImage.Path.Split('\\').Last() select img).First();
                res = new KeyValuePair<string, IMImage>(res.Key, SelectedImage);
                foreach(var v in LVImages.Items)
                {
                    if((v as ListViewItem).Text == res.Key)
                    {
                        LVImages.Items.Remove(v as ListViewItem);
                        LVImages.Items.Add(res.Value.ToListViewItem());
                        return;
                    }
                }
            }
        }

        private void fileHelpMSI_Click(object sender, EventArgs e)
        {
            ShowHelp();
            Text = BuildTitle();
        }

        private void fileNewMSI_Click(object sender, EventArgs e)
        {
            CreateNew();
            Text = BuildTitle();
        }

        private void imagesImportMSI_Click(object sender, EventArgs e)
        {
            ImportImages();
            Text = BuildTitle();
        }

        private void fileSaveMSI_Click(object sender, EventArgs e)
        {
            Save();
            Text = BuildTitle();
        }

        private void fileOpenMSI_Click(object sender, EventArgs e)
        {
            Open();
            Text = BuildTitle();
        }

        private void LVImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (sender as ListView).SelectedItems;
            try
            {
                string key = "";
                foreach (var v in s) {
                    //i = (sender as ListView).Items.IndexOf(v as ListViewItem);
                    key = (v as ListViewItem).Text;
                }
                Console.WriteLine("##### \"" + key + "\"");
                SelectedImage = Images[key];
                Text = BuildTitle();
                if(tabControl2.SelectedIndex == 0) Previewer.Load(Helper.PathToUrl(SelectedImage.Path));
                editImagePictureBox.Image = Image.FromFile(SelectedImage.Path);
                editImagePathTextBox.Text = SelectedImage.Path;
                editImageAliasTextBox.Text = SelectedImage.Alias;

                UpdateEditLists();

                if(SelectedImage != null)
                {
                    foreach(var i in editImageTagsCheckedListBox.Items)
                    {
                        editImageTagsCheckedListBox.SetItemChecked(editImageTagsCheckedListBox.Items.IndexOf(i), SelectedImage.Tags.Contains(i.ToString()));
                    }
                    foreach (var i in editImageCharactersCheckedListBox.Items)
                    {
                        editImageCharactersCheckedListBox.SetItemChecked(editImageCharactersCheckedListBox.Items.IndexOf(i), SelectedImage.Characters.Contains(i.ToString()));
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void editImageCharactersFilterTextBox_TextChanged(object sender, EventArgs e)
        {

            var clb = editImageCharactersCheckedListBox;
            UpdateEditLists();
            try
            {
                var mismatcheditems = new List<object>();
                foreach (var i in clb.Items)
                {
                    var matches = Regex.Matches(i as string, (sender as TextBox).Text);
                    if (matches.Count <= 0)
                    {
                        mismatcheditems.Add(i);
                    }
                }
                foreach (var i in mismatcheditems)
                {
                    clb.Items.Remove(i);
                }
                (sender as TextBox).BackColor = Color.FromArgb(255, 0, 186, 255);
                (sender as TextBox).ForeColor = Color.FromArgb(255, 40, 56, 60);
            }
            catch (ArgumentException)
            {
                (sender as TextBox).BackColor = Color.FromArgb(255, 255, 0, 0);
                (sender as TextBox).ForeColor = Color.FromArgb(255, 255, 255, 255);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void editImageTagsCheckedListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (SelectedImage != null)
            {
                var clb = (sender as CheckedListBox);
                foreach (var i in clb.Items)
                {
                    var index = clb.Items.IndexOf(i);
                    if (clb.GetItemChecked(index))
                    {
                        if (!SelectedImage.Tags.Contains(i))
                        {
                            SelectedImage.Tags.Add(i as string);
                        }
                    }
                    else
                    {
                        if (SelectedImage.Tags.Contains(i))
                        {
                            SelectedImage.Tags.Remove(i as string);
                        }
                    }
                }
            }
            UpdateSelectedImage();
        }

        private void editImageAliasTextBox_TextChanged(object sender, EventArgs e)
        {
            if(SelectedImage != null)
            {
                SelectedImage.Alias = (sender as TextBox).Text;
            }
            UpdateSelectedImage();
        }

        private void LVImagesContextViewLargeIcon_Click(object sender, EventArgs e)
        {
            LVImages.View = View.LargeIcon;
        }

        private void LVImagesContextViewSnallIcon_Click(object sender, EventArgs e)
        {
            LVImages.View = View.SmallIcon;
        }

        private void LVImagesContextViewTile_Click(object sender, EventArgs e)
        {
            LVImages.View = View.Tile;
        }

        private void LVImagesContextViewList_Click(object sender, EventArgs e)
        {
            LVImages.View = View.List;
        }

        private void LVImagesContextViewDetail_Click(object sender, EventArgs e)
        {
            LVImages.View = View.Details;
        }

        private void LVTagsContextAdd_Click(object sender, EventArgs e)
        {
            var dialog = new TagForm();
            dialog.FormClosed += new FormClosedEventHandler(AddTagClosed);
            dialog.ShowDialog();
        }

        private void AddTagClosed(object sender, FormClosedEventArgs e)
        {
            var s = (sender as TagForm);
            switch (s.dialogResult)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.OK:
                    Tags.Add(s.result.Key, s.result);
                    LVTags.Items.Add(s.result.ToListViewItem());
                    UpdateEditLists();
                    break;
            }
        }

        private void editImageTagsFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var clb = editImageTagsCheckedListBox;
            UpdateEditLists();
            try
            {
                var mismatcheditems = new List<object>();
                foreach (var i in clb.Items) {
                    var matches = Regex.Matches(i as string, (sender as TextBox).Text);
                    if(matches.Count <= 0)
                    {
                        mismatcheditems.Add(i);
                    }
                }
                foreach (var i in mismatcheditems)
                {
                    clb.Items.Remove(i);
                }
                (sender as TextBox).BackColor = Color.FromArgb(255, 0, 186, 255);
                (sender as TextBox).ForeColor = Color.FromArgb(255, 40, 56, 60);
            }
            catch (ArgumentException)
            {
                (sender as TextBox).BackColor = Color.FromArgb(255, 255, 0, 0);
                (sender as TextBox).ForeColor = Color.FromArgb(255, 255, 255, 255);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void editImageCharactersCheckedListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (SelectedImage != null) {
                var clb = (sender as CheckedListBox);
                foreach (var i in clb.CheckedItems)
                {
                    var index = clb.Items.IndexOf(i);
                    if (clb.GetItemChecked(index))
                    {
                        if (!SelectedImage.Characters.Contains(i))
                        {
                            SelectedImage.Characters.Add(i as string);
                        }
                    } else
                    {
                        if (SelectedImage.Characters.Contains(i))
                        {
                            SelectedImage.Characters.Remove(i as string);
                        }
                    }
                }
            }
        }

        private void ProjectCodeEditorReloadBtn_Click(object sender, EventArgs e)
        {
            UpdateProject();
            ProjectCodeEditor.Text = Project.ToString();
        }

        private void ProjectCodeEditorSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Project = JObject.Parse(ProjectCodeEditor.Text);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Occured");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ProjectCodeEditor.Select(ProjectCodeEditor.Text.IndexOf(ProjectCodeEditorSearch.Text), ProjectCodeEditorSearch.Text.Length);
            }
            catch { }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = sender as TabControl;
            if(s.SelectedIndex == 3)
            {
                UpdateProject();
                ProjectCodeEditor.Text = Project.ToString();
            }
        }

        private void LVCharactersContextAdd_Click(object sender, EventArgs e)
        {
            var dialog = new CharacterForm();
            dialog.FormClosed += new FormClosedEventHandler(AddCharacterClosed);
            dialog.ShowDialog();
        }

        private void AddCharacterClosed(object sender, FormClosedEventArgs e)
        {
            var s = (sender as CharacterForm);
            switch (s.dialogResult)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.OK:
                    Characters.Add(s.result.Key, s.result);
                    LVCharacters.Items.Add(s.result.ToListViewItem());
                    UpdateEditLists();
                    break;
            }
        }
    }

    public class IMImage
    {
        public string Path = "";
        public string Alias = "";
        public List<string> Tags = new List<string>();
        public List<string> Characters = new List<string>();
        public int Width;
        public int Height;

        public IMImage()
        {
        }

        public static IMImage FromJObject(JObject obj, string basePath)
        {
            var x = basePath.Split('\\').ToList();
            x.Remove(x.Last());
            basePath = Helper.StrArrayToStr(x, "\\");
            var res = new IMImage()
            {
                Path = basePath + "\\" + obj["path"].ToString().Replace("\\", "/").Replace("./", "").Replace("/", "\\"),
                Alias = obj["alias"].ToString(),
                Tags = (from o in obj["tags"].Values() select o.ToString()).ToList(),
                Characters = (from o in obj["characters"].Values() select o.ToString()).ToList(),
                Width = Convert.ToInt32(obj["width"].ToString()),
                Height = Convert.ToInt32(obj["height"].ToString()),
            };
            return res;
        }

        public JObject ToJObject(string basePath)
        {
            var json = "{\"path\": \"" +
                "./" + basePath.Split('\\').Last() + "/" + Path.Split('\\').Last() +
                "\", \"alias\": \"" +
                Alias +
                "\", \"tags\": [" + ((Tags.Count() > 0) ? "\"" : "") + Helper.StrArrayToStr(Tags, "\", \"") + ((Tags.Count() > 0) ? "\"" : "") +
                "], \"characters\": [" + ((Characters.Count() > 0) ? "\"" : "") + Helper.StrArrayToStr(Characters, "\", \"") + ((Characters.Count() > 0) ? "\"" : "") +
                "], \"width\": " + Width +
                ", \"height\": " + Height + "}";
            return JObject.Parse(json);
        }

        public ListViewItem ToListViewItem()
        {
            var lvi = new ListViewItem(new string[] {
                Path.Split('\\').Last(),
                Alias,
                Helper.StrArrayToStr(Tags, ", "),
                Helper.StrArrayToStr(Characters, ", "),
            });
            lvi.ToolTipText = string.Format("{0} | {1} \n\nSize: {2} x {3}\nTags: [\n\t{4}\n]\nCharacters: [\n\t{5}\n]", Path.Split('\\').Last(), Alias, Width, Height, Helper.StrArrayToStr(Tags, ",\n\t"), Helper.StrArrayToStr(Characters, ",\n\t"));
            lvi.ImageKey = Path.Split('\\').Last();

            return lvi;
        }
    }

    public class IMTag
    {
        public string Key = "";
        public List<string> Synonyms = new List<string>();
        public string Description = "";

        public IMTag()
        {

        }

        public static IMTag FromJObject(JObject obj, string key)
        {
            var res = new IMTag()
            {
                Key = key,
                Synonyms = (from o in obj[key]["synonyms"].Values() select o.ToString()).ToList(),
                Description = obj[key]["description"].ToString()
            };
            return res;
        }

        public JObject ToJObject()
        {
            var res = "{" +
                    "\"synonyms\": [" + ((Synonyms.Count > 0) ? "\"" : "") + Helper.StrArrayToStr(Synonyms, "\", \"") + ((Synonyms.Count > 0) ? "\"" : "") + "]," +
                    "\"description\": \"" + Description + "\"" + 
                "}";
            return JObject.Parse(res);
        }

        public ListViewItem ToListViewItem()
        {
            var res = new ListViewItem(new string[] { Key, Helper.StrArrayToStr(Synonyms, ", "), Description });
            res.ToolTipText = string.Format("{0} ({1})\n\n{2}", Key, Helper.StrArrayToStr(Synonyms, ", "), Description);
            return res;
        }
    }

    public class IMCharacter
    {
        public string Key = "";
        public string Name = "";
        public List<string> Aliases = new List<string>();
        public string Gender = "";
        public string Description = "";
        public int Age = 0;

        public IMCharacter()
        {

        }

        public static IMCharacter FromJObject(JObject obj, string key)
        {
            var res = new IMCharacter()
            {
                Key = key,
                Name = obj[key]["name"].ToString(),
                Aliases = (from o in obj[key]["aliases"].Values() select o.ToString()).ToList(),
                Gender = obj[key]["gender"].ToString(),
                Description = obj[key]["description"].ToString(),
                Age = Convert.ToInt32(obj[key]["age"].ToString())
            };
            return res;
        }

        public JObject ToJObject()
        {
            var res = "{" +
                    "\"name\": \"" + Name + "\"," +
                    "\"aliases\": [" + ((Aliases.Count > 0) ? "\"" : "") + Helper.StrArrayToStr(Aliases, "\", \"") + ((Aliases.Count > 0) ? "\"" : "") + "]," +
                    "\"gender\": \"" + Gender + "\"," +
                    "\"description\": \"" + Description + "\"," +
                    "\"age\": \"" + Age + "\"" +
                "}";
            return JObject.Parse(res);
        }

        public ListViewItem ToListViewItem()
        {
            var res = new ListViewItem(new string[] { Key, Name, Helper.StrArrayToStr(Aliases, ", "), Gender, Description, Age.ToString() });
            res.ToolTipText = string.Format("{0} ({4}) aka: {1}\nGender: {2}\n\n{3}", Name, Helper.StrArrayToStr(Aliases, ", "), Gender, Description, Age);
            return res;
        }
    }

    public class HelpForm : Form
    {
        public HelpForm(string HelpFileLocation)
        {
            ChromiumWebBrowser Browser = new ChromiumWebBrowser("file:///" + Environment.CurrentDirectory.Replace("\\", "/") + "\\Data\\HelpEN\\help.html");

            Browser.Dock = DockStyle.Fill;
            Browser.Name = "Browser";
            Browser.Tag = "Browser";

            Controls.Add(Browser);
            Width = 1260;
            Height = 720;
            StartPosition = FormStartPosition.CenterScreen;

            FormClosing += new FormClosingEventHandler(HelpFormClosing);
        }

        public void HelpFormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }

    public abstract class Helper
    {
        public static string PathToUrl(string Path)
        {
            return "file:///" + Path.Replace("\\", "/");
        }

        public static string StrArrayToStr(string[] array, string joinChar)
        {
            var res = "";
            foreach (var s in array)
            {
                res += s + ((s != array.Last()) ? joinChar : "");
            }
            return res;
        }

        public static string StrArrayToStr(List<string> list, string joinChar)
        {
            return StrArrayToStr(list.ToArray(), joinChar);
        }
    }
}
