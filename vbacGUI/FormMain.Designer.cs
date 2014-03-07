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
            this.SuspendLayout();
            // 
            // metroButtonCompile
            // 
            this.metroButtonCompile.Highlight = false;
            this.metroButtonCompile.Location = new System.Drawing.Point(392, 361);
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
            this.metroButtonDecompile.Location = new System.Drawing.Point(203, 361);
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
            this.metroButtonBrowseSourceDirectory.Location = new System.Drawing.Point(392, 111);
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
            this.metroButtonBrowseBinaryDirectory.Location = new System.Drawing.Point(392, 161);
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
            this.metroTextBoxSourceDirectory.Location = new System.Drawing.Point(20, 130);
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
            this.metroTextBoxBinaryDirectory.Location = new System.Drawing.Point(20, 181);
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
            this.metroLabel1.Location = new System.Drawing.Point(19, 469);
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
            this.metroLabel2.Location = new System.Drawing.Point(20, 158);
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
            this.metroButtonOpenSourceDirectory.Location = new System.Drawing.Point(431, 112);
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
            this.metroButtonOpenBinaryDirectory.Location = new System.Drawing.Point(431, 161);
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
            this.metroToggleOptionCompact.Location = new System.Drawing.Point(182, 230);
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
            this.metroTile1.Location = new System.Drawing.Point(20, 72);
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
            this.metroLabel3.Location = new System.Drawing.Point(20, 226);
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
            this.metroLabel4.Location = new System.Drawing.Point(20, 265);
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
            this.metroToggleOptionVbaproj.Location = new System.Drawing.Point(182, 269);
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
            this.metroTile2.Location = new System.Drawing.Point(20, 332);
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
            this.metroButtonSearch.Location = new System.Drawing.Point(391, 470);
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
            this.metroTile3.Location = new System.Drawing.Point(20, 429);
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
            this.metroTextBoxSearchWord.Location = new System.Drawing.Point(20, 490);
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
            this.metroLabel5.Location = new System.Drawing.Point(20, 107);
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
            this.metroProgressSpinner.Location = new System.Drawing.Point(431, 28);
            this.metroProgressSpinner.Margin = new System.Windows.Forms.Padding(2);
            this.metroProgressSpinner.Maximum = 100;
            this.metroProgressSpinner.Name = "metroProgressSpinner";
            this.metroProgressSpinner.Size = new System.Drawing.Size(43, 40);
            this.metroProgressSpinner.Speed = 0.8F;
            this.metroProgressSpinner.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroProgressSpinner.StyleManager = null;
            this.metroProgressSpinner.TabIndex = 12;
            this.metroProgressSpinner.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroProgressSpinner.Value = 25;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 554);
            this.Controls.Add(this.metroProgressSpinner);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroToggleOptionVbaproj);
            this.Controls.Add(this.metroToggleOptionCompact);
            this.Controls.Add(this.metroButtonOpenBinaryDirectory);
            this.Controls.Add(this.metroButtonOpenSourceDirectory);
            this.Controls.Add(this.metroButtonDecompile);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButtonSearch);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButtonCompile);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxBinaryDirectory);
            this.Controls.Add(this.metroButtonBrowseSourceDirectory);
            this.Controls.Add(this.metroTextBoxSearchWord);
            this.Controls.Add(this.metroTextBoxSourceDirectory);
            this.Controls.Add(this.metroButtonBrowseBinaryDirectory);
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
            this.Text = "vbac with pt GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

