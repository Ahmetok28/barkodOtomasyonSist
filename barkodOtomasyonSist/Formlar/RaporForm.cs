using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barkodOtomasyonSist
{
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {


        }

        void hesapla()
        {
            double sonuc = 0;
            double toplamFiyat = 0;
            double alisfiyati = 0;
            int adet = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                toplamFiyat = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                alisfiyati = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                adet = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                sonuc += toplamFiyat - (alisfiyati * adet);

            }
            label3.Text = sonuc + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridDoldur();
            hesapla();
            grafikCiz();
           
        }

        private void dataGridDoldur()
        {
            try
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter("SELECT BarkodNo,UrunAd,ToplamFiyat,SatisFiyati,AlisFiyati,SatilanAdet,SatisTarihi FROM Satislar WHERE SatisTarihi BETWEEN @BaslangıcTar AND @BitisTar", new dbBaglanti().baglantiKur());
                adp.SelectCommand.Parameters.AddWithValue("@BaslangıcTar", dateTimePicker1.Value.ToShortDateString() + " 00:00:00");
                adp.SelectCommand.Parameters.AddWithValue("@BitisTar", dateTimePicker2.Value.ToShortDateString() + " 23:59:59");
                adp.Fill(dt);

                dataGridView1.DataSource = dt;
                
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Tekrar Deneyin.", "Bir Sorunla Karşılaştık", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void grafikCiz()
        {
            List<double> barkodlar = new List<double>();
            List<int> adetler = new List<int>();

            
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                bool urunVarmi = barkodlar.Contains(Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value));
                if (urunVarmi)
                {
                    int arananIndex = barkodlar.IndexOf(Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value));

                    int oncekiUrunAdet =Convert.ToInt32( adetler[arananIndex]);
                    int urunAdedi = Convert.ToInt32((dataGridView1.Rows[i].Cells[5].Value));
                    adetler[arananIndex] = oncekiUrunAdet + urunAdedi;
                   
                   
                }
                else
                {
                    barkodlar.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value));
                    adetler.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
                }
            }
            double sonuc = 0;
            for (int i = 0; i <adetler.Count; i++)
            {
                
                if (i<6)
                {
                    chart1.Series["urunChart"].Points.AddXY((new UrunService().UrunAra(barkodlar[i]).UrunAd), adetler[i]*(new UrunService().UrunAra(barkodlar[i]).SatisFiyati));
                   
                }
                else if (i > 6)
                {
                    sonuc += adetler[i] * (new UrunService().UrunAra(barkodlar[i]).SatisFiyati);

                }
            }
            chart1.Series["urunChart"].Points.AddXY("Diğer", sonuc);

        }
    }
}
