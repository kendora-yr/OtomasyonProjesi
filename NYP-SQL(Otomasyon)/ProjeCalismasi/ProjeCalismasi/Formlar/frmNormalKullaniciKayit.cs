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
    public partial class frmNormalKullaniciKayit : Form
    {
        public frmNormalKullaniciKayit()
        {
            InitializeComponent();
        }

        private readonly NormalKullaniciDBEntity kullaniciDB = new NormalKullaniciDBEntity();
        private void KullaniciEkle(string kullanici_adi, string sifre, string adres, string tel, string isim, string mail)
        {
            NormalKullanici kullanicilar = new NormalKullanici
            {
                Adres = adres,
                Sifre = sifre,
                KullaniciAdi = kullanici_adi,
                TelefonNo = tel,
                Eposta = mail,
                AdSoyad = isim,
            };
            kullaniciDB.Ekle(kullanicilar);

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmNormalKullaniciGiris frmKullanicilarGiris = new frmNormalKullaniciGiris();
            frmKullanicilarGiris.Show();
            this.Hide();
        }

        private void btnKullaniciKayıt_Click(object sender, EventArgs e)
        {
            if (txtKullaniciIsim.Text != "" && txtKullaniciAdi.Text != "" && txtSifre.Text != "" && txtMail.Text != "" && txtAdres.Text != "" && mtbTelefon.Text != "")
            {
                try
                {
                    KullaniciEkle(txtKullaniciAdi.Text, txtSifre.Text, txtAdres.Text, mtbTelefon.Text, txtKullaniciAdi.Text, txtMail.Text);
                    MessageBox.Show("Kayıt Tamamlandı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem Başarısız.Hata" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
            }
        }
    }
}
