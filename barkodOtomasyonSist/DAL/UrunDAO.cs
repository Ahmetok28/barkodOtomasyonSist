using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkodOtomasyonSist
{
    class urunDAO
    {
        dbBaglanti bagla = new dbBaglanti();

       
        
        internal ArrayList urunOku()
        {
            ArrayList okunanUrunler = new ArrayList();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM  Urun", bagla.baglantiKur());
            OleDbDataReader okunan = komut.ExecuteReader();
            while (okunan.Read())
            {
                okunanUrunler.Add(new Urun(Convert.ToInt32(okunan[0]), okunan[1].ToString(), okunan[2].ToString(), Convert.ToInt32(okunan[3]), Convert.ToInt32(okunan[4]), Convert.ToInt32(okunan[5]), Convert.ToDouble(okunan[6]), Convert.ToDouble(okunan[7]), Convert.ToDateTime(okunan[8])));
            }
            bagla.baglantiyiKapat();
            return okunanUrunler;
            
        }

        public int getirKDV(int kategoriNo)
        {
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kategori WHERE Kategori_No=" + kategoriNo, ((new dbBaglanti()).baglantiKur()));
            OleDbDataReader okunan = komut.ExecuteReader();
            int KDV= 0;
            while (okunan.Read())
            {
                KDV = Convert.ToInt32(okunan[2]);
            }

                return KDV;
        }

        internal void UrunGuncelle(Urun urun)
        {
            new OleDbCommand("UPDATE Urun SET Alis_Fiyati='" + urun.AlisFiyati + "',Satis_Fiyati='" + urun.SatisFiyati + "'WHERE Barkod_No=" + urun.BarkodNo, new dbBaglanti().baglantiKur()).ExecuteNonQuery();
            bagla.baglantiyiKapat();
        }
        internal void urunAdetEksilt(int gelenAdet,double gelenBarkod)
        {
            new OleDbCommand("UPDATE Urun SET Stok_Adedi='" + gelenAdet + "'WHERE Barkod_No=" + gelenBarkod, new dbBaglanti().baglantiKur()).ExecuteNonQuery();
            bagla.baglantiyiKapat();
        }
        internal void urunSil(double p)
        {
            new OleDbCommand("DELETE FROM Urun WHERE Barkod_No=" + p, new dbBaglanti().baglantiKur()).ExecuteNonQuery();
            bagla.baglantiyiKapat();
        }

        internal void urunKaydet(Urun urun)
        {
           OleDbCommand komut = new OleDbCommand("INSERT INTO Urun (Barkod_No,Urun_Ad,Urun_Aciklama,Kategori_No,Uretici_No,Stok_Adedi,Alis_Fiyati,Satis_Fiyati,Alis_Tarihi) values ('" + urun.BarkodNo + "','" + urun.UrunAd + "','" + urun.UrunAciklam + "','" + urun.KategoriNo + "','" + urun.UreticiNo + "','" + urun.StokAdedi + "','" + urun.AlisFiyati + "','" + urun.SatisFiyati + "','" + urun.AlisZamani + "') ",bagla.baglantiKur());
            komut.ExecuteNonQuery();
            bagla.baglantiyiKapat();
        }
        
        public Urun urunAra(double p)
        {


            Urun urn = new Urun();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Urun WHERE Barkod_No=" + p, ((new dbBaglanti()).baglantiKur()));
            OleDbDataReader okunan = komut.ExecuteReader();
            while (okunan.Read())
            {
                urn.BarkodNo = Convert.ToDouble(okunan[0]);
                urn.UrunAd = okunan[1].ToString();
                urn.UrunAciklam = okunan[2].ToString();
                urn.KategoriNo = Convert.ToInt32(okunan[3]);
                urn.UreticiNo = Convert.ToInt32(okunan[4]);
                urn.StokAdedi = Convert.ToInt32(okunan[5]);
                urn.AlisFiyati = Convert.ToDouble(okunan[6]);
                urn.SatisFiyati = Convert.ToDouble(okunan[7]);
                urn.AlisZamani = Convert.ToDateTime(okunan[8]);


            }
            bagla.baglantiyiKapat();
            return urn;
            
        }
        internal void satısKaydet(double Barkod,string Ad,int satilanAdet, double toplamFiyat, double satisFiyati, double alisFiyati,int kategori, DateTime satisZamani )
        {
            new OleDbCommand("insert into Satislar (BarkodNo,UrunAd,SatilanAdet,ToplamFiyat,SatisFiyati,AlisFiyati,Kategori,SatisTarihi) values ('" +Barkod+ "','" +Ad+ "','"+satilanAdet+ "','" + toplamFiyat + "','" + satisFiyati+ "','"+alisFiyati+ "','"+kategori+ "','"+satisZamani+"') ", new dbBaglanti().baglantiKur()).ExecuteNonQuery();
            bagla.baglantiyiKapat();
        }
        

    }
}
