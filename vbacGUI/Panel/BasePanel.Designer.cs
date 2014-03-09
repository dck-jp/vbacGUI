namespace vbacGUI.Panel
{
    partial class BasePanel
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // metroPanel
            // 
            this.metroPanel.CustomBackground = false;
            this.metroPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel.HorizontalScrollbar = false;
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(0, 0);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(548, 323);
            this.metroPanel.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel.StyleManager = null;
            this.metroPanel.TabIndex = 0;
            this.metroPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel.VerticalScrollbar = false;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // BasePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel);
            this.Name = "BasePanel";
            this.Size = new System.Drawing.Size(548, 503);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel;
    }
}
