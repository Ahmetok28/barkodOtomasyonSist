using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkodOtomasyonSist
{
    class ureticiClass
    {
        public ureticiClass(int gSaticiNo, string gSaticiAd, string gSaticiUnvan, string gAdres, int gTelNo, string gInternetAdres, string gEposta, string gNotlar)
        {
            this.SatıcıNo = gSaticiNo;
            this.SatıcıAd = gSaticiAd;
            this.SaticiUnvan = gSaticiUnvan;
            this.Adres = gAdres;
            this.TelNo = gTelNo;
            this.InternetAdresi = gInternetAdres;
            this.Eposta = gEposta;
            this.Notlar = gNotlar;
            
        }
        int satıcıNo;
        string satıcıAd;
        string saticiUnvan;
        string adres;
        int telNo;
        string internetAdresi;
        string eposta;
        string notlar;

        public int SatıcıNo { get => satıcıNo; set => satıcıNo = value; }
        public string SatıcıAd { get => satıcıAd; set => satıcıAd = value; }
        public string SaticiUnvan { get => saticiUnvan; set => saticiUnvan = value; }
        public string Adres { get => adres; set => adres = value; }
        public int TelNo { get => telNo; set => telNo = value; }
        public string InternetAdresi { get => internetAdresi; set => internetAdresi = value; }
        public string Eposta { get => eposta; set => eposta = value; }
        public string Notlar { get => notlar; set => notlar = value; }

        public override string ToString()
        {
            return this.SatıcıAd+" (" +this.SaticiUnvan+")";
        }
    }

}
