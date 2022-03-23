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
    public partial class frmIsyeriYetkilisiKayit : Form
    {
        public frmIsyeriYetkilisiKayit()
        {
            InitializeComponent();
        }

        private readonly IsyeriYetkilisiDBEntity isyeriYetkilisiDB = new IsyeriYetkilisiDBEntity();

        private void IsyeriYetkilisiEkle(string kullaniciAdi, string sifre, string eposta, string adSoyad, string adres, string telefonNo, string dogumTarihi, string tCKimlikNo)
        {
            IsyeriYetkilisi isyeriYetkilisi = new IsyeriYetkilisi();
            isyeriYetkilisi.KullaniciAdi = kullaniciAdi;
            isyeriYetkilisi.Sifre = sifre;
            isyeriYetkilisi.Eposta = eposta;
            isyeriYetkilisi.AdSoyad = adSoyad;
            isyeriYetkilisi.Adres = adres;
            isyeriYetkilisi.TelefonNo = telefonNo;
            isyeriYetkilisi.DogumTarihi = dogumTarihi;
            isyeriYetkilisi.TCKimlikNo = tCKimlikNo;

            isyeriYetkilisiDB.Ekle(isyeriYetkilisi);
        }

       
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmIsyeriYetkilisiGiris frmIsyeriYetkilisiGiris = new frmIsyeriYetkilisiGiris();
            frmIsyeriYetkilisiGiris.Show();
            this.Hide();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && txtAdSoyad.Text != "" && txtSifre.Text != "" && txtEposta.Text != "" && txtAdres.Text != "" && maskedTxtTelefon.Text != "" && dateTimePickerDogumTarihi.Text != "")
            {
                try
                {
                    IsyeriYetkilisiEkle(txtKullaniciAdi.Text, txtSifre.Text, txtEposta.Text, txtAdSoyad.Text, txtAdres.Text, maskedTxtTelefon.Text, dateTimePickerDogumTarihi.Text, maskedTxtTCKimlikNo.Text);
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

        private void frmIsyeriYetkilisiKayit_Shown(object sender, EventArgs e)
        {
            txtAdSoyad.Focus();
        }
    }
}
