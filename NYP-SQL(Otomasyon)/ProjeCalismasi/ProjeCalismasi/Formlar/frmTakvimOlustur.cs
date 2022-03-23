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
    public partial class frmTakvimOlustur : Form
    {
        public frmTakvimOlustur()
        {
            InitializeComponent();
        }
        private readonly RandevuyaKapaliTarihDBEntity randevuyaKapaliTarihDB = new RandevuyaKapaliTarihDBEntity();
        private readonly IsyeriDBEntity isyeriDB = new IsyeriDBEntity();
        private readonly IsyeriYetkilisiDBEntity isyeriYetkilisiDBEntity = new IsyeriYetkilisiDBEntity();
        static public string IsyeriYetkilisiKullaniciAdi;

        public void EkranHazirla()
        {
            txtGun.Text = maskedTxtBoxBaslangicSaat.Text = maskedTxtBoxBitisSaat.Text = "";
            txtGun.Focus();
        }
        private void RandevuyaKapaliTarihEkle(int isyeriID, int baslangicSaat, int bitisSaat, string gun)
        {
            RandevuyaKapaliTarih randevuyaKapaliTarih = new RandevuyaKapaliTarih();
            randevuyaKapaliTarih.IsyeriID = isyeriID;
            randevuyaKapaliTarih.BaslangicSaat = baslangicSaat;
            randevuyaKapaliTarih.BitisSaat = bitisSaat;
            randevuyaKapaliTarih.Gun = gun;
            randevuyaKapaliTarihDB.RandevuyaKapaliTarihEkle(randevuyaKapaliTarih);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int YetkilininIsyeriID = isyeriDB.YetkilinIsyeriIDTut(IsyeriYetkilisiKullaniciAdi);
            if (txtGun.Text!=""&&maskedTxtBoxBaslangicSaat.Text!=""&&maskedTxtBoxBitisSaat.Text!="")
            {
                    RandevuyaKapaliTarihEkle(YetkilininIsyeriID, Convert.ToInt32(maskedTxtBoxBaslangicSaat.Text), Convert.ToInt32(maskedTxtBoxBitisSaat.Text), txtGun.Text);
                    MessageBox.Show("Randevuya kapalı tarih başarı ile eklendi.");
                    EkranHazirla();

            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız.");
            }
        }

        private void frmTakvimOlustur_Shown(object sender, EventArgs e)
        {
            txtGun.Focus();
        }
    }
}
