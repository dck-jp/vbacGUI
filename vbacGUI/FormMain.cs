using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vbacGUI.Command;

namespace vbacGUI
{
    public partial class FormMain : MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
            metroTabControl1.SelectedIndex = 0;
            Core.FormMain = this;
            Core.Config = Config.Load();
            SetConfig();
            EnableUI(true);
        }


        private void SetConfig()
        {
             metroTextBoxSearchWord.Text=Core.Config.pt.searchWord ;
             metroTextBoxSourceDirectory.Text = Core.Config.vbac.SourceDirectory;
             metroTextBoxBinaryDirectory.Text = Core.Config.vbac.BinaryDirectory;
             metroToggleOptionCompact.Checked = Core.Config.vbac.EnableCompact;
             metroToggleOptionVbaproj.Checked = Core.Config.vbac.EnableVbaproj;
             metroToggleOptionBackupBinary.Checked = Core.Config.vbac.EnableBackupBinary;
        }

        async private void metroButtonCompile_Click(object sender, EventArgs e)
        {
            EnableUI(false);
            try
            {
                await Task.Run(() => { new vbac().Build(Core.Config.vbac); });
            }
            finally
            {
                EnableUI(true);
            }
        }

        async private void metroButtonDecompile_Click(object sender, EventArgs e)
        {
            EnableUI(false);
            try
            {
                await Task.Run(() => { new vbac().Debuild(Core.Config.vbac); });
            }
            finally
            {
                EnableUI(true);
            }

        }

        async private void metroButtonSearch_Click(object sender, EventArgs e)
        {
            if (metroTextBoxSearchWord.Text == "") return;

            EnableUI(false);
            try
            {
                await Task.Run(() =>
                {
                    new pt().Execute(
                        Core.Config.pt.searchWord,
                        Core.Config.vbac.SourceDirectory);
                });
            }
            finally
            {
                EnableUI(true);
            }
        }

        private void EnableUI(bool boolean)
        {
            metroButtonSearch.Enabled =
            metroButtonDecompile.Enabled =
            metroButtonCompile.Enabled = boolean;

            metroProgressSpinner.Visible = !boolean;

            Core.Config.pt.searchWord = metroTextBoxSearchWord.Text;
            Core.Config.vbac.SourceDirectory = metroTextBoxSourceDirectory.Text;
            Core.Config.vbac.BinaryDirectory = metroTextBoxBinaryDirectory.Text;
            Core.Config.vbac.EnableCompact = metroToggleOptionCompact.Checked;
            Core.Config.vbac.EnableVbaproj = metroToggleOptionVbaproj.Checked;
            Core.Config.vbac.EnableBackupBinary = metroToggleOptionBackupBinary.Checked;

            Restrict_Win8_64bit();
        }

        private void Restrict_Win8_64bit()
        {
            if(Environment.OSVersion.VersionString.Contains("6.2") 
                || Environment.OSVersion.VersionString.Contains("6.3") )
            {
                if( Environment.Is64BitOperatingSystem)
                {
                    metroToggleOptionVbaproj.Enabled = false;
                    metroToggleOptionVbaproj.Checked = false;
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Core.Config.Save();
        }

        private void metroButtonOpenSourceDirectory_Click(object sender, EventArgs e)
        {
            var srcText = metroTextBoxSourceDirectory.Text;
            var path = srcText == "" ? Environment.CurrentDirectory + @"\src" : srcText;
            new Explorer().Execute(path);
        }

        private void metroButtonOpenBinaryDirectory_Click(object sender, EventArgs e)
        {
            var binText = metroTextBoxBinaryDirectory.Text;
            var path = binText == "" ? Environment.CurrentDirectory + @"\bin" : binText;
            new Explorer().Execute(path);
        }

        private void metroButtonBrowseSourceDirectory_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                metroTextBoxSourceDirectory.Text = dlg.SelectedPath;
            }
        }

        private void metroButtonBrowseBinaryDirectory_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                metroTextBoxBinaryDirectory.Text = dlg.SelectedPath;
            }
        }

        async private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab != metroTabPage2) return;

            metroLabelGUIVersion.Text = Core.Version;
            metroLabelvbacVersion.Text = await Task.Run(() => { return new vbac().Version; });
            metroLabelptVersion.Text = await Task.Run(() => { return new pt().Version; });

        }

        private void metroLink6_Click(object sender, EventArgs e)
        {
            Process.Start(((MetroLink)sender).Text);
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {
            Process.Start(((MetroLink)sender).Text);
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            Process.Start(((MetroLink)sender).Text);
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            Process.Start(((MetroLink)sender).Text);
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            Process.Start(((MetroLink)sender).Text);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start(((MetroLink)sender).Text);
        }

    }
}
