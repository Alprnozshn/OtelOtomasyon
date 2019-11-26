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

        private void VeriCek()
        {
            Baglanti b = new Baglanti();
            try
            {
                SqlCommand cmd = new SqlCommand("Select tblMusteri.MusteriKayitID as [ID], tblMusteri.MusteriTcKNo as [TC Kimlik No],tblMusteri.MusteriAd as [Adı],tblMusteri.MusteriSoyad as [Soyadı],tblMusteri.MusteriGirisTarih as [Giriş Tarihi],tblMusteri.MusteriCikisTarih as [Çıkış Tarihi],tblMusteri.MusteriOdaNo as [Oda No] from tblMusteri inner join tblOda on tblMusteri.MusteriOdaNo=tblOda.OdaNo", b.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                b.Ac();
                da.Fill(dt);
                dgwResepsiyon.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Hatası ile Karşılaşıldı. Hata Kodu: " + ex.Number);
            }
            finally
            {
                b.Dispose();
            }
        }

        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {
            frmMusteriKayit frmkyt = new frmMusteriKayit();
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
            this.Close();
        }

        private void frmResepsiyon_Load(object sender, EventArgs e)
        {
            VeriCek();
            dgwResepsiyon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwResepsiyon.AllowUserToAddRows = false;
            dgwResepsiyon.AllowUserToDeleteRows = false;
        }
    }
}
