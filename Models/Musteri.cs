using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Musteri
    {
        private string ad;
        private string soyad;
        public int MusteriKayitID { get; set; }
        public string TcKNo { get; set; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value.ToUpper(); }
        public DateTime GirTar { get; set; }
        public DateTime CikTar { get; set; }
        public int OdaNo { get; set; }
        
    }
}
