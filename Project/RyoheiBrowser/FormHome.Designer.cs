namespace RyoheiBrowser
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlStrip = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHub = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.lstFavorite = new System.Windows.Forms.ListBox();
            this.pnlMenu.SuspendLayout();
            this.pnlStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlMenu.Controls.Add(this.pnlStrip);
            this.pnlMenu.Controls.Add(this.txtUrl);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.btnReload);
            this.pnlMenu.Controls.Add(this.btnNext);
            this.pnlMenu.Controls.Add(this.btnBack);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1273, 31);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlStrip
            // 
            this.pnlStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlStrip.Controls.Add(this.menuStrip1);
            this.pnlStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlStrip.Location = new System.Drawing.Point(932, 0);
            this.pnlStrip.Name = "pnlStrip";
            this.pnlStrip.Size = new System.Drawing.Size(341, 31);
            this.pnlStrip.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHub,
            this.menuInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(341, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHub
            // 
            this.menuHub.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favoriteToolStripMenuItem,
            this.readingToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.downloadsToolStripMenuItem});
            this.menuHub.Name = "menuHub";
            this.menuHub.Size = new System.Drawing.Size(55, 29);
            this.menuHub.Text = "hub";
            // 
            // favoriteToolStripMenuItem
            // 
            this.favoriteToolStripMenuItem.Name = "favoriteToolStripMenuItem";
            this.favoriteToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.favoriteToolStripMenuItem.Text = "favorite";
            this.favoriteToolStripMenuItem.Click += new System.EventHandler(this.favoriteToolStripMenuItem_Click);
            // 
            // readingToolStripMenuItem
            // 
            this.readingToolStripMenuItem.Name = "readingToolStripMenuItem";
            this.readingToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.readingToolStripMenuItem.Text = "reading";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.historyToolStripMenuItem.Text = "history";
            // 
            // downloadsToolStripMenuItem
            // 
            this.downloadsToolStripMenuItem.Name = "downloadsToolStripMenuItem";
            this.downloadsToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.downloadsToolStripMenuItem.Text = "downloads";
            // 
            // menuInfo
            // 
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.Size = new System.Drawing.Size(55, 29);
            this.menuInfo.Text = "info";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(284, 3);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(5);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(456, 25);
            this.txtUrl.TabIndex = 11;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.Location = new System.Drawing.Point(213, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(71, 31);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "家";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnReload
            // 
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReload.Location = new System.Drawing.Point(142, 0);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(71, 31);
            this.btnReload.TabIndex = 10;
            this.btnReload.Text = "更新";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(71, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(71, 31);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 31);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 31);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(1273, 814);
            this.browser.TabIndex = 12;
            // 
            // lstFavorite
            // 
            this.lstFavorite.FormattingEnabled = true;
            this.lstFavorite.ItemHeight = 18;
            this.lstFavorite.Location = new System.Drawing.Point(422, 210);
            this.lstFavorite.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lstFavorite.Name = "lstFavorite";
            this.lstFavorite.Size = new System.Drawing.Size(125, 166);
            this.lstFavorite.TabIndex = 13;
            this.lstFavorite.SelectedIndexChanged += new System.EventHandler(this.lstFavorite_SelectedIndexChanged);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 845);
            this.Controls.Add(this.lstFavorite);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormHome";
            this.Text = "RyoheiBrowserVer1.3.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHome_FormClosed);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlStrip.ResumeLayout(false);
            this.pnlStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHub;
        private System.Windows.Forms.ToolStripMenuItem menuInfo;
        private System.Windows.Forms.Panel pnlStrip;
        private System.Windows.Forms.ToolStripMenuItem readingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoriteToolStripMenuItem;
        private System.Windows.Forms.ListBox lstFavorite;
    }
}

