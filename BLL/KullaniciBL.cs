using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KullaniciBL : IDisposable
    {
        Baglanti b = new Baglanti();

        public void Dispose()
        {
            ((IDisposable)b).Dispose();
        }

        public SqlDataReader Giris(Kullanici k)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@KullaniciAdi", k.KullaniciAdi), new SqlParameter("@Sifre", k.Sifre) };
                return b.ExecuteReader("Select YetkiID from tblKullanici Where KullaniciAdi=@KullaniciAdi and KullaniciSifre=@Sifre", p);
            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Yetki> YetkiGetir()
        {
            try
            {
                SqlDataReader dr = b.ExecuteReader("Select YetkiID,YetkiAd from tblYetki", null);
                List<Yetki> lst = new List<Yetki>();
                while (dr.Read())
                {
                    lst.Add(new Yetki { YetkiID = Convert.ToInt32(dr["YetkiID"]), YetkiAd = dr["YetkiAd"].ToString() });
                }
                dr.Close();
                return lst;
            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable KullaniciTablosu()
        {
            try
            {
                return b.GetDataTable("select KullaniciID,KullaniciAdi,KullaniciSifre,YetkiID from tblKullanici");
            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Ekle(Kullanici k)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Adi", k.KullaniciAdi), new SqlParameter("@Sifre", k.Sifre), new SqlParameter("@YetkiID", k.YetkiID) };
                return b.ExecuteNonQuery("Insert into tblKullanici values(@Adi,@Sifre,@YetkiID)", p) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Guncelle(Kullanici k)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@ID", k.KullaniciID), new SqlParameter("@Adi", k.KullaniciAdi), new SqlParameter("@Sifre", k.Sifre), new SqlParameter("@YetkiID", k.YetkiID) };
                return b.ExecuteNonQuery("update tblKullanici set KullaniciAdi=@Adi, KullaniciSifre=@Sifre,YetkiID=@YetkiID where KullaniciID=@ID", p) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Sil(int KullaniciID)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@ID", KullaniciID) };
                return b.ExecuteNonQuery("delete from tblKullanici where KullaniciID=@ID", p) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
