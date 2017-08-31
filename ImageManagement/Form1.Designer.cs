namespace ImageManagement
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Path", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Alias", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Tags", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup16 = new System.Windows.Forms.ListViewGroup("Characters", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Key", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Synonyms", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Description", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Key", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Name", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Aliases", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Gender", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup17 = new System.Windows.Forms.ListViewGroup("Age", System.Windows.Forms.HorizontalAlignment.Left);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNewMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpenMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileSaveMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveAsMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileHelpMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.imagesMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.imagesImportMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.imagesExportMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabImages = new System.Windows.Forms.TabPage();
            this.LVImages = new System.Windows.Forms.ListView();
            this.LVImagesColumnPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVImagesColumnAlias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVImagesColumnTags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVImagesColumnCharacters = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVImagesContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LVImagesContextRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LVImagesContextView = new System.Windows.Forms.ToolStripMenuItem();
            this.LVImagesContextViewLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.LVImagesContextViewSnallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.LVImagesContextViewTile = new System.Windows.Forms.ToolStripMenuItem();
            this.LVImagesContextViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.LVImagesContextViewDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.TabTags = new System.Windows.Forms.TabPage();
            this.LVTags = new System.Windows.Forms.ListView();
            this.LVTagsHeaderKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVTagsHeaderSynonyms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVTagsHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVTagsContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LVTagsContextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.LVTagsContextRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.TabCharacters = new System.Windows.Forms.TabPage();
            this.LVCharacters = new System.Windows.Forms.ListView();
            this.LVCharactersColumnKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVCharactersColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVCharactersColumnAliases = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVCharactersColumnGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVCharactersColumnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVCharactersColumnAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.PreviewTabPage = new System.Windows.Forms.TabPage();
            this.TabPageEditImage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.editImagePictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.editImageTagsGroupBox = new System.Windows.Forms.GroupBox();
            this.editImageTagsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.editImageTagsFilterLabel = new System.Windows.Forms.Label();
            this.editImageTagsFilterTextBox = new System.Windows.Forms.TextBox();
            this.editImageCharactersGroupBox = new System.Windows.Forms.GroupBox();
            this.editImageCharactersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.editImageCharactersFilterLabel = new System.Windows.Forms.Label();
            this.editImageCharactersFilterTextBox = new System.Windows.Forms.TextBox();
            this.editImageApplyButton = new System.Windows.Forms.Button();
            this.editImageAliasTextBox = new System.Windows.Forms.TextBox();
            this.editImagePathTextBox = new System.Windows.Forms.TextBox();
            this.editImageAliasLabel = new System.Windows.Forms.Label();
            this.editImagePathLabel = new System.Windows.Forms.Label();
            this.TabPageEditTags = new System.Windows.Forms.TabPage();
            this.TabPageEditCharacters = new System.Windows.Forms.TabPage();
            this.MainContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabImages.SuspendLayout();
            this.LVImagesContext.SuspendLayout();
            this.TabTags.SuspendLayout();
            this.LVTagsContext.SuspendLayout();
            this.TabCharacters.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.TabPageEditImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.editImageTagsGroupBox.SuspendLayout();
            this.editImageCharactersGroupBox.SuspendLayout();
            this.MainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMSI,
            this.imagesMSI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMSI
            // 
            this.fileMSI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNewMSI,
            this.fileOpenMSI,
            this.toolStripSeparator1,
            this.fileSaveMSI,
            this.fileSaveAsMSI,
            this.toolStripSeparator2,
            this.fileHelpMSI});
            this.fileMSI.Name = "fileMSI";
            this.fileMSI.Size = new System.Drawing.Size(37, 20);
            this.fileMSI.Text = "File";
            // 
            // fileNewMSI
            // 
            this.fileNewMSI.Name = "fileNewMSI";
            this.fileNewMSI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileNewMSI.Size = new System.Drawing.Size(239, 22);
            this.fileNewMSI.Text = "New";
            this.fileNewMSI.Click += new System.EventHandler(this.fileNewMSI_Click);
            // 
            // fileOpenMSI
            // 
            this.fileOpenMSI.Name = "fileOpenMSI";
            this.fileOpenMSI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileOpenMSI.Size = new System.Drawing.Size(239, 22);
            this.fileOpenMSI.Text = "Open";
            this.fileOpenMSI.Click += new System.EventHandler(this.fileOpenMSI_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(236, 6);
            // 
            // fileSaveMSI
            // 
            this.fileSaveMSI.Name = "fileSaveMSI";
            this.fileSaveMSI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileSaveMSI.Size = new System.Drawing.Size(239, 22);
            this.fileSaveMSI.Text = "Save";
            this.fileSaveMSI.Click += new System.EventHandler(this.fileSaveMSI_Click);
            // 
            // fileSaveAsMSI
            // 
            this.fileSaveAsMSI.Name = "fileSaveAsMSI";
            this.fileSaveAsMSI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.fileSaveAsMSI.Size = new System.Drawing.Size(239, 22);
            this.fileSaveAsMSI.Text = "Save As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(236, 6);
            // 
            // fileHelpMSI
            // 
            this.fileHelpMSI.Name = "fileHelpMSI";
            this.fileHelpMSI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.fileHelpMSI.Size = new System.Drawing.Size(239, 22);
            this.fileHelpMSI.Text = "Help";
            this.fileHelpMSI.Click += new System.EventHandler(this.fileHelpMSI_Click);
            // 
            // imagesMSI
            // 
            this.imagesMSI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagesImportMSI,
            this.imagesExportMSI});
            this.imagesMSI.Name = "imagesMSI";
            this.imagesMSI.Size = new System.Drawing.Size(57, 20);
            this.imagesMSI.Text = "Images";
            // 
            // imagesImportMSI
            // 
            this.imagesImportMSI.Name = "imagesImportMSI";
            this.imagesImportMSI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.imagesImportMSI.Size = new System.Drawing.Size(146, 22);
            this.imagesImportMSI.Text = "Import";
            this.imagesImportMSI.Click += new System.EventHandler(this.imagesImportMSI_Click);
            // 
            // imagesExportMSI
            // 
            this.imagesExportMSI.Name = "imagesExportMSI";
            this.imagesExportMSI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.imagesExportMSI.Size = new System.Drawing.Size(146, 22);
            this.imagesExportMSI.Text = "Export";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgressBar,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1076, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(72, 17);
            this.statusLabel.Text = "Status: Clear";
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1076, 478);
            this.splitContainer1.SplitterDistance = 447;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.TabImages);
            this.tabControl1.Controls.Add(this.TabTags);
            this.tabControl1.Controls.Add(this.TabCharacters);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(447, 478);
            this.tabControl1.TabIndex = 3;
            // 
            // TabImages
            // 
            this.TabImages.Controls.Add(this.LVImages);
            this.TabImages.Location = new System.Drawing.Point(4, 4);
            this.TabImages.Name = "TabImages";
            this.TabImages.Padding = new System.Windows.Forms.Padding(3);
            this.TabImages.Size = new System.Drawing.Size(439, 452);
            this.TabImages.TabIndex = 1;
            this.TabImages.Text = "Images";
            this.TabImages.UseVisualStyleBackColor = true;
            // 
            // LVImages
            // 
            this.LVImages.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.LVImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVImagesColumnPath,
            this.LVImagesColumnAlias,
            this.LVImagesColumnTags,
            this.LVImagesColumnCharacters});
            this.LVImages.ContextMenuStrip = this.LVImagesContext;
            this.LVImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVImages.FullRowSelect = true;
            this.LVImages.GridLines = true;
            listViewGroup13.Header = "Path";
            listViewGroup13.Name = "LVImagesGroupPath";
            listViewGroup13.Tag = "LVImagesPath";
            listViewGroup14.Header = "Alias";
            listViewGroup14.Name = "LVImagesGroupAlias";
            listViewGroup14.Tag = "LVImagesAlias";
            listViewGroup15.Header = "Tags";
            listViewGroup15.Name = "LVImagesGroupTags";
            listViewGroup15.Tag = "LVImagesTags";
            listViewGroup16.Header = "Characters";
            listViewGroup16.Name = "LVImagesGroupCharacters";
            listViewGroup16.Tag = "LVImagesCharacters";
            this.LVImages.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup13,
            listViewGroup14,
            listViewGroup15,
            listViewGroup16});
            this.LVImages.Location = new System.Drawing.Point(3, 3);
            this.LVImages.MultiSelect = false;
            this.LVImages.Name = "LVImages";
            this.LVImages.ShowItemToolTips = true;
            this.LVImages.Size = new System.Drawing.Size(433, 446);
            this.LVImages.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LVImages.TabIndex = 1;
            this.LVImages.UseCompatibleStateImageBehavior = false;
            this.LVImages.View = System.Windows.Forms.View.Tile;
            this.LVImages.SelectedIndexChanged += new System.EventHandler(this.LVImages_SelectedIndexChanged);
            // 
            // LVImagesColumnPath
            // 
            this.LVImagesColumnPath.Text = "Path";
            this.LVImagesColumnPath.Width = 180;
            // 
            // LVImagesColumnAlias
            // 
            this.LVImagesColumnAlias.Text = "Alias";
            // 
            // LVImagesColumnTags
            // 
            this.LVImagesColumnTags.Text = "Tags";
            // 
            // LVImagesColumnCharacters
            // 
            this.LVImagesColumnCharacters.Text = "Characters";
            this.LVImagesColumnCharacters.Width = 120;
            // 
            // LVImagesContext
            // 
            this.LVImagesContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LVImagesContextRemove,
            this.toolStripSeparator3,
            this.LVImagesContextView});
            this.LVImagesContext.Name = "LVImagesContext";
            this.LVImagesContext.Size = new System.Drawing.Size(146, 54);
            // 
            // LVImagesContextRemove
            // 
            this.LVImagesContextRemove.Name = "LVImagesContextRemove";
            this.LVImagesContextRemove.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.LVImagesContextRemove.Size = new System.Drawing.Size(145, 22);
            this.LVImagesContextRemove.Text = "Remove";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(142, 6);
            // 
            // LVImagesContextView
            // 
            this.LVImagesContextView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LVImagesContextViewLargeIcon,
            this.LVImagesContextViewSnallIcon,
            this.LVImagesContextViewTile,
            this.LVImagesContextViewList,
            this.LVImagesContextViewDetail});
            this.LVImagesContextView.Name = "LVImagesContextView";
            this.LVImagesContextView.Size = new System.Drawing.Size(145, 22);
            this.LVImagesContextView.Text = "View";
            // 
            // LVImagesContextViewLargeIcon
            // 
            this.LVImagesContextViewLargeIcon.Name = "LVImagesContextViewLargeIcon";
            this.LVImagesContextViewLargeIcon.Size = new System.Drawing.Size(129, 22);
            this.LVImagesContextViewLargeIcon.Text = "Large Icon";
            this.LVImagesContextViewLargeIcon.Click += new System.EventHandler(this.LVImagesContextViewLargeIcon_Click);
            // 
            // LVImagesContextViewSnallIcon
            // 
            this.LVImagesContextViewSnallIcon.Name = "LVImagesContextViewSnallIcon";
            this.LVImagesContextViewSnallIcon.Size = new System.Drawing.Size(129, 22);
            this.LVImagesContextViewSnallIcon.Text = "Small Icon";
            this.LVImagesContextViewSnallIcon.Click += new System.EventHandler(this.LVImagesContextViewSnallIcon_Click);
            // 
            // LVImagesContextViewTile
            // 
            this.LVImagesContextViewTile.Name = "LVImagesContextViewTile";
            this.LVImagesContextViewTile.Size = new System.Drawing.Size(129, 22);
            this.LVImagesContextViewTile.Text = "Tile";
            this.LVImagesContextViewTile.Click += new System.EventHandler(this.LVImagesContextViewTile_Click);
            // 
            // LVImagesContextViewList
            // 
            this.LVImagesContextViewList.Name = "LVImagesContextViewList";
            this.LVImagesContextViewList.Size = new System.Drawing.Size(129, 22);
            this.LVImagesContextViewList.Text = "List";
            this.LVImagesContextViewList.Click += new System.EventHandler(this.LVImagesContextViewList_Click);
            // 
            // LVImagesContextViewDetail
            // 
            this.LVImagesContextViewDetail.Name = "LVImagesContextViewDetail";
            this.LVImagesContextViewDetail.Size = new System.Drawing.Size(129, 22);
            this.LVImagesContextViewDetail.Text = "Detail";
            this.LVImagesContextViewDetail.Click += new System.EventHandler(this.LVImagesContextViewDetail_Click);
            // 
            // TabTags
            // 
            this.TabTags.Controls.Add(this.LVTags);
            this.TabTags.Location = new System.Drawing.Point(4, 4);
            this.TabTags.Name = "TabTags";
            this.TabTags.Size = new System.Drawing.Size(439, 452);
            this.TabTags.TabIndex = 2;
            this.TabTags.Text = "Tags";
            this.TabTags.UseVisualStyleBackColor = true;
            // 
            // LVTags
            // 
            this.LVTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVTags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVTagsHeaderKey,
            this.LVTagsHeaderSynonyms,
            this.LVTagsHeaderDescription});
            this.LVTags.ContextMenuStrip = this.LVTagsContext;
            this.LVTags.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Key";
            listViewGroup1.Name = "LVTagsGroupKey";
            listViewGroup1.Tag = "LVTagsKey";
            listViewGroup2.Header = "Synonyms";
            listViewGroup2.Name = "LVTagsGroupSynonyms";
            listViewGroup2.Tag = "LVTagsSynonyms";
            listViewGroup3.Header = "Description";
            listViewGroup3.Name = "LVTagsGroupDescription";
            listViewGroup3.Tag = "LVTagsDescription";
            this.LVTags.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.LVTags.Location = new System.Drawing.Point(0, 0);
            this.LVTags.Name = "LVTags";
            this.LVTags.Size = new System.Drawing.Size(439, 452);
            this.LVTags.TabIndex = 0;
            this.LVTags.UseCompatibleStateImageBehavior = false;
            this.LVTags.View = System.Windows.Forms.View.Details;
            // 
            // LVTagsHeaderKey
            // 
            this.LVTagsHeaderKey.Text = "Key";
            // 
            // LVTagsHeaderSynonyms
            // 
            this.LVTagsHeaderSynonyms.Text = "Synonyms";
            // 
            // LVTagsHeaderDescription
            // 
            this.LVTagsHeaderDescription.Text = "Description";
            // 
            // LVTagsContext
            // 
            this.LVTagsContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LVTagsContextAdd,
            this.LVTagsContextRemove});
            this.LVTagsContext.Name = "LVTagsContext";
            this.LVTagsContext.Size = new System.Drawing.Size(146, 48);
            // 
            // LVTagsContextAdd
            // 
            this.LVTagsContextAdd.Name = "LVTagsContextAdd";
            this.LVTagsContextAdd.Size = new System.Drawing.Size(145, 22);
            this.LVTagsContextAdd.Text = "Add";
            this.LVTagsContextAdd.Click += new System.EventHandler(this.LVTagsContextAdd_Click);
            // 
            // LVTagsContextRemove
            // 
            this.LVTagsContextRemove.Name = "LVTagsContextRemove";
            this.LVTagsContextRemove.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.LVTagsContextRemove.Size = new System.Drawing.Size(145, 22);
            this.LVTagsContextRemove.Text = "Remove";
            // 
            // TabCharacters
            // 
            this.TabCharacters.Controls.Add(this.LVCharacters);
            this.TabCharacters.Location = new System.Drawing.Point(4, 4);
            this.TabCharacters.Name = "TabCharacters";
            this.TabCharacters.Size = new System.Drawing.Size(439, 452);
            this.TabCharacters.TabIndex = 3;
            this.TabCharacters.Text = "Characters";
            this.TabCharacters.UseVisualStyleBackColor = true;
            // 
            // LVCharacters
            // 
            this.LVCharacters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVCharacters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVCharactersColumnKey,
            this.LVCharactersColumnName,
            this.LVCharactersColumnAliases,
            this.LVCharactersColumnGender,
            this.LVCharactersColumnDescription,
            this.LVCharactersColumnAge});
            this.LVCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup4.Header = "Key";
            listViewGroup4.Name = "LVCharactersGroupKey";
            listViewGroup4.Tag = "LVCharactersKey";
            listViewGroup5.Header = "Name";
            listViewGroup5.Name = "LVCharactersGroupName";
            listViewGroup5.Tag = "LVCharactersName";
            listViewGroup6.Header = "Aliases";
            listViewGroup6.Name = "LVCharactersGroupAliases";
            listViewGroup6.Tag = "LVCharactersAliases";
            listViewGroup7.Header = "Gender";
            listViewGroup7.Name = "LVCharactersGroupGender";
            listViewGroup7.Tag = "LVCharactersGender";
            listViewGroup17.Header = "Age";
            listViewGroup17.Name = "LVCharactersGroupAge";
            listViewGroup17.Tag = "LVCharactersAge";
            this.LVCharacters.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup17});
            this.LVCharacters.Location = new System.Drawing.Point(0, 0);
            this.LVCharacters.Name = "LVCharacters";
            this.LVCharacters.Size = new System.Drawing.Size(439, 452);
            this.LVCharacters.TabIndex = 0;
            this.LVCharacters.UseCompatibleStateImageBehavior = false;
            this.LVCharacters.View = System.Windows.Forms.View.Details;
            // 
            // LVCharactersColumnKey
            // 
            this.LVCharactersColumnKey.Text = "Key";
            // 
            // LVCharactersColumnName
            // 
            this.LVCharactersColumnName.Text = "Name";
            // 
            // LVCharactersColumnAliases
            // 
            this.LVCharactersColumnAliases.Text = "Aliases";
            // 
            // LVCharactersColumnGender
            // 
            this.LVCharactersColumnGender.Text = "Gender";
            // 
            // LVCharactersColumnAge
            // 
            this.LVCharactersColumnAge.Text = "Age";
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl2.Controls.Add(this.PreviewTabPage);
            this.tabControl2.Controls.Add(this.TabPageEditImage);
            this.tabControl2.Controls.Add(this.TabPageEditTags);
            this.tabControl2.Controls.Add(this.TabPageEditCharacters);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(625, 478);
            this.tabControl2.TabIndex = 0;
            // 
            // PreviewTabPage
            // 
            this.PreviewTabPage.Location = new System.Drawing.Point(4, 4);
            this.PreviewTabPage.Name = "PreviewTabPage";
            this.PreviewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PreviewTabPage.Size = new System.Drawing.Size(617, 452);
            this.PreviewTabPage.TabIndex = 0;
            this.PreviewTabPage.Text = "Preview";
            this.PreviewTabPage.UseVisualStyleBackColor = true;
            // 
            // TabPageEditImage
            // 
            this.TabPageEditImage.Controls.Add(this.splitContainer2);
            this.TabPageEditImage.Location = new System.Drawing.Point(4, 4);
            this.TabPageEditImage.Name = "TabPageEditImage";
            this.TabPageEditImage.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageEditImage.Size = new System.Drawing.Size(617, 452);
            this.TabPageEditImage.TabIndex = 1;
            this.TabPageEditImage.Text = "Edit Image";
            this.TabPageEditImage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.editImagePictureBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.Controls.Add(this.editImageApplyButton);
            this.splitContainer2.Panel2.Controls.Add(this.editImageAliasTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.editImagePathTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.editImageAliasLabel);
            this.splitContainer2.Panel2.Controls.Add(this.editImagePathLabel);
            this.splitContainer2.Size = new System.Drawing.Size(611, 446);
            this.splitContainer2.SplitterDistance = 233;
            this.splitContainer2.TabIndex = 0;
            // 
            // editImagePictureBox
            // 
            this.editImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editImagePictureBox.Location = new System.Drawing.Point(0, 0);
            this.editImagePictureBox.Name = "editImagePictureBox";
            this.editImagePictureBox.Size = new System.Drawing.Size(233, 446);
            this.editImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editImagePictureBox.TabIndex = 0;
            this.editImagePictureBox.TabStop = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(7, 56);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.editImageTagsGroupBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.editImageCharactersGroupBox);
            this.splitContainer3.Size = new System.Drawing.Size(362, 350);
            this.splitContainer3.SplitterDistance = 175;
            this.splitContainer3.TabIndex = 8;
            // 
            // editImageTagsGroupBox
            // 
            this.editImageTagsGroupBox.Controls.Add(this.editImageTagsCheckedListBox);
            this.editImageTagsGroupBox.Controls.Add(this.editImageTagsFilterLabel);
            this.editImageTagsGroupBox.Controls.Add(this.editImageTagsFilterTextBox);
            this.editImageTagsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editImageTagsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.editImageTagsGroupBox.Name = "editImageTagsGroupBox";
            this.editImageTagsGroupBox.Size = new System.Drawing.Size(362, 175);
            this.editImageTagsGroupBox.TabIndex = 5;
            this.editImageTagsGroupBox.TabStop = false;
            this.editImageTagsGroupBox.Text = "Tags";
            // 
            // editImageTagsCheckedListBox
            // 
            this.editImageTagsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editImageTagsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editImageTagsCheckedListBox.FormattingEnabled = true;
            this.editImageTagsCheckedListBox.Location = new System.Drawing.Point(9, 45);
            this.editImageTagsCheckedListBox.Name = "editImageTagsCheckedListBox";
            this.editImageTagsCheckedListBox.Size = new System.Drawing.Size(347, 120);
            this.editImageTagsCheckedListBox.TabIndex = 2;
            this.editImageTagsCheckedListBox.SelectedValueChanged += new System.EventHandler(this.editImageTagsCheckedListBox_SelectedValueChanged);
            // 
            // editImageTagsFilterLabel
            // 
            this.editImageTagsFilterLabel.AutoSize = true;
            this.editImageTagsFilterLabel.Location = new System.Drawing.Point(6, 22);
            this.editImageTagsFilterLabel.Name = "editImageTagsFilterLabel";
            this.editImageTagsFilterLabel.Size = new System.Drawing.Size(29, 13);
            this.editImageTagsFilterLabel.TabIndex = 1;
            this.editImageTagsFilterLabel.Text = "Filter";
            // 
            // editImageTagsFilterTextBox
            // 
            this.editImageTagsFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editImageTagsFilterTextBox.Location = new System.Drawing.Point(49, 19);
            this.editImageTagsFilterTextBox.Name = "editImageTagsFilterTextBox";
            this.editImageTagsFilterTextBox.Size = new System.Drawing.Size(307, 20);
            this.editImageTagsFilterTextBox.TabIndex = 0;
            this.editImageTagsFilterTextBox.TextChanged += new System.EventHandler(this.editImageTagsFilterTextBox_TextChanged);
            // 
            // editImageCharactersGroupBox
            // 
            this.editImageCharactersGroupBox.Controls.Add(this.editImageCharactersCheckedListBox);
            this.editImageCharactersGroupBox.Controls.Add(this.editImageCharactersFilterLabel);
            this.editImageCharactersGroupBox.Controls.Add(this.editImageCharactersFilterTextBox);
            this.editImageCharactersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editImageCharactersGroupBox.Location = new System.Drawing.Point(0, 0);
            this.editImageCharactersGroupBox.Name = "editImageCharactersGroupBox";
            this.editImageCharactersGroupBox.Size = new System.Drawing.Size(362, 171);
            this.editImageCharactersGroupBox.TabIndex = 7;
            this.editImageCharactersGroupBox.TabStop = false;
            this.editImageCharactersGroupBox.Text = "Characters";
            // 
            // editImageCharactersCheckedListBox
            // 
            this.editImageCharactersCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editImageCharactersCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editImageCharactersCheckedListBox.FormattingEnabled = true;
            this.editImageCharactersCheckedListBox.Location = new System.Drawing.Point(9, 45);
            this.editImageCharactersCheckedListBox.Name = "editImageCharactersCheckedListBox";
            this.editImageCharactersCheckedListBox.Size = new System.Drawing.Size(347, 105);
            this.editImageCharactersCheckedListBox.TabIndex = 2;
            this.editImageCharactersCheckedListBox.SelectedValueChanged += new System.EventHandler(this.editImageCharactersCheckedListBox_SelectedValueChanged);
            // 
            // editImageCharactersFilterLabel
            // 
            this.editImageCharactersFilterLabel.AutoSize = true;
            this.editImageCharactersFilterLabel.Location = new System.Drawing.Point(6, 22);
            this.editImageCharactersFilterLabel.Name = "editImageCharactersFilterLabel";
            this.editImageCharactersFilterLabel.Size = new System.Drawing.Size(29, 13);
            this.editImageCharactersFilterLabel.TabIndex = 1;
            this.editImageCharactersFilterLabel.Text = "Filter";
            // 
            // editImageCharactersFilterTextBox
            // 
            this.editImageCharactersFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editImageCharactersFilterTextBox.Location = new System.Drawing.Point(49, 19);
            this.editImageCharactersFilterTextBox.Name = "editImageCharactersFilterTextBox";
            this.editImageCharactersFilterTextBox.Size = new System.Drawing.Size(307, 20);
            this.editImageCharactersFilterTextBox.TabIndex = 0;
            this.editImageCharactersFilterTextBox.TextChanged += new System.EventHandler(this.editImageCharactersFilterTextBox_TextChanged);
            // 
            // editImageApplyButton
            // 
            this.editImageApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editImageApplyButton.Location = new System.Drawing.Point(294, 412);
            this.editImageApplyButton.Name = "editImageApplyButton";
            this.editImageApplyButton.Size = new System.Drawing.Size(75, 31);
            this.editImageApplyButton.TabIndex = 7;
            this.editImageApplyButton.Text = "Apply";
            this.editImageApplyButton.UseVisualStyleBackColor = true;
            // 
            // editImageAliasTextBox
            // 
            this.editImageAliasTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editImageAliasTextBox.Location = new System.Drawing.Point(56, 30);
            this.editImageAliasTextBox.Name = "editImageAliasTextBox";
            this.editImageAliasTextBox.Size = new System.Drawing.Size(313, 20);
            this.editImageAliasTextBox.TabIndex = 3;
            this.editImageAliasTextBox.TextChanged += new System.EventHandler(this.editImageAliasTextBox_TextChanged);
            // 
            // editImagePathTextBox
            // 
            this.editImagePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editImagePathTextBox.Location = new System.Drawing.Point(56, 4);
            this.editImagePathTextBox.Name = "editImagePathTextBox";
            this.editImagePathTextBox.ReadOnly = true;
            this.editImagePathTextBox.Size = new System.Drawing.Size(313, 20);
            this.editImagePathTextBox.TabIndex = 2;
            // 
            // editImageAliasLabel
            // 
            this.editImageAliasLabel.AutoSize = true;
            this.editImageAliasLabel.Location = new System.Drawing.Point(4, 33);
            this.editImageAliasLabel.Name = "editImageAliasLabel";
            this.editImageAliasLabel.Size = new System.Drawing.Size(29, 13);
            this.editImageAliasLabel.TabIndex = 1;
            this.editImageAliasLabel.Text = "Alias";
            // 
            // editImagePathLabel
            // 
            this.editImagePathLabel.AutoSize = true;
            this.editImagePathLabel.Location = new System.Drawing.Point(2, 7);
            this.editImagePathLabel.Name = "editImagePathLabel";
            this.editImagePathLabel.Size = new System.Drawing.Size(29, 13);
            this.editImagePathLabel.TabIndex = 0;
            this.editImagePathLabel.Text = "Path";
            // 
            // TabPageEditTags
            // 
            this.TabPageEditTags.Location = new System.Drawing.Point(4, 4);
            this.TabPageEditTags.Name = "TabPageEditTags";
            this.TabPageEditTags.Size = new System.Drawing.Size(617, 452);
            this.TabPageEditTags.TabIndex = 2;
            this.TabPageEditTags.Text = "Edit tags";
            this.TabPageEditTags.UseVisualStyleBackColor = true;
            // 
            // TabPageEditCharacters
            // 
            this.TabPageEditCharacters.Location = new System.Drawing.Point(4, 4);
            this.TabPageEditCharacters.Name = "TabPageEditCharacters";
            this.TabPageEditCharacters.Size = new System.Drawing.Size(617, 452);
            this.TabPageEditCharacters.TabIndex = 3;
            this.TabPageEditCharacters.Text = "Edit Characters";
            this.TabPageEditCharacters.UseVisualStyleBackColor = true;
            // 
            // MainContent
            // 
            this.MainContent.Controls.Add(this.splitContainer1);
            this.MainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContent.Location = new System.Drawing.Point(0, 24);
            this.MainContent.Name = "MainContent";
            this.MainContent.Size = new System.Drawing.Size(1076, 478);
            this.MainContent.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 524);
            this.Controls.Add(this.MainContent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TabImages.ResumeLayout(false);
            this.LVImagesContext.ResumeLayout(false);
            this.TabTags.ResumeLayout(false);
            this.LVTagsContext.ResumeLayout(false);
            this.TabCharacters.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.TabPageEditImage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editImagePictureBox)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.editImageTagsGroupBox.ResumeLayout(false);
            this.editImageTagsGroupBox.PerformLayout();
            this.editImageCharactersGroupBox.ResumeLayout(false);
            this.editImageCharactersGroupBox.PerformLayout();
            this.MainContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMSI;
        private System.Windows.Forms.ToolStripMenuItem fileNewMSI;
        private System.Windows.Forms.ToolStripMenuItem fileOpenMSI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fileSaveMSI;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAsMSI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fileHelpMSI;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar statusProgressBar;
        private System.Windows.Forms.ToolStripMenuItem imagesMSI;
        private System.Windows.Forms.ToolStripMenuItem imagesImportMSI;
        private System.Windows.Forms.ToolStripMenuItem imagesExportMSI;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabImages;
        private System.Windows.Forms.ListView LVImages;
        private System.Windows.Forms.ColumnHeader LVImagesColumnPath;
        private System.Windows.Forms.ColumnHeader LVImagesColumnAlias;
        private System.Windows.Forms.ColumnHeader LVImagesColumnTags;
        private System.Windows.Forms.ColumnHeader LVImagesColumnCharacters;
        private System.Windows.Forms.TabPage TabTags;
        private System.Windows.Forms.ListView LVTags;
        private System.Windows.Forms.ColumnHeader LVTagsHeaderKey;
        private System.Windows.Forms.ColumnHeader LVTagsHeaderSynonyms;
        private System.Windows.Forms.ColumnHeader LVTagsHeaderDescription;
        private System.Windows.Forms.TabPage TabCharacters;
        private System.Windows.Forms.ListView LVCharacters;
        private System.Windows.Forms.ColumnHeader LVCharactersColumnKey;
        private System.Windows.Forms.ColumnHeader LVCharactersColumnName;
        private System.Windows.Forms.ColumnHeader LVCharactersColumnAliases;
        private System.Windows.Forms.ColumnHeader LVCharactersColumnGender;
        private System.Windows.Forms.ColumnHeader LVCharactersColumnDescription;
        private System.Windows.Forms.ColumnHeader LVCharactersColumnAge;
        private System.Windows.Forms.Panel MainContent;
        private System.Windows.Forms.ContextMenuStrip LVImagesContext;
        private System.Windows.Forms.ToolStripMenuItem LVImagesContextRemove;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage PreviewTabPage;
        private System.Windows.Forms.TabPage TabPageEditImage;
        private System.Windows.Forms.TabPage TabPageEditTags;
        private System.Windows.Forms.TabPage TabPageEditCharacters;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox editImagePictureBox;
        private System.Windows.Forms.Button editImageApplyButton;
        private System.Windows.Forms.TextBox editImageAliasTextBox;
        private System.Windows.Forms.TextBox editImagePathTextBox;
        private System.Windows.Forms.Label editImageAliasLabel;
        private System.Windows.Forms.Label editImagePathLabel;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox editImageTagsGroupBox;
        private System.Windows.Forms.CheckedListBox editImageTagsCheckedListBox;
        private System.Windows.Forms.Label editImageTagsFilterLabel;
        private System.Windows.Forms.TextBox editImageTagsFilterTextBox;
        private System.Windows.Forms.GroupBox editImageCharactersGroupBox;
        private System.Windows.Forms.CheckedListBox editImageCharactersCheckedListBox;
        private System.Windows.Forms.Label editImageCharactersFilterLabel;
        private System.Windows.Forms.TextBox editImageCharactersFilterTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem LVImagesContextView;
        private System.Windows.Forms.ToolStripMenuItem LVImagesContextViewLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem LVImagesContextViewSnallIcon;
        private System.Windows.Forms.ToolStripMenuItem LVImagesContextViewTile;
        private System.Windows.Forms.ToolStripMenuItem LVImagesContextViewList;
        private System.Windows.Forms.ToolStripMenuItem LVImagesContextViewDetail;
        private System.Windows.Forms.ContextMenuStrip LVTagsContext;
        private System.Windows.Forms.ToolStripMenuItem LVTagsContextAdd;
        private System.Windows.Forms.ToolStripMenuItem LVTagsContextRemove;
    }
}

