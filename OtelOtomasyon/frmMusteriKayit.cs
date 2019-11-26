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
using Models;
using BLL;

namespace OtelOtomasyon
{
    public partial class frmMusteriKayit : Form
    {
        public frmMusteriKayit()
        {
            InitializeComponent();
            CmbVeriCek();
        }
        Musteri mus = new Musteri();
        MusteriBL mbl = new MusteriBL();
        private void btnMusEkle_Click(object sender, EventArgs e)
        {
            try
            {
                mus.TcKNo = txtETcKNo.Text.Trim();
                mus.Ad = txtEAdi.Text.Trim();
                mus.Soyad = txtESoyadi.Text.Trim();
                mus.GirTar = dtpEGirTar.Value;
                mus.CikTar = dtpECikTar.Value;
                mus.OdaNo = (int)cmEBosOda.SelectedValue;
                mbl.MusteriEkle(mus);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Hatası! Hata Kodu: "+ex.Number+" !! "+ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen Hata! "+ex.Message);
            }
            finally
            {
                mbl.Dispose();
                this.Close();
            } 
        }
        private void CmbVeriCek()
        {
            OdaBL obl = new OdaBL();
            cmEBosOda.DisplayMember = "OdaNoAndTip";
            cmEBosOda.ValueMember = "OdaNo";
            cmEBosOda.DataSource=obl.BosOdaListesi();
            obl.Dispose();
        }
    }
}
