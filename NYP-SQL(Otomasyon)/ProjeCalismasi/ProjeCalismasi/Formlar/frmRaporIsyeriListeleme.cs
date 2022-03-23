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
    public partial class frmRaporIsyeriListeleme : Form
    {
        public frmRaporIsyeriListeleme()
        {
            InitializeComponent();
        }

        private readonly IsyeriDBEntity isyeriDB = new IsyeriDBEntity();

        private void Listele(string aranan)
        {
            dgvIsyeri.DataSource = isyeriDB.Listele(aranan);
            dgvIsyeri.Refresh();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele("");
        }
    }
}
