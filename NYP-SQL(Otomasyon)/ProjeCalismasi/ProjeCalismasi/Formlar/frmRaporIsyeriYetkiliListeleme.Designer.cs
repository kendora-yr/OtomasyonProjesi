
namespace ProjeCalismasi.Formlar
{
    partial class frmRaporIsyeriYetkiliListeleme
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
            this.dgvIsyeriYetkili = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriYetkili)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(440, 27);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgvIsyeriYetkili
            // 
            this.dgvIsyeriYetkili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsyeriYetkili.Location = new System.Drawing.Point(0, 83);
            this.dgvIsyeriYetkili.Name = "dgvIsyeriYetkili";
            this.dgvIsyeriYetkili.Size = new System.Drawing.Size(529, 369);
            this.dgvIsyeriYetkili.TabIndex = 2;
            // 
            // frmRaporIsyeriYetkiliListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvIsyeriYetkili);
            this.Name = "frmRaporIsyeriYetkiliListeleme";
            this.Text = "İşyeri Yetkili Listeleme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriYetkili)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgvIsyeriYetkili;
    }
}