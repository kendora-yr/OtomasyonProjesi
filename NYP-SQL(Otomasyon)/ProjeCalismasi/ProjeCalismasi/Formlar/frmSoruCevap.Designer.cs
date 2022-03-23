namespace ProjeCalismasi.Formlar
{
    partial class frmIsyerineSoruSor
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
            this.lblSoruGir = new System.Windows.Forms.Label();
            this.txtSoruGir = new System.Windows.Forms.TextBox();
            this.lblIsyeriIDGir = new System.Windows.Forms.Label();
            this.maskedTxtIsyeriID = new System.Windows.Forms.MaskedTextBox();
            this.btnSoruGonder = new System.Windows.Forms.Button();
            this.grpBoxIsyerineSoruSor = new System.Windows.Forms.GroupBox();
            this.dgvCevaplar = new System.Windows.Forms.DataGridView();
            this.btnCevaplarıGoruntule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriListele)).BeginInit();
            this.grpBoxIsyerineSoruSor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCevaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIsyeriListele
            // 
            this.dgvIsyeriListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsyeriListele.Location = new System.Drawing.Point(448, 27);
            this.dgvIsyeriListele.Name = "dgvIsyeriListele";
            this.dgvIsyeriListele.RowHeadersWidth = 51;
            this.dgvIsyeriListele.RowTemplate.Height = 24;
            this.dgvIsyeriListele.Size = new System.Drawing.Size(384, 208);
            this.dgvIsyeriListele.TabIndex = 0;
            // 
            // btnIsyeriListele
            // 
            this.btnIsyeriListele.Location = new System.Drawing.Point(562, 241);
            this.btnIsyeriListele.Name = "btnIsyeriListele";
            this.btnIsyeriListele.Size = new System.Drawing.Size(171, 30);
            this.btnIsyeriListele.TabIndex = 1;
            this.btnIsyeriListele.Text = "İşyeri Listele";
            this.btnIsyeriListele.UseVisualStyleBackColor = true;
            this.btnIsyeriListele.Click += new System.EventHandler(this.btnIsyeriListele_Click);
            // 
            // lblSoruGir
            // 
            this.lblSoruGir.AutoSize = true;
            this.lblSoruGir.Location = new System.Drawing.Point(17, 69);
            this.lblSoruGir.Name = "lblSoruGir";
            this.lblSoruGir.Size = new System.Drawing.Size(222, 17);
            this.lblSoruGir.TabIndex = 2;
            this.lblSoruGir.Text = "Sorunuzu Aşağıdaki Alana Giriniz ";
            // 
            // txtSoruGir
            // 
            this.txtSoruGir.Location = new System.Drawing.Point(20, 99);
            this.txtSoruGir.Multiline = true;
            this.txtSoruGir.Name = "txtSoruGir";
            this.txtSoruGir.Size = new System.Drawing.Size(358, 80);
            this.txtSoruGir.TabIndex = 3;
            // 
            // lblIsyeriIDGir
            // 
            this.lblIsyeriIDGir.AutoSize = true;
            this.lblIsyeriIDGir.Location = new System.Drawing.Point(20, 32);
            this.lblIsyeriIDGir.Name = "lblIsyeriIDGir";
            this.lblIsyeriIDGir.Size = new System.Drawing.Size(252, 17);
            this.lblIsyeriIDGir.TabIndex = 4;
            this.lblIsyeriIDGir.Text = "Soru Sormak İstediğiniz İşyeriId Giriniz:";
            // 
            // maskedTxtIsyeriID
            // 
            this.maskedTxtIsyeriID.Location = new System.Drawing.Point(278, 32);
            this.maskedTxtIsyeriID.Name = "maskedTxtIsyeriID";
            this.maskedTxtIsyeriID.Size = new System.Drawing.Size(100, 22);
            this.maskedTxtIsyeriID.TabIndex = 5;
            // 
            // btnSoruGonder
            // 
            this.btnSoruGonder.Location = new System.Drawing.Point(164, 185);
            this.btnSoruGonder.Name = "btnSoruGonder";
            this.btnSoruGonder.Size = new System.Drawing.Size(75, 23);
            this.btnSoruGonder.TabIndex = 6;
            this.btnSoruGonder.Text = "Gönder";
            this.btnSoruGonder.UseVisualStyleBackColor = true;
            this.btnSoruGonder.Click += new System.EventHandler(this.btnSoruGonder_Click);
            // 
            // grpBoxIsyerineSoruSor
            // 
            this.grpBoxIsyerineSoruSor.Controls.Add(this.txtSoruGir);
            this.grpBoxIsyerineSoruSor.Controls.Add(this.btnSoruGonder);
            this.grpBoxIsyerineSoruSor.Controls.Add(this.lblSoruGir);
            this.grpBoxIsyerineSoruSor.Controls.Add(this.maskedTxtIsyeriID);
            this.grpBoxIsyerineSoruSor.Controls.Add(this.lblIsyeriIDGir);
            this.grpBoxIsyerineSoruSor.Location = new System.Drawing.Point(28, 27);
            this.grpBoxIsyerineSoruSor.Name = "grpBoxIsyerineSoruSor";
            this.grpBoxIsyerineSoruSor.Size = new System.Drawing.Size(404, 244);
            this.grpBoxIsyerineSoruSor.TabIndex = 7;
            this.grpBoxIsyerineSoruSor.TabStop = false;
            this.grpBoxIsyerineSoruSor.Text = "Soru Sor";
            // 
            // dgvCevaplar
            // 
            this.dgvCevaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCevaplar.Location = new System.Drawing.Point(28, 308);
            this.dgvCevaplar.Name = "dgvCevaplar";
            this.dgvCevaplar.RowHeadersWidth = 51;
            this.dgvCevaplar.RowTemplate.Height = 24;
            this.dgvCevaplar.Size = new System.Drawing.Size(804, 150);
            this.dgvCevaplar.TabIndex = 8;
            // 
            // btnCevaplarıGoruntule
            // 
            this.btnCevaplarıGoruntule.Location = new System.Drawing.Point(360, 464);
            this.btnCevaplarıGoruntule.Name = "btnCevaplarıGoruntule";
            this.btnCevaplarıGoruntule.Size = new System.Drawing.Size(145, 30);
            this.btnCevaplarıGoruntule.TabIndex = 9;
            this.btnCevaplarıGoruntule.Text = "Cevapları Görüntüle";
            this.btnCevaplarıGoruntule.UseVisualStyleBackColor = true;
            this.btnCevaplarıGoruntule.Click += new System.EventHandler(this.btnCevaplarıGoruntule_Click);
            // 
            // frmIsyerineSoruSor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 513);
            this.Controls.Add(this.btnCevaplarıGoruntule);
            this.Controls.Add(this.dgvCevaplar);
            this.Controls.Add(this.grpBoxIsyerineSoruSor);
            this.Controls.Add(this.btnIsyeriListele);
            this.Controls.Add(this.dgvIsyeriListele);
            this.Name = "frmIsyerineSoruSor";
            this.Text = "İşyerine Soru Sor";
            this.Shown += new System.EventHandler(this.frmIsyerineSoruSor_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriListele)).EndInit();
            this.grpBoxIsyerineSoruSor.ResumeLayout(false);
            this.grpBoxIsyerineSoruSor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCevaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvIsyeriListele;
        public System.Windows.Forms.Button btnIsyeriListele;
        public System.Windows.Forms.GroupBox grpBoxIsyerineSoruSor;
        public System.Windows.Forms.Label lblSoruGir;
        public System.Windows.Forms.TextBox txtSoruGir;
        public System.Windows.Forms.Label lblIsyeriIDGir;
        public System.Windows.Forms.MaskedTextBox maskedTxtIsyeriID;
        public System.Windows.Forms.Button btnSoruGonder;
        private System.Windows.Forms.DataGridView dgvCevaplar;
        private System.Windows.Forms.Button btnCevaplarıGoruntule;
    }
}