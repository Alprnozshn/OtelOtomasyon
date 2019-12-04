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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
            CmbVeriCek();
        }
        Musteri mus = new Musteri();
        public int MusteriID = 0;
        void Temizle()
        {
            foreach (Control item in this.Controls["pnlText"].Controls)
            {
                item.Text = string.Empty;
            }
            dtpECikTar.Value = DateTime.Today;
            dtpEGirTar.Value = DateTime.Today;
            cmEBosOda.SelectedIndex = 0;
            BtnSil.Visible = false;
            btnVazgec.Visible = false;
        }
        private void btnMusEkle_Click(object sender, EventArgs e)
        {
            MusteriBL mbl = new MusteriBL();
            try
            {
                mus.MusteriKayitID = MusteriID;
                mus.TcKNo = txtETcKNo.Text.Trim();
                mus.Ad = txtEAdi.Text.Trim();
                mus.Soyad = txtESoyadi.Text.Trim();
                mus.GirTar = dtpEGirTar.Value;
                mus.CikTar = dtpECikTar.Value;
                mus.OdaNo = (int)cmEBosOda.SelectedValue;
                switch (MusteriID)
                {

                    case (0):
                        if (mbl.MusteriEkle(mus))
                        {
                            Temizle();
                            MessageBox.Show("Ekleme Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Ekleme Başarısız!");
                        }
                        break;
                    default:
                        if (mbl.MusteriGuncelle(mus))
                        {
                            Temizle();
                            MessageBox.Show("Güncelleme Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme Başarısız!");
                        }
                        break;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Hatası! Hata Kodu: " + ex.Number + " !! " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen Hata! " + ex.Message);
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
            cmEBosOda.DataSource = obl.BosOdaListesi();
            obl.Dispose();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            frmBul frm = new frmBul();
            frm.Show();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            DialogResult cvp = MessageBox.Show("Kayıt Silinecek. Emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cvp == DialogResult.Yes)
            {
                MusteriBL mbl = new MusteriBL();
                if (mbl.MusteriSil(MusteriID))
                {
                    Temizle();
                    MessageBox.Show("Silme Başarılı!");
                }
                else
                {
                    MessageBox.Show("Silme hatalı!");
                }
                mbl.Dispose();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
