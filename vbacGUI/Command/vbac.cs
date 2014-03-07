using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vbacGUI.Command
{
    class vbac
    {
        internal void Build(string sourceDirectory, string binaryDirectory,
                            bool enableCompact, bool enableVbaproj)
        {
            Execute("combine", sourceDirectory, binaryDirectory, enableCompact, enableVbaproj);
        }

        internal void Debuild(string sourceDirectory, string binaryDirectory,
                            bool enableCompact, bool enableVbaproj)
        {
            Execute("decombine", sourceDirectory, binaryDirectory, enableCompact, enableVbaproj);
        }

        internal void Execute(string command , 
                            string sourceDirectory, string binaryDirectory,
                            bool enableCompact, bool enableVbaproj)
        {
            var p = new ProcessStartInfo();
            p.FileName = "cscript.exe";
            p.Arguments = Core.Config.vbac.Path + " " + command;

            if (sourceDirectory != "") p.Arguments += " /source:\"" + sourceDirectory + "\"";

            if (binaryDirectory != "") p.Arguments += " /binary:\"" + binaryDirectory + "\"";

            if (enableCompact) p.Arguments += " /dbcompact";

            if (enableVbaproj) p.Arguments += " /vbaproj";

            p.UseShellExecute = false;
            Process.Start(p).WaitForExit();
        }
    }
}
