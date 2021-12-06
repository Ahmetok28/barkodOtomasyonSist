using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkodOtomasyonSist
{
    public class Barkodsuz
    {
        int urun_No;
        string urun_Ad;
        string urun_Acıklama;
        int kategori_No;
        int uretici_No;
        int stok_Adedi;
        double alis_Fiyati;
        double satis_Fiyati;
        DateTime alis_Tarihi;
       

        public Barkodsuz()
        {
        }

        public Barkodsuz(string v1, string v2, int v3, int v4, int v5, double v6, double v7, DateTime dateTime, int v8)
        {
            Urun_Ad = v1;
            Urun_Acıklama = v2;

            Kategori_No = v3;
            Uretici_No = v4;
            Stok_Adedi = v5;
            Alis_Fiyati = v6;
            Satis_Fiyati = v7;
            Alis_Tarihi = dateTime;
            Urun_No = v8;
        }

        public int Urun_No { get => urun_No; set => urun_No = value; }
        public string Urun_Ad { get => urun_Ad; set => urun_Ad = value; }
        public string Urun_Acıklama { get => urun_Acıklama; set => urun_Acıklama = value; }
        public int Kategori_No { get => kategori_No; set => kategori_No = value; }
        public int Uretici_No { get => uretici_No; set => uretici_No = value; }
        public int Stok_Adedi { get => stok_Adedi; set => stok_Adedi = value; }
        public double Alis_Fiyati { get => alis_Fiyati; set => alis_Fiyati = value; }
        public double Satis_Fiyati { get => satis_Fiyati; set => satis_Fiyati = value; }
        public DateTime Alis_Tarihi { get => alis_Tarihi; set => alis_Tarihi = value; }

        public override string ToString()
        {
            return this.Urun_Ad + "\n" + this.Urun_Acıklama;
        }
    }
    
   
}
