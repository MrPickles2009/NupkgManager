namespace NupkgManager
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.pushPackagesButton = new System.Windows.Forms.Button();
            this.nuspecSearchResults = new System.Windows.Forms.CheckedListBox();
            this.buildPackagesButton = new System.Windows.Forms.Button();
            this.nupkgSearchResults = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCheckedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.majorVersionTo0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minorVersionTo0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildNumberTo0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideCmdOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.packagesPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.majorCheckBox = new System.Windows.Forms.CheckBox();
            this.minorCheckBox = new System.Windows.Forms.CheckBox();
            this.buildNumberCheckBox = new System.Windows.Forms.CheckBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.commandPromptOutputTextBox = new System.Windows.Forms.TextBox();
            this.deletePackagesButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pushPackagesButton
            // 
            this.pushPackagesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pushPackagesButton.Enabled = false;
            this.pushPackagesButton.Location = new System.Drawing.Point(3, 480);
            this.pushPackagesButton.Name = "pushPackagesButton";
            this.pushPackagesButton.Size = new System.Drawing.Size(77, 23);
            this.pushPackagesButton.TabIndex = 3;
            this.pushPackagesButton.Text = "Push";
            this.pushPackagesButton.UseVisualStyleBackColor = true;
            this.pushPackagesButton.Click += new System.EventHandler(this.pushPackagesButton_Click);
            // 
            // nuspecSearchResults
            // 
            this.nuspecSearchResults.CheckOnClick = true;
            this.tableLayoutPanel1.SetColumnSpan(this.nuspecSearchResults, 5);
            this.nuspecSearchResults.FormattingEnabled = true;
            this.nuspecSearchResults.HorizontalScrollbar = true;
            this.nuspecSearchResults.Location = new System.Drawing.Point(3, 56);
            this.nuspecSearchResults.Name = "nuspecSearchResults";
            this.nuspecSearchResults.Size = new System.Drawing.Size(357, 199);
            this.nuspecSearchResults.TabIndex = 5;
            this.nuspecSearchResults.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.nuspecSearchResults_ItemCheck);
            // 
            // buildPackagesButton
            // 
            this.buildPackagesButton.Enabled = false;
            this.buildPackagesButton.Location = new System.Drawing.Point(3, 261);
            this.buildPackagesButton.Name = "buildPackagesButton";
            this.buildPackagesButton.Size = new System.Drawing.Size(75, 23);
            this.buildPackagesButton.TabIndex = 6;
            this.buildPackagesButton.Text = "Build";
            this.buildPackagesButton.UseVisualStyleBackColor = true;
            this.buildPackagesButton.Click += new System.EventHandler(this.buildPackagesButton_Click);
            // 
            // nupkgSearchResults
            // 
            this.nupkgSearchResults.CheckOnClick = true;
            this.tableLayoutPanel1.SetColumnSpan(this.nupkgSearchResults, 5);
            this.nupkgSearchResults.FormattingEnabled = true;
            this.nupkgSearchResults.HorizontalScrollbar = true;
            this.nupkgSearchResults.Location = new System.Drawing.Point(3, 290);
            this.nupkgSearchResults.Name = "nupkgSearchResults";
            this.nupkgSearchResults.Size = new System.Drawing.Size(357, 184);
            this.nupkgSearchResults.TabIndex = 7;
            this.nupkgSearchResults.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.nupkgSearchResults_ItemCheck);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 6);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.resetCheckedToolStripMenuItem,
            this.refreshSearchToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // resetCheckedToolStripMenuItem
            // 
            this.resetCheckedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.majorVersionTo0ToolStripMenuItem,
            this.minorVersionTo0ToolStripMenuItem,
            this.buildNumberTo0ToolStripMenuItem});
            this.resetCheckedToolStripMenuItem.Name = "resetCheckedToolStripMenuItem";
            this.resetCheckedToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.resetCheckedToolStripMenuItem.Text = "Reset checked ...";
            // 
            // majorVersionTo0ToolStripMenuItem
            // 
            this.majorVersionTo0ToolStripMenuItem.CheckOnClick = true;
            this.majorVersionTo0ToolStripMenuItem.Enabled = false;
            this.majorVersionTo0ToolStripMenuItem.Name = "majorVersionTo0ToolStripMenuItem";
            this.majorVersionTo0ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.majorVersionTo0ToolStripMenuItem.Text = "Major version to 0";
            this.majorVersionTo0ToolStripMenuItem.Click += new System.EventHandler(this.majorVersionTo0ToolStripMenuItem_Click);
            // 
            // minorVersionTo0ToolStripMenuItem
            // 
            this.minorVersionTo0ToolStripMenuItem.CheckOnClick = true;
            this.minorVersionTo0ToolStripMenuItem.Enabled = false;
            this.minorVersionTo0ToolStripMenuItem.Name = "minorVersionTo0ToolStripMenuItem";
            this.minorVersionTo0ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.minorVersionTo0ToolStripMenuItem.Text = "Minor version to 0";
            this.minorVersionTo0ToolStripMenuItem.Click += new System.EventHandler(this.minorVersionTo0ToolStripMenuItem_Click);
            // 
            // buildNumberTo0ToolStripMenuItem
            // 
            this.buildNumberTo0ToolStripMenuItem.CheckOnClick = true;
            this.buildNumberTo0ToolStripMenuItem.Enabled = false;
            this.buildNumberTo0ToolStripMenuItem.Name = "buildNumberTo0ToolStripMenuItem";
            this.buildNumberTo0ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.buildNumberTo0ToolStripMenuItem.Text = "Build number to 0";
            this.buildNumberTo0ToolStripMenuItem.Click += new System.EventHandler(this.buildNumberTo0ToolStripMenuItem_Click);
            // 
            // refreshSearchToolStripMenuItem
            // 
            this.refreshSearchToolStripMenuItem.Name = "refreshSearchToolStripMenuItem";
            this.refreshSearchToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.refreshSearchToolStripMenuItem.Text = "Refresh search";
            this.refreshSearchToolStripMenuItem.Click += new System.EventHandler(this.refreshSearchToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideCmdOutputToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showHideCmdOutputToolStripMenuItem
            // 
            this.showHideCmdOutputToolStripMenuItem.Name = "showHideCmdOutputToolStripMenuItem";
            this.showHideCmdOutputToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.showHideCmdOutputToolStripMenuItem.Text = "Show/Hide cmd output";
            this.showHideCmdOutputToolStripMenuItem.Click += new System.EventHandler(this.showHideCmdOutputToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 355F));
            this.tableLayoutPanel1.Controls.Add(this.pushPackagesButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nupkgSearchResults, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.packagesPathTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buildPackagesButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nuspecSearchResults, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.majorCheckBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.minorCheckBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buildNumberCheckBox, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.browseButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.commandPromptOutputTextBox, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.deletePackagesButton, 4, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 513);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // packagesPathTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.packagesPathTextBox, 3);
            this.packagesPathTextBox.Enabled = false;
            this.packagesPathTextBox.Location = new System.Drawing.Point(3, 27);
            this.packagesPathTextBox.Name = "packagesPathTextBox";
            this.packagesPathTextBox.Size = new System.Drawing.Size(214, 20);
            this.packagesPathTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Increment Version by 1:";
            // 
            // majorCheckBox
            // 
            this.majorCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.majorCheckBox.AutoSize = true;
            this.majorCheckBox.Enabled = false;
            this.majorCheckBox.Location = new System.Drawing.Point(160, 264);
            this.majorCheckBox.Name = "majorCheckBox";
            this.majorCheckBox.Size = new System.Drawing.Size(52, 17);
            this.majorCheckBox.TabIndex = 10;
            this.majorCheckBox.Text = "Major";
            this.majorCheckBox.UseVisualStyleBackColor = true;
            // 
            // minorCheckBox
            // 
            this.minorCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.minorCheckBox.AutoSize = true;
            this.minorCheckBox.Enabled = false;
            this.minorCheckBox.Location = new System.Drawing.Point(223, 264);
            this.minorCheckBox.Name = "minorCheckBox";
            this.minorCheckBox.Size = new System.Drawing.Size(52, 17);
            this.minorCheckBox.TabIndex = 11;
            this.minorCheckBox.Text = "Minor";
            this.minorCheckBox.UseVisualStyleBackColor = true;
            // 
            // buildNumberCheckBox
            // 
            this.buildNumberCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buildNumberCheckBox.AutoSize = true;
            this.buildNumberCheckBox.Enabled = false;
            this.buildNumberCheckBox.Location = new System.Drawing.Point(285, 264);
            this.buildNumberCheckBox.Name = "buildNumberCheckBox";
            this.buildNumberCheckBox.Size = new System.Drawing.Size(67, 17);
            this.buildNumberCheckBox.TabIndex = 12;
            this.buildNumberCheckBox.Text = "Build no.";
            this.buildNumberCheckBox.UseVisualStyleBackColor = true;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.SetColumnSpan(this.browseButton, 2);
            this.browseButton.Location = new System.Drawing.Point(289, 27);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse ...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // commandPromptOutputTextBox
            // 
            this.commandPromptOutputTextBox.BackColor = System.Drawing.Color.Black;
            this.commandPromptOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandPromptOutputTextBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.commandPromptOutputTextBox.ForeColor = System.Drawing.Color.Lime;
            this.commandPromptOutputTextBox.Location = new System.Drawing.Point(370, 27);
            this.commandPromptOutputTextBox.Multiline = true;
            this.commandPromptOutputTextBox.Name = "commandPromptOutputTextBox";
            this.tableLayoutPanel1.SetRowSpan(this.commandPromptOutputTextBox, 5);
            this.commandPromptOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.commandPromptOutputTextBox.Size = new System.Drawing.Size(349, 483);
            this.commandPromptOutputTextBox.TabIndex = 14;
            // 
            // deletePackagesButton
            // 
            this.deletePackagesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deletePackagesButton.Enabled = false;
            this.deletePackagesButton.Location = new System.Drawing.Point(285, 480);
            this.deletePackagesButton.Name = "deletePackagesButton";
            this.deletePackagesButton.Size = new System.Drawing.Size(79, 23);
            this.deletePackagesButton.TabIndex = 15;
            this.deletePackagesButton.Text = "Delete";
            this.deletePackagesButton.UseVisualStyleBackColor = true;
            this.deletePackagesButton.Click += new System.EventHandler(this.deletePackagesButton_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.buildPackagesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Nupkg Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button pushPackagesButton;
        private System.Windows.Forms.CheckedListBox nuspecSearchResults;
        private System.Windows.Forms.Button buildPackagesButton;
        private System.Windows.Forms.CheckedListBox nupkgSearchResults;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem refreshSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox majorCheckBox;
        private System.Windows.Forms.CheckBox minorCheckBox;
        private System.Windows.Forms.CheckBox buildNumberCheckBox;
        private System.Windows.Forms.TextBox packagesPathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ToolStripMenuItem resetCheckedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem majorVersionTo0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minorVersionTo0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildNumberTo0ToolStripMenuItem;
        private System.Windows.Forms.TextBox commandPromptOutputTextBox;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideCmdOutputToolStripMenuItem;
        private System.Windows.Forms.Button deletePackagesButton;
    }
}

