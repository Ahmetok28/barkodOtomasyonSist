using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkodOtomasyonSist
{
    public class Urun
    {

        private double barkodNo;
        private string urunAd;
        private string urunAciklam;
        private int kategoriNo;
        private int ureticiNo;
        private int stokAdedi;
        private double alisFiyati;
        private double satisFiyati;
        private DateTime alisZamani;
        private int urun_No;

        public Urun()
        {
        }

        public Urun(double p1, double p2)
        {
            this.AlisFiyati = p1;
            this.SatisFiyati = p2;
        }
        //////////////////////////////////      Barkodsuz ürünler için           /////////////////////////////////
        public Urun(string v1, string v2, int v3, int v4, int v5, double v6, double v7, DateTime dateTime, int v8)
        {
            UrunAd = v1;
            UrunAciklam = v2;

            KategoriNo = v3;
            UreticiNo = v4;
            StokAdedi = v5;
            AlisFiyati = v6;
            SatisFiyati = v7;
            AlisZamani = dateTime;
            Urun_No = v8;
        }

        public Urun(double v1, string v2, string v3, int v4, int v5, int v6, double v7, double v8, DateTime dateTime)
        {
            this.BarkodNo = v1;
            this.UrunAd = v2;
            this.UrunAciklam = v3;
            this.KategoriNo = v4;
            this.UreticiNo = v5;
            this.StokAdedi = v6;
            this.AlisFiyati = v7;
            this.SatisFiyati = v8;
            this.AlisZamani = dateTime;
        }


        public double BarkodNo { get => barkodNo; set => barkodNo = value; }
        public string UrunAd { get => urunAd; set => urunAd = value; }
        public string UrunAciklam { get => urunAciklam; set => urunAciklam = value; }
        public int KategoriNo { get => kategoriNo; set => kategoriNo = value; }
        public int UreticiNo { get => ureticiNo; set => ureticiNo = value; }
        public int StokAdedi { get => stokAdedi; set => stokAdedi = value; }
        public double AlisFiyati { get => alisFiyati; set => alisFiyati = value; }
        public double SatisFiyati { get => satisFiyati; set => satisFiyati = value; }
        public DateTime AlisZamani { get => alisZamani; set => alisZamani = value; }
        public int Urun_No { get => urun_No; set => urun_No = value; }


        
        public override string ToString()
        {

            if (barkodNo!=0)
            {
                return this.BarkodNo + " " + this.UrunAd + " " + this.UrunAciklam + " " + this.KategoriNo + " " + this.UreticiNo + " " + this.StokAdedi + " " + this.AlisFiyati + " " + this.SatisFiyati + " " + this.AlisZamani;
            }
            else
            {
                return this.UrunAd+"\n"+this.UrunAciklam;
            }
           
        }

        

    }
}
