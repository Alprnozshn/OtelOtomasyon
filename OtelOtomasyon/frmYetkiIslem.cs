using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace OtelOtomasyon
{
    public partial class frmYetkiIslem : Form
    {
        public frmYetkiIslem()
        {
            InitializeComponent();
        }
        int YetkiID;
        tblYetki yetki;
        private void frmYetkiIslem_Load(object sender, EventArgs e)
        {

        }
        void Temizle()
        {
            foreach (Control item in this.Controls["pnlText"].Controls)
            {
                item.Text = string.Empty;
            }
            yetki = null;
            YetkiID = 0;
            btnKaydet.Text = "Kaydet";
            btnSil.Visible = false;
            btnVazgec.Visible = false;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YetkiContext ctx = new YetkiContext();
            switch (YetkiID)
            {
                case (0):
                    if (txtYetkiAd != null)
                    {
                        ctx.tblYetkis.Add(new tblYetki { YetkiAd = txtYetkiAd.Text.Trim() });
                    }
                    break;
                default:
                    yetki.YetkiAd = txtYetkiAd.Text.Trim();
                    ctx.Entry<tblYetki>(yetki).State = EntityState.Modified;
                    break;
            }
            ctx.SaveChanges();
            ctx.Dispose();
            Temizle();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            try
            {

                YetkiContext ctx = new YetkiContext();
                YetkiID = Convert.ToInt32(txtYetkiID.Text.Trim());
                yetki = ctx.tblYetkis.Find(YetkiID);
                ctx.Dispose();
                txtYetkiAd.Text = yetki.YetkiAd;
                btnKaydet.Text = "Güncelle";
                btnSil.Visible = true;
                btnVazgec.Visible = true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Belirtilen ID Bulunamadı.");
                Temizle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (yetki != null)
            {
                YetkiContext ctx = new YetkiContext();
                ctx.tblYetkis.Remove(yetki);
                ctx.SaveChanges();
                ctx.Dispose();
                Temizle();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
