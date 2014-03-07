using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vbacGUI.Command
{
    class Explorer
    {
        public void Execute(string path)
        {
            var p = new ProcessStartInfo();
            p.FileName = "explorer";
            p.Arguments = "/e /select,\"" + path + "\"";
            //ref : http://support.microsoft.com/kb/152457/ja

            Process.Start(p);
        }
    }
}
