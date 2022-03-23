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
    public partial class frmAnaGiris : Form
    {
        public frmAnaGiris()
        {
            InitializeComponent();
        }

        private void btnIsYeriYetkilisiGiris_Click(object sender, EventArgs e)
        {
            frmIsyeriYetkilisiGiris FrmIsyeriYetkilisiGiris = new frmIsyeriYetkilisiGiris();
            FrmIsyeriYetkilisiGiris.Show();
            this.Hide();

        }

        private void btnNormalKullanicilarGiris_Click(object sender, EventArgs e)
        {
            frmNormalKullaniciGiris FrmKullaniciGiris = new frmNormalKullaniciGiris();
            FrmKullaniciGiris.Show();
            this.Hide();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            frmAdminGiris FrmAdminGiris = new frmAdminGiris();
            FrmAdminGiris.Show();
            this.Hide();
        }
    }
}
