using BLL;
using Models;
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
    public partial class frmAdisyonIslem : Form
    {
        DataTable dt = null;
        public frmAdisyonIslem()
        {
            InitializeComponent();
            gridAdisyon.AutoGenerateColumns = false;
        }
        void VeriCek()
        {
            AdisyonBL abl = new AdisyonBL();
            dt = abl.AdisyonGetir();
            gridAdisyon.DataSource = dt;
            abl.Dispose();
        }
        private void frmAdisyonIslem_Load(object sender, EventArgs e)
        {
            VeriCek();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AdisyonBL abl = new AdisyonBL();
            foreach (DataRow item in dt.Rows)
            {
                Adisyon a = new Adisyon();
                if (item.RowState != DataRowState.Deleted)
                {
                    a.AdisyonAd = item[1].ToString();
                    a.Fiyat = Convert.ToSingle(item[2]);
                }
                switch (item.RowState)
                {
                    case DataRowState.Added:
                        abl.AdisyonEkle(a);
                        break;
                    case DataRowState.Deleted:
                        abl.AdisyonSil(Convert.ToInt32(item[0, DataRowVersion.Original]));
                        break;
                    case DataRowState.Modified:
                        a.AdisyonID = Convert.ToInt32(item[0, DataRowVersion.Original]);
                        abl.AdisyonGuncelle(a);
                        break;
                    default:
                        break;
                }
                VeriCek();
                btnYenile.Visible = false;
            }
        }

        private void gridAdisyon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            btnYenile.Visible = true;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Kaydedilmemiş bilgiler kaybolacaktır. Devam Edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cvp == DialogResult.Yes)
            {
                VeriCek();
                btnYenile.Visible = false;
            }
        }
    }
}
