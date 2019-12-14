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
    public class OdaBL:IDisposable
    {
        Baglanti b = new Baglanti();
        public bool MusOdaBosalt(int odaNo)
        {
            SqlParameter[] p = { new SqlParameter("@odaNo", odaNo) };
            return b.ExecuteNonQuery("Update tblOda set OdaBosmu=1 where OdaNo=@odaNo", p)>0;
        }
        public List<Oda> BosOdaListesi()
        {
            SqlDataReader dr = b.ExecuteReader("Select OdaNo,OdaTip,OdaYatakSayisi,OdaGunlukFiyat,OdaBosmu from tblOda where OdaBosmu=1", null);
            List<Oda> lst = new List<Oda>();
            while (dr.Read())
            {
                lst.Add(new Oda { OdaNo = Convert.ToInt32(dr["OdaNo"]), OdaTip = dr["OdaTip"].ToString(), YatakSayisi = Convert.ToInt32(dr["OdaYatakSayisi"]), OdaGunlukFiyat = Convert.ToInt32(dr["OdaGunlukFiyat"]), OdaBosmu = (bool)dr["OdaBosmu"],OdaNoAndTip=dr["OdaNo"].ToString()+" No'lu "+dr["OdaTip"].ToString()+" Fiyat ="+dr["OdaGunlukFiyat"]+"TL"}); 
            }
            dr.Close();
            return lst;
        }

        public void Dispose()
        {
            ((IDisposable)b).Dispose();
        }
    }
}
