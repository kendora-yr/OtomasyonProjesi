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
    public partial class frmNormalKullaniciGiris : Form
    {
        public frmNormalKullaniciGiris()
        {
            InitializeComponent();
        }

        private readonly NormalKullaniciDBEntity normalKullaniciDB = new NormalKullaniciDBEntity();

        private void SonGirisZamaniDuzenle(string sonGirisZamani, int kullaniciID)
        {
            NormalKullanici normalKullanici = new NormalKullanici();
            normalKullanici.SonGirisZamani = sonGirisZamani;
            normalKullanici.KullaniciID = kullaniciID;
            normalKullaniciDB.SonGirisZamaniDuzenle(normalKullanici);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAnaGiris FrmGirisEkrani = new frmAnaGiris();
            FrmGirisEkrani.Show();
            this.Hide();
        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            string ad = txtKullaniciAdi.Text;
            string sifre = txtKullaniciSifre.Text;
            int kullaniciID = normalKullaniciDB.soruSorKullaniciID(ad);
            DateTime zaman;
            zaman = DateTime.Now;

            if (ad != "" && sifre != "")
            {
                bool giris = normalKullaniciDB.girisDogrulama(ad, sifre);
                if (giris)
                {
                    SonGirisZamaniDuzenle(zaman.ToString(), kullaniciID);
                    frmIsyerineSoruSor.kullaniciAdi = ad;
                    frmRandevuAl.kullaniciAdi = ad;
                    MessageBox.Show("Giriş Başarılı.");
                    this.Hide();
                    frmMainNormalKullanici FrmKullaniciPaneli = new frmMainNormalKullanici();
                    FrmKullaniciPaneli.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı Ya Da Şifre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Kullanıcı Adı Ya Da Şifre Boş Geçilemez.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnKullaniciKayit_Click(object sender, EventArgs e)
        {
            frmNormalKullaniciKayit frmYeniKullanicilar = new frmNormalKullaniciKayit();
            frmYeniKullanicilar.Show();
            this.Hide();
        }

      
    }
}
