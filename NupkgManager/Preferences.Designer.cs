namespace NupkgManager
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.prefDefaultPath = new System.Windows.Forms.TextBox();
            this.prefBrowseButton = new System.Windows.Forms.Button();
            this.prefCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prefDefaultServer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apiKey = new System.Windows.Forms.ComboBox();
            this.prefSaveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Controls.Add(this.prefDefaultPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.prefBrowseButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.prefCancelButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.prefDefaultServer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.apiKey, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.prefSaveButton, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 280);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // prefDefaultPath
            // 
            this.prefDefaultPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prefDefaultPath.Enabled = false;
            this.prefDefaultPath.Location = new System.Drawing.Point(97, 16);
            this.prefDefaultPath.Name = "prefDefaultPath";
            this.prefDefaultPath.Size = new System.Drawing.Size(258, 20);
            this.prefDefaultPath.TabIndex = 1;
            // 
            // prefBrowseButton
            // 
            this.prefBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prefBrowseButton.Location = new System.Drawing.Point(373, 13);
            this.prefBrowseButton.Name = "prefBrowseButton";
            this.prefBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.prefBrowseButton.TabIndex = 2;
            this.prefBrowseButton.Text = "Browse ...";
            this.prefBrowseButton.UseVisualStyleBackColor = true;
            this.prefBrowseButton.Click += new System.EventHandler(this.prefBrowseButton_Click);
            // 
            // prefCancelButton
            // 
            this.prefCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prefCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.prefCancelButton.Location = new System.Drawing.Point(373, 249);
            this.prefCancelButton.Name = "prefCancelButton";
            this.prefCancelButton.Size = new System.Drawing.Size(75, 23);
            this.prefCancelButton.TabIndex = 3;
            this.prefCancelButton.Text = "Cancel";
            this.prefCancelButton.UseVisualStyleBackColor = true;
            this.prefCancelButton.Click += new System.EventHandler(this.prefCancelButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default Search Path:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Default NuGet Server:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prefDefaultServer
            // 
            this.prefDefaultServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.prefDefaultServer, 2);
            this.prefDefaultServer.FormattingEnabled = true;
            this.prefDefaultServer.Location = new System.Drawing.Point(97, 47);
            this.prefDefaultServer.Name = "prefDefaultServer";
            this.prefDefaultServer.Size = new System.Drawing.Size(351, 21);
            this.prefDefaultServer.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "API key:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // apiKey
            // 
            this.apiKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.apiKey, 2);
            this.apiKey.FormattingEnabled = true;
            this.apiKey.Location = new System.Drawing.Point(97, 77);
            this.apiKey.Name = "apiKey";
            this.apiKey.Size = new System.Drawing.Size(351, 21);
            this.apiKey.TabIndex = 9;
            // 
            // prefSaveButton
            // 
            this.prefSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prefSaveButton.Location = new System.Drawing.Point(280, 249);
            this.prefSaveButton.Name = "prefSaveButton";
            this.prefSaveButton.Size = new System.Drawing.Size(75, 23);
            this.prefSaveButton.TabIndex = 4;
            this.prefSaveButton.Text = "Save";
            this.prefSaveButton.UseVisualStyleBackColor = true;
            this.prefSaveButton.Click += new System.EventHandler(this.prefSaveButton_Click);
            // 
            // Preferences
            // 
            this.AcceptButton = this.prefSaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 280);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preferences";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox prefDefaultPath;
        private System.Windows.Forms.Button prefBrowseButton;
        private System.Windows.Forms.Button prefCancelButton;
        private System.Windows.Forms.Button prefSaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox prefDefaultServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox apiKey;
    }
}