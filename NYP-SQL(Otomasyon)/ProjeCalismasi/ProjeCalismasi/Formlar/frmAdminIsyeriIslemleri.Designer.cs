
namespace ProjeCalismasi.Formlar
{
    partial class frmAdminIsyeriIslemleri
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
            this.grpArama = new System.Windows.Forms.GroupBox();
            this.cmbArama = new System.Windows.Forms.ComboBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dgvIsyeri = new System.Windows.Forms.DataGridView();
            this.grpIsyeri = new System.Windows.Forms.GroupBox();
            this.mtbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblIsyeriID = new System.Windows.Forms.Label();
            this.txtIsyeriID = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblIsyeriTuru = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtIsyeriIsim = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblIsyeriIsmi = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnIsyeriEkle = new System.Windows.Forms.Button();
            this.grpArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeri)).BeginInit();
            this.grpIsyeri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpArama
            // 
            this.grpArama.Controls.Add(this.cmbArama);
            this.grpArama.Controls.Add(this.txtArama);
            this.grpArama.Location = new System.Drawing.Point(385, 418);
            this.grpArama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpArama.Name = "grpArama";
            this.grpArama.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpArama.Size = new System.Drawing.Size(464, 102);
            this.grpArama.TabIndex = 62;
            this.grpArama.TabStop = false;
            this.grpArama.Text = "Arama";
            // 
            // cmbArama
            // 
            this.cmbArama.FormattingEnabled = true;
            this.cmbArama.Items.AddRange(new object[] {
            "İşyeri ID",
            "İşyeri İsmi",
            "İşyeri Türü",
            "Adres",
            "Telefon"});
            this.cmbArama.Location = new System.Drawing.Point(8, 55);
            this.cmbArama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbArama.Name = "cmbArama";
            this.cmbArama.Size = new System.Drawing.Size(160, 24);
            this.cmbArama.TabIndex = 55;
            this.cmbArama.Text = "Arama Türü";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(201, 57);
            this.txtArama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(193, 22);
            this.txtArama.TabIndex = 55;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(57, 475);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(269, 28);
            this.btnTemizle.TabIndex = 61;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dgvIsyeri
            // 
            this.dgvIsyeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsyeri.Location = new System.Drawing.Point(385, 60);
            this.dgvIsyeri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvIsyeri.Name = "dgvIsyeri";
            this.dgvIsyeri.RowHeadersWidth = 51;
            this.dgvIsyeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsyeri.Size = new System.Drawing.Size(837, 330);
            this.dgvIsyeri.TabIndex = 59;
            this.dgvIsyeri.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIsyeri_CellEnter);
            // 
            // grpIsyeri
            // 
            this.grpIsyeri.Controls.Add(this.mtbTelefon);
            this.grpIsyeri.Controls.Add(this.lblIsyeriID);
            this.grpIsyeri.Controls.Add(this.txtIsyeriID);
            this.grpIsyeri.Controls.Add(this.cmbKategori);
            this.grpIsyeri.Controls.Add(this.lblIsyeriTuru);
            this.grpIsyeri.Controls.Add(this.txtAdres);
            this.grpIsyeri.Controls.Add(this.txtIsyeriIsim);
            this.grpIsyeri.Controls.Add(this.lblTelefon);
            this.grpIsyeri.Controls.Add(this.lblAdres);
            this.grpIsyeri.Controls.Add(this.lblIsyeriIsmi);
            this.grpIsyeri.Location = new System.Drawing.Point(23, 60);
            this.grpIsyeri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpIsyeri.Name = "grpIsyeri";
            this.grpIsyeri.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpIsyeri.Size = new System.Drawing.Size(332, 257);
            this.grpIsyeri.TabIndex = 56;
            this.grpIsyeri.TabStop = false;
            this.grpIsyeri.Text = "İşyeri Bilgileri";
            // 
            // mtbTelefon
            // 
            this.mtbTelefon.Location = new System.Drawing.Point(109, 199);
            this.mtbTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbTelefon.Mask = "9990000000";
            this.mtbTelefon.Name = "mtbTelefon";
            this.mtbTelefon.Size = new System.Drawing.Size(193, 22);
            this.mtbTelefon.TabIndex = 51;
            // 
            // lblIsyeriID
            // 
            this.lblIsyeriID.AutoSize = true;
            this.lblIsyeriID.Location = new System.Drawing.Point(31, 57);
            this.lblIsyeriID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsyeriID.Name = "lblIsyeriID";
            this.lblIsyeriID.Size = new System.Drawing.Size(58, 17);
            this.lblIsyeriID.TabIndex = 50;
            this.lblIsyeriID.Text = "İşyeri ID";
            // 
            // txtIsyeriID
            // 
            this.txtIsyeriID.Enabled = false;
            this.txtIsyeriID.Location = new System.Drawing.Point(109, 53);
            this.txtIsyeriID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsyeriID.Name = "txtIsyeriID";
            this.txtIsyeriID.Size = new System.Drawing.Size(193, 22);
            this.txtIsyeriID.TabIndex = 49;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Dişci",
            "Psikolog"});
            this.cmbKategori.Location = new System.Drawing.Point(109, 124);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(193, 24);
            this.cmbKategori.TabIndex = 48;
            // 
            // lblIsyeriTuru
            // 
            this.lblIsyeriTuru.AutoSize = true;
            this.lblIsyeriTuru.Location = new System.Drawing.Point(28, 128);
            this.lblIsyeriTuru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsyeriTuru.Name = "lblIsyeriTuru";
            this.lblIsyeriTuru.Size = new System.Drawing.Size(75, 17);
            this.lblIsyeriTuru.TabIndex = 47;
            this.lblIsyeriTuru.Text = "İşyeri Türü";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(109, 162);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(193, 22);
            this.txtAdres.TabIndex = 41;
            // 
            // txtIsyeriIsim
            // 
            this.txtIsyeriIsim.Location = new System.Drawing.Point(109, 89);
            this.txtIsyeriIsim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsyeriIsim.Name = "txtIsyeriIsim";
            this.txtIsyeriIsim.Size = new System.Drawing.Size(193, 22);
            this.txtIsyeriIsim.TabIndex = 39;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(28, 199);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 17);
            this.lblTelefon.TabIndex = 38;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(31, 162);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(45, 17);
            this.lblAdres.TabIndex = 37;
            this.lblAdres.Text = "Adres";
            // 
            // lblIsyeriIsmi
            // 
            this.lblIsyeriIsmi.AutoSize = true;
            this.lblIsyeriIsmi.Location = new System.Drawing.Point(28, 92);
            this.lblIsyeriIsmi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsyeriIsmi.Name = "lblIsyeriIsmi";
            this.lblIsyeriIsmi.Size = new System.Drawing.Size(69, 17);
            this.lblIsyeriIsmi.TabIndex = 34;
            this.lblIsyeriIsmi.Text = "İşyeri İsmi";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(209, 362);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(117, 28);
            this.btnSil.TabIndex = 58;
            this.btnSil.Text = " Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(57, 418);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(117, 28);
            this.btnListele.TabIndex = 60;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(209, 418);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(117, 28);
            this.btnGuncelle.TabIndex = 57;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnIsyeriEkle
            // 
            this.btnIsyeriEkle.Location = new System.Drawing.Point(57, 362);
            this.btnIsyeriEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIsyeriEkle.Name = "btnIsyeriEkle";
            this.btnIsyeriEkle.Size = new System.Drawing.Size(117, 28);
            this.btnIsyeriEkle.TabIndex = 55;
            this.btnIsyeriEkle.Text = "Ekle";
            this.btnIsyeriEkle.UseVisualStyleBackColor = true;
            this.btnIsyeriEkle.Click += new System.EventHandler(this.btnIsyeriEkle_Click);
            // 
            // frmAdminIsyeriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 582);
            this.Controls.Add(this.grpArama);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.dgvIsyeri);
            this.Controls.Add(this.grpIsyeri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnIsyeriEkle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdminIsyeriIslemleri";
            this.Text = "Admin İşyeri İşlemleri";
            this.Shown += new System.EventHandler(this.frmAdminIsyeriIslemleri_Shown);
            this.grpArama.ResumeLayout(false);
            this.grpArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeri)).EndInit();
            this.grpIsyeri.ResumeLayout(false);
            this.grpIsyeri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpArama;
        private System.Windows.Forms.ComboBox cmbArama;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dgvIsyeri;
        private System.Windows.Forms.GroupBox grpIsyeri;
        private System.Windows.Forms.MaskedTextBox mtbTelefon;
        private System.Windows.Forms.Label lblIsyeriID;
        private System.Windows.Forms.TextBox txtIsyeriID;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblIsyeriTuru;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtIsyeriIsim;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblIsyeriIsmi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnIsyeriEkle;
    }
}