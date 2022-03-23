namespace ProjeCalismasi.Formlar
{
    partial class frmIsyeriYetkilisiTanimla
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
            this.dgvIsyeriYetkilisiListe = new System.Windows.Forms.DataGridView();
            this.btnIsyeriYetkilisiListele = new System.Windows.Forms.Button();
            this.lblIsyeriIdGir = new System.Windows.Forms.Label();
            this.maskedTxtBoxIsyeriID = new System.Windows.Forms.MaskedTextBox();
            this.lblIsyeriYetkilisiIdGir = new System.Windows.Forms.Label();
            this.maskedTxtBoxIsyeriYetkilisiID = new System.Windows.Forms.MaskedTextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.grpBoxBilgileriGir = new System.Windows.Forms.GroupBox();
            this.btnTanimla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriYetkilisiListe)).BeginInit();
            this.grpBoxBilgileriGir.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIsyeriYetkilisiListe
            // 
            this.dgvIsyeriYetkilisiListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsyeriYetkilisiListe.Location = new System.Drawing.Point(420, 65);
            this.dgvIsyeriYetkilisiListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIsyeriYetkilisiListe.Name = "dgvIsyeriYetkilisiListe";
            this.dgvIsyeriYetkilisiListe.RowHeadersWidth = 51;
            this.dgvIsyeriYetkilisiListe.RowTemplate.Height = 24;
            this.dgvIsyeriYetkilisiListe.Size = new System.Drawing.Size(639, 194);
            this.dgvIsyeriYetkilisiListe.TabIndex = 0;
            // 
            // btnIsyeriYetkilisiListele
            // 
            this.btnIsyeriYetkilisiListele.Location = new System.Drawing.Point(623, 286);
            this.btnIsyeriYetkilisiListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIsyeriYetkilisiListele.Name = "btnIsyeriYetkilisiListele";
            this.btnIsyeriYetkilisiListele.Size = new System.Drawing.Size(265, 33);
            this.btnIsyeriYetkilisiListele.TabIndex = 1;
            this.btnIsyeriYetkilisiListele.Text = "İşyeri Yetkililerini Listele";
            this.btnIsyeriYetkilisiListele.UseVisualStyleBackColor = true;
            this.btnIsyeriYetkilisiListele.Click += new System.EventHandler(this.btnIsyeriYetkilisiListele_Click);
            // 
            // lblIsyeriIdGir
            // 
            this.lblIsyeriIdGir.AutoSize = true;
            this.lblIsyeriIdGir.Location = new System.Drawing.Point(15, 52);
            this.lblIsyeriIdGir.Name = "lblIsyeriIdGir";
            this.lblIsyeriIdGir.Size = new System.Drawing.Size(98, 17);
            this.lblIsyeriIdGir.TabIndex = 2;
            this.lblIsyeriIdGir.Text = "İşyeriID Giriniz";
            // 
            // maskedTxtBoxIsyeriID
            // 
            this.maskedTxtBoxIsyeriID.Location = new System.Drawing.Point(195, 52);
            this.maskedTxtBoxIsyeriID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTxtBoxIsyeriID.Mask = "00000";
            this.maskedTxtBoxIsyeriID.Name = "maskedTxtBoxIsyeriID";
            this.maskedTxtBoxIsyeriID.Size = new System.Drawing.Size(100, 22);
            this.maskedTxtBoxIsyeriID.TabIndex = 3;
            this.maskedTxtBoxIsyeriID.ValidatingType = typeof(int);
            // 
            // lblIsyeriYetkilisiIdGir
            // 
            this.lblIsyeriYetkilisiIdGir.AutoSize = true;
            this.lblIsyeriYetkilisiIdGir.Location = new System.Drawing.Point(15, 95);
            this.lblIsyeriYetkilisiIdGir.Name = "lblIsyeriYetkilisiIdGir";
            this.lblIsyeriYetkilisiIdGir.Size = new System.Drawing.Size(145, 17);
            this.lblIsyeriYetkilisiIdGir.TabIndex = 4;
            this.lblIsyeriYetkilisiIdGir.Text = "İşyeriYetkilisiID Giriniz";
            // 
            // maskedTxtBoxIsyeriYetkilisiID
            // 
            this.maskedTxtBoxIsyeriYetkilisiID.Location = new System.Drawing.Point(195, 95);
            this.maskedTxtBoxIsyeriYetkilisiID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTxtBoxIsyeriYetkilisiID.Mask = "00000";
            this.maskedTxtBoxIsyeriYetkilisiID.Name = "maskedTxtBoxIsyeriYetkilisiID";
            this.maskedTxtBoxIsyeriYetkilisiID.Size = new System.Drawing.Size(100, 22);
            this.maskedTxtBoxIsyeriYetkilisiID.TabIndex = 5;
            this.maskedTxtBoxIsyeriYetkilisiID.ValidatingType = typeof(int);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAciklama.Location = new System.Drawing.Point(25, 21);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(931, 24);
            this.lblAciklama.TabIndex = 6;
            this.lblAciklama.Text = "İşyeri için atamak istediğiniz işyeri yetkilisini; gerekli iş yeri ve yetkilinin " +
    "ID bilgilerini girerek gerçekleştirebilirsiniz.";
            // 
            // grpBoxBilgileriGir
            // 
            this.grpBoxBilgileriGir.Controls.Add(this.lblIsyeriIdGir);
            this.grpBoxBilgileriGir.Controls.Add(this.maskedTxtBoxIsyeriID);
            this.grpBoxBilgileriGir.Controls.Add(this.maskedTxtBoxIsyeriYetkilisiID);
            this.grpBoxBilgileriGir.Controls.Add(this.lblIsyeriYetkilisiIdGir);
            this.grpBoxBilgileriGir.Location = new System.Drawing.Point(28, 65);
            this.grpBoxBilgileriGir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxBilgileriGir.Name = "grpBoxBilgileriGir";
            this.grpBoxBilgileriGir.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxBilgileriGir.Size = new System.Drawing.Size(313, 177);
            this.grpBoxBilgileriGir.TabIndex = 7;
            this.grpBoxBilgileriGir.TabStop = false;
            this.grpBoxBilgileriGir.Text = "İşyeri Yetkilisi Tanımla";
            // 
            // btnTanimla
            // 
            this.btnTanimla.Location = new System.Drawing.Point(124, 256);
            this.btnTanimla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTanimla.Name = "btnTanimla";
            this.btnTanimla.Size = new System.Drawing.Size(100, 32);
            this.btnTanimla.TabIndex = 6;
            this.btnTanimla.Text = "Tanımla";
            this.btnTanimla.UseVisualStyleBackColor = true;
            this.btnTanimla.Click += new System.EventHandler(this.btnTanimla_Click);
            // 
            // frmIsyeriYetkilisiTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 368);
            this.Controls.Add(this.btnTanimla);
            this.Controls.Add(this.grpBoxBilgileriGir);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.btnIsyeriYetkilisiListele);
            this.Controls.Add(this.dgvIsyeriYetkilisiListe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmIsyeriYetkilisiTanimla";
            this.Text = "İşyeri Yetkilisi Tanımla";
            this.Shown += new System.EventHandler(this.frmIsyeriYetkilisiTanimla_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriYetkilisiListe)).EndInit();
            this.grpBoxBilgileriGir.ResumeLayout(false);
            this.grpBoxBilgileriGir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIsyeriYetkilisiListe;
        private System.Windows.Forms.Button btnIsyeriYetkilisiListele;
        private System.Windows.Forms.Label lblIsyeriIdGir;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxIsyeriID;
        private System.Windows.Forms.Label lblIsyeriYetkilisiIdGir;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxIsyeriYetkilisiID;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.GroupBox grpBoxBilgileriGir;
        private System.Windows.Forms.Button btnTanimla;
    }
}