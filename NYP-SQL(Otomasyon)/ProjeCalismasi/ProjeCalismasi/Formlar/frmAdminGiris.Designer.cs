namespace ProjeCalismasi.Formlar
{
    partial class frmAdminGiris
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
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.txtAdminAdi = new System.Windows.Forms.TextBox();
            this.lblAdminSifre = new System.Windows.Forms.Label();
            this.lblAdminAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(140, 115);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(77, 23);
            this.btnGeri.TabIndex = 19;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Location = new System.Drawing.Point(21, 115);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(77, 23);
            this.btnAdminGiris.TabIndex = 18;
            this.btnAdminGiris.Text = "Giriş";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Location = new System.Drawing.Point(93, 63);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.Size = new System.Drawing.Size(123, 20);
            this.txtAdminSifre.TabIndex = 17;
            // 
            // txtAdminAdi
            // 
            this.txtAdminAdi.Location = new System.Drawing.Point(93, 18);
            this.txtAdminAdi.Name = "txtAdminAdi";
            this.txtAdminAdi.Size = new System.Drawing.Size(123, 20);
            this.txtAdminAdi.TabIndex = 16;
            // 
            // lblAdminSifre
            // 
            this.lblAdminSifre.AutoSize = true;
            this.lblAdminSifre.Location = new System.Drawing.Point(18, 63);
            this.lblAdminSifre.Name = "lblAdminSifre";
            this.lblAdminSifre.Size = new System.Drawing.Size(28, 13);
            this.lblAdminSifre.TabIndex = 15;
            this.lblAdminSifre.Text = "Şifre";
            // 
            // lblAdminAdi
            // 
            this.lblAdminAdi.AutoSize = true;
            this.lblAdminAdi.Location = new System.Drawing.Point(18, 18);
            this.lblAdminAdi.Name = "lblAdminAdi";
            this.lblAdminAdi.Size = new System.Drawing.Size(57, 13);
            this.lblAdminAdi.TabIndex = 14;
            this.lblAdminAdi.Text = "Admin  Adı";
            // 
            // frmAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 173);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.txtAdminSifre);
            this.Controls.Add(this.txtAdminAdi);
            this.Controls.Add(this.lblAdminSifre);
            this.Controls.Add(this.lblAdminAdi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.TextBox txtAdminAdi;
        private System.Windows.Forms.Label lblAdminSifre;
        private System.Windows.Forms.Label lblAdminAdi;
    }
}