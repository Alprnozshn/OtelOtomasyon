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
    public class MusteriBL:IDisposable
    {
        Baglanti b = new Baglanti();

        public void Dispose()
        {
            ((IDisposable)b).Dispose();
        }

        public void MusteriEkle(Musteri mus)
        {
            
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", mus.Ad), new SqlParameter("@Soyad", mus.Soyad), new SqlParameter("@TcKNo", mus.TcKNo), new SqlParameter("@GirTar", mus.GirTar.Date), new SqlParameter("@CikTar", mus.CikTar.Date), new SqlParameter("@OdaNo", mus.OdaNo) };
                if ((b.ExecuteNonQuery("Insert into tblMusteri values(@TcKNo,@Ad,@Soyad,@GirTar,@CikTar,@OdaNo)", p))>0)
                {
                    b.ExecuteNonQuery($"Update tblOda Set OdaBosmu=0 Where OdaNo={mus.OdaNo}",null);
                }

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
