using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkodOtomasyonSist
{
   public class urunSat
    {
        public urunSat(int gBarkodNo,string gUrunAd,string gAcıklama,int gKategori,int gUreticiNo,int gStokAdedi,int gAlısFiyat,int gSatisFiyat,string gAlısTarihi)
        {
            this.Barkod_No = gBarkodNo;
            this.Urun_Ad = gUrunAd;
            this.Urun_Aciklama = gAcıklama;
            this.Kategori_No = gKategori;
            this.Uretici_No = gUreticiNo;
            this.Stok_Adedi = gStokAdedi;
            this.Alıs_Fiyati = gAlısFiyat;
            this.Satıs_Fiyati = gSatisFiyat;
            this.Alıs_Tarihi = gAlısTarihi;
        }

        int barkod_No;
        string urun_Ad;
        string urun_Aciklama;
        int kategori_No;
        int uretici_No;
        int stok_Adedi;
        int alıs_Fiyati;
        int satıs_Fiyati;
        string alıs_Tarihi;

        public int Barkod_No { get => barkod_No; set => barkod_No = value; }
        public string Urun_Ad { get => urun_Ad; set => urun_Ad = value; }
        public string Urun_Aciklama { get => urun_Aciklama; set => urun_Aciklama = value; }
        public int Kategori_No { get => kategori_No; set => kategori_No = value; }
        public int Uretici_No { get => uretici_No; set => uretici_No = value; }
        public int Stok_Adedi { get => stok_Adedi; set => stok_Adedi = value; }
        public int Alıs_Fiyati { get => alıs_Fiyati; set => alıs_Fiyati = value; }
        public int Satıs_Fiyati { get => satıs_Fiyati; set => satıs_Fiyati = value; }
        public string Alıs_Tarihi { get => alıs_Tarihi; set => alıs_Tarihi = value; }

        public override string ToString()
        {
            return this.Barkod_No + " "+ this.Urun_Ad + " "/** + this.Urun_Aciklama + " " + this.Kategori_No + " " + this.Uretici_No + " " + this.Stok_Adedi + " " + this.Satıs_Fiyati + " " + this.Alıs_Fiyati + " " + this.Alıs_Tarihi **/;
        }
    }
}
