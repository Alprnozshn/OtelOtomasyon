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
        public int YetkiID=0;

        private void menuGiris_Click(object sender, EventArgs e)
        {
            frmGirisPnl frm = new frmGirisPnl();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuCikis_Click(object sender, EventArgs e)
        {
            if (YetkiID!=0)
            {
                YetkiID = 0;
                menuMain.Items["menuYonetim"].Visible = false;
                menuMain.Items["menuResepsiyon"].Visible = false; 
            }
            else
            {
                MessageBox.Show("Lütfen Giriş Yapınız.");
            }
        }

        private void menuResepsiyonPnl_Click(object sender, EventArgs e)
        {
            frmResepsiyon frm = new frmResepsiyon();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
