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
    public partial class CharacterForm : Form
    {
        public DialogResult dialogResult = DialogResult.Cancel;
        public IMCharacter result = null;
        public CharacterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = new IMCharacter()
            {
                Key = textBox1.Text,
                Name = textBox2.Text,
                Aliases = (textBox3.Text != "") ? textBox3.Lines.ToList() : new List<string>(),
                Gender = textBox4.Text,
                Age = Convert.ToInt32(numericUpDown1.Value),
                Description = textBox5.Text,
            };
            result = res;
            dialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
