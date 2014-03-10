using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace vbacGUI.Command
{
    class vbac
    {
        public string Version { get { return GetVersion(); } }

        private string GetVersion()
        {
            var vbacSource = File.ReadAllLines(Core.Config.vbac.Path);
            var re = new Regex(@"vbac \(version (.+)\)");
            return vbacSource
                 .Where(x => re.IsMatch(x))
                 .Select(x => re.Match(x).Groups[1].Value)
                 .First();
            
        }

        internal void Debuild(Config.vbacConfig vbacConfig)
        {
            Execute("decombine", vbacConfig.SourceDirectory, vbacConfig.BinaryDirectory,
                vbacConfig.EnableCompact, vbacConfig.EnableVbaproj, vbacConfig.EnableBackupBinary);
        }

        internal void Build(Config.vbacConfig vbacConfig)
        {
            Execute("combine", vbacConfig.SourceDirectory, vbacConfig.BinaryDirectory,
                vbacConfig.EnableCompact, vbacConfig.EnableVbaproj, vbacConfig.EnableBackupBinary);
        }

        internal void Execute(string command , 
                            string sourceDirectory, string binaryDirectory,
                            bool enableCompact, bool enableVbaproj, bool enableBackupBin)
        {
            var p = new ProcessStartInfo();
            p.FileName = "cscript.exe";
            p.Arguments = Core.Config.vbac.Path + " " + command;

            if (sourceDirectory != "") p.Arguments += " /source:\"" + sourceDirectory + "\"";

            if (binaryDirectory != "") p.Arguments += " /binary:\"" + binaryDirectory + "\"";

            if (enableCompact) p.Arguments += " /dbcompact";

            if (enableVbaproj) p.Arguments += " /vbaproj";

            EnableBackupBin(enableBackupBin);
            p.UseShellExecute = true;

            var process = Process.Start(p);
            process.WaitForExit();
        }

        private void EnableBackupBin(bool enableBackupBin)
        {
            var vbacSoruce = File.ReadAllLines(Core.Config.vbac.Path);

            var re = new Regex("param.binbak.flag = .+;");
            var replaceText = "param.binbak.flag = " + enableBackupBin.ToString().ToLower() +";";
            var vbaSourceNew = vbacSoruce.Select(x => re.IsMatch(x) ? re.Replace(x, replaceText) : x);

            File.WriteAllLines(Core.Config.vbac.Path, vbaSourceNew);
        }


    }
}
