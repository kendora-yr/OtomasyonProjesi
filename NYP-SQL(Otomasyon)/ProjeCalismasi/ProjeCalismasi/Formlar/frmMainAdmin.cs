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
    public partial class frmMainAdmin : Form
    {
        public frmMainAdmin()
        {
            InitializeComponent();
        }

        private void işyeriYetkilisiTanimlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyeriYetkilisiTanimla frmIsyeriYetkilisiTanimla = new frmIsyeriYetkilisiTanimla();
            frmIsyeriYetkilisiTanimla.MdiParent = this;
            frmIsyeriYetkilisiTanimla.Show();
        }

        private void isyeriIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminIsyeriIslemleri FrmIsyeriIslemleri = new frmAdminIsyeriIslemleri();
            FrmIsyeriIslemleri.MdiParent = this;
            FrmIsyeriIslemleri.Show();
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminGiris frm = new frmAdminGiris();
            frm.Show();
            this.Hide();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void isyeriListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaporIsyeriListeleme frm = new frmRaporIsyeriListeleme();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kullaniciListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaporKullaniciListeleme frm = new frmRaporKullaniciListeleme();
            frm.MdiParent = this;
            frm.Show();
        }

        private void isyeriYetkiliListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaporIsyeriYetkiliListeleme frm = new frmRaporIsyeriYetkiliListeleme();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
