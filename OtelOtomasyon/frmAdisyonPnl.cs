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
    public partial class frmAdisyonPnl : Form
    {
        public frmAdisyonPnl()
        {
            InitializeComponent();
        }
        frmMain frm = (frmMain)Application.OpenForms["frmMain"];
        private void btnAdisyon_Click(object sender, EventArgs e)
        {
            if (frm.YetkiID == 1)
            {
                frmAdisyonIslem frmI = new frmAdisyonIslem();
                frmI.MdiParent = Application.OpenForms["frmMain"];
                frmI.Show();
            }
            else
            {
                MessageBox.Show("Yetkiniz Yetersiz!");
            }
        }

        private void btnMusteriAdisyon_Click(object sender, EventArgs e)
        {
            frmMusteriAdisyon frm = new frmMusteriAdisyon();
            frm.MdiParent = Application.OpenForms["frmMain"];
            frm.Show();
        }
    }
}
