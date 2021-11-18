using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barkodOtomasyonSist.Forms
{
    class KullanıcıDAL
    {

        dbBaglanti bagla = new dbBaglanti();
       

        private string onay;
        private string yoneticimi;

        public string Onay { get => onay; set => onay = value; }
        public string Yoneticimi { get => yoneticimi; set => yoneticimi = value; }

        //Kullanici Giriş Metodu
        public string kullaniciGirisi( TextBox kullaniciAd ,TextBox sifre)
        {


           
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kullanici WHERE KullaniciAdi='" +kullaniciAd.Text+"'AND Sifre ='"+sifre.Text+"'", ((new dbBaglanti()).baglantiKur()));
            OleDbDataReader okunan = komut.ExecuteReader();

            

            if (okunan.Read() == true)
            {
                Onay = "Onaylandı";

            }
            else
            {
                onay = "Onaylanmadı";
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı. Lütfen tekrar deneyin.", "Hata");
            }
           

            bagla.baglantiyiKapat();
            return Onay;
        }
        //kullanici kayit metodu
        internal void kullaniciKayit(string kulAd, string sifre, string yonetici)
        {
            OleDbCommand komut = new OleDbCommand("INSERT INTO Kullanici (KullaniciAdi,Sifre,Yoneticimi) values ('" + kulAd + "','" + sifre + "','" + yonetici + "') ", bagla.baglantiKur());
            komut.ExecuteNonQuery();
            bagla.baglantiyiKapat();
        }

        //Giriş yapanı kontrol eden metod
        public string yoneticiKontrol(string kullaniciAd, string yonetici)
        {
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kullanici WHERE KullaniciAdi='" + kullaniciAd + "'AND Yoneticimi ='" + yonetici + "'", ((new dbBaglanti()).baglantiKur()));
            OleDbDataReader okunan = komut.ExecuteReader();


            if (okunan.Read() == true)
            {
                Yoneticimi = "Evet";

            }
            else
            {
                Yoneticimi = "Hayır";
               
            }


            bagla.baglantiyiKapat();
            return yoneticimi;

        }
        
       
        //internal void kullaniciKayit(string kulAd, Kullanici kul)
        //{
        //    OleDbCommand komut = new OleDbCommand("INSERT INTO Kullanici (KullaniciAdi,Sifre,Yoneticimi) values ('" + kul.KullaniciAdi + "','" + kul.Sifre + "','" + kul.Yoneticimi + "') ", bagla.baglantiKur());
        //    komut.ExecuteNonQuery();
        //    bagla.baglantiyiKapat();
        //}
    }    
}
