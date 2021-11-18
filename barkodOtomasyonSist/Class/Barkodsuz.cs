using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkodOtomasyonSist
{
    class Barkodsuz
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

        public int Urun_No { get => urun_No; set => urun_No = value; }
        public string Urun_Ad { get => urun_Ad; set => urun_Ad = value; }
        public string Urun_Acıklama { get => urun_Acıklama; set => urun_Acıklama = value; }
        public int Kategori_No { get => kategori_No; set => kategori_No = value; }
        public int Uretici_No { get => uretici_No; set => uretici_No = value; }
        public int Stok_Adedi { get => stok_Adedi; set => stok_Adedi = value; }
        public double Alis_Fiyati { get => alis_Fiyati; set => alis_Fiyati = value; }
        public double Satis_Fiyati { get => satis_Fiyati; set => satis_Fiyati = value; }
        public DateTime Alis_Tarihi { get => alis_Tarihi; set => alis_Tarihi = value; }
    }
}
