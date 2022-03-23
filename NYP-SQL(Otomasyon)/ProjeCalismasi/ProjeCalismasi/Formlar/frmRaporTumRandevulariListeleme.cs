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
    public partial class frmRaporTumRandevulariListeleme : Form
    {
        public frmRaporTumRandevulariListeleme()
        {
            InitializeComponent();
        }


        private readonly RandevuDBEntity randevuDB = new RandevuDBEntity();
        private readonly IsyeriDBEntity isyeriDB = new IsyeriDBEntity();
        static public string IsyeriYetkilisiKullaniciAdi;

        private void RandevuListele(int isyeriID)
        {
            dgvRandevu.DataSource = randevuDB.TumRandevulariListele(isyeriID);
            dgvRandevu.Refresh();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            int YetkilininIsyeriID = isyeriDB.YetkilinIsyeriIDTut(IsyeriYetkilisiKullaniciAdi);
            RandevuListele(YetkilininIsyeriID);
        }
    }
}
