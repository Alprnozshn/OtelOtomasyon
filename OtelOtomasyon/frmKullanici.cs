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
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void frmKullanici_Load(object sender, EventArgs e)
        {
            gridKullanici.AutoGenerateColumns = false;
            KullaniciBL kbl = new KullaniciBL();
            dt=kbl.KullaniciTablosu();
            gridKullanici.DataSource = dt;
            clmYetki.ValueMember = "YetkiID";
            clmYetki.DisplayMember = "YetkiAd";
            clmYetki.DataSource = kbl.YetkiGetir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KullaniciBL kbl = new KullaniciBL();
            foreach (DataRow item in dt.Rows)
            {
                Kullanici y = new Kullanici();
                if (item.RowState != DataRowState.Deleted)
                {
                    y.KullaniciAdi = item[1].ToString();
                }
                switch (item.RowState)
                {
                    case DataRowState.Added:
                        kbl.Ekle(y);
                        break;
                    case DataRowState.Deleted:
                        kbl.Sil(Convert.ToInt32(item[0, DataRowVersion.Original]));
                        break;
                    case DataRowState.Modified:
                        y.KullaniciID = Convert.ToInt32(item[0]);
                        kbl.Guncelle(y);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
