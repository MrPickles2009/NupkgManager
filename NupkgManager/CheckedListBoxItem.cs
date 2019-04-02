using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NupkgManager
{
    public class CheckedListBoxItem
    {
        public string Tag;
        public string Text;
        public override string ToString() { return Text; }
    }
}
