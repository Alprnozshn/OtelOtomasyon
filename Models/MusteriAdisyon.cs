using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MusteriAdisyon
    {
        public int MusteriID { get; set; }
        public int AdisyonID { get; set; }
        public int AdisyonAdet { get; set; }
        public float ToplamFiyat { get; set; }       
    }
}
