namespace ProjeCalismasi.Formlar
{
    partial class frmGelenSorular
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
            this.dgvSoruListe = new System.Windows.Forms.DataGridView();
            this.btnSoruListele = new System.Windows.Forms.Button();
            this.grpBoxCevapGir = new System.Windows.Forms.GroupBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.maskedTxtBoxSoruCevapID = new System.Windows.Forms.MaskedTextBox();
            this.lblCevap = new System.Windows.Forms.Label();
            this.lblSoruID = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoruListe)).BeginInit();
            this.grpBoxCevapGir.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSoruListe
            // 
            this.dgvSoruListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoruListe.Location = new System.Drawing.Point(517, 31);
            this.dgvSoruListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSoruListe.Name = "dgvSoruListe";
            this.dgvSoruListe.RowHeadersWidth = 51;
            this.dgvSoruListe.RowTemplate.Height = 24;
            this.dgvSoruListe.Size = new System.Drawing.Size(608, 246);
            this.dgvSoruListe.TabIndex = 0;
            // 
            // btnSoruListele
            // 
            this.btnSoruListele.Location = new System.Drawing.Point(721, 288);
            this.btnSoruListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSoruListele.Name = "btnSoruListele";
            this.btnSoruListele.Size = new System.Drawing.Size(192, 37);
            this.btnSoruListele.TabIndex = 1;
            this.btnSoruListele.Text = "Soruları Listele";
            this.btnSoruListele.UseVisualStyleBackColor = true;
            this.btnSoruListele.Click += new System.EventHandler(this.btnSoruListele_Click);
            // 
            // grpBoxCevapGir
            // 
            this.grpBoxCevapGir.Controls.Add(this.txtCevap);
            this.grpBoxCevapGir.Controls.Add(this.maskedTxtBoxSoruCevapID);
            this.grpBoxCevapGir.Controls.Add(this.lblCevap);
            this.grpBoxCevapGir.Controls.Add(this.lblSoruID);
            this.grpBoxCevapGir.Location = new System.Drawing.Point(57, 31);
            this.grpBoxCevapGir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxCevapGir.Name = "grpBoxCevapGir";
            this.grpBoxCevapGir.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxCevapGir.Size = new System.Drawing.Size(417, 251);
            this.grpBoxCevapGir.TabIndex = 2;
            this.grpBoxCevapGir.TabStop = false;
            this.grpBoxCevapGir.Text = "Cevaplar";
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(33, 106);
            this.txtCevap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCevap.Multiline = true;
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(361, 111);
            this.txtCevap.TabIndex = 3;
            // 
            // maskedTxtBoxSoruCevapID
            // 
            this.maskedTxtBoxSoruCevapID.Location = new System.Drawing.Point(171, 39);
            this.maskedTxtBoxSoruCevapID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTxtBoxSoruCevapID.Mask = "00000";
            this.maskedTxtBoxSoruCevapID.Name = "maskedTxtBoxSoruCevapID";
            this.maskedTxtBoxSoruCevapID.Size = new System.Drawing.Size(100, 22);
            this.maskedTxtBoxSoruCevapID.TabIndex = 2;
            this.maskedTxtBoxSoruCevapID.ValidatingType = typeof(int);
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(29, 78);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(92, 17);
            this.lblCevap.TabIndex = 1;
            this.lblCevap.Text = "Cevap Giriniz";
            // 
            // lblSoruID
            // 
            this.lblSoruID.AutoSize = true;
            this.lblSoruID.Location = new System.Drawing.Point(29, 39);
            this.lblSoruID.Name = "lblSoruID";
            this.lblSoruID.Size = new System.Drawing.Size(135, 17);
            this.lblSoruID.TabIndex = 0;
            this.lblSoruID.Text = "SoruCevapID Giriniz";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(211, 288);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(117, 30);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Cevap Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // frmGelenSorular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 374);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.grpBoxCevapGir);
            this.Controls.Add(this.btnSoruListele);
            this.Controls.Add(this.dgvSoruListe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGelenSorular";
            this.Text = "Gelen Sorular";
            this.Shown += new System.EventHandler(this.frmGelenSorular_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoruListe)).EndInit();
            this.grpBoxCevapGir.ResumeLayout(false);
            this.grpBoxCevapGir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSoruListe;
        private System.Windows.Forms.Button btnSoruListele;
        private System.Windows.Forms.GroupBox grpBoxCevapGir;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxSoruCevapID;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Label lblSoruID;
        private System.Windows.Forms.Button btnGonder;
    }
}