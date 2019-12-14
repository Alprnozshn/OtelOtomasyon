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
            dgwResepsiyon.AutoGenerateColumns = false;
        }
        DataTable dt = null;
        private void VeriCek()
        {
            MusteriBL mbl = new MusteriBL();
            dt = mbl.MusteriGetir();
            dgwResepsiyon.DataSource = dt;
            mbl.Dispose();

            //OdaBL obl = new OdaBL();
            //clmOdaNo.DataSource = obl.BosOdaListesi();
            //clmOdaNo.DisplayMember = "OdaNo";
            //clmOdaNo.ValueMember = "OdaNo";
            //obl.Dispose();
        }
        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {
            frmMusteri frmkyt = new frmMusteri();
            frmkyt.Show();
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
        private void frmResepsiyon_Load(object sender, EventArgs e)
        {
            VeriCek();
        }
        private void btnMusteri_Click(object sender, EventArgs e)
        {
            frmMusteri frmMus = new frmMusteri();
            frmMus.Show();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MusteriBL mbl = new MusteriBL();
            foreach (DataRow item in dt.Rows)
            {
                Musteri m = new Musteri();
                if (item.RowState != DataRowState.Deleted)
                {
                    m.TcKNo = item[1].ToString();
                    m.Ad = item[2].ToString();
                    m.Soyad = item[3].ToString();
                    m.GirTar = Convert.ToDateTime(item[4]);
                    m.CikTar = Convert.ToDateTime(item[5]);
                    m.OdaNo = Convert.ToInt32(item[6]);
                }
                switch (item.RowState)
                {
                    case DataRowState.Added:
                        mbl.MusteriEkle(m);
                        break;
                    case DataRowState.Deleted:
                        mbl.MusteriSil(Convert.ToInt32(item[0, DataRowVersion.Original]));
                        break;
                    case DataRowState.Modified:
                        m.MusteriKayitID = Convert.ToInt32(item[0]);
                        mbl.MusteriGuncelle(m);
                        break;
                    default:
                        break;
                }
            }
        }
        private void dgwResepsiyon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            btnYenile.Visible = true;
        }
    }
}
