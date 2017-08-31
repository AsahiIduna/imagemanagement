using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageManagement
{
    public partial class TagForm : Form
    {
        public DialogResult dialogResult = DialogResult.Cancel;
        public IMTag result = null;

        public TagForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = new IMTag()
            {
                Key = textBoxKey.Text,
                Synonyms = textBoxAliases.Lines.ToList(),
                Description = textBoxDescription.Text,
            };
            dialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
