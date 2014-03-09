namespace vbacGUI
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButtonCompile = new MetroFramework.Controls.MetroButton();
            this.metroButtonDecompile = new MetroFramework.Controls.MetroButton();
            this.metroButtonBrowseSourceDirectory = new MetroFramework.Controls.MetroButton();
            this.metroButtonBrowseBinaryDirectory = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxSourceDirectory = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxBinaryDirectory = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonOpenSourceDirectory = new MetroFramework.Controls.MetroButton();
            this.metroButtonOpenBinaryDirectory = new MetroFramework.Controls.MetroButton();
            this.metroToggleOptionCompact = new MetroFramework.Controls.MetroToggle();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroToggleOptionVbaproj = new MetroFramework.Controls.MetroToggle();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroButtonSearch = new MetroFramework.Controls.MetroButton();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTextBoxSearchWord = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroLink4 = new MetroFramework.Controls.MetroLink();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLink5 = new MetroFramework.Controls.MetroLink();
            this.metroLink6 = new MetroFramework.Controls.MetroLink();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButtonCompile
            // 
            this.metroButtonCompile.Highlight = false;
            this.metroButtonCompile.Location = new System.Drawing.Point(374, 301);
            this.metroButtonCompile.Margin = new System.Windows.Forms.Padding(2);
            this.metroButtonCompile.Name = "metroButtonCompile";
            this.metroButtonCompile.Size = new System.Drawing.Size(184, 40);
            this.metroButtonCompile.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonCompile.StyleManager = null;
            this.metroButtonCompile.TabIndex = 6;
            this.metroButtonCompile.Text = "Combine";
            this.metroButtonCompile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButtonCompile.Click += new System.EventHandler(this.metroButtonCompile_Click);
            // 
            // metroButtonDecompile
            // 
            this.metroButtonDecompile.Highlight = false;
            this.metroButtonDecompile.Location = new System.Drawing.Point(185, 301);
            this.metroButtonDecompile.Margin = new System.Windows.Forms.Padding(2);
            this.metroButtonDecompile.Name = "metroButtonDecompile";
            this.metroButtonDecompile.Size = new System.Drawing.Size(184, 40);
            this.metroButtonDecompile.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonDecompile.StyleManager = null;
            this.metroButtonDecompile.TabIndex = 7;
            this.metroButtonDecompile.Text = "Decombine";
            this.metroButtonDecompile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButtonDecompile.Click += new System.EventHandler(this.metroButtonDecompile_Click);
            // 
            // metroButtonBrowseSourceDirectory
            // 
            this.metroButtonBrowseSourceDirectory.Highlight = false;
            this.metroButtonBrowseSourceDirectory.Location = new System.Drawing.Point(374, 51);
            this.metroButtonBrowseSourceDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.metroButtonBrowseSourceDirectory.Name = "metroButtonBrowseSourceDirectory";
            this.metroButtonBrowseSourceDirectory.Size = new System.Drawing.Size(35, 39);
            this.metroButtonBrowseSourceDirectory.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButtonBrowseSourceDirectory.StyleManager = null;
            this.metroButtonBrowseSourceDirectory.TabIndex = 0;
            this.metroButtonBrowseSourceDirectory.Text = "…";
            this.metroButtonBrowseSourceDirectory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButtonBrowseSourceDirectory.Click += new System.EventHandler(this.metroButtonBrowseSourceDirectory_Click);
            // 
            // metroButtonBrowseBinaryDirectory
            // 
            this.metroButtonBrowseBinaryDirectory.Highlight = false;
            this.metroButtonBrowseBinaryDirectory.Location = new System.Drawing.Point(374, 101);
            this.metroButtonBrowseBinaryDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.metroButtonBrowseBinaryDirectory.Name = "metroButtonBrowseBinaryDirectory";
            this.metroButtonBrowseBinaryDirectory.Size = new System.Drawing.Size(35, 39);
            this.metroButtonBrowseBinaryDirectory.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButtonBrowseBinaryDirectory.StyleManager = null;
            this.metroButtonBrowseBinaryDirectory.TabIndex = 1;
            this.metroButtonBrowseBinaryDirectory.Text = "…";
            this.metroButtonBrowseBinaryDirectory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButtonBrowseBinaryDirectory.Click += new System.EventHandler(this.metroButtonBrowseBinaryDirectory_Click);
            // 
            // metroTextBoxSourceDirectory
            // 
            this.metroTextBoxSourceDirectory.CustomBackground = false;
            this.metroTextBoxSourceDirectory.CustomForeColor = false;
            this.metroTextBoxSourceDirectory.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.metroTextBoxSourceDirectory.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.metroTextBoxSourceDirectory.Location = new System.Drawing.Point(2, 70);
            this.metroTextBoxSourceDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBoxSourceDirectory.Multiline = false;
            this.metroTextBoxSourceDirectory.Name = "metroTextBoxSourceDirectory";
            this.metroTextBoxSourceDirectory.SelectedText = "";
            this.metroTextBoxSourceDirectory.Size = new System.Drawing.Size(366, 20);
            this.metroTextBoxSourceDirectory.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSourceDirectory.StyleManager = null;
            this.metroTextBoxSourceDirectory.TabIndex = 2;
            this.metroTextBoxSourceDirectory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSourceDirectory.UseStyleColors = false;
            // 
            // metroTextBoxBinaryDirectory
            // 
            this.metroTextBoxBinaryDirectory.CustomBackground = false;
            this.metroTextBoxBinaryDirectory.CustomForeColor = false;
            this.metroTextBoxBinaryDirectory.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.metroTextBoxBinaryDirectory.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.metroTextBoxBinaryDirectory.Location = new System.Drawing.Point(2, 121);
            this.metroTextBoxBinaryDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBoxBinaryDirectory.Multiline = false;
            this.metroTextBoxBinaryDirectory.Name = "metroTextBoxBinaryDirectory";
            this.metroTextBoxBinaryDirectory.SelectedText = "";
            this.metroTextBoxBinaryDirectory.Size = new System.Drawing.Size(366, 20);
            this.metroTextBoxBinaryDirectory.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxBinaryDirectory.StyleManager = null;
            this.metroTextBoxBinaryDirectory.TabIndex = 3;
            this.metroTextBoxBinaryDirectory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxBinaryDirectory.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(1, 409);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Search Word:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(2, 98);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Binary Directory:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroButtonOpenSourceDirectory
            // 
            this.metroButtonOpenSourceDirectory.Highlight = false;
            this.metroButtonOpenSourceDirectory.Location = new System.Drawing.Point(413, 52);
            this.metroButtonOpenSourceDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.metroButtonOpenSourceDirectory.Name = "metroButtonOpenSourceDirectory";
            this.metroButtonOpenSourceDirectory.Size = new System.Drawing.Size(137, 38);
            this.metroButtonOpenSourceDirectory.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButtonOpenSourceDirectory.StyleManager = null;
            this.metroButtonOpenSourceDirectory.TabIndex = 8;
            this.metroButtonOpenSourceDirectory.Text = "Open in Explorer";
            this.metroButtonOpenSourceDirectory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButtonOpenSourceDirectory.Click += new System.EventHandler(this.metroButtonOpenSourceDirectory_Click);
            // 
            // metroButtonOpenBinaryDirectory
            // 
            this.metroButtonOpenBinaryDirectory.Highlight = false;
            this.metroButtonOpenBinaryDirectory.Location = new System.Drawing.Point(413, 101);
            this.metroButtonOpenBinaryDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.metroButtonOpenBinaryDirectory.Name = "metroButtonOpenBinaryDirectory";
            this.metroButtonOpenBinaryDirectory.Size = new System.Drawing.Size(136, 40);
            this.metroButtonOpenBinaryDirectory.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButtonOpenBinaryDirectory.StyleManager = null;
            this.metroButtonOpenBinaryDirectory.TabIndex = 9;
            this.metroButtonOpenBinaryDirectory.Text = "Open in Explorer";
            this.metroButtonOpenBinaryDirectory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButtonOpenBinaryDirectory.Click += new System.EventHandler(this.metroButtonOpenBinaryDirectory_Click);
            // 
            // metroToggleOptionCompact
            // 
            this.metroToggleOptionCompact.AutoSize = true;
            this.metroToggleOptionCompact.CustomBackground = false;
            this.metroToggleOptionCompact.DisplayStatus = true;
            this.metroToggleOptionCompact.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroToggleOptionCompact.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroToggleOptionCompact.Location = new System.Drawing.Point(164, 170);
            this.metroToggleOptionCompact.Margin = new System.Windows.Forms.Padding(2);
            this.metroToggleOptionCompact.Name = "metroToggleOptionCompact";
            this.metroToggleOptionCompact.Size = new System.Drawing.Size(80, 17);
            this.metroToggleOptionCompact.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToggleOptionCompact.StyleManager = null;
            this.metroToggleOptionCompact.TabIndex = 10;
            this.metroToggleOptionCompact.Text = "Off";
            this.metroToggleOptionCompact.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToggleOptionCompact.UseStyleColors = false;
            this.metroToggleOptionCompact.UseVisualStyleBackColor = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.CustomBackground = false;
            this.metroTile1.CustomForeColor = false;
            this.metroTile1.Location = new System.Drawing.Point(2, 12);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.PaintTileCount = true;
            this.metroTile1.Size = new System.Drawing.Size(548, 24);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.StyleManager = null;
            this.metroTile1.TabIndex = 11;
            this.metroTile1.Text = "Option";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.TileCount = 0;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.CustomForeColor = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(2, 166);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(120, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Compact accessDB";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.CustomForeColor = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(2, 205);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Create .vbaproj";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = false;
            // 
            // metroToggleOptionVbaproj
            // 
            this.metroToggleOptionVbaproj.AutoSize = true;
            this.metroToggleOptionVbaproj.CustomBackground = false;
            this.metroToggleOptionVbaproj.DisplayStatus = true;
            this.metroToggleOptionVbaproj.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroToggleOptionVbaproj.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroToggleOptionVbaproj.Location = new System.Drawing.Point(164, 209);
            this.metroToggleOptionVbaproj.Margin = new System.Windows.Forms.Padding(2);
            this.metroToggleOptionVbaproj.Name = "metroToggleOptionVbaproj";
            this.metroToggleOptionVbaproj.Size = new System.Drawing.Size(80, 17);
            this.metroToggleOptionVbaproj.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToggleOptionVbaproj.StyleManager = null;
            this.metroToggleOptionVbaproj.TabIndex = 10;
            this.metroToggleOptionVbaproj.Text = "Off";
            this.metroToggleOptionVbaproj.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToggleOptionVbaproj.UseStyleColors = false;
            this.metroToggleOptionVbaproj.UseVisualStyleBackColor = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.CustomBackground = false;
            this.metroTile2.CustomForeColor = false;
            this.metroTile2.Location = new System.Drawing.Point(2, 272);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.PaintTileCount = true;
            this.metroTile2.Size = new System.Drawing.Size(555, 24);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile2.StyleManager = null;
            this.metroTile2.TabIndex = 11;
            this.metroTile2.Text = "vbac Command";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile2.TileCount = 0;
            // 
            // metroButtonSearch
            // 
            this.metroButtonSearch.Highlight = false;
            this.metroButtonSearch.Location = new System.Drawing.Point(373, 410);
            this.metroButtonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.metroButtonSearch.Name = "metroButtonSearch";
            this.metroButtonSearch.Size = new System.Drawing.Size(184, 40);
            this.metroButtonSearch.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonSearch.StyleManager = null;
            this.metroButtonSearch.TabIndex = 6;
            this.metroButtonSearch.Text = "Search";
            this.metroButtonSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButtonSearch.Click += new System.EventHandler(this.metroButtonSearch_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.CustomBackground = false;
            this.metroTile3.CustomForeColor = false;
            this.metroTile3.Location = new System.Drawing.Point(2, 369);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.PaintTileCount = true;
            this.metroTile3.Size = new System.Drawing.Size(555, 24);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile3.StyleManager = null;
            this.metroTile3.TabIndex = 11;
            this.metroTile3.Text = "pt Command";
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile3.TileCount = 0;
            // 
            // metroTextBoxSearchWord
            // 
            this.metroTextBoxSearchWord.CustomBackground = false;
            this.metroTextBoxSearchWord.CustomForeColor = false;
            this.metroTextBoxSearchWord.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.metroTextBoxSearchWord.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.metroTextBoxSearchWord.Location = new System.Drawing.Point(2, 430);
            this.metroTextBoxSearchWord.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBoxSearchWord.Multiline = false;
            this.metroTextBoxSearchWord.Name = "metroTextBoxSearchWord";
            this.metroTextBoxSearchWord.SelectedText = "";
            this.metroTextBoxSearchWord.Size = new System.Drawing.Size(366, 20);
            this.metroTextBoxSearchWord.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSearchWord.StyleManager = null;
            this.metroTextBoxSearchWord.TabIndex = 2;
            this.metroTextBoxSearchWord.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSearchWord.UseStyleColors = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = false;
            this.metroLabel5.CustomForeColor = false;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel5.Location = new System.Drawing.Point(2, 47);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(219, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.StyleManager = null;
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Source Directory (Search Directory):";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseStyleColors = false;
            // 
            // metroProgressSpinner
            // 
            this.metroProgressSpinner.Backwards = true;
            this.metroProgressSpinner.CustomBackground = false;
            this.metroProgressSpinner.Enabled = false;
            this.metroProgressSpinner.EnsureVisible = false;
            this.metroProgressSpinner.Location = new System.Drawing.Point(397, 20);
            this.metroProgressSpinner.Margin = new System.Windows.Forms.Padding(2);
            this.metroProgressSpinner.Maximum = 100;
            this.metroProgressSpinner.Name = "metroProgressSpinner";
            this.metroProgressSpinner.Size = new System.Drawing.Size(36, 38);
            this.metroProgressSpinner.Speed = 0.8F;
            this.metroProgressSpinner.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroProgressSpinner.StyleManager = null;
            this.metroProgressSpinner.TabIndex = 12;
            this.metroProgressSpinner.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroProgressSpinner.Value = 25;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.CustomBackground = false;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(574, 540);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.StyleManager = null;
            this.metroTabControl1.TabIndex = 13;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseStyleColors = false;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroTile3);
            this.metroTabPage1.Controls.Add(this.metroTile1);
            this.metroTabPage1.Controls.Add(this.metroTile2);
            this.metroTabPage1.Controls.Add(this.metroButtonBrowseBinaryDirectory);
            this.metroTabPage1.Controls.Add(this.metroTextBoxSourceDirectory);
            this.metroTabPage1.Controls.Add(this.metroToggleOptionVbaproj);
            this.metroTabPage1.Controls.Add(this.metroTextBoxSearchWord);
            this.metroTabPage1.Controls.Add(this.metroToggleOptionCompact);
            this.metroTabPage1.Controls.Add(this.metroButtonBrowseSourceDirectory);
            this.metroTabPage1.Controls.Add(this.metroButtonOpenBinaryDirectory);
            this.metroTabPage1.Controls.Add(this.metroTextBoxBinaryDirectory);
            this.metroTabPage1.Controls.Add(this.metroButtonOpenSourceDirectory);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroButtonDecompile);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroButtonCompile);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroButtonSearch);
            this.metroTabPage1.CustomBackground = false;
            this.metroTabPage1.HorizontalScrollbar = false;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(566, 498);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.StyleManager = null;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Main";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbar = false;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel14);
            this.metroTabPage2.Controls.Add(this.metroLabel12);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.metroLabel13);
            this.metroTabPage2.Controls.Add(this.metroLabel11);
            this.metroTabPage2.Controls.Add(this.metroLink6);
            this.metroTabPage2.Controls.Add(this.metroLink4);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.metroLink5);
            this.metroTabPage2.Controls.Add(this.metroLink3);
            this.metroTabPage2.Controls.Add(this.metroLink2);
            this.metroTabPage2.Controls.Add(this.metroLink1);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.CustomBackground = false;
            this.metroTabPage2.HorizontalScrollbar = false;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(566, 445);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage2.StyleManager = null;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Info";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage2.VerticalScrollbar = false;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = false;
            this.metroLabel6.CustomForeColor = false;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(19, 61);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(266, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "vbac GUI  is created by D*isuke YAMAKAWA";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = false;
            this.metroLabel7.CustomForeColor = false;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel7.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel7.Location = new System.Drawing.Point(19, 163);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(322, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.StyleManager = null;
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "vbac (vbac is not VBA Compiler) is created by @igeta";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel7.UseStyleColors = false;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.CustomBackground = false;
            this.metroLabel8.CustomForeColor = false;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel8.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel8.Location = new System.Drawing.Point(19, 269);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(365, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel8.StyleManager = null;
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "pt (the Platinum Searcher) is created by @monochromegane";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel8.UseStyleColors = false;
            // 
            // metroLink1
            // 
            this.metroLink1.CustomBackground = false;
            this.metroLink1.CustomForeColor = false;
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroLink1.Location = new System.Drawing.Point(108, 92);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(197, 23);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink1.StyleManager = null;
            this.metroLink1.TabIndex = 3;
            this.metroLink1.Text = "http://www.clockahead.com/";
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink1.UseStyleColors = false;
            // 
            // metroLink2
            // 
            this.metroLink2.CustomBackground = false;
            this.metroLink2.CustomForeColor = false;
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroLink2.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroLink2.Location = new System.Drawing.Point(108, 121);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(233, 23);
            this.metroLink2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink2.StyleManager = null;
            this.metroLink2.TabIndex = 3;
            this.metroLink2.Text = "https://github.com/dck-jp/vbacGUI";
            this.metroLink2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink2.UseStyleColors = false;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = false;
            this.metroLabel9.CustomForeColor = false;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel9.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel9.Location = new System.Drawing.Point(62, 92);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(40, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel9.StyleManager = null;
            this.metroLabel9.TabIndex = 4;
            this.metroLabel9.Text = "WEB:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel9.UseStyleColors = false;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.CustomBackground = false;
            this.metroLabel10.CustomForeColor = false;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel10.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel10.Location = new System.Drawing.Point(62, 121);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(50, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel10.StyleManager = null;
            this.metroLabel10.TabIndex = 4;
            this.metroLabel10.Text = "Github:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel10.UseStyleColors = false;
            // 
            // metroLink3
            // 
            this.metroLink3.CustomBackground = false;
            this.metroLink3.CustomForeColor = false;
            this.metroLink3.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroLink3.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroLink3.Location = new System.Drawing.Point(108, 198);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(177, 23);
            this.metroLink3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink3.StyleManager = null;
            this.metroLink3.TabIndex = 3;
            this.metroLink3.Text = "https://twitter.com/igeta/";
            this.metroLink3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink3.UseStyleColors = false;
            // 
            // metroLink4
            // 
            this.metroLink4.CustomBackground = false;
            this.metroLink4.CustomForeColor = false;
            this.metroLink4.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroLink4.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroLink4.Location = new System.Drawing.Point(108, 227);
            this.metroLink4.Name = "metroLink4";
            this.metroLink4.Size = new System.Drawing.Size(241, 23);
            this.metroLink4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink4.StyleManager = null;
            this.metroLink4.TabIndex = 3;
            this.metroLink4.Text = "https://github.com/vbaidiot/Ariawase";
            this.metroLink4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink4.UseStyleColors = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.CustomBackground = false;
            this.metroLabel11.CustomForeColor = false;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel11.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel11.Location = new System.Drawing.Point(62, 198);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(51, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel11.StyleManager = null;
            this.metroLabel11.TabIndex = 4;
            this.metroLabel11.Text = "Twitter:";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel11.UseStyleColors = false;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.CustomBackground = false;
            this.metroLabel12.CustomForeColor = false;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel12.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel12.Location = new System.Drawing.Point(62, 227);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(50, 19);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel12.StyleManager = null;
            this.metroLabel12.TabIndex = 4;
            this.metroLabel12.Text = "Github:";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel12.UseStyleColors = false;
            // 
            // metroLink5
            // 
            this.metroLink5.CustomBackground = false;
            this.metroLink5.CustomForeColor = false;
            this.metroLink5.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroLink5.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroLink5.Location = new System.Drawing.Point(108, 306);
            this.metroLink5.Name = "metroLink5";
            this.metroLink5.Size = new System.Drawing.Size(246, 23);
            this.metroLink5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink5.StyleManager = null;
            this.metroLink5.TabIndex = 3;
            this.metroLink5.Text = "https://twitter.com/monochromegane";
            this.metroLink5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink5.UseStyleColors = false;
            // 
            // metroLink6
            // 
            this.metroLink6.CustomBackground = false;
            this.metroLink6.CustomForeColor = false;
            this.metroLink6.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroLink6.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroLink6.Location = new System.Drawing.Point(108, 335);
            this.metroLink6.Name = "metroLink6";
            this.metroLink6.Size = new System.Drawing.Size(377, 23);
            this.metroLink6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink6.StyleManager = null;
            this.metroLink6.TabIndex = 3;
            this.metroLink6.Text = "https://github.com/monochromegane/the_platinum_searcher";
            this.metroLink6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink6.UseStyleColors = false;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.CustomBackground = false;
            this.metroLabel13.CustomForeColor = false;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel13.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel13.Location = new System.Drawing.Point(62, 306);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(51, 19);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel13.StyleManager = null;
            this.metroLabel13.TabIndex = 4;
            this.metroLabel13.Text = "Twitter:";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel13.UseStyleColors = false;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.CustomBackground = false;
            this.metroLabel14.CustomForeColor = false;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel14.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel14.Location = new System.Drawing.Point(62, 335);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(50, 19);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel14.StyleManager = null;
            this.metroLabel14.TabIndex = 4;
            this.metroLabel14.Text = "Github:";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel14.UseStyleColors = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 602);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroProgressSpinner);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 17);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.ShadowType.DropShadow;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "vbac GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonCompile;
        private MetroFramework.Controls.MetroButton metroButtonDecompile;
        private MetroFramework.Controls.MetroButton metroButtonBrowseSourceDirectory;
        private MetroFramework.Controls.MetroButton metroButtonBrowseBinaryDirectory;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSourceDirectory;
        private MetroFramework.Controls.MetroTextBox metroTextBoxBinaryDirectory;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButtonOpenSourceDirectory;
        private MetroFramework.Controls.MetroButton metroButtonOpenBinaryDirectory;
        private MetroFramework.Controls.MetroToggle metroToggleOptionCompact;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroToggle metroToggleOptionVbaproj;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroButton metroButtonSearch;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearchWord;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLink metroLink6;
        private MetroFramework.Controls.MetroLink metroLink4;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLink metroLink5;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}

