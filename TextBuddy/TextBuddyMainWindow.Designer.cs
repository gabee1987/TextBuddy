namespace TextBuddy
{
    partial class TextBuddyMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectPatternComboBox = new System.Windows.Forms.ComboBox();
            this.SelectPatternLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddPatternLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.PreviewGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OriginalLabel = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DonePatternButton = new System.Windows.Forms.Button();
            this.DoneReplaceButton = new System.Windows.Forms.Button();
            this.ReplaceStartButton = new System.Windows.Forms.Button();
            this.PreviewOriginalRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PreviewModifiedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.PreviewGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStripMenuItem,
            this.searchForFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1185, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Image = global::TextBuddy.Properties.Resources.open_file;
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.OpenFileToolStripMenuItem.Text = "Open File";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // searchForFileToolStripMenuItem
            // 
            this.searchForFileToolStripMenuItem.Image = global::TextBuddy.Properties.Resources.System_search_icon;
            this.searchForFileToolStripMenuItem.Name = "searchForFileToolStripMenuItem";
            this.searchForFileToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.searchForFileToolStripMenuItem.Text = "Search for File";
            // 
            // SelectPatternComboBox
            // 
            this.SelectPatternComboBox.FormattingEnabled = true;
            this.SelectPatternComboBox.Location = new System.Drawing.Point(84, 3);
            this.SelectPatternComboBox.Name = "SelectPatternComboBox";
            this.SelectPatternComboBox.Size = new System.Drawing.Size(177, 21);
            this.SelectPatternComboBox.TabIndex = 1;
            // 
            // SelectPatternLabel
            // 
            this.SelectPatternLabel.AutoSize = true;
            this.SelectPatternLabel.Location = new System.Drawing.Point(7, 6);
            this.SelectPatternLabel.Name = "SelectPatternLabel";
            this.SelectPatternLabel.Size = new System.Drawing.Size(74, 13);
            this.SelectPatternLabel.TabIndex = 2;
            this.SelectPatternLabel.Text = "Select Pattern";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(741, 21);
            this.textBox1.TabIndex = 3;
            // 
            // AddPatternLabel
            // 
            this.AddPatternLabel.AutoSize = true;
            this.AddPatternLabel.Location = new System.Drawing.Point(285, 6);
            this.AddPatternLabel.Name = "AddPatternLabel";
            this.AddPatternLabel.Size = new System.Drawing.Size(63, 13);
            this.AddPatternLabel.TabIndex = 4;
            this.AddPatternLabel.Text = "Add Pattern";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ReplaceStartButton);
            this.panel1.Controls.Add(this.DoneReplaceButton);
            this.panel1.Controls.Add(this.DonePatternButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.SelectPatternComboBox);
            this.panel1.Controls.Add(this.AddPatternLabel);
            this.panel1.Controls.Add(this.SelectPatternLabel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 80);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 99);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Pattern Controls";
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(3, 16);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.PreviewOriginalRichTextBox);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.PreviewModifiedRichTextBox);
            this.SplitContainer.Size = new System.Drawing.Size(1179, 444);
            this.SplitContainer.SplitterDistance = 566;
            this.SplitContainer.TabIndex = 7;
            // 
            // PreviewGroupBox
            // 
            this.PreviewGroupBox.Controls.Add(this.label1);
            this.PreviewGroupBox.Controls.Add(this.OriginalLabel);
            this.PreviewGroupBox.Controls.Add(this.SplitContainer);
            this.PreviewGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PreviewGroupBox.Location = new System.Drawing.Point(0, 132);
            this.PreviewGroupBox.Name = "PreviewGroupBox";
            this.PreviewGroupBox.Size = new System.Drawing.Size(1185, 463);
            this.PreviewGroupBox.TabIndex = 8;
            this.PreviewGroupBox.TabStop = false;
            this.PreviewGroupBox.Text = "Preview";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(862, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Modified";
            // 
            // OriginalLabel
            // 
            this.OriginalLabel.AutoSize = true;
            this.OriginalLabel.Location = new System.Drawing.Point(244, 0);
            this.OriginalLabel.Name = "OriginalLabel";
            this.OriginalLabel.Size = new System.Drawing.Size(42, 13);
            this.OriginalLabel.TabIndex = 8;
            this.OriginalLabel.Text = "Original";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Replace With:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(354, 30);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(741, 21);
            this.textBox2.TabIndex = 5;
            // 
            // DonePatternButton
            // 
            this.DonePatternButton.Location = new System.Drawing.Point(1101, 2);
            this.DonePatternButton.Name = "DonePatternButton";
            this.DonePatternButton.Size = new System.Drawing.Size(50, 23);
            this.DonePatternButton.TabIndex = 7;
            this.DonePatternButton.Text = "Done";
            this.DonePatternButton.UseVisualStyleBackColor = true;
            // 
            // DoneReplaceButton
            // 
            this.DoneReplaceButton.Location = new System.Drawing.Point(1101, 29);
            this.DoneReplaceButton.Name = "DoneReplaceButton";
            this.DoneReplaceButton.Size = new System.Drawing.Size(50, 23);
            this.DoneReplaceButton.TabIndex = 8;
            this.DoneReplaceButton.Text = "Done";
            this.DoneReplaceButton.UseVisualStyleBackColor = true;
            // 
            // ReplaceStartButton
            // 
            this.ReplaceStartButton.Location = new System.Drawing.Point(1076, 54);
            this.ReplaceStartButton.Name = "ReplaceStartButton";
            this.ReplaceStartButton.Size = new System.Drawing.Size(75, 23);
            this.ReplaceStartButton.TabIndex = 9;
            this.ReplaceStartButton.Text = "Replace";
            this.ReplaceStartButton.UseVisualStyleBackColor = true;
            // 
            // PreviewOriginalRichTextBox
            // 
            this.PreviewOriginalRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewOriginalRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.PreviewOriginalRichTextBox.Name = "PreviewOriginalRichTextBox";
            this.PreviewOriginalRichTextBox.Size = new System.Drawing.Size(566, 444);
            this.PreviewOriginalRichTextBox.TabIndex = 10;
            this.PreviewOriginalRichTextBox.Text = "";
            this.PreviewOriginalRichTextBox.WordWrap = false;
            // 
            // PreviewModifiedRichTextBox
            // 
            this.PreviewModifiedRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewModifiedRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.PreviewModifiedRichTextBox.Name = "PreviewModifiedRichTextBox";
            this.PreviewModifiedRichTextBox.Size = new System.Drawing.Size(609, 444);
            this.PreviewModifiedRichTextBox.TabIndex = 0;
            this.PreviewModifiedRichTextBox.Text = "";
            // 
            // TextBuddyMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 595);
            this.Controls.Add(this.PreviewGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextBuddyMainWindow";
            this.Text = "TextBuddy";
            this.Load += new System.EventHandler(this.TextBuddyMainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.PreviewGroupBox.ResumeLayout(false);
            this.PreviewGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForFileToolStripMenuItem;
        private System.Windows.Forms.ComboBox SelectPatternComboBox;
        private System.Windows.Forms.Label SelectPatternLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AddPatternLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.GroupBox PreviewGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OriginalLabel;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button ReplaceStartButton;
        private System.Windows.Forms.Button DoneReplaceButton;
        private System.Windows.Forms.Button DonePatternButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox PreviewOriginalRichTextBox;
        private System.Windows.Forms.RichTextBox PreviewModifiedRichTextBox;
    }
}

