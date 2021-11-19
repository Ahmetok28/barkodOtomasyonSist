using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkodOtomasyonSist
{
    class Nakit : ISatisYap
    {
        UrunService urnServ = new UrunService();
        public void analizYap()
        {
            
        }

        public void satisYap(List<double> gelenBarkodlar, List<int> gelenAdet)
        {
            for (int i = 0; i < gelenBarkodlar.Count(); i++)
            {
                double barkod= urnServ.UrunAra(Convert.ToDouble(gelenBarkodlar[i])).BarkodNo;
                string adı= urnServ.UrunAra(Convert.ToDouble(gelenBarkodlar[i])).UrunAd.ToString();
                double satisFiyati = urnServ.UrunAra(Convert.ToDouble(gelenBarkodlar[i])).SatisFiyati;
                int kategoriNo = urnServ.UrunAra(Convert.ToDouble(gelenBarkodlar[i])).KategoriNo;
                double alisFiyati = urnServ.UrunAra(Convert.ToDouble(gelenBarkodlar[i])).AlisFiyati;
                int dbAdet = urnServ.UrunAra(gelenBarkodlar[i]).StokAdedi;
                int adet = gelenAdet[i];
                double sonuc = satisFiyati * adet;
                DateTime satisZamani= DateTime.Now;

                urnServ.satısKaydet(barkod,adı,adet,sonuc,satisFiyati,alisFiyati,kategoriNo,satisZamani);
                

                
                if (dbAdet-adet>=0)
                {
                   
                    new UrunService().urunAdetEksilt((dbAdet - adet), barkod);
                    System.Windows.Forms.MessageBox.Show("urun satıldı ve adeti eksiltildi."+(dbAdet-adet).ToString());
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Stokta Satış İçin Yeterli Ürün Kalmamıştır.");
                }
                

            }
        }

        public void dbKaydet()
        {
            
        }

       
    }
}
