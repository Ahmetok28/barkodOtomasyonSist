
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using barkodOtomasyonSist.Service;

namespace barkodOtomasyonSist
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
       
        KullaniciService kulServ = new KullaniciService();
       
        public string kulAdi;
        protected virtual void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Kapatılacak Emin siniz?", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (Cikis == DialogResult.No)
            {
                
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            UrunSatıs urn = new UrunSatıs();
            urn.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            UrunEkle frm = new UrunEkle();
            frm.Show();
        }

       private void metroTile4_Click(object sender, EventArgs e)
        {
            Uretici uret = new Uretici();

            uret.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Kategori kat = new Kategori();
            kat.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Stok_Durumu_DataGrid stok = new Stok_Durumu_DataGrid();
            stok.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {

        }

        

        private void metroTile6_Click(object sender, EventArgs e)
        {
            gunOzetForm frm = new gunOzetForm();            
            frm.Show();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroContextMenu2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ksasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stokDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stok_Durumu_DataGrid stok = new Stok_Durumu_DataGrid();
            stok.Show();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            RaporForm frm = new RaporForm();
            frm.Show();
        }

        private void programHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ayarlarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            if (kulServ.yoneticiKontrol(kulAdi, "Evet")== "Evet")
            {
                AyarlarForm ay = new AyarlarForm();
                ay.Show();
            }
            else
            {
               
                MessageBox.Show("Sadece yönetici olanlar Ayarlar menüsüne girebilir !","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            

        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunEkle frm = new UrunEkle();
            frm.Show();
        }

        private void üreticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uretici uret = new Uretici();
            uret.Show();
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kategori kat = new Kategori();
            kat.Show();
        }
    }
}
