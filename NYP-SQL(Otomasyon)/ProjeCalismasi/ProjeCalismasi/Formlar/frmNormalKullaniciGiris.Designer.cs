namespace ProjeCalismasi.Formlar
{
    partial class frmNormalKullaniciGiris
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnKullaniciKayit = new System.Windows.Forms.Button();
            this.btnKullaniciGiris = new System.Windows.Forms.Button();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullanıcıSifre = new System.Windows.Forms.Label();
            this.lblKullanıcıAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(16, 124);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(77, 23);
            this.btnGeri.TabIndex = 13;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnKullaniciKayit
            // 
            this.btnKullaniciKayit.Location = new System.Drawing.Point(220, 124);
            this.btnKullaniciKayit.Name = "btnKullaniciKayit";
            this.btnKullaniciKayit.Size = new System.Drawing.Size(77, 23);
            this.btnKullaniciKayit.TabIndex = 12;
            this.btnKullaniciKayit.Text = "Yeni Kayıt";
            this.btnKullaniciKayit.UseVisualStyleBackColor = true;
            this.btnKullaniciKayit.Click += new System.EventHandler(this.btnKullaniciKayit_Click);
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.Location = new System.Drawing.Point(117, 124);
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.Size = new System.Drawing.Size(77, 23);
            this.btnKullaniciGiris.TabIndex = 11;
            this.btnKullaniciGiris.Text = "Giriş";
            this.btnKullaniciGiris.UseVisualStyleBackColor = true;
            this.btnKullaniciGiris.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(88, 67);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(123, 20);
            this.txtKullaniciSifre.TabIndex = 10;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(88, 20);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(123, 20);
            this.txtKullaniciAdi.TabIndex = 9;
            // 
            // lblKullanıcıSifre
            // 
            this.lblKullanıcıSifre.AutoSize = true;
            this.lblKullanıcıSifre.Location = new System.Drawing.Point(13, 67);
            this.lblKullanıcıSifre.Name = "lblKullanıcıSifre";
            this.lblKullanıcıSifre.Size = new System.Drawing.Size(28, 13);
            this.lblKullanıcıSifre.TabIndex = 8;
            this.lblKullanıcıSifre.Text = "Şifre";
            // 
            // lblKullanıcıAdi
            // 
            this.lblKullanıcıAdi.AutoSize = true;
            this.lblKullanıcıAdi.Location = new System.Drawing.Point(13, 20);
            this.lblKullanıcıAdi.Name = "lblKullanıcıAdi";
            this.lblKullanıcıAdi.Size = new System.Drawing.Size(64, 13);
            this.lblKullanıcıAdi.TabIndex = 7;
            this.lblKullanıcıAdi.Text = "Kullanıcı Adı";
            // 
            // frmNormalKullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 171);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnKullaniciKayit);
            this.Controls.Add(this.btnKullaniciGiris);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullanıcıSifre);
            this.Controls.Add(this.lblKullanıcıAdi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNormalKullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGeri;
        public System.Windows.Forms.Button btnKullaniciKayit;
        public System.Windows.Forms.Button btnKullaniciGiris;
        public System.Windows.Forms.TextBox txtKullaniciSifre;
        public System.Windows.Forms.TextBox txtKullaniciAdi;
        public System.Windows.Forms.Label lblKullanıcıSifre;
        public System.Windows.Forms.Label lblKullanıcıAdi;
    }
}