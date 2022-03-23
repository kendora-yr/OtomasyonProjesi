
namespace ProjeCalismasi.Formlar
{
    partial class frmRaporCevaplanmamisSorulariListeleme
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
            this.dgvSorular = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorular)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(421, 32);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(101, 23);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgvSorular
            // 
            this.dgvSorular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSorular.Location = new System.Drawing.Point(-3, 82);
            this.dgvSorular.Name = "dgvSorular";
            this.dgvSorular.Size = new System.Drawing.Size(549, 366);
            this.dgvSorular.TabIndex = 4;
            // 
            // frmRaporCevaplanmamisSorulariListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvSorular);
            this.Name = "frmRaporCevaplanmamisSorulariListeleme";
            this.Text = "Cevaplanmamış Soruları Listeleme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgvSorular;
    }
}