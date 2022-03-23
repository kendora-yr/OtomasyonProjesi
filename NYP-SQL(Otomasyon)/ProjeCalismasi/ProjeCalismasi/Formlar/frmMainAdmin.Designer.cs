namespace ProjeCalismasi.Formlar
{
    partial class frmMainAdmin
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
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işyeriYetkilisiTanimlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isyeriIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isyeriListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isyeriYetkiliListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAdmin
            // 
            this.menuStripAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.geriToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStripAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripAdmin.Size = new System.Drawing.Size(608, 24);
            this.menuStripAdmin.TabIndex = 1;
            this.menuStripAdmin.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işyeriYetkilisiTanimlaToolStripMenuItem,
            this.isyeriIslemleriToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // işyeriYetkilisiTanimlaToolStripMenuItem
            // 
            this.işyeriYetkilisiTanimlaToolStripMenuItem.Name = "işyeriYetkilisiTanimlaToolStripMenuItem";
            this.işyeriYetkilisiTanimlaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.işyeriYetkilisiTanimlaToolStripMenuItem.Text = "İşyeri Yetkilisi Tanımla";
            this.işyeriYetkilisiTanimlaToolStripMenuItem.Click += new System.EventHandler(this.işyeriYetkilisiTanimlaToolStripMenuItem_Click);
            // 
            // isyeriIslemleriToolStripMenuItem
            // 
            this.isyeriIslemleriToolStripMenuItem.Name = "isyeriIslemleriToolStripMenuItem";
            this.isyeriIslemleriToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.isyeriIslemleriToolStripMenuItem.Text = "İşyeri İşlemleri";
            this.isyeriIslemleriToolStripMenuItem.Click += new System.EventHandler(this.isyeriIslemleriToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isyeriListelemeToolStripMenuItem,
            this.kullaniciListelemeToolStripMenuItem,
            this.isyeriYetkiliListelemeToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // geriToolStripMenuItem
            // 
            this.geriToolStripMenuItem.Name = "geriToolStripMenuItem";
            this.geriToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.geriToolStripMenuItem.Text = "Geri";
            this.geriToolStripMenuItem.Click += new System.EventHandler(this.geriToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // isyeriListelemeToolStripMenuItem
            // 
            this.isyeriListelemeToolStripMenuItem.Name = "isyeriListelemeToolStripMenuItem";
            this.isyeriListelemeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.isyeriListelemeToolStripMenuItem.Text = "İşyeri Listeleme";
            this.isyeriListelemeToolStripMenuItem.Click += new System.EventHandler(this.isyeriListelemeToolStripMenuItem_Click);
            // 
            // kullaniciListelemeToolStripMenuItem
            // 
            this.kullaniciListelemeToolStripMenuItem.Name = "kullaniciListelemeToolStripMenuItem";
            this.kullaniciListelemeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.kullaniciListelemeToolStripMenuItem.Text = "Kullanıcı Listeleme";
            this.kullaniciListelemeToolStripMenuItem.Click += new System.EventHandler(this.kullaniciListelemeToolStripMenuItem_Click);
            // 
            // isyeriYetkiliListelemeToolStripMenuItem
            // 
            this.isyeriYetkiliListelemeToolStripMenuItem.Name = "isyeriYetkiliListelemeToolStripMenuItem";
            this.isyeriYetkiliListelemeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.isyeriYetkiliListelemeToolStripMenuItem.Text = "İşyeri Yetkili Listeleme";
            this.isyeriYetkiliListelemeToolStripMenuItem.Click += new System.EventHandler(this.isyeriYetkiliListelemeToolStripMenuItem_Click);
            // 
            // frmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 364);
            this.Controls.Add(this.menuStripAdmin);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripAdmin;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainAdmin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işyeriYetkilisiTanimlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isyeriIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isyeriListelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciListelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isyeriYetkiliListelemeToolStripMenuItem;
    }
}