namespace ProjeCalismasi.Formlar
{
    partial class frmMainNormalKullanici
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
            this.menuStripKullanici = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruSorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aramaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripKullanici.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripKullanici
            // 
            this.menuStripKullanici.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripKullanici.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.geriToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStripKullanici.Location = new System.Drawing.Point(0, 0);
            this.menuStripKullanici.Name = "menuStripKullanici";
            this.menuStripKullanici.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripKullanici.Size = new System.Drawing.Size(800, 28);
            this.menuStripKullanici.TabIndex = 1;
            this.menuStripKullanici.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soruSorToolStripMenuItem,
            this.aramaİşlemleriToolStripMenuItem,
            this.randevuAlToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.işlemlerToolStripMenuItem.Text = "İşyeri İşlemleri";
            // 
            // soruSorToolStripMenuItem
            // 
            this.soruSorToolStripMenuItem.Name = "soruSorToolStripMenuItem";
            this.soruSorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.soruSorToolStripMenuItem.Text = "Soru Sor";
            this.soruSorToolStripMenuItem.Click += new System.EventHandler(this.soruSorToolStripMenuItem_Click);
            // 
            // aramaİşlemleriToolStripMenuItem
            // 
            this.aramaİşlemleriToolStripMenuItem.Name = "aramaİşlemleriToolStripMenuItem";
            this.aramaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aramaİşlemleriToolStripMenuItem.Text = "Arama İşlemleri";
            this.aramaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.aramaİşlemleriToolStripMenuItem_Click);
            // 
            // geriToolStripMenuItem
            // 
            this.geriToolStripMenuItem.Name = "geriToolStripMenuItem";
            this.geriToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.geriToolStripMenuItem.Text = "Geri";
            this.geriToolStripMenuItem.Click += new System.EventHandler(this.geriToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // randevuAlToolStripMenuItem
            // 
            this.randevuAlToolStripMenuItem.Name = "randevuAlToolStripMenuItem";
            this.randevuAlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.randevuAlToolStripMenuItem.Text = "Randevu Al";
            this.randevuAlToolStripMenuItem.Click += new System.EventHandler(this.randevuAlToolStripMenuItem_Click);
            // 
            // frmMainNormalKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripKullanici);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripKullanici;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMainNormalKullanici";
            this.Text = "Normal Kullanıcı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripKullanici.ResumeLayout(false);
            this.menuStripKullanici.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripKullanici;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruSorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aramaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuAlToolStripMenuItem;
    }
}