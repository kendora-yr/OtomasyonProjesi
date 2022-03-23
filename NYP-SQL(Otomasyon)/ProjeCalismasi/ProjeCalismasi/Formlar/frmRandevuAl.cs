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
    public partial class frmRandevuAl : Form
    {
        public frmRandevuAl()
        {
            InitializeComponent();
        }

        private readonly RandevuDBEntity randevuDB = new RandevuDBEntity();
        private readonly RandevuyaKapaliTarihDBEntity randevuyaKapaliTarihDB = new RandevuyaKapaliTarihDBEntity();
        private readonly IsyeriDBEntity isyeriDB = new IsyeriDBEntity();
        private readonly IsyeriYetkilisiDBEntity isyeriYetkilisiDB = new IsyeriYetkilisiDBEntity();
        private readonly NormalKullaniciDBEntity normalKullaniciDB = new NormalKullaniciDBEntity();

        static public string kullaniciAdi;

        public void EkranHazirla()
        {
            maskedTxtBoxIsyeriID.Text = txtSaat.Text= "";
            maskedTxtBoxIsyeriID.Focus();
        }
        private void btnSaat8_Click(object sender, EventArgs e)
        {
            txtSaat.Text =btnSaat8.Text;
        }

        private void btnSaat9_Click(object sender, EventArgs e)
        {
            txtSaat.Text = btnSaat9.Text;
        }

        private void btnSaat10_Click(object sender, EventArgs e)
        {
            txtSaat.Text = btnSaat10.Text;
        }

        private void btnSaat11_Click(object sender, EventArgs e)
        {
            txtSaat.Text = btnSaat11.Text;
        }

        private void btnSaat13_Click(object sender, EventArgs e)
        {
            txtSaat.Text = btnSaat13.Text;
        }

        private void btnSaat14_Click(object sender, EventArgs e)
        {
            txtSaat.Text = btnSaat14.Text;
        }

        private void btnSaat15_Click(object sender, EventArgs e)
        {
            txtSaat.Text = btnSaat15.Text;
        }

        private void btnSaat16_Click(object sender, EventArgs e)
        {
            txtSaat.Text = btnSaat16.Text;
        }

        private void RandevuEkle(int isyeriID, string randevuTarihi, int randevuSaati, int randevuAlanID)
        {
            Randevu randevu = new Randevu();
            randevu.IsyeriID = isyeriID;
            randevu.RandevuTarihi = randevuTarihi;
            randevu.RandevuSaati = randevuSaati;
            randevu.OnayDurum = 2;
            randevu.RandevuAlanID = randevuAlanID;
            randevuDB.RandevuEkle(randevu);
        }

        private void IsyeriListele(string aranan)
        {
            dgvIsyeriListele.DataSource = isyeriDB.Listele(aranan);
            dgvIsyeriListele.Refresh();
        }

        private void OnaylananRandevulariListele(int kullaniciID)
        {
            dgvOnaylananRandevuListe.DataSource = randevuDB.KullaniciOnaylananRandevuListele(kullaniciID);
            dgvOnaylananRandevuListe.Refresh();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            int IsyeriID = Convert.ToInt32(maskedTxtBoxIsyeriID.Text);
            int kullaniciID = normalKullaniciDB.soruSorKullaniciID(kullaniciAdi);
            int saat =Convert.ToInt32(txtSaat.Text);
            string tarih = dtpTarih.Text;

            DateTime geciciTarih = Convert.ToDateTime(dtpTarih.Text);
            string gun = string.Empty;
            gun = geciciTarih.ToString("dddd");

            if (gun != "Cumartesi" && gun != "Pazar")
            {
                RandevuEkle(IsyeriID, tarih, saat, kullaniciID);
                MessageBox.Show("Randevu Başarıyla Eklendi.");
                EkranHazirla();
            }
            else
            {
                MessageBox.Show("Cumartesi Veya Pazar Günü Randevu Alamazsınız!.");
            }
        }

        private void btnUygunSaatleriGoster_Click(object sender, EventArgs e)
        {
            if (maskedTxtBoxIsyeriID.Text != "" && dtpTarih.Text != "")
            {

                btnSaat8.Enabled = true;
                btnSaat9.Enabled = true;
                btnSaat10.Enabled = true;
                btnSaat11.Enabled = true;
                btnSaat13.Enabled = true;
                btnSaat14.Enabled = true;
                btnSaat15.Enabled = true;
                btnSaat16.Enabled = true;

                int IsyeriID = Convert.ToInt32(maskedTxtBoxIsyeriID.Text);
                int kullaniciID = normalKullaniciDB.soruSorKullaniciID(kullaniciAdi);

                bool RandevuyaKapaliTarihKontrol = randevuyaKapaliTarihDB.RandevuyaKapaliTarihKontrol(IsyeriID);
                int baslangicSaat = randevuyaKapaliTarihDB.BaslangicSaatTut(IsyeriID);
                int bitisSaat = randevuyaKapaliTarihDB.BitisSaatTut(IsyeriID);
                string RandevuyaKapaliGun = randevuyaKapaliTarihDB.GunTut(IsyeriID);

                DateTime geciciTarih = Convert.ToDateTime(dtpTarih.Text);
                string gun = string.Empty;
                gun = geciciTarih.ToString("dddd");
                


                if (RandevuyaKapaliTarihKontrol)
                {
                    if (gun == RandevuyaKapaliGun)
                    {
                        for (int i = baslangicSaat; i <= bitisSaat; i++)
                        {
                            if (Convert.ToInt32(btnSaat8.Text) == i)
                            {
                                btnSaat8.Enabled = false;
                            }
                            else if (Convert.ToInt32(btnSaat9.Text) == i)
                            {
                                btnSaat9.Enabled = false;
                            }
                            else if (Convert.ToInt32(btnSaat10.Text) == i)
                            {
                                btnSaat10.Enabled = false;
                            }
                            else if (Convert.ToInt32(btnSaat11.Text) == i)
                            {
                                btnSaat11.Enabled = false;
                            }
                            else if (Convert.ToInt32(btnSaat13.Text) == i)
                            {
                                btnSaat13.Enabled = false;
                            }
                            else if (Convert.ToInt32(btnSaat14.Text) == i)
                            {
                                btnSaat14.Enabled = false;
                            }
                            else if (Convert.ToInt32(btnSaat15.Text) == i)
                            {
                                btnSaat9.Enabled = false;
                            }
                            else if (Convert.ToInt32(btnSaat16.Text) == i)
                            {
                                btnSaat9.Enabled = false;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz.");
            }
        }

        private void btnIsyeriListele_Click(object sender, EventArgs e)
        {
            IsyeriListele("");
        }

        private void btnOnaylananRandevulariGoster_Click(object sender, EventArgs e)
        {
            int kullaniciID = normalKullaniciDB.soruSorKullaniciID(kullaniciAdi);
            OnaylananRandevulariListele(kullaniciID);
        }

        private void frmRandevuAl_Shown(object sender, EventArgs e)
        {
            maskedTxtBoxIsyeriID.Focus();
        }
    }
}
