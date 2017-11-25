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
            this.SelectPatternComboBox = new System.Windows.Forms.ComboBox();
            this.SelectPatternLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddPatternLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.OriginalListView = new System.Windows.Forms.ListView();
            this.ModifiedListView = new System.Windows.Forms.ListView();
            this.PreviewGroupBox = new System.Windows.Forms.GroupBox();
            this.OriginalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.openFileToolStripMenuItem,
            this.searchForFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1185, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.textBox1.Location = new System.Drawing.Point(339, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(797, 21);
            this.textBox1.TabIndex = 3;
            // 
            // AddPatternLabel
            // 
            this.AddPatternLabel.AutoSize = true;
            this.AddPatternLabel.Location = new System.Drawing.Point(273, 6);
            this.AddPatternLabel.Name = "AddPatternLabel";
            this.AddPatternLabel.Size = new System.Drawing.Size(63, 13);
            this.AddPatternLabel.TabIndex = 4;
            this.AddPatternLabel.Text = "Add Pattern";
            // 
            // panel1
            // 
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
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = global::TextBuddy.Properties.Resources.open_file;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.openFileToolStripMenuItem.Text = "Open File";
            // 
            // searchForFileToolStripMenuItem
            // 
            this.searchForFileToolStripMenuItem.Image = global::TextBuddy.Properties.Resources.System_search_icon;
            this.searchForFileToolStripMenuItem.Name = "searchForFileToolStripMenuItem";
            this.searchForFileToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.searchForFileToolStripMenuItem.Text = "Search for File";
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(3, 16);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.OriginalListView);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.ModifiedListView);
            this.SplitContainer.Size = new System.Drawing.Size(1179, 444);
            this.SplitContainer.SplitterDistance = 566;
            this.SplitContainer.TabIndex = 7;
            // 
            // OriginalListView
            // 
            this.OriginalListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalListView.Location = new System.Drawing.Point(0, 0);
            this.OriginalListView.Name = "OriginalListView";
            this.OriginalListView.Size = new System.Drawing.Size(566, 444);
            this.OriginalListView.TabIndex = 0;
            this.OriginalListView.UseCompatibleStateImageBehavior = false;
            // 
            // ModifiedListView
            // 
            this.ModifiedListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifiedListView.Location = new System.Drawing.Point(0, 0);
            this.ModifiedListView.Name = "ModifiedListView";
            this.ModifiedListView.Size = new System.Drawing.Size(609, 444);
            this.ModifiedListView.TabIndex = 0;
            this.ModifiedListView.UseCompatibleStateImageBehavior = false;
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
            // OriginalLabel
            // 
            this.OriginalLabel.AutoSize = true;
            this.OriginalLabel.Location = new System.Drawing.Point(244, 0);
            this.OriginalLabel.Name = "OriginalLabel";
            this.OriginalLabel.Size = new System.Drawing.Size(42, 13);
            this.OriginalLabel.TabIndex = 8;
            this.OriginalLabel.Text = "Original";
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
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForFileToolStripMenuItem;
        private System.Windows.Forms.ComboBox SelectPatternComboBox;
        private System.Windows.Forms.Label SelectPatternLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AddPatternLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.ListView OriginalListView;
        private System.Windows.Forms.ListView ModifiedListView;
        private System.Windows.Forms.GroupBox PreviewGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OriginalLabel;
    }
}

