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
    public partial class frmRaporKullaniciListeleme : Form
    {
        public frmRaporKullaniciListeleme()
        {
            InitializeComponent();
        }

        private readonly NormalKullaniciDBEntity kullaniciDB = new NormalKullaniciDBEntity();

        private void Listele()
        {
            dgvKullaniciListele.DataSource = kullaniciDB.Listele();
            dgvKullaniciListele.Refresh();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            bool dogrulama = kullaniciDB.girisYapmisKullaniciDogrulama();
            if (dogrulama)
            {
                Listele();
            }
        }
    }
}
