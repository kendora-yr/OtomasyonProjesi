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
using System.Data.SqlClient;

namespace ProjeCalismasi.Formlar
{
    public partial class frmNormalKullaniciIsyeriIslemleri : Form
    {
        public frmNormalKullaniciIsyeriIslemleri()
        {
            InitializeComponent();
        }

        private readonly IsyeriDBEntity isyeriDB = new IsyeriDBEntity();

        private void Listele(string aranan)
        {
            dgvKullaniciArama.DataSource = isyeriDB.Listele(aranan);
            dgvKullaniciArama.Refresh();
        }

      

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele("");
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string arama = txtArama.Text;
            if (cmbAramaTur.SelectedIndex < 0 && arama.Length > 0)
            {
                MessageBox.Show("Arama Türünü Seçin!");
                txtArama.Text = "";
                cmbAramaTur.Focus();
            }
            else
            {
                if (cmbAramaTur.SelectedIndex == 0)
                {
                    Listele("Isim  Like '" + arama + "%'");
                }
                if (cmbAramaTur.SelectedIndex == 1)
                {
                    Listele("Adres  Like '" + arama + "%'");
                }
                if (cmbAramaTur.SelectedIndex == 2)
                {
                    Listele("Telefon  Like '" + arama + "%'");
                }
                if (cmbAramaTur.SelectedIndex == 3)
                {
                    Listele("IsyeriTur Like '" + arama + "%'");
                }

            }

        }
    }
}
