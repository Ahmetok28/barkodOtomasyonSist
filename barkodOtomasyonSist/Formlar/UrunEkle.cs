using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace barkodOtomasyonSist
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
            
        }
        dbBaglanti bagla = new dbBaglanti();
        int kategoriNo; 
        int ureticiNo;

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            barkodNoTxt.Focus();
            kategoriComboDoldur();
            ureticiComboDoldur();
        }

        private void kategoriComboDoldur()
        {
            OleDbCommand komut = new OleDbCommand("SELECT * FROM  Kategori", bagla.baglantiKur());
            OleDbDataReader okunan = komut.ExecuteReader();
            while (okunan.Read())
            {
                kategoriNoCombo.Items.Add(okunan["Kategori_No"].ToString() + " (" + okunan["Kategori_Adı"].ToString()+")");
            }
        }

        private void ureticiComboDoldur()
        {
            OleDbCommand komut = new OleDbCommand("SELECT * FROM  Uretici", bagla.baglantiKur());
            OleDbDataReader okunan = komut.ExecuteReader();
            while (okunan.Read())
            {
                ureticiNoCombo.Items.Add(okunan["Satıcı_No"].ToString()+ " ("+okunan["Marka"].ToString()+")");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UrunService().urunKaydet(Convert.ToDouble(barkodNoTxt.Text),urunAdTxt.Text,urunAcııklamaTxt.Text,kategoriNo,ureticiNo,Convert.ToInt32(stokAdetTxt.Text),Convert.ToDouble(alısFiyatTxt.Text),Convert.ToDouble(satısFiyatTxt.Text),Convert.ToDateTime(alısTarihDateTime.Text));
        }

        private void kategoriNoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {           
           kategoriNo = parcala(kategoriNoCombo.Text) ;
        }

        private void ureticiNoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {           
            ureticiNo = parcala(ureticiNoCombo.Text);
        }

        private int parcala(string gelen)
        {
            
            string[] giden = gelen.Split(' ');
            return Convert.ToInt32(giden[0]);
        }
    }
}
