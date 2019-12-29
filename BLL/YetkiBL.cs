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
    public class YetkiBL
    {
        Baglanti b = new Baglanti();
        public DataTable YetkiListesi()
        {
            try
            {
                return b.GetDataTable("Select YetkiID, YetkiAd from tblYetki");
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
        public bool Ekle(Yetki y)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", y.YetkiAd) };
                return b.ExecuteNonQuery("Insert into tblYetki values(@Ad)", p) > 0;
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
        public bool Guncelle(Yetki y)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@ID", y.YetkiID), new SqlParameter("@Ad", y.YetkiAd) };
                return b.ExecuteNonQuery("Update tblYetki SET YetkiAd=@Ad where YetkiID=@ID", p) > 0;
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
        public bool Sil(int YetkiID)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@ID", YetkiID) };
                return b.ExecuteNonQuery("Delete from tblYetki where YetkiID=@ID", p) > 0;
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
