using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NupkgManager
{
    public partial class MissingInfoDialog : Form
    {
        public MissingInfoDialog()
        {
            InitializeComponent();
            try
            {
                apiKeyComboBox.Text = Properties.Settings.Default.ApiKey[0];
                serverComboBox.Text = Properties.Settings.Default.NugetRepositories[0];
            }
            catch (Exception)
            {
                apiKeyComboBox.Text = string.Empty;
                serverComboBox.Text = string.Empty;
            }
            
            
            HandleComboBoxData handleComboBoxData = new HandleComboBoxData();
            handleComboBoxData.handleNugetServers(serverComboBox);
            handleComboBoxData.handleApiKeys(apiKeyComboBox);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (apiKeyComboBox.Text != string.Empty || serverComboBox.Text != string.Empty)
            {
                try
                {
                    Properties.Settings.Default.NugetRepositories.Insert(0, serverComboBox.Text);
                    Properties.Settings.Default.ApiKey.Insert(0, apiKeyComboBox.Text);
                    Properties.Settings.Default.Save();

                }
                catch (Exception)
                {
                    Properties.Settings.Default.NugetRepositories.Add(serverComboBox.Text);
                    Properties.Settings.Default.ApiKey.Add(apiKeyComboBox.Text);
                    Properties.Settings.Default.Save();
                }

                ActiveForm.Close();
            }
            else
            {
                apiKeyTextError.Text = apiKeyComboBox.Text == string.Empty ? "Value cannot be blank" : string.Empty;
                serverTextError.Text = serverComboBox.Text == string.Empty ? "Value cannot be blank" : string.Empty;
                okButton.DialogResult = DialogResult.None;
            }
        }
    }
}
