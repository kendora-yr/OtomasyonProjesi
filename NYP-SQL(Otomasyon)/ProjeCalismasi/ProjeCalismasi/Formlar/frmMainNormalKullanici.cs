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
    public partial class frmMainNormalKullanici : Form
    {
        public frmMainNormalKullanici()
        {
            InitializeComponent();
        }

        private void soruSorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyerineSoruSor frmIsyerineSoruSor = new frmIsyerineSoruSor();
            frmIsyerineSoruSor.MdiParent = this;
            frmIsyerineSoruSor.Show();
        }

        private void aramaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNormalKullaniciIsyeriIslemleri FrmKullaniciIsyeriIslemleri = new frmNormalKullaniciIsyeriIslemleri();
            FrmKullaniciIsyeriIslemleri.MdiParent = this;
            FrmKullaniciIsyeriIslemleri.Show();
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNormalKullaniciGiris FrmGirisEkrani = new frmNormalKullaniciGiris();
            FrmGirisEkrani.Show();
            this.Hide();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRandevuAl frmRandevuAl = new frmRandevuAl();
            frmRandevuAl.MdiParent = this;
            frmRandevuAl.Show();
        }
    }
}
