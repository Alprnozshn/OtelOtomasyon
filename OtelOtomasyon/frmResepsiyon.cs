using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Data;
using BLL;
using Models;

namespace OtelOtomasyon
{
    public partial class frmResepsiyon : Form
    {
        
        public frmResepsiyon()
        {
            InitializeComponent();
        }
        DataTable dt = null;
        private void VeriCek()
        {
            MusteriBL mbl = new MusteriBL();
            dt=mbl.MusteriGetir();
            dgwResepsiyon.DataSource = dt;
            mbl.Dispose();
        }

        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {
            frmMusteri frmkyt = new frmMusteri();
            frmkyt.Show();
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            GirisEkraninaDon();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            VeriCek();
        }

        void GirisEkraninaDon()
        {
            frmGirisPnl frm = (frmGirisPnl)Application.OpenForms["frmGirisPnl"];
            frm.Show();
            this.Dispose();
        }

        private void frmResepsiyon_Load(object sender, EventArgs e)
        {
            VeriCek();
            dgwResepsiyon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwResepsiyon.AllowUserToAddRows = false;
            dgwResepsiyon.AllowUserToDeleteRows = false;
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            frmMusteri frmMus = new frmMusteri();
            frmMus.Show();
        }
    }
}
