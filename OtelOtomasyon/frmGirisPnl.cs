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
                    switch (dr["KullaniciTip"].ToString())
                    {
                        case ("Resepsiyon"):
                            frmResepsiyon frmR = new frmResepsiyon();
                            frmR.Show();
                            this.Hide();
                            break;
                        case ("Yönetici"):
                            frmYonetici frmY = new frmYonetici();
                            frmY.Show();
                            this.Hide();
                            break;
                    }
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
                MessageBox.Show("Bağlantı Hatası! Hata Kodu: " + ex.Number+ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Oluştu!\n" + ex.Message);
            }
        }
    }
}
