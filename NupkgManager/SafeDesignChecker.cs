using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NupkgManager
{
    public class SafeDesignChecker
    {
        private SafeDesignChecker()
        { }

        public static bool DesignMode
        {
            get
            {
                //return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
                return Application.ExecutablePath.ToLower().IndexOf("devenv.exe") > -1;
            }
        }

    }
}
