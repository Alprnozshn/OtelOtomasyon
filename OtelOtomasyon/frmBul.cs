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
    public partial class frmBul : Form
    {
        public frmBul()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            OdaBL obl = new OdaBL();
            MusteriBL mbl = new MusteriBL();
            Musteri m=mbl.MusteriBul(txtTcKNo.Text);
            frmMusteri frm = (frmMusteri)Application.OpenForms["frmMusteri"];
            frm.MusteriID = m.MusteriKayitID;
            frm.txtEAdi.Text = m.Ad;
            frm.txtESoyadi.Text = m.Soyad;
            frm.txtETcKNo.Text = m.TcKNo;
            frm.dtpECikTar.Text = m.CikTar.ToString();
            if (obl.MusOdaBosalt(m.OdaNo))
            {
                frm.cmEBosOda.DataSource = obl.BosOdaListesi();
                frm.cmEBosOda.SelectedValue = m.OdaNo;
            }
            frm.dtpEGirTar.Text = m.GirTar.ToString();
            frm.btnMusEkle.Text = "Güncelle";
            frm.BtnSil.Visible = true;
            frm.btnVazgec.Visible = true;
            this.Dispose();
        }
    }
}
