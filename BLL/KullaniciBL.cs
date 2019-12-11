using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KullaniciBL
    {
        public SqlDataReader Giris(Kullanici k)
        {
            try
            {
                Baglanti b = new Baglanti();
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
    }
}
