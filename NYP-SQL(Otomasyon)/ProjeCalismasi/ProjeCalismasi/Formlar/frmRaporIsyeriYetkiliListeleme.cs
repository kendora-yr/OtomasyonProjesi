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
    public partial class frmRaporIsyeriYetkiliListeleme : Form
    {
        public frmRaporIsyeriYetkiliListeleme()
        {
            InitializeComponent();
        }

        private readonly IsyeriYetkilisiDBEntity isyeriYetkilisiDB = new IsyeriYetkilisiDBEntity();

        private void IsyeriListele(string aranan)
        {
            dgvIsyeriYetkili.DataSource = isyeriYetkilisiDB.Listele();
            dgvIsyeriYetkili.Refresh();
        }


        private void btnListele_Click(object sender, EventArgs e)
        {
            IsyeriListele("");
        }
    }
}
