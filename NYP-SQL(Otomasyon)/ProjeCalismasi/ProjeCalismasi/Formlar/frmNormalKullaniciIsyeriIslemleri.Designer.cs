namespace ProjeCalismasi.Formlar
{
    partial class frmNormalKullaniciIsyeriIslemleri
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
            this.btnListele = new System.Windows.Forms.Button();
            this.dgvKullaniciArama = new System.Windows.Forms.DataGridView();
            this.grpIsyeriIslemleri = new System.Windows.Forms.GroupBox();
            this.cmbAramaTur = new System.Windows.Forms.ComboBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciArama)).BeginInit();
            this.grpIsyeriIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(18, 126);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(178, 23);
            this.btnListele.TabIndex = 63;
            this.btnListele.Text = "Tümünü Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgvKullaniciArama
            // 
            this.dgvKullaniciArama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullaniciArama.Location = new System.Drawing.Point(12, 173);
            this.dgvKullaniciArama.Name = "dgvKullaniciArama";
            this.dgvKullaniciArama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullaniciArama.Size = new System.Drawing.Size(644, 252);
            this.dgvKullaniciArama.TabIndex = 62;
            // 
            // grpIsyeriIslemleri
            // 
            this.grpIsyeriIslemleri.Controls.Add(this.cmbAramaTur);
            this.grpIsyeriIslemleri.Controls.Add(this.txtArama);
            this.grpIsyeriIslemleri.Location = new System.Drawing.Point(12, 22);
            this.grpIsyeriIslemleri.Name = "grpIsyeriIslemleri";
            this.grpIsyeriIslemleri.Size = new System.Drawing.Size(644, 94);
            this.grpIsyeriIslemleri.TabIndex = 61;
            this.grpIsyeriIslemleri.TabStop = false;
            this.grpIsyeriIslemleri.Text = "Arama";
            // 
            // cmbAramaTur
            // 
            this.cmbAramaTur.FormattingEnabled = true;
            this.cmbAramaTur.Items.AddRange(new object[] {
            "İşyeri İsmi",
            "Adres",
            "Telefon",
            "İşyeri Türü"});
            this.cmbAramaTur.Location = new System.Drawing.Point(6, 39);
            this.cmbAramaTur.Name = "cmbAramaTur";
            this.cmbAramaTur.Size = new System.Drawing.Size(121, 21);
            this.cmbAramaTur.TabIndex = 59;
            this.cmbAramaTur.Text = "Arama Türü";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(173, 40);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(146, 20);
            this.txtArama.TabIndex = 57;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // frmNormalKullaniciIsyeriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvKullaniciArama);
            this.Controls.Add(this.grpIsyeriIslemleri);
            this.Name = "frmNormalKullaniciIsyeriIslemleri";
            this.Text = "Normal Kullanıcı İşyeri İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciArama)).EndInit();
            this.grpIsyeriIslemleri.ResumeLayout(false);
            this.grpIsyeriIslemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgvKullaniciArama;
        private System.Windows.Forms.GroupBox grpIsyeriIslemleri;
        private System.Windows.Forms.ComboBox cmbAramaTur;
        private System.Windows.Forms.TextBox txtArama;
    }
}