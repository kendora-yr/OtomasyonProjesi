namespace ProjeCalismasi.Formlar
{
    partial class frmRandevuTalepleri
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
            this.dgvRandevuTalepleri = new System.Windows.Forms.DataGridView();
            this.btnRandevuTalepleriniGoruntule = new System.Windows.Forms.Button();
            this.grpBoxRandevuTalebiOnayRed = new System.Windows.Forms.GroupBox();
            this.maskedTxtBoxRandevuID = new System.Windows.Forms.MaskedTextBox();
            this.lblRandevuID = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuTalepleri)).BeginInit();
            this.grpBoxRandevuTalebiOnayRed.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRandevuTalepleri
            // 
            this.dgvRandevuTalepleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevuTalepleri.Location = new System.Drawing.Point(497, 12);
            this.dgvRandevuTalepleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRandevuTalepleri.Name = "dgvRandevuTalepleri";
            this.dgvRandevuTalepleri.RowHeadersWidth = 51;
            this.dgvRandevuTalepleri.RowTemplate.Height = 24;
            this.dgvRandevuTalepleri.Size = new System.Drawing.Size(475, 174);
            this.dgvRandevuTalepleri.TabIndex = 0;
            // 
            // btnRandevuTalepleriniGoruntule
            // 
            this.btnRandevuTalepleriniGoruntule.Location = new System.Drawing.Point(564, 213);
            this.btnRandevuTalepleriniGoruntule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandevuTalepleriniGoruntule.Name = "btnRandevuTalepleriniGoruntule";
            this.btnRandevuTalepleriniGoruntule.Size = new System.Drawing.Size(341, 34);
            this.btnRandevuTalepleriniGoruntule.TabIndex = 1;
            this.btnRandevuTalepleriniGoruntule.Text = "Randevu Taleplerini Görüntüle";
            this.btnRandevuTalepleriniGoruntule.UseVisualStyleBackColor = true;
            this.btnRandevuTalepleriniGoruntule.Click += new System.EventHandler(this.btnRandevuTalepleriniGoruntule_Click);
            // 
            // grpBoxRandevuTalebiOnayRed
            // 
            this.grpBoxRandevuTalebiOnayRed.Controls.Add(this.maskedTxtBoxRandevuID);
            this.grpBoxRandevuTalebiOnayRed.Controls.Add(this.lblRandevuID);
            this.grpBoxRandevuTalebiOnayRed.Location = new System.Drawing.Point(36, 25);
            this.grpBoxRandevuTalebiOnayRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxRandevuTalebiOnayRed.Name = "grpBoxRandevuTalebiOnayRed";
            this.grpBoxRandevuTalebiOnayRed.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxRandevuTalebiOnayRed.Size = new System.Drawing.Size(437, 94);
            this.grpBoxRandevuTalebiOnayRed.TabIndex = 2;
            this.grpBoxRandevuTalebiOnayRed.TabStop = false;
            this.grpBoxRandevuTalebiOnayRed.Text = "Talep Düzenleme Bilgisi";
            // 
            // maskedTxtBoxRandevuID
            // 
            this.maskedTxtBoxRandevuID.Location = new System.Drawing.Point(299, 34);
            this.maskedTxtBoxRandevuID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTxtBoxRandevuID.Mask = "00000";
            this.maskedTxtBoxRandevuID.Name = "maskedTxtBoxRandevuID";
            this.maskedTxtBoxRandevuID.Size = new System.Drawing.Size(100, 22);
            this.maskedTxtBoxRandevuID.TabIndex = 1;
            this.maskedTxtBoxRandevuID.ValidatingType = typeof(int);
            // 
            // lblRandevuID
            // 
            this.lblRandevuID.AutoSize = true;
            this.lblRandevuID.Location = new System.Drawing.Point(5, 34);
            this.lblRandevuID.Name = "lblRandevuID";
            this.lblRandevuID.Size = new System.Drawing.Size(274, 17);
            this.lblRandevuID.TabIndex = 0;
            this.lblRandevuID.Text = "İşlem yapmak istediğiniz RandevuID giriniz";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(116, 134);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(115, 32);
            this.btnOnayla.TabIndex = 3;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.Location = new System.Drawing.Point(272, 134);
            this.btnReddet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(115, 32);
            this.btnReddet.TabIndex = 4;
            this.btnReddet.Text = "Reddet";
            this.btnReddet.UseVisualStyleBackColor = true;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // frmRandevuTalepleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 304);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.grpBoxRandevuTalebiOnayRed);
            this.Controls.Add(this.btnRandevuTalepleriniGoruntule);
            this.Controls.Add(this.dgvRandevuTalepleri);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRandevuTalepleri";
            this.Text = "Randevu Talepleri";
            this.Shown += new System.EventHandler(this.frmRandevuTalepleri_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuTalepleri)).EndInit();
            this.grpBoxRandevuTalebiOnayRed.ResumeLayout(false);
            this.grpBoxRandevuTalebiOnayRed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRandevuTalepleri;
        private System.Windows.Forms.Button btnRandevuTalepleriniGoruntule;
        private System.Windows.Forms.GroupBox grpBoxRandevuTalebiOnayRed;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxRandevuID;
        private System.Windows.Forms.Label lblRandevuID;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;
    }
}