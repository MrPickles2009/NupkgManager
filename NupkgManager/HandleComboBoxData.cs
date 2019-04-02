using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NupkgManager
{
    public class HandleComboBoxData
    {
        public void handleNugetServers(ComboBox comboBox)
        {
            StringCollection s = new StringCollection();

            try
            {
                for (int i = 0; i < Properties.Settings.Default.NugetRepositories.Count; i++)
                {
                    bool Contains = comboBox.Items.Contains(Properties.Settings.Default.NugetRepositories[i]);
                    if (!Contains)
                    {
                        comboBox.Items.Add(Properties.Settings.Default.NugetRepositories[i]);
                    }
                }

                var uniques = Properties.Settings.Default.NugetRepositories.Cast<IEnumerable>();
                var unique = uniques.Distinct();

                foreach (var x in unique)
                {
                    s.Add(x.ToString());
                }

                if (s.Count > 5)
                {
                    s.RemoveAt(4);
                }

                Properties.Settings.Default.NugetRepositories = s;
            }
            catch (Exception)
            {
                Properties.Settings.Default.NugetRepositories = s;
            }
        }

        public void handleApiKeys(ComboBox comboBox)
        {
            StringCollection s = new StringCollection();

            try
            {
                for (int i = 0; i < Properties.Settings.Default.ApiKey.Count; i++)
                {
                    bool Contains = comboBox.Items.Contains(Properties.Settings.Default.ApiKey[i]);
                    if (!Contains)
                    {
                        comboBox.Items.Add(Properties.Settings.Default.ApiKey[i]);
                    }
                }

                var uniques = Properties.Settings.Default.ApiKey.Cast<IEnumerable>();
                var unique = uniques.Distinct();

                foreach (var x in unique)
                {
                    s.Add(x.ToString());
                }

                if (s.Count > 5)
                {
                    s.RemoveAt(4);
                }

                Properties.Settings.Default.ApiKey = s;

            }
            catch (Exception)
            {
                Properties.Settings.Default.ApiKey = s;
            }
        }
    }
}
