using barkodOtomasyonSist.Forms;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barkodOtomasyonSist.Service
{
    class KullaniciService
    {
        public string kullaniciGirisi(TextBox kulAd,TextBox sifre)
        {
            return new KullanıcıDAL().kullaniciGirisi(kulAd,sifre);
        }

        public string yoneticiKontrol(string kulAd, string sifre)
        {
            return new KullanıcıDAL().yoneticiKontrol(kulAd, sifre);
        }

        public void kullaniciKayit(string kulAd,string sifre,string yonetici)
        {
          new KullanıcıDAL().kullaniciKayit(kulAd,sifre,yonetici);
        }
    }
}
