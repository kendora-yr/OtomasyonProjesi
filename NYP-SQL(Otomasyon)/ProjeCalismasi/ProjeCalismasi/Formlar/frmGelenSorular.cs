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
    public partial class frmGelenSorular : Form
    {
        public frmGelenSorular()
        {
            InitializeComponent();
        }

        private readonly IsyeriYetkilisiDBEntity isyeriYetkilisiDB = new IsyeriYetkilisiDBEntity();
        private readonly IsyeriDBEntity isyeriDB = new IsyeriDBEntity();
        private readonly SoruCevapDBEntity soruCevapDB = new SoruCevapDBEntity();
        static public string IsyeriYetkilisiKullaniciAdi;

        public void EkranHazirla()
        {
            txtCevap.Text = maskedTxtBoxSoruCevapID.Text = "";
            maskedTxtBoxSoruCevapID.Focus();
        }
        private void SoruListele(int isyeriID)
        {
            dgvSoruListe.DataSource = soruCevapDB.SorulariListele(isyeriID);
            dgvSoruListe.Refresh();
        }

        private void CevapEkle(string cevap, int cevapID, int soruCevapID)
        {
            byte durum = 1;
            SoruCevap soruCevap = new SoruCevap();
            soruCevap.Cevap = cevap;
            soruCevap.CevapID = cevapID;
            soruCevap.SoruCevapID = soruCevapID;
            soruCevap.Durum = durum;
            soruCevapDB.CevapEkle(soruCevap);
        }

        private void btnSoruListele_Click(object sender, EventArgs e)
        {
            int YetkiliID = isyeriYetkilisiDB.YetkiliIDTut(IsyeriYetkilisiKullaniciAdi);
            int YetkilininIsyeriID = isyeriDB.YetkilinIsyeriIDTut(IsyeriYetkilisiKullaniciAdi);
            SoruListele(YetkilininIsyeriID);
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            int YetkiliID = isyeriYetkilisiDB.YetkiliIDTut(IsyeriYetkilisiKullaniciAdi);
            int YetkilininIsyeriID = isyeriDB.YetkilinIsyeriIDTut(IsyeriYetkilisiKullaniciAdi);
            SoruListele(YetkilininIsyeriID);

            if (txtCevap.Text!="" && maskedTxtBoxSoruCevapID.Text!="")
            {
                CevapEkle(txtCevap.Text, YetkiliID, Convert.ToInt32(maskedTxtBoxSoruCevapID.Text));
                SoruListele(YetkilininIsyeriID);
                MessageBox.Show("Cevap başarıyla eklendi.");
                EkranHazirla();
            } 
            else
                MessageBox.Show("Boş Alan Bırakmayınız.");
        }

        private void frmGelenSorular_Shown(object sender, EventArgs e)
        {
            EkranHazirla();
        }
    }
}
