using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.Text = "vbac GUI Ver." + Core.Version;
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
        }

        async private void metroButtonCompile_Click(object sender, EventArgs e)
        {
            EnableUI(false);
            try
            {
                await Task.Run(() =>
                {
                    new vbac().Build(
                        Core.Config.vbac.SourceDirectory,
                        Core.Config.vbac.BinaryDirectory,
                        Core.Config.vbac.EnableCompact,
                        Core.Config.vbac.EnableVbaproj);
                });
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
                await Task.Run(() =>
                {
                    new vbac().Debuild(
                        Core.Config.vbac.SourceDirectory,
                        Core.Config.vbac.BinaryDirectory,
                        Core.Config.vbac.EnableCompact,
                        Core.Config.vbac.EnableVbaproj);
                });
            }
            finally
            {
                EnableUI(true);
            }

        }

        async private void metroButtonSearch_Click(object sender, EventArgs e)
        {
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
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Core.Config.Save();
        }

    }
}
