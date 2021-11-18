using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkodOtomasyonSist
{
    interface ISatisYap
    {
        public void satisYap(List<double> barkodlar,List<int> gelenAdet);
        public void dbKaydet();
        public void analizYap();
    }
    
}