namespace ProjeCalismasi.Formlar
{
    partial class frmAnaGiris
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
            this.lblHosGeldiniz = new System.Windows.Forms.Label();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnIsYeriYetkilisiGiris = new System.Windows.Forms.Button();
            this.btnNormalKullanicilarGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHosGeldiniz
            // 
            this.lblHosGeldiniz.AutoSize = true;
            this.lblHosGeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosGeldiniz.Location = new System.Drawing.Point(77, 67);
            this.lblHosGeldiniz.Name = "lblHosGeldiniz";
            this.lblHosGeldiniz.Size = new System.Drawing.Size(303, 24);
            this.lblHosGeldiniz.TabIndex = 0;
            this.lblHosGeldiniz.Text = "Randevu Sistemimize Hoş Geldiniz";
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Location = new System.Drawing.Point(24, 150);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(110, 30);
            this.btnAdminGiris.TabIndex = 1;
            this.btnAdminGiris.Text = "Admin";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // btnIsYeriYetkilisiGiris
            // 
            this.btnIsYeriYetkilisiGiris.Location = new System.Drawing.Point(167, 150);
            this.btnIsYeriYetkilisiGiris.Name = "btnIsYeriYetkilisiGiris";
            this.btnIsYeriYetkilisiGiris.Size = new System.Drawing.Size(110, 30);
            this.btnIsYeriYetkilisiGiris.TabIndex = 2;
            this.btnIsYeriYetkilisiGiris.Text = "İşyeri Yetkilisi";
            this.btnIsYeriYetkilisiGiris.UseVisualStyleBackColor = true;
            this.btnIsYeriYetkilisiGiris.Click += new System.EventHandler(this.btnIsYeriYetkilisiGiris_Click);
            // 
            // btnNormalKullanicilarGiris
            // 
            this.btnNormalKullanicilarGiris.Location = new System.Drawing.Point(308, 150);
            this.btnNormalKullanicilarGiris.Name = "btnNormalKullanicilarGiris";
            this.btnNormalKullanicilarGiris.Size = new System.Drawing.Size(110, 30);
            this.btnNormalKullanicilarGiris.TabIndex = 3;
            this.btnNormalKullanicilarGiris.Text = "Normal Kullanıcı";
            this.btnNormalKullanicilarGiris.UseVisualStyleBackColor = true;
            this.btnNormalKullanicilarGiris.Click += new System.EventHandler(this.btnNormalKullanicilarGiris_Click);
            // 
            // frmAnaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 223);
            this.Controls.Add(this.btnNormalKullanicilarGiris);
            this.Controls.Add(this.btnIsYeriYetkilisiGiris);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.lblHosGeldiniz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "frmAnaGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosGeldiniz;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnIsYeriYetkilisiGiris;
        private System.Windows.Forms.Button btnNormalKullanicilarGiris;
    }
}