
namespace ProjeCalismasi.Formlar
{
    partial class frmRaporIsyeriListeleme
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
            this.dgvIsyeri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(450, 22);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(101, 23);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgvIsyeri
            // 
            this.dgvIsyeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsyeri.Location = new System.Drawing.Point(-1, 71);
            this.dgvIsyeri.Name = "dgvIsyeri";
            this.dgvIsyeri.RowHeadersWidth = 51;
            this.dgvIsyeri.Size = new System.Drawing.Size(586, 384);
            this.dgvIsyeri.TabIndex = 2;
            // 
            // frmRaporIsyeriListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvIsyeri);
            this.Name = "frmRaporIsyeriListeleme";
            this.Text = "İşyeri Listeleme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgvIsyeri;
    }
}