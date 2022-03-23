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
    public partial class frmIsyeriYetkilisiGiris : Form
    {
        public frmIsyeriYetkilisiGiris()
        {
            InitializeComponent();
        }
        private readonly IsyeriYetkilisiDBEntity isyeriYetkilisiDB = new IsyeriYetkilisiDBEntity();
        private readonly IsyeriDBEntity isyeriDB = new IsyeriDBEntity();
        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            frmIsyeriYetkilisiKayit frmIsyeriYetkilisiKayit = new frmIsyeriYetkilisiKayit();
            frmIsyeriYetkilisiKayit.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ad = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            int ID = isyeriYetkilisiDB.YetkiliIDTut(ad);
            

            if (ad != "" && sifre != "")
            {
                
                bool giris = isyeriYetkilisiDB.girisDogrulama(ad, sifre);
                bool giris2 = isyeriDB.IsyeriYetkilisiDogrulama(ID);
                if (giris && giris2)
                {
                    frmGelenSorular.IsyeriYetkilisiKullaniciAdi = ad;
                    frmTakvimOlustur.IsyeriYetkilisiKullaniciAdi = ad;
                    frmRandevuTalepleri.IsyeriYetkilisiKullaniciAdi = ad;
                    frmRaporTumSorulariListeleme.IsyeriYetkilisiKullaniciAdi = ad;
                    frmRaporCevaplanmamisSorulariListeleme.IsyeriYetkilisiKullaniciAdi = ad;
                    frmRaporTumRandevulariListeleme.IsyeriYetkilisiKullaniciAdi = ad;
                    frmRaporRetEdilmisRandevulariListeleme.IsyeriYetkilisiKullaniciAdi = ad;
                    MessageBox.Show("Giriş Başarılı.");
                    this.Hide();
                    frmMainIsyeriYetkilisi frmMainIsyeriYetkilisi = new frmMainIsyeriYetkilisi();
                    frmMainIsyeriYetkilisi.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı Ya Da Şifre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Kullanıcı Adı Ya Da Şifre Boş Geçilemez.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAnaGiris frm = new frmAnaGiris();
            frm.Show();
            this.Hide();
        }
    }
}
