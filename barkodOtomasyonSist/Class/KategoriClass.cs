using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barkodOtomasyonSist
{
    public class KategoriClass
    {
       public KategoriClass(int gKatNo,string gKatAd,int gkdvOrani)
        {
            this.KategoriNo = gKatNo;
            this.KategoriAd = gKatAd;
            this.KDVOranı = gkdvOrani;
        }

        int kategoriNo;
        string kategoriAd;
        int kDVOranı;

        public int KategoriNo { get => kategoriNo; set => kategoriNo = value; }
        public string KategoriAd { get => kategoriAd; set => kategoriAd = value; }
        public int KDVOranı { get => kDVOranı; set => kDVOranı = value; }

        public override string ToString()
        {
            return this.KategoriAd ;
        }

        
    }
}
