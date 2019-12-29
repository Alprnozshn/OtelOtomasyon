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
    public class MusteriAdisyonBL
    {
        Baglanti b = new Baglanti();
        public List<Musteri> MusteriGetir()
        {
            try
            {
                SqlDataReader dr = b.ExecuteReader("Select MusteriKayitID, MusteriAd,MusteriSoyad from tblMusteri", null);
                List<Musteri> lst = new List<Musteri>();
                while (dr.Read())
                {
                    lst.Add(new Musteri { MusteriKayitID = Convert.ToInt32(dr["MusteriKayitID"]), AdSoyad = dr["MusteriAd"].ToString() + " " + dr["MusteriSoyad"].ToString() });
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
        public List<Adisyon> AdisyonGetir()
        {
            try
            {
                SqlDataReader dr = b.ExecuteReader("Select AdisyonID, AdisyonAd, AdisyonFiyat from tblAdisyon", null);
                List<Adisyon> lst = new List<Adisyon>();
                while (dr.Read())
                {
                    lst.Add(new Adisyon { AdisyonID = Convert.ToInt32(dr["AdisyonID"]), AdisyonAd = dr["AdisyonAd"].ToString(), Fiyat = Convert.ToSingle(dr["AdisyonFiyat"]) });
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
        public DataTable MusteriAdisGetir()
        {
            try
            {
                return b.GetDataTable("Select MusteriID,AdisyonID,AdisyonAdet,AdisyonToplamFiyat from tblMusteriAdisyon");
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
        public MusteriAdisyon ToplamFiyatiBelirle(Adisyon a ,MusteriAdisyon ma)
        {
            ma.ToplamFiyat = a.Fiyat * ma.AdisyonAdet;
            return ma;
        }
        public bool MusAdisEkle(MusteriAdisyon ma)
        {
            try
            {
                SqlParameter[] p = {new SqlParameter("@MusID",ma.MusteriID) ,new SqlParameter("@AdisID",ma.AdisyonID) ,new SqlParameter("@AdisAdet",ma.AdisyonAdet) ,new SqlParameter("@ToplamFiyat",ma.ToplamFiyat) };
                return b.ExecuteNonQuery("Insert into tblMusteriAdisyon values(@MusID,@AdisID,@AdisAdet,@ToplamFiyat)", p) > 0;

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
        public bool MusAdisSil(int AdisID,int MusID)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@AdisID", AdisID), new SqlParameter("@MusID", MusID) };
                return b.ExecuteNonQuery("Delete from tblMusteriAdisyon where AdisyonID=@AdisID and MusteriID=@MusID", p) > 0;
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
        public bool MusAdisGuncelle(MusteriAdisyon ma)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@MusID", ma.MusteriID), new SqlParameter("@AdisID", ma.AdisyonID), new SqlParameter("@AdisAdet", ma.AdisyonAdet), new SqlParameter("@TopFiyat", ma.ToplamFiyat) };
                return b.ExecuteNonQuery("Update tblMusteriAdisyon SET MusteriID=@MusID,AdisyonID=@AdisID,AdisyonAdet=@AdisAdet,AdisyonToplamFiyat=@TopFiyat where MusteriID=@MusID and AdisyonID=@AdisID", p) > 0;
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
