using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBuddy
{
    public partial class TextBuddyMainWindow : Form
    {
        public TextBuddyMainWindow()
        {
            InitializeComponent();
            PopulateSelectPatternComboBox();
        }

        private void TextBuddyMainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resDialog = OpenFileDialog.ShowDialog();
            if (resDialog.ToString() == "OK")
            {
                string openedFileName = OpenFileDialog.FileName;
                this.Text = "TextBuddy";
                this.Text += "    Opened File: " + openedFileName;
                string openedFile = IOManager.OpenTextFile(openedFileName);
                PreviewOriginalRichTextBox.Text = openedFile;
            }
        }

        private void PopulateSelectPatternComboBox()
        {
            List<String> regexNames = IOManager.OpenTextFileByLines(@"regexNames.txt");
            List<String> regexPatterns = IOManager.OpenTextFileByLines(@"regexPatterns.txt");
            Dictionary<String, String> comboboxItems = regexNames.Zip(regexPatterns, (k, v) => new { Key = k, Value = v }).ToDictionary(x => x.Key, x => x.Value);

            SelectPatternComboBox.DataSource = new BindingSource(comboboxItems, null);
            SelectPatternComboBox.DisplayMember = "Key";
            SelectPatternComboBox.ValueMember = "Value";
        }
    }
}
