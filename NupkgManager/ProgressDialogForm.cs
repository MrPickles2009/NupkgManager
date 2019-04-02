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
    public partial class ProgressDialogForm : Form
    {
        public Action Worker { get; set; }
        private delegate void SafeCallDelegate(string message);

        public ProgressDialogForm(string message)
        {
            InitializeComponent();

            if (message == null)
                throw new ArgumentNullException();
            
            UpdateMessage(message);
        }

        public void UpdateMessage(string message)
        {
            if (label1.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateMessage);
                Invoke(d, new object[] { message });
            }
            else
            {
                label1.Text = message;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
    }
}
