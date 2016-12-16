namespace RyoheiBrowser
{
    partial class FormFavorite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.btnAddFavorite = new System.Windows.Forms.Button();
            this.pnlFavorite = new System.Windows.Forms.Panel();
            this.btnDeleteFavorite = new System.Windows.Forms.Button();
            this.lstFavorite = new System.Windows.Forms.ListBox();
            this.pnlFavorite.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(812, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblFavorite
            // 
            this.lblFavorite.AutoSize = true;
            this.lblFavorite.Location = new System.Drawing.Point(34, 11);
            this.lblFavorite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(84, 18);
            this.lblFavorite.TabIndex = 2;
            this.lblFavorite.Text = "お気に入り";
            // 
            // btnAddFavorite
            // 
            this.btnAddFavorite.Location = new System.Drawing.Point(12, 34);
            this.btnAddFavorite.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddFavorite.Name = "btnAddFavorite";
            this.btnAddFavorite.Size = new System.Drawing.Size(64, 34);
            this.btnAddFavorite.TabIndex = 0;
            this.btnAddFavorite.Text = "追加";
            this.btnAddFavorite.UseVisualStyleBackColor = true;
            this.btnAddFavorite.Click += new System.EventHandler(this.btnAddFavorite_Click);
            // 
            // pnlFavorite
            // 
            this.pnlFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlFavorite.Controls.Add(this.lblFavorite);
            this.pnlFavorite.Controls.Add(this.btnDeleteFavorite);
            this.pnlFavorite.Controls.Add(this.btnAddFavorite);
            this.pnlFavorite.Location = new System.Drawing.Point(14, 82);
            this.pnlFavorite.Margin = new System.Windows.Forms.Padding(5);
            this.pnlFavorite.Name = "pnlFavorite";
            this.pnlFavorite.Size = new System.Drawing.Size(165, 74);
            this.pnlFavorite.TabIndex = 8;
            // 
            // btnDeleteFavorite
            // 
            this.btnDeleteFavorite.Location = new System.Drawing.Point(86, 34);
            this.btnDeleteFavorite.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteFavorite.Name = "btnDeleteFavorite";
            this.btnDeleteFavorite.Size = new System.Drawing.Size(65, 34);
            this.btnDeleteFavorite.TabIndex = 1;
            this.btnDeleteFavorite.Text = "削除";
            this.btnDeleteFavorite.UseVisualStyleBackColor = true;
            // 
            // lstFavorite
            // 
            this.lstFavorite.FormattingEnabled = true;
            this.lstFavorite.ItemHeight = 18;
            this.lstFavorite.Location = new System.Drawing.Point(498, 92);
            this.lstFavorite.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lstFavorite.Name = "lstFavorite";
            this.lstFavorite.Size = new System.Drawing.Size(125, 166);
            this.lstFavorite.TabIndex = 9;
            this.lstFavorite.SelectedIndexChanged += new System.EventHandler(this.lstFavorite_SelectedIndexChanged);
            // 
            // FormFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 395);
            this.Controls.Add(this.lstFavorite);
            this.Controls.Add(this.pnlFavorite);
            this.Controls.Add(this.button1);
            this.Name = "FormFavorite";
            this.Text = "FormFavorite";
            this.Load += new System.EventHandler(this.FormFavorite_Load);
            this.pnlFavorite.ResumeLayout(false);
            this.pnlFavorite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFavorite;
        private System.Windows.Forms.Button btnAddFavorite;
        private System.Windows.Forms.Panel pnlFavorite;
        private System.Windows.Forms.Button btnDeleteFavorite;
        private System.Windows.Forms.ListBox lstFavorite;
    }
}