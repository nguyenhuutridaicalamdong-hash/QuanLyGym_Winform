namespace QuanLyGym
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hộiViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.góiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýGóiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hộiViênToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.góiTậpToolStripMenuItem,
            this.đăngKýGóiTậpToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hộiViênToolStripMenuItem
            // 
            this.hộiViênToolStripMenuItem.Name = "hộiViênToolStripMenuItem";
            this.hộiViênToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.hộiViênToolStripMenuItem.Text = "Hội viên";
            this.hộiViênToolStripMenuItem.Click += new System.EventHandler(this.hộiViênToolStripMenuItem_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // góiTậpToolStripMenuItem
            // 
            this.góiTậpToolStripMenuItem.Name = "góiTậpToolStripMenuItem";
            this.góiTậpToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.góiTậpToolStripMenuItem.Text = "Gói tập";
            this.góiTậpToolStripMenuItem.Click += new System.EventHandler(this.góiTậpToolStripMenuItem_Click);
            // 
            // đăngKýGóiTậpToolStripMenuItem
            // 
            this.đăngKýGóiTậpToolStripMenuItem.Name = "đăngKýGóiTậpToolStripMenuItem";
            this.đăngKýGóiTậpToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.đăngKýGóiTậpToolStripMenuItem.Text = "Đăng ký gói tập";
            this.đăngKýGóiTậpToolStripMenuItem.Click += new System.EventHandler(this.đăngKýGóiTậpToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hộiViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem góiTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýGóiTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
    }
}