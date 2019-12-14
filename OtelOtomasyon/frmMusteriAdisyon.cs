using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class frmMusteriAdisyon : Form
    {
        public frmMusteriAdisyon()
        {
            InitializeComponent();
            gridMusteriAdisyon.AutoGenerateColumns = false;
        }
        DataTable dt = null;
        void VeriCek()
        {
            MusteriAdisyonBL mabl = new MusteriAdisyonBL();
            dt = mabl.MusteriAdisGetir();
            gridMusteriAdisyon.DataSource = dt;
            clmMusteri.ValueMember = "MusteriKayitID";
            clmMusteri.DisplayMember = "AdSoyad";
            clmAdisyon.ValueMember = "AdisyonID";
            clmAdisyon.DisplayMember = "AdisyonAd";
            clmMusteri.DataSource = mabl.MusteriGetir();
            clmAdisyon.DataSource = mabl.AdisyonGetir();
        }
        private void frmMusteriAdisyon_Load(object sender, EventArgs e)
        {
            VeriCek();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                MusteriAdisyonBL mabl = new MusteriAdisyonBL();
                foreach (DataRow item in dt.Rows)
                {
                    MusteriAdisyon ma = new MusteriAdisyon();
                    if (item.RowState != DataRowState.Deleted)
                    {
                        ma.MusteriID = Convert.ToInt32(item[0]);
                        ma.AdisyonID = Convert.ToInt32(item[1]);
                        ma.AdisyonAdet = Convert.ToInt32(item[2]);
                        Adisyon a = new Adisyon();
                        AdisyonBL abl = new AdisyonBL();
                        a.AdisyonID = ma.AdisyonID;
                        a = abl.FiyatGetir(a);
                        ma = mabl.ToplamFiyatiBelirle(a, ma);
                    }
                    switch (item.RowState)
                    {
                        case DataRowState.Added:
                            mabl.MusAdisEkle(ma);
                            break;
                        case DataRowState.Deleted:
                            mabl.MusAdisSil(Convert.ToInt32(item[1, DataRowVersion.Original]), Convert.ToInt32(item[0, DataRowVersion.Original]));
                            break;
                        case DataRowState.Modified:
                            mabl.MusAdisGuncelle(ma);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                VeriCek();
                btnYenile.Visible = false;
            }
        }

        private void gridMusteriAdisyon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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
