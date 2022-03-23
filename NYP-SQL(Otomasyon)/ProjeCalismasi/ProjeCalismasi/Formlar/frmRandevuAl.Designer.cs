namespace ProjeCalismasi.Formlar
{
    partial class frmRandevuAl
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
            this.dgvIsyeriListele = new System.Windows.Forms.DataGridView();
            this.btnIsyeriListele = new System.Windows.Forms.Button();
            this.grpBoxRandevuBilgileri = new System.Windows.Forms.GroupBox();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.lblSaat = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.maskedTxtBoxIsyeriID = new System.Windows.Forms.MaskedTextBox();
            this.lblIsyeriID = new System.Windows.Forms.Label();
            this.btnUygunSaatleriGoster = new System.Windows.Forms.Button();
            this.btnSaat8 = new System.Windows.Forms.Button();
            this.btnSaat9 = new System.Windows.Forms.Button();
            this.btnSaat10 = new System.Windows.Forms.Button();
            this.btnSaat11 = new System.Windows.Forms.Button();
            this.btnSaat16 = new System.Windows.Forms.Button();
            this.btnSaat15 = new System.Windows.Forms.Button();
            this.btnSaat14 = new System.Windows.Forms.Button();
            this.btnSaat13 = new System.Windows.Forms.Button();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.dgvOnaylananRandevuListe = new System.Windows.Forms.DataGridView();
            this.btnOnaylananRandevulariGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriListele)).BeginInit();
            this.grpBoxRandevuBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnaylananRandevuListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIsyeriListele
            // 
            this.dgvIsyeriListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsyeriListele.Location = new System.Drawing.Point(485, 12);
            this.dgvIsyeriListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIsyeriListele.Name = "dgvIsyeriListele";
            this.dgvIsyeriListele.RowHeadersWidth = 51;
            this.dgvIsyeriListele.RowTemplate.Height = 24;
            this.dgvIsyeriListele.Size = new System.Drawing.Size(523, 302);
            this.dgvIsyeriListele.TabIndex = 0;
            // 
            // btnIsyeriListele
            // 
            this.btnIsyeriListele.Location = new System.Drawing.Point(684, 320);
            this.btnIsyeriListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIsyeriListele.Name = "btnIsyeriListele";
            this.btnIsyeriListele.Size = new System.Drawing.Size(132, 34);
            this.btnIsyeriListele.TabIndex = 1;
            this.btnIsyeriListele.Text = "İşyeri Listele";
            this.btnIsyeriListele.UseVisualStyleBackColor = true;
            this.btnIsyeriListele.Click += new System.EventHandler(this.btnIsyeriListele_Click);
            // 
            // grpBoxRandevuBilgileri
            // 
            this.grpBoxRandevuBilgileri.Controls.Add(this.txtSaat);
            this.grpBoxRandevuBilgileri.Controls.Add(this.lblSaat);
            this.grpBoxRandevuBilgileri.Controls.Add(this.dtpTarih);
            this.grpBoxRandevuBilgileri.Controls.Add(this.lblTarih);
            this.grpBoxRandevuBilgileri.Controls.Add(this.maskedTxtBoxIsyeriID);
            this.grpBoxRandevuBilgileri.Controls.Add(this.lblIsyeriID);
            this.grpBoxRandevuBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpBoxRandevuBilgileri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxRandevuBilgileri.Name = "grpBoxRandevuBilgileri";
            this.grpBoxRandevuBilgileri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxRandevuBilgileri.Size = new System.Drawing.Size(467, 149);
            this.grpBoxRandevuBilgileri.TabIndex = 2;
            this.grpBoxRandevuBilgileri.TabStop = false;
            this.grpBoxRandevuBilgileri.Text = "Randevu Bilgileri";
            // 
            // txtSaat
            // 
            this.txtSaat.Enabled = false;
            this.txtSaat.Location = new System.Drawing.Point(279, 103);
            this.txtSaat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(100, 22);
            this.txtSaat.TabIndex = 5;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(19, 103);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(206, 17);
            this.lblSaat.TabIndex = 4;
            this.lblSaat.Text = "Randevu Almak İstediğiniz Saat";
            // 
            // dtpTarih
            // 
            this.dtpTarih.CustomFormat = "dd-MM-yyyy";
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTarih.Location = new System.Drawing.Point(279, 70);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(100, 22);
            this.dtpTarih.TabIndex = 3;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(19, 70);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(210, 17);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Randevu Almak İstediğiniz Tarih";
            // 
            // maskedTxtBoxIsyeriID
            // 
            this.maskedTxtBoxIsyeriID.Location = new System.Drawing.Point(279, 38);
            this.maskedTxtBoxIsyeriID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTxtBoxIsyeriID.Mask = "00000";
            this.maskedTxtBoxIsyeriID.Name = "maskedTxtBoxIsyeriID";
            this.maskedTxtBoxIsyeriID.Size = new System.Drawing.Size(100, 22);
            this.maskedTxtBoxIsyeriID.TabIndex = 1;
            this.maskedTxtBoxIsyeriID.ValidatingType = typeof(int);
            // 
            // lblIsyeriID
            // 
            this.lblIsyeriID.AutoSize = true;
            this.lblIsyeriID.Location = new System.Drawing.Point(19, 38);
            this.lblIsyeriID.Name = "lblIsyeriID";
            this.lblIsyeriID.Size = new System.Drawing.Size(223, 17);
            this.lblIsyeriID.TabIndex = 0;
            this.lblIsyeriID.Text = "Randevu Almak İstediğiniz İşyeriID";
            // 
            // btnUygunSaatleriGoster
            // 
            this.btnUygunSaatleriGoster.Location = new System.Drawing.Point(133, 167);
            this.btnUygunSaatleriGoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUygunSaatleriGoster.Name = "btnUygunSaatleriGoster";
            this.btnUygunSaatleriGoster.Size = new System.Drawing.Size(213, 30);
            this.btnUygunSaatleriGoster.TabIndex = 3;
            this.btnUygunSaatleriGoster.Text = "Uygun Saatleri Göster";
            this.btnUygunSaatleriGoster.UseVisualStyleBackColor = true;
            this.btnUygunSaatleriGoster.Click += new System.EventHandler(this.btnUygunSaatleriGoster_Click);
            // 
            // btnSaat8
            // 
            this.btnSaat8.Enabled = false;
            this.btnSaat8.Location = new System.Drawing.Point(35, 230);
            this.btnSaat8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaat8.Name = "btnSaat8";
            this.btnSaat8.Size = new System.Drawing.Size(85, 33);
            this.btnSaat8.TabIndex = 4;
            this.btnSaat8.Text = "8";
            this.btnSaat8.UseVisualStyleBackColor = true;
            this.btnSaat8.Click += new System.EventHandler(this.btnSaat8_Click);
            // 
            // btnSaat9
            // 
            this.btnSaat9.Enabled = false;
            this.btnSaat9.Location = new System.Drawing.Point(152, 230);
            this.btnSaat9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaat9.Name = "btnSaat9";
            this.btnSaat9.Size = new System.Drawing.Size(85, 33);
            this.btnSaat9.TabIndex = 5;
            this.btnSaat9.Text = "9";
            this.btnSaat9.UseVisualStyleBackColor = true;
            this.btnSaat9.Click += new System.EventHandler(this.btnSaat9_Click);
            // 
            // btnSaat10
            // 
            this.btnSaat10.Enabled = false;
            this.btnSaat10.Location = new System.Drawing.Point(261, 230);
            this.btnSaat10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaat10.Name = "btnSaat10";
            this.btnSaat10.Size = new System.Drawing.Size(85, 33);
            this.btnSaat10.TabIndex = 6;
            this.btnSaat10.Text = "10";
            this.btnSaat10.UseVisualStyleBackColor = true;
            this.btnSaat10.Click += new System.EventHandler(this.btnSaat10_Click);
            // 
            // btnSaat11
            // 
            this.btnSaat11.Enabled = false;
            this.btnSaat11.Location = new System.Drawing.Point(367, 230);
            this.btnSaat11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaat11.Name = "btnSaat11";
            this.btnSaat11.Size = new System.Drawing.Size(85, 33);
            this.btnSaat11.TabIndex = 7;
            this.btnSaat11.Text = "11";
            this.btnSaat11.UseVisualStyleBackColor = true;
            this.btnSaat11.Click += new System.EventHandler(this.btnSaat11_Click);
            // 
            // btnSaat16
            // 
            this.btnSaat16.Enabled = false;
            this.btnSaat16.Location = new System.Drawing.Point(367, 281);
            this.btnSaat16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaat16.Name = "btnSaat16";
            this.btnSaat16.Size = new System.Drawing.Size(85, 33);
            this.btnSaat16.TabIndex = 11;
            this.btnSaat16.Text = "16";
            this.btnSaat16.UseVisualStyleBackColor = true;
            this.btnSaat16.Click += new System.EventHandler(this.btnSaat16_Click);
            // 
            // btnSaat15
            // 
            this.btnSaat15.Enabled = false;
            this.btnSaat15.Location = new System.Drawing.Point(261, 281);
            this.btnSaat15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaat15.Name = "btnSaat15";
            this.btnSaat15.Size = new System.Drawing.Size(85, 33);
            this.btnSaat15.TabIndex = 10;
            this.btnSaat15.Text = "15";
            this.btnSaat15.UseVisualStyleBackColor = true;
            this.btnSaat15.Click += new System.EventHandler(this.btnSaat15_Click);
            // 
            // btnSaat14
            // 
            this.btnSaat14.Enabled = false;
            this.btnSaat14.Location = new System.Drawing.Point(152, 281);
            this.btnSaat14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaat14.Name = "btnSaat14";
            this.btnSaat14.Size = new System.Drawing.Size(85, 33);
            this.btnSaat14.TabIndex = 9;
            this.btnSaat14.Text = "14";
            this.btnSaat14.UseVisualStyleBackColor = true;
            this.btnSaat14.Click += new System.EventHandler(this.btnSaat14_Click);
            // 
            // btnSaat13
            // 
            this.btnSaat13.Enabled = false;
            this.btnSaat13.Location = new System.Drawing.Point(35, 281);
            this.btnSaat13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaat13.Name = "btnSaat13";
            this.btnSaat13.Size = new System.Drawing.Size(85, 33);
            this.btnSaat13.TabIndex = 8;
            this.btnSaat13.Text = "13";
            this.btnSaat13.UseVisualStyleBackColor = true;
            this.btnSaat13.Click += new System.EventHandler(this.btnSaat13_Click);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Location = new System.Drawing.Point(152, 354);
            this.btnRandevuAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(183, 42);
            this.btnRandevuAl.TabIndex = 12;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // dgvOnaylananRandevuListe
            // 
            this.dgvOnaylananRandevuListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOnaylananRandevuListe.Location = new System.Drawing.Point(35, 423);
            this.dgvOnaylananRandevuListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOnaylananRandevuListe.Name = "dgvOnaylananRandevuListe";
            this.dgvOnaylananRandevuListe.RowHeadersWidth = 51;
            this.dgvOnaylananRandevuListe.RowTemplate.Height = 24;
            this.dgvOnaylananRandevuListe.Size = new System.Drawing.Size(973, 150);
            this.dgvOnaylananRandevuListe.TabIndex = 13;
            // 
            // btnOnaylananRandevulariGoster
            // 
            this.btnOnaylananRandevulariGoster.Location = new System.Drawing.Point(393, 590);
            this.btnOnaylananRandevulariGoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnaylananRandevulariGoster.Name = "btnOnaylananRandevulariGoster";
            this.btnOnaylananRandevulariGoster.Size = new System.Drawing.Size(237, 30);
            this.btnOnaylananRandevulariGoster.TabIndex = 14;
            this.btnOnaylananRandevulariGoster.Text = "Onaylanan Randevuları Göster";
            this.btnOnaylananRandevulariGoster.UseVisualStyleBackColor = true;
            this.btnOnaylananRandevulariGoster.Click += new System.EventHandler(this.btnOnaylananRandevulariGoster_Click);
            // 
            // frmRandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 633);
            this.Controls.Add(this.btnOnaylananRandevulariGoster);
            this.Controls.Add(this.dgvOnaylananRandevuListe);
            this.Controls.Add(this.btnRandevuAl);
            this.Controls.Add(this.btnSaat16);
            this.Controls.Add(this.btnSaat15);
            this.Controls.Add(this.btnSaat14);
            this.Controls.Add(this.btnSaat13);
            this.Controls.Add(this.btnSaat11);
            this.Controls.Add(this.btnSaat10);
            this.Controls.Add(this.btnSaat9);
            this.Controls.Add(this.btnSaat8);
            this.Controls.Add(this.btnUygunSaatleriGoster);
            this.Controls.Add(this.grpBoxRandevuBilgileri);
            this.Controls.Add(this.btnIsyeriListele);
            this.Controls.Add(this.dgvIsyeriListele);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRandevuAl";
            this.Text = "Randevu Oluştur";
            this.Shown += new System.EventHandler(this.frmRandevuAl_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriListele)).EndInit();
            this.grpBoxRandevuBilgileri.ResumeLayout(false);
            this.grpBoxRandevuBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnaylananRandevuListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIsyeriListele;
        private System.Windows.Forms.Button btnIsyeriListele;
        private System.Windows.Forms.GroupBox grpBoxRandevuBilgileri;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxIsyeriID;
        private System.Windows.Forms.Label lblIsyeriID;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Button btnUygunSaatleriGoster;
        private System.Windows.Forms.Button btnSaat8;
        private System.Windows.Forms.Button btnSaat9;
        private System.Windows.Forms.Button btnSaat10;
        private System.Windows.Forms.Button btnSaat11;
        private System.Windows.Forms.Button btnSaat16;
        private System.Windows.Forms.Button btnSaat15;
        private System.Windows.Forms.Button btnSaat14;
        private System.Windows.Forms.Button btnSaat13;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.DataGridView dgvOnaylananRandevuListe;
        private System.Windows.Forms.Button btnOnaylananRandevulariGoster;
    }
}