using ProjeCalismasi.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeCalismasi.Formlar
{
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }

        private readonly AdminDBEntity adminDB = new AdminDBEntity();


        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAnaGiris FrmGirisEkrani = new frmAnaGiris();
            FrmGirisEkrani.Show();
            this.Hide();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            string ad = txtAdminAdi.Text;
            string sifre = txtAdminSifre.Text;

            if (ad != "" && sifre != "")
            {
                bool giris = adminDB.girisDogrulama(ad, sifre);
                if (giris)
                {
                    MessageBox.Show("Giriş Başarılı.");
                    this.Hide();
                    frmMainAdmin Frm = new frmMainAdmin();
                    Frm.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Admin Adı Ya Da Şifre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else

                MessageBox.Show("Admin Adı Ya Da Şifre Boş Geçilemez.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
