﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kullanici
    {
        private string kullaniciAdi;

        public int KullaniciID { get; set; }
        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value.Trim().ToLower(); }
        public string Sifre { get; set; }
        public int YetkiID { get; set; }
    }
}
