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
        }

        private void TextBuddyMainWindow_Load(object sender, EventArgs e)
        {
            PopulateSelectPatternComboBox();
            PopulateDateFormatComboBox();
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
                ConvertDateFormatButton.Enabled = true;
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

        private void PopulateDateFormatComboBox()
        {
            DateFormatComboBox.Items.Add("MM/dd/yyyy");
            DateFormatComboBox.Items.Add("MM-dd-yyyy");
            DateFormatComboBox.Items.Add("MM.dd.yyyy");
            DateFormatComboBox.Items.Add("dd/MM/yyyy");
            DateFormatComboBox.Items.Add("dd-MM-yyyy");
            DateFormatComboBox.Items.Add("dd.MM.yyyy");
            DateFormatComboBox.Items.Add("yyyy/MM/dd");
            DateFormatComboBox.Items.Add("yyyy-MM-dd");
            DateFormatComboBox.Items.Add("yyyy.MM.dd");
        }

        private void ReplaceStartButton_Click(object sender, EventArgs e)
        {
            string searchPattern = RegexPatternTextBox.Text;
            string replacePattern = ReplaceWithTextBox.Text;
            string document = PreviewOriginalRichTextBox.Text;
            PreviewModifiedRichTextBox.Text = RegexManager.ReplaceFoundMatches(document, searchPattern, replacePattern);
        }

        private void SelectPatternComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get ComboBox from sender
            ComboBox comboBox = (ComboBox)sender;

            // get selected KVP
            KeyValuePair<String, String> selectedEntry = (KeyValuePair<String, String>)comboBox.SelectedItem;

            // get selected Key
            String selectedValue = selectedEntry.Value;

            if (RegexPatternTextBox.Enabled == true)
            {
                RegexPatternTextBox.Text = selectedValue;
            }
            else
            {
                ReplaceWithTextBox.Text = selectedValue;
            }
        }

        private void SearchMatchesButton_Click(object sender, EventArgs e)
        {
            string documentToSearch = PreviewOriginalRichTextBox.Text;
            string pattern = RegexPatternTextBox.Text;
            FoundMatchesTextBox.Text = RegexManager.CountFoundMatches(documentToSearch, pattern).ToString();
        }

        private void PreviewOriginalRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PreviewOriginalRichTextBox.TextLength > 0)
            {
                SearchMatchesButton.Enabled = true;
                SearchAndGetButton.Enabled = true;
            }
            else if (PreviewOriginalRichTextBox.TextLength <= 0)
            {
                SearchMatchesButton.Enabled = false;
                SearchAndGetButton.Enabled = false;
            }
        }

        private void SearchAndGetButton_Click(object sender, EventArgs e)
        {
            if (SearchAndGetButton.Enabled == true)
            {
                int matchCount = 0;
                string documentToSearch = PreviewOriginalRichTextBox.Text;
                string pattern = RegexPatternTextBox.Text;
                string foundMatchesString = "";
                List<string> foundMatches = RegexManager.SearchAndGetMatches(documentToSearch, pattern);
                foreach (string match in foundMatches)
                {
                    foundMatchesString += match + "\n";
                    matchCount++;
                }
                PreviewModifiedRichTextBox.Text = foundMatchesString;
                FoundMatchesTextBox.Text = matchCount.ToString();
            }
        }

        private void RegexPatternTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchAndGetButton.PerformClick();
            }
        }

        private void ReplaceWithTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ReplaceWithTextBox.Text.Length > 0)
            {
                ReplaceStartButton.Enabled = true;
            }
        }

        private void LockPictureBox_Click(object sender, EventArgs e)
        {
            if (RegexPatternTextBox.Enabled == true)
            {
                LockPictureBox.Image = Properties.Resources.close_lock_512;
                RegexPatternTextBox.Enabled = false;
            }
            else
            {
                LockPictureBox.Image = Properties.Resources.open_lock_512;
                RegexPatternTextBox.Enabled = true;
            }
        }

        private void ConvertDateFormatButton_Click(object sender, EventArgs e)
        {
            if (PreviewOriginalRichTextBox.Text.Length > 0)
            {
                string pattern = RegexPatternTextBox.Text;
                string document = PreviewOriginalRichTextBox.Text;
                string dateFormat = DateFormatComboBox.SelectedItem.ToString();
                
                PreviewModifiedRichTextBox.Text = RegexManager.FormatDate(document, pattern, dateFormat);
            }
        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PreviewModifiedRichTextBox.Text.Length > 0)
            {
                string documentToSave = PreviewModifiedRichTextBox.Text;
                DialogResult resDialog = SaveFileDialog.ShowDialog();
                if (resDialog.ToString() == "OK")
                {
                    string savedFileName = SaveFileDialog.FileName;
                    IOManager.WriteToFile(savedFileName, documentToSave);
                    MessageBox.Show("File successfully saved.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
