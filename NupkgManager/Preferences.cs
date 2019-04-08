using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Forms;

namespace NupkgManager
{
    public partial class Preferences : Form
    {
        string userProfile = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\source\repos\");
        public Preferences()
        {
            InitializeComponent();
            if (Properties.Settings.Default.DefaultSearchFolder == string.Empty)
            {
                prefDefaultPath.Text = userProfile;
            }
            else
            {
                prefDefaultPath.Text = Properties.Settings.Default.DefaultSearchFolder;
            }

            try
            {
                prefDefaultServer.Text = Properties.Settings.Default.NugetRepositories[0];
                apiKey.Text = Properties.Settings.Default.ApiKey[0];
            }
            catch (Exception)
            {
                prefDefaultServer.Text = string.Empty;
                apiKey.Text = string.Empty;
            }
            

            HandleComboBoxData handleComboBoxData = new HandleComboBoxData();
            handleComboBoxData.handleNugetServers(prefDefaultServer);
            handleComboBoxData.handleApiKeys(apiKey);
        }

        private void prefBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.SelectedPath = userProfile;
            fbd.Description = "Select default packages folder:";
            fbd.ShowNewFolderButton = false;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                prefDefaultPath.Text = fbd.SelectedPath;
            }
        }

        private void prefSaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultSearchFolder = prefDefaultPath.Text;
            Properties.Settings.Default.NugetRepositories.Insert(0, prefDefaultServer.Text);
            Properties.Settings.Default.ApiKey.Insert(0, apiKey.Text);
            Properties.Settings.Default.Save();

            ActiveForm.Close();
        }

        private void prefCancelButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
