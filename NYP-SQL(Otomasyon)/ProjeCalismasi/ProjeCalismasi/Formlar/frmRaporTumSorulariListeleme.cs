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
    public partial class frmRaporTumSorulariListeleme : Form
    {
        public frmRaporTumSorulariListeleme()
        {
            InitializeComponent();
        }

        private readonly IsyeriDBEntity isyeriDB = new IsyeriDBEntity();
        private readonly SoruCevapDBEntity soruCevapDB = new SoruCevapDBEntity();
        static public string IsyeriYetkilisiKullaniciAdi;


        private void SoruListele(int isyeriID)
        {
            dgvTumSorular.DataSource = soruCevapDB.TumSorulariListele(isyeriID);
            dgvTumSorular.Refresh();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            int YetkilininIsyeriID = isyeriDB.YetkilinIsyeriIDTut(IsyeriYetkilisiKullaniciAdi);
            SoruListele(YetkilininIsyeriID);
        }
    }
}
