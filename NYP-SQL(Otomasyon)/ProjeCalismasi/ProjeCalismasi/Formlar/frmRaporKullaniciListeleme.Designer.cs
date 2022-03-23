
namespace ProjeCalismasi.Formlar
{
    partial class frmRaporKullaniciListeleme
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
            this.dgvKullaniciListele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciListele)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(468, 34);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(116, 25);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgvKullaniciListele
            // 
            this.dgvKullaniciListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullaniciListele.Location = new System.Drawing.Point(7, 83);
            this.dgvKullaniciListele.Name = "dgvKullaniciListele";
            this.dgvKullaniciListele.Size = new System.Drawing.Size(619, 365);
            this.dgvKullaniciListele.TabIndex = 2;
            // 
            // frmRaporKullaniciListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvKullaniciListele);
            this.Name = "frmRaporKullaniciListeleme";
            this.Text = "Kullanıcı Listeleme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgvKullaniciListele;
    }
}