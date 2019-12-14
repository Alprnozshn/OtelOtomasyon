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
    public class AdisyonBL:IDisposable
    {
        Baglanti b = new Baglanti();
        public Adisyon FiyatGetir(Adisyon a)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@AdisID", a.AdisyonID) };
                SqlDataReader dr = b.ExecuteReader("Select AdisyonFiyat from tblAdisyon where AdisyonID=@AdisID", p);//HOCAYA SOR!!!
                if (dr.Read())
                {
                    a.Fiyat = Convert.ToSingle(dr["AdisyonFiyat"]);
                }
                return a;
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
        public DataTable AdisyonGetir()
        {
            return b.GetDataTable("Select AdisyonID, AdisyonAd, AdisyonFiyat from tblAdisyon");
        }
        public bool AdisyonEkle(Adisyon adis)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", adis.AdisyonAd),new SqlParameter("@Fiyat",adis.Fiyat)};
                return b.ExecuteNonQuery("Insert into tblAdisyon values(@Ad,@Fiyat)", p) > 0;
                
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
        public bool AdisyonGuncelle(Adisyon adis)
        {
            SqlParameter[] p = { new SqlParameter("@ID",adis.AdisyonID),new SqlParameter("@Ad",adis.AdisyonAd),new SqlParameter("@Fiyat",adis.Fiyat)};
            return b.ExecuteNonQuery("Update tblAdisyon SET AdisyonAd=@Ad,AdisyonFiyat=@Fiyat where AdisyonID=@ID", p) > 0;
           
        }
        public bool AdisyonSil(int AdisID)
        {
            SqlParameter[] p = { new SqlParameter("@AdisID", AdisID) };
            return b.ExecuteNonQuery("Delete from tblAdisyon where AdisyonID=@AdisID", p) > 0;
        }
        public void Dispose()
        {
            ((IDisposable)b).Dispose();
        }
    }
}
