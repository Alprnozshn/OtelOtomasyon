﻿using Data;
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
    public class MusteriBL : IDisposable
    {
        Baglanti b = new Baglanti();

        public void Dispose()
        {
            ((IDisposable)b).Dispose();
        }
        public bool MusteriEkle(Musteri mus)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", mus.Ad), new SqlParameter("@Soyad", mus.Soyad), new SqlParameter("@TcKNo", mus.TcKNo), new SqlParameter("@GirTar", mus.GirTar.Date), new SqlParameter("@CikTar", mus.CikTar.Date), new SqlParameter("@OdaNo", mus.OdaNo) };
                if ((b.ExecuteNonQuery("Insert into tblMusteri values(@TcKNo,@Ad,@Soyad,@GirTar,@CikTar,@OdaNo)", p)) > 0)
                {
                    return b.ExecuteNonQuery($"Update tblOda Set OdaBosmu=0 Where OdaNo={mus.OdaNo}", null) > 0;
                }
                else
                {
                    return false;
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
        public Musteri MusteriBul(string TC)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@TC", TC) };
                SqlDataReader dr = b.ExecuteReader("Select MusteriKayitID,MusteriTcKNo,MusteriAd,MusteriSoyad,MusteriGirisTarih,MusteriCikisTarih,MusteriOdaNo from tblMusteri where MusteriTcKNo=@TC", p);
                Musteri m = null;
                if (dr.Read())
                {
                    m = new Musteri();
                    m.MusteriKayitID = Convert.ToInt32(dr["MusteriKayitID"]);
                    m.TcKNo = dr["MusteriTcKNo"].ToString();
                    m.Ad = dr["MusteriAd"].ToString();
                    m.Soyad = dr["MusteriSoyad"].ToString();
                    m.GirTar = Convert.ToDateTime(dr["MusteriGirisTarih"]);
                    m.CikTar = Convert.ToDateTime(dr["MusteriCikisTarih"]);
                    m.OdaNo = Convert.ToInt32(dr["MusteriOdaNo"]);
                }
                return m;
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
        public bool MusteriGuncelle(Musteri mus)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@MusID", mus.MusteriKayitID), new SqlParameter("@MusAd", mus.Ad), new SqlParameter("@MusSoyad", mus.Soyad), new SqlParameter("@MusTcKNo", mus.TcKNo), new SqlParameter("@GirTar", mus.GirTar), new SqlParameter("@CikTar", mus.CikTar), new SqlParameter("@OdaNo", mus.OdaNo) };
                if (b.ExecuteNonQuery("Update tblMusteri SET MusteriTcKNo=@MusTcKNo,MusteriAd=@MusAd,MusteriSoyad=@MusSoyad,MusteriGirisTarih=@GirTar,MusteriCikisTarih=@CikTar,MusteriOdaNo=@OdaNo where MusteriKayitID=@MusID", p) > 0)
                {
                    return b.ExecuteNonQuery($"Update tblOda Set OdaBosmu=0 Where OdaNo={mus.OdaNo}", null) > 0;
                }
                else
                {
                    return false;
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
        public bool MusteriSil(int musID)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@MusID", musID) };
                return b.ExecuteNonQuery("Delete from tblMusteri where MusteriKayitID=@MusID", p) > 0;
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
        public DataTable MusteriGetir()
        {
            try
            {
                return b.GetDataTable("Select m.MusteriKayitID ,m.MusteriTcKNo ,m.MusteriAd ,m.MusteriSoyad ,m.MusteriGirisTarih ,m.MusteriCikisTarih ,m.MusteriOdaNo  from tblMusteri m inner join tblOda o on m.MusteriOdaNo=o.OdaNo");
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
