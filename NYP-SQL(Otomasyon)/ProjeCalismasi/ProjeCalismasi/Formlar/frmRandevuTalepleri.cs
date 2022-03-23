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
    public partial class frmRandevuTalepleri : Form
    {
        public frmRandevuTalepleri()
        {
            InitializeComponent();
        }

        private readonly RandevuDBEntity randevuDB = new RandevuDBEntity();
        private readonly IsyeriYetkilisiDBEntity isyeriYetkilisiDB = new IsyeriYetkilisiDBEntity();
        private readonly IsyeriDBEntity isyeriDB = new IsyeriDBEntity();
        static public string IsyeriYetkilisiKullaniciAdi;

        public void EkranHazirla()
        {
            maskedTxtBoxRandevuID.Text = "";
            maskedTxtBoxRandevuID.Focus();
        }
        private void RandevuListele(int isyeriID)
        {
            dgvRandevuTalepleri.DataSource=randevuDB.IsyerineGelenRandevuListele(isyeriID);
            dgvRandevuTalepleri.Refresh();
        }

        private void OnayDurumDuzenleme(int onayDurum, int randevuID)
        {
            Randevu randevu = new Randevu();
            randevu.OnayDurum = onayDurum;
            randevu.RandevuID = randevuID;
            randevuDB.OnayDurumDuzenle(randevu);
        }
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int YetkilininIsyeriID = isyeriDB.YetkilinIsyeriIDTut(IsyeriYetkilisiKullaniciAdi);
            if (maskedTxtBoxRandevuID.Text != "")
            {
                OnayDurumDuzenleme(1, Convert.ToInt32(maskedTxtBoxRandevuID.Text));
                RandevuListele(YetkilininIsyeriID);
                MessageBox.Show("Randevu Başarı İle Onaylanmıştır.");
                EkranHazirla();
            }
            
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            int YetkilininIsyeriID = isyeriDB.YetkilinIsyeriIDTut(IsyeriYetkilisiKullaniciAdi);
            if (maskedTxtBoxRandevuID.Text != "")
            {
                OnayDurumDuzenleme(0, Convert.ToInt32(maskedTxtBoxRandevuID.Text));
                RandevuListele(YetkilininIsyeriID);
                MessageBox.Show("Randevu Başarı İle Reddedilmiştir.");
                EkranHazirla();
            }
        }

        private void btnRandevuTalepleriniGoruntule_Click(object sender, EventArgs e)
        {
            int YetkilininIsyeriID = isyeriDB.YetkilinIsyeriIDTut(IsyeriYetkilisiKullaniciAdi);
            RandevuListele(YetkilininIsyeriID);
        }

        private void frmRandevuTalepleri_Shown(object sender, EventArgs e)
        {
            maskedTxtBoxRandevuID.Focus();
        }
    }
}
