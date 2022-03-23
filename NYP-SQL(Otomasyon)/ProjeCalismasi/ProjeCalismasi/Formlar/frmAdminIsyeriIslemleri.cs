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
    public partial class frmAdminIsyeriIslemleri : Form
    {
        public frmAdminIsyeriIslemleri()
        {
            InitializeComponent();
        }

        private void EkranHazirla()
        {
            txtAdres.Text = txtIsyeriIsim.Text = mtbTelefon.Text = cmbKategori.Text = txtIsyeriID.Text = "";
            txtIsyeriIsim.Focus();
        }

        private void dgvIsyeri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtIsyeriID.Text = dgvIsyeri.CurrentRow.Cells[0].Value.ToString();
            txtIsyeriIsim.Text = dgvIsyeri.CurrentRow.Cells[1].Value.ToString();
            cmbKategori.Text = dgvIsyeri.CurrentRow.Cells[2].Value.ToString();
            txtAdres.Text = dgvIsyeri.CurrentRow.Cells[4].Value.ToString();
            mtbTelefon.Text = dgvIsyeri.CurrentRow.Cells[5].Value.ToString();
        }

        private readonly IsyeriDBEntity isyeriDB = new IsyeriDBEntity();

        private void IsyeriEkle(string Isyeri, string tur, string adres, string tel)
        {
            Isyeri isyeri = new Isyeri
            {
                Isim = Isyeri,
                IsyeriTur = tur,
                Adres = adres,
                Telefon = tel,
            };
            isyeriDB.Ekle(isyeri);
        }

        private void Sil(int ID)
        {
            Isyeri isyeri = new Isyeri
            {
                IsyeriID = ID,
            };
            isyeriDB.Sil(isyeri);
        }

        private void Guncelle(string Isyeri, string tur, string adres, string tel, int ID)
        {
            Isyeri isyeri = new Isyeri
            {
                Isim = Isyeri,
                IsyeriTur = tur,
                Adres = adres,
                Telefon = tel,
                IsyeriID = ID,
            };
            isyeriDB.KayitGuncelleme(isyeri);
        }

        private void Listele(string aranan)
        {
            dgvIsyeri.DataSource = isyeriDB.Listele(aranan);
            dgvIsyeri.Refresh();
        }

        private void btnIsyeriEkle_Click(object sender, EventArgs e)
        {
            if (txtIsyeriIsim.Text != "" && cmbKategori.Text != "" && txtAdres.Text != "" && mtbTelefon.Text != "")
            {
                try
                {                    
                    IsyeriEkle(txtIsyeriIsim.Text, cmbKategori.Text, txtAdres.Text, mtbTelefon.Text);
                    Listele("");
                    MessageBox.Show("Kayıt Tamamlandı.");
                    EkranHazirla();
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvIsyeri.SelectedRows.Count != 0)
            {
                try
                {
                    Sil(Convert.ToInt32(txtIsyeriID.Text));
                    Listele("");
                    MessageBox.Show("Kayıt Silindi.");
                    EkranHazirla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem Başarısız.Hata" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }

            }
            else
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!");
            }


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele("");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvIsyeri.SelectedRows.Count != 0)
            {
                try
                {
                    Guncelle(txtIsyeriIsim.Text, cmbKategori.Text, txtAdres.Text, mtbTelefon.Text, Convert.ToInt32(txtIsyeriID.Text));
                    Listele("");
                    MessageBox.Show("Kayıt Güncellendi.");
                    EkranHazirla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem Başarısız.Hata" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }

            }
            else
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!");
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            EkranHazirla();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string arama = txtArama.Text;
            if (cmbArama.SelectedIndex < 0 && arama.Length > 0)
            {
                MessageBox.Show("Arama Türünü Seçin!");
                txtArama.Text = "";
                cmbArama.Focus();
            }
            else
            {
                if (cmbArama.SelectedIndex == 0)
                {
                    Listele("IsyeriID  Like '" + arama + "%'");
                }
                if (cmbArama.SelectedIndex == 1)
                {
                    Listele("Isim  Like '" + arama + "%'");
                }
                if (cmbArama.SelectedIndex == 2)
                {
                    Listele("IsyeriTur Like '" + arama + "%'");
                }
                if (cmbArama.SelectedIndex == 3)
                {
                    Listele("Adres  Like '" + arama + "%'");
                }
                if (cmbArama.SelectedIndex == 4)
                {
                    Listele("Telefon  Like '" + arama + "%'");
                }

            }

        }

        private void frmAdminIsyeriIslemleri_Shown(object sender, EventArgs e)
        {
            txtIsyeriIsim.Focus();
        }
    }
}

