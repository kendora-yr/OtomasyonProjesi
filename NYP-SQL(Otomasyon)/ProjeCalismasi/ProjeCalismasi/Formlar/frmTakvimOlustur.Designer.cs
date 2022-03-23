namespace ProjeCalismasi.Formlar
{
    partial class frmTakvimOlustur
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
            this.lblAciklama = new System.Windows.Forms.Label();
            this.grpBoxRandevuyaKapaliTarih = new System.Windows.Forms.GroupBox();
            this.maskedTxtBoxBitisSaat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxBaslangicSaat = new System.Windows.Forms.MaskedTextBox();
            this.lblBitisSaat = new System.Windows.Forms.Label();
            this.lblBaslangicSaat = new System.Windows.Forms.Label();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.lblGun = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblAciklama2 = new System.Windows.Forms.Label();
            this.grpBoxRandevuyaKapaliTarih.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(35, 31);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(608, 17);
            this.lblAciklama.TabIndex = 0;
            this.lblAciklama.Text = "Aşağıdaki alanlardan randevu alınmasını istemediğiniz gün ve saat aralığı bilgile" +
    "rini girebilirsiniz.";
            // 
            // grpBoxRandevuyaKapaliTarih
            // 
            this.grpBoxRandevuyaKapaliTarih.Controls.Add(this.maskedTxtBoxBitisSaat);
            this.grpBoxRandevuyaKapaliTarih.Controls.Add(this.maskedTxtBoxBaslangicSaat);
            this.grpBoxRandevuyaKapaliTarih.Controls.Add(this.lblBitisSaat);
            this.grpBoxRandevuyaKapaliTarih.Controls.Add(this.lblBaslangicSaat);
            this.grpBoxRandevuyaKapaliTarih.Controls.Add(this.txtGun);
            this.grpBoxRandevuyaKapaliTarih.Controls.Add(this.lblGun);
            this.grpBoxRandevuyaKapaliTarih.Location = new System.Drawing.Point(37, 87);
            this.grpBoxRandevuyaKapaliTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxRandevuyaKapaliTarih.Name = "grpBoxRandevuyaKapaliTarih";
            this.grpBoxRandevuyaKapaliTarih.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxRandevuyaKapaliTarih.Size = new System.Drawing.Size(605, 134);
            this.grpBoxRandevuyaKapaliTarih.TabIndex = 1;
            this.grpBoxRandevuyaKapaliTarih.TabStop = false;
            this.grpBoxRandevuyaKapaliTarih.Text = "Randevuya Kapalı Tarih Bilgileri";
            // 
            // maskedTxtBoxBitisSaat
            // 
            this.maskedTxtBoxBitisSaat.Location = new System.Drawing.Point(171, 98);
            this.maskedTxtBoxBitisSaat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTxtBoxBitisSaat.Mask = "00000";
            this.maskedTxtBoxBitisSaat.Name = "maskedTxtBoxBitisSaat";
            this.maskedTxtBoxBitisSaat.Size = new System.Drawing.Size(152, 22);
            this.maskedTxtBoxBitisSaat.TabIndex = 6;
            this.maskedTxtBoxBitisSaat.ValidatingType = typeof(int);
            // 
            // maskedTxtBoxBaslangicSaat
            // 
            this.maskedTxtBoxBaslangicSaat.Location = new System.Drawing.Point(171, 70);
            this.maskedTxtBoxBaslangicSaat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTxtBoxBaslangicSaat.Mask = "00000";
            this.maskedTxtBoxBaslangicSaat.Name = "maskedTxtBoxBaslangicSaat";
            this.maskedTxtBoxBaslangicSaat.Size = new System.Drawing.Size(152, 22);
            this.maskedTxtBoxBaslangicSaat.TabIndex = 5;
            this.maskedTxtBoxBaslangicSaat.ValidatingType = typeof(int);
            // 
            // lblBitisSaat
            // 
            this.lblBitisSaat.AutoSize = true;
            this.lblBitisSaat.Location = new System.Drawing.Point(33, 97);
            this.lblBitisSaat.Name = "lblBitisSaat";
            this.lblBitisSaat.Size = new System.Drawing.Size(67, 17);
            this.lblBitisSaat.TabIndex = 4;
            this.lblBitisSaat.Text = "Bitiş Saat";
            // 
            // lblBaslangicSaat
            // 
            this.lblBaslangicSaat.AutoSize = true;
            this.lblBaslangicSaat.Location = new System.Drawing.Point(33, 69);
            this.lblBaslangicSaat.Name = "lblBaslangicSaat";
            this.lblBaslangicSaat.Size = new System.Drawing.Size(94, 17);
            this.lblBaslangicSaat.TabIndex = 2;
            this.lblBaslangicSaat.Text = "Başlagıç Saat";
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(171, 42);
            this.txtGun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(152, 22);
            this.txtGun.TabIndex = 1;
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Location = new System.Drawing.Point(33, 41);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(35, 17);
            this.lblGun.TabIndex = 0;
            this.lblGun.Text = "Gün";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(263, 241);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 30);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblAciklama2
            // 
            this.lblAciklama2.AutoSize = true;
            this.lblAciklama2.Location = new System.Drawing.Point(35, 57);
            this.lblAciklama2.Name = "lblAciklama2";
            this.lblAciklama2.Size = new System.Drawing.Size(266, 17);
            this.lblAciklama2.TabIndex = 3;
            this.lblAciklama2.Text = "Gün ismi girerken ilk harfini büyük giriniz.";
            // 
            // frmTakvimOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 295);
            this.Controls.Add(this.lblAciklama2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpBoxRandevuyaKapaliTarih);
            this.Controls.Add(this.lblAciklama);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTakvimOlustur";
            this.Text = "Takvim Oluştur";
            this.Shown += new System.EventHandler(this.frmTakvimOlustur_Shown);
            this.grpBoxRandevuyaKapaliTarih.ResumeLayout(false);
            this.grpBoxRandevuyaKapaliTarih.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.GroupBox grpBoxRandevuyaKapaliTarih;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxBitisSaat;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxBaslangicSaat;
        private System.Windows.Forms.Label lblBitisSaat;
        private System.Windows.Forms.Label lblBaslangicSaat;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblAciklama2;
    }
}