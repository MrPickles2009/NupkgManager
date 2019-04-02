namespace NupkgManager
{
    partial class MissingInfoDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MissingInfoDialog));
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.serverLabel = new System.Windows.Forms.Label();
            this.apiKeyComboBox = new System.Windows.Forms.ComboBox();
            this.serverComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.serverTextError = new System.Windows.Forms.Label();
            this.apiKeyTextError = new System.Windows.Forms.Label();
            this.missingInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.missingInfoTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Location = new System.Drawing.Point(3, 7);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(47, 13);
            this.apiKeyLabel.TabIndex = 0;
            this.apiKeyLabel.Text = "API key:";
            // 
            // serverLabel
            // 
            this.serverLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(3, 47);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(81, 13);
            this.serverLabel.TabIndex = 1;
            this.serverLabel.Text = "Server address:";
            // 
            // apiKeyComboBox
            // 
            this.apiKeyComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apiKeyComboBox.FormattingEnabled = true;
            this.apiKeyComboBox.Location = new System.Drawing.Point(90, 3);
            this.apiKeyComboBox.Name = "apiKeyComboBox";
            this.apiKeyComboBox.Size = new System.Drawing.Size(350, 21);
            this.apiKeyComboBox.TabIndex = 2;
            // 
            // serverComboBox
            // 
            this.serverComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverComboBox.FormattingEnabled = true;
            this.serverComboBox.Location = new System.Drawing.Point(90, 43);
            this.serverComboBox.Name = "serverComboBox";
            this.serverComboBox.Size = new System.Drawing.Size(350, 21);
            this.serverComboBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.okButton.Location = new System.Drawing.Point(365, 87);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // serverTextError
            // 
            this.serverTextError.AutoSize = true;
            this.serverTextError.Dock = System.Windows.Forms.DockStyle.Right;
            this.serverTextError.ForeColor = System.Drawing.Color.Red;
            this.serverTextError.Location = new System.Drawing.Point(440, 67);
            this.serverTextError.Name = "serverTextError";
            this.serverTextError.Size = new System.Drawing.Size(0, 13);
            this.serverTextError.TabIndex = 5;
            // 
            // apiKeyTextError
            // 
            this.apiKeyTextError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.apiKeyTextError.AutoSize = true;
            this.apiKeyTextError.ForeColor = System.Drawing.Color.Red;
            this.apiKeyTextError.Location = new System.Drawing.Point(440, 27);
            this.apiKeyTextError.Name = "apiKeyTextError";
            this.apiKeyTextError.Size = new System.Drawing.Size(0, 13);
            this.apiKeyTextError.TabIndex = 6;
            // 
            // missingInfoTableLayoutPanel
            // 
            this.missingInfoTableLayoutPanel.ColumnCount = 2;
            this.missingInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.missingInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.missingInfoTableLayoutPanel.Controls.Add(this.apiKeyLabel, 0, 0);
            this.missingInfoTableLayoutPanel.Controls.Add(this.okButton, 1, 4);
            this.missingInfoTableLayoutPanel.Controls.Add(this.serverTextError, 1, 3);
            this.missingInfoTableLayoutPanel.Controls.Add(this.apiKeyTextError, 1, 1);
            this.missingInfoTableLayoutPanel.Controls.Add(this.serverLabel, 0, 2);
            this.missingInfoTableLayoutPanel.Controls.Add(this.apiKeyComboBox, 1, 0);
            this.missingInfoTableLayoutPanel.Controls.Add(this.serverComboBox, 1, 2);
            this.missingInfoTableLayoutPanel.Location = new System.Drawing.Point(20, 20);
            this.missingInfoTableLayoutPanel.Name = "missingInfoTableLayoutPanel";
            this.missingInfoTableLayoutPanel.RowCount = 5;
            this.missingInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.missingInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.missingInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.missingInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.missingInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.missingInfoTableLayoutPanel.Size = new System.Drawing.Size(441, 118);
            this.missingInfoTableLayoutPanel.TabIndex = 7;
            // 
            // MissingInfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.missingInfoTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MissingInfoDialog";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Missing Info";
            this.missingInfoTableLayoutPanel.ResumeLayout(false);
            this.missingInfoTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.ComboBox apiKeyComboBox;
        private System.Windows.Forms.ComboBox serverComboBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label serverTextError;
        private System.Windows.Forms.Label apiKeyTextError;
        private System.Windows.Forms.TableLayoutPanel missingInfoTableLayoutPanel;
    }
}