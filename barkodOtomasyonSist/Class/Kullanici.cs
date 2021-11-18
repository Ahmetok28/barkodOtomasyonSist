using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkodOtomasyonSist
{
   public  class Kullanici
    {
        private static string kullaniciAdi;
        private static string sifre;
        private static string yoneticimi;
        public Kullanici()
        {

        }

        public Kullanici(string kullaniciAdi, string sifre, string yoneticimi)
        {
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
            Yoneticimi = yoneticimi;
        }

        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string Yoneticimi { get => yoneticimi; set => yoneticimi = value; }


    }
}
