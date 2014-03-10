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
        public string Version { get { return GetVersion(); } }

        public void Execute(string pattern, string path)
        {
            var p = new ProcessStartInfo();
            p.FileName = "cmd.exe";

            if(path == "") path = "src\"";
 
            p.Arguments =  "/k " + Core.Config.pt.Path  + " "+ pattern + " --nocolor " + path;

            p.UseShellExecute = true;
            
            Process.Start(p);
        }

        private string GetVersion()
        {
            var p = new ProcessStartInfo();
            p.FileName = Core.Config.pt.Path;
            p.Arguments = "--version";

            p.UseShellExecute = false;
            p.CreateNoWindow = true;
            p.RedirectStandardOutput = true;

            var process = Process.Start(p);
            var output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return output;

        }
    }
}
