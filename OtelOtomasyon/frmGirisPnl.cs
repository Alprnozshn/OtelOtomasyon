using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Models;
using BLL;

namespace OtelOtomasyon
{
    public partial class frmGirisPnl : Form
    {
        public frmGirisPnl()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici kl = new Kullanici();
                KullaniciBL klbl = new KullaniciBL();
                kl.KullaniciAdi = txtKullanici.Text.Trim();
                kl.Sifre = txtSifre.Text.Trim();
                SqlDataReader dr = klbl.Giris(kl);
                if (dr.Read())
                {
                    txtKullanici.Clear();
                    txtSifre.Clear();
                    frmMain frm = (frmMain)Application.OpenForms["frmMain"];
                    MessageBox.Show($"Hoşgeldiniz {kl.KullaniciAdi}");
                    frm.menuMain.Items["menuResepsiyon"].Visible = true;
                    switch (dr["YetkiID"])
                    {
                        case (1):
                            frm.YetkiID = 1;
                            frm.menuMain.Items["menuYonetim"].Visible = true;
                            break;
                        case (2):
                            frm.YetkiID = 2;
                            break;
                    }
                    this.Dispose();
                }
                else
                {
                    txtKullanici.Clear();
                    txtSifre.Clear();
                    MessageBox.Show("Kullanıcı Bulunamadı!");
                }
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case (2):
                        MessageBox.Show("Veritabanına Bağlanamıyor. Lütfen internet bağlantınızı kontrol ediniz.\n\n Bağlantınız ile ilgi yapabilecekleriniz: \n 1. Uzak sunucu bağlantı ayarlarınızı kontrol ediniz.\n 2. Uzak sunucuyu tekrar başlatınız.\n\nEğer bağantınız düzelmedi ise lütfen destek hattımıza başvurunuz. ");
                        break;
                    default:
                        MessageBox.Show("Bağlantı Hatası! Hata Kodu: " + ex.Number+"\n\n"+ ex.Message);
                        break;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Oluştu!\n\n" + ex.Message);
            }
        }
    }
}
