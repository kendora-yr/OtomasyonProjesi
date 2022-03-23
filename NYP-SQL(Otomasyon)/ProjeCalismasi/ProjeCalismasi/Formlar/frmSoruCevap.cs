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
    public partial class frmIsyerineSoruSor : Form
    {
        public frmIsyerineSoruSor()
        {
            InitializeComponent();
        }

        static public string kullaniciAdi;

        private readonly IsyeriDBEntity isyeriDB = new IsyeriDBEntity();
        private readonly NormalKullaniciDBEntity normalKullaniciDB = new NormalKullaniciDBEntity();
        private readonly SoruCevapDBEntity soruCevapDB=new SoruCevapDBEntity();

        private void EkranHazirla()
        {
                maskedTxtIsyeriID.Text = "";
                txtSoruGir.Text = "";
                maskedTxtIsyeriID.Focus();
        }
        private void SoruEkle(int isyeriID, int soranID, string soru)
        {
            SoruCevap soruCevap = new SoruCevap();
            soruCevap.IsyeriID = isyeriID;
            soruCevap.SoranID = soranID;
            soruCevap.Soru = soru;
            soruCevap.Durum = 0;
            soruCevapDB.SoruEkle(soruCevap);
        }
        private void IsyeriListele(string aranan)
        {
            dgvIsyeriListele.DataSource = isyeriDB.Listele(aranan);
            dgvIsyeriListele.Refresh();
        }

        private void btnIsyeriListele_Click(object sender, EventArgs e)
        {
            IsyeriListele("");
        }

        private void btnSoruGonder_Click(object sender, EventArgs e)
        {
            
            
            int isyeriID = Convert.ToInt32(maskedTxtIsyeriID.Text);
            string soru = txtSoruGir.Text;
            int kullaniciID = normalKullaniciDB.soruSorKullaniciID(kullaniciAdi);
            if (soru != "" && maskedTxtIsyeriID.Text!="")
            {
                SoruEkle(isyeriID, kullaniciID, soru);
                MessageBox.Show("Sorunuz Başarıyla Gönderildi.");
                EkranHazirla();
            }
            else
                MessageBox.Show("Boş alan bırakmayınız.");
            
        }
        private void CevaplariListele(int soranID)
        {
            dgvCevaplar.DataSource = soruCevapDB.CevaplariListele(soranID);
            dgvCevaplar.Refresh();
        }
        private void btnCevaplarıGoruntule_Click(object sender, EventArgs e)
        {
            int kullaniciID = normalKullaniciDB.soruSorKullaniciID(kullaniciAdi);
            CevaplariListele(kullaniciID);
        }

        private void frmIsyerineSoruSor_Shown(object sender, EventArgs e)
        {
            maskedTxtIsyeriID.Focus();
        }
    }
}
