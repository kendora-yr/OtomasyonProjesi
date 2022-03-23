using ProjeCalismasi.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeCalismasi
{
    public partial class frmMainIsyeriYetkilisi : Form
    {
        public frmMainIsyeriYetkilisi()
        {
            InitializeComponent();
        }

        private void soruCevapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gelenSorularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGelenSorular frmGelenSorular = new frmGelenSorular();
            frmGelenSorular.MdiParent = this;
            frmGelenSorular.Show();
        }

               
        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyeriYetkilisiGiris frm = new frmIsyeriYetkilisiGiris();
            frm.Show();
            this.Hide();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void takvimOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakvimOlustur frmTakvimOlustur = new frmTakvimOlustur();
            frmTakvimOlustur.MdiParent = this;
            frmTakvimOlustur.Show();
        }

        private void randevuTalepleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRandevuTalepleri frmRandevuTalepleri = new frmRandevuTalepleri();
            frmRandevuTalepleri.MdiParent = this;
            frmRandevuTalepleri.Show();
        }

        private void GelenTumSorularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaporTumSorulariListeleme Frm = new frmRaporTumSorulariListeleme();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void cevaplanmamisSorularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaporCevaplanmamisSorulariListeleme Frm = new frmRaporCevaplanmamisSorulariListeleme();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void randevularıListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaporTumRandevulariListeleme frm = new frmRaporTumRandevulariListeleme();
            frm.MdiParent = this;
            frm.Show();

        }

        private void RetEdilmisRandevulariListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaporRetEdilmisRandevulariListeleme frm = new frmRaporRetEdilmisRandevulariListeleme();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
