using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vbacGUI.Command
{
    public class pt
    {
        public void Execute(string pattern, string path)
        {
            var p = new ProcessStartInfo();
            p.FileName = "cmd.exe";

            if(path == "") path = "src\"";
 
            p.Arguments =  "/k " + Core.Config.pt.Path  + " "+ pattern + " --nocolor " + path;

            p.UseShellExecute = true;
            
            Process.Start(p);
        }
        
    }
}
