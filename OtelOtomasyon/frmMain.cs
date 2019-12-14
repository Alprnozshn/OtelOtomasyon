using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public int YetkiID = 0;

        private void menuGiris_Click(object sender, EventArgs e)
        {
            frmGirisPnl frm = new frmGirisPnl();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuCikis_Click(object sender, EventArgs e)
        {
            YetkiID = 0;
            menuGiris.Visible = true;
            menuMain.Items["menuYonetim"].Visible = false;
            menuMain.Items["menuResepsiyon"].Visible = false;
            menuDosya.DropDownItems["menuCikis"].Visible = false;
        }

        private void menuResepsiyonPnl_Click(object sender, EventArgs e)
        {
            frmResepsiyon frm = new frmResepsiyon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuYonetimPnl_Click(object sender, EventArgs e)
        {
            frmYonetici frm = new frmYonetici();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuMusteri_Click(object sender, EventArgs e)
        {
            frmMusteri frm = new frmMusteri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuAdisyon_Click(object sender, EventArgs e)
        {
            frmAdisyonPnl frm = new frmAdisyonPnl();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
