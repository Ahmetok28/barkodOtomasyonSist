using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using barkodOtomasyonSist.Forms;

namespace barkodOtomasyonSist
{
    class UrunService
    {
        public ArrayList urunGetir()
        {
            return new urunDAO().urunOku();
        }
        public Barkodsuz barkodsuzUrunAra()
        {
            return new urunDAO().barkodsuzUrunAra();
        }
        public ArrayList barkodsuzUrunOku()
        {
            return new urunDAO().barkodsuzUrunOku();
        }
        public void urunKaydet(double v1, string v2, string v3, int v4, int v5, int v6, double v7, double v8, DateTime dateTime)
        {
            new urunDAO().urunKaydet(new Urun(v1, v2, v3, v4, v5, v6, v7, v8, dateTime));
        }
        internal void urunSil(double p)
        {
            new urunDAO().urunSil(p);
        }
        internal void urunGuncelle(double p1, double p2)
        {
            new urunDAO().UrunGuncelle(new Urun(p1, p2));
        }
        public int getirKDV(int katNo)
        {
            return new urunDAO().getirKDV(katNo);
        }
        public void urunAdetEksilt(int g1,double g2)
        {
            new urunDAO().urunAdetEksilt(g1,g2);
        }
        public Urun UrunAra(double p)
        {
            return new urunDAO().urunAra(p);
        }
        public void satısKaydet(double Barkod, string Ad, int satilanAdet, double toplamFiyat, double satisFiyati, double alisFiyati, int kategori, DateTime satisZamani)
        {
            new urunDAO().satısKaydet(Barkod,Ad,satilanAdet,toplamFiyat,satisFiyati,alisFiyati,kategori,satisZamani);
        }
        
    }
}