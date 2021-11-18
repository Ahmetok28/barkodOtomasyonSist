using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace barkodOtomasyonSist
{
    class dbBaglanti
    {
        public OleDbConnection baglantiKur()


        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ahmet\\Desktop\\BarkodOtomasyon1.accdb");
            baglanti.Open();
            return baglanti;
        }
        public OleDbConnection baglantiyiKapat()


        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ahmet\\Desktop\\BarkodOtomasyon1.accdb");
            baglanti.Close();
            return baglanti;
        }



    }
}
