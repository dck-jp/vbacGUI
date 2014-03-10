using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vbacGUI
{
    public class Config
    {
        public readonly bool IsFirstBoot;
        public static string GetPath()
        {
            return Application.UserAppDataPath + "\\config.xml";
        }
        public Config()
        {
            IsFirstBoot = !File.Exists(Config.GetPath());
        }
        public void Save()
        {
            Files.SaveXML<Config>(Config.GetPath(), this);
        }
        public static Config Load()
        {
            if (File.Exists(Config.GetPath()))
            {
                return Files.LoadXML<Config>(Config.GetPath(), true);
            }
            else
            {
                return new Config();
            }
        }

        public vbacConfig vbac = new vbacConfig();
        public class vbacConfig
        {
            public readonly string Path = "vbac.wsf";

            public string SourceDirectory = "";
            public string BinaryDirectory = "";
            public bool EnableCompact = false;
            public bool EnableVbaproj = false;
            public bool EnableBackupBinary = false;
        }

        public ptConfig pt = new ptConfig();
        public class ptConfig
        {
            public readonly string Path = "pt.exe";
            public string searchWord = "";
        }
    }
}
