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
    public partial class frmIsyeriYetkilisiTanimla : Form
    {
        public frmIsyeriYetkilisiTanimla()
        {
            InitializeComponent();
        }

        private readonly IsyeriYetkilisiDBEntity isyeriYetkilisiDB = new IsyeriYetkilisiDBEntity();
        private readonly IsyeriDBEntity isyeriDB = new IsyeriDBEntity();

        public void EkranHazirla()
        {
            maskedTxtBoxIsyeriID.Text = maskedTxtBoxIsyeriYetkilisiID.Text = "";
            maskedTxtBoxIsyeriID.Focus();

        }
        private void IsyeriYetkilisiListele()
        {
            dgvIsyeriYetkilisiListe.DataSource = isyeriYetkilisiDB.Listele();
            dgvIsyeriYetkilisiListe.Refresh();
        }

        private void btnIsyeriYetkilisiListele_Click(object sender, EventArgs e)
        {
            IsyeriYetkilisiListele();
        }

        private void btnTanimla_Click(object sender, EventArgs e)
        {
            if (maskedTxtBoxIsyeriID.Text != "" && maskedTxtBoxIsyeriYetkilisiID.Text != "")
            {
                int isyeriID = Convert.ToInt32(maskedTxtBoxIsyeriID.Text);
                int isyeriYetkilisiID = Convert.ToInt32(maskedTxtBoxIsyeriYetkilisiID.Text);
                isyeriDB.IsyeriYetkilisiniEkle(isyeriYetkilisiID, isyeriID);
                MessageBox.Show("İşyeri yetkilisi başarıyla tanımlanmıştır.");
                EkranHazirla();
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            }
            
        }

        private void frmIsyeriYetkilisiTanimla_Shown(object sender, EventArgs e)
        {
            EkranHazirla();
        }
    }
}
