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
    public partial class Stok_Durumu : Form
    {
        OleDbConnection baglanti1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ahmet\\Desktop\\BarkodOtomasyon1.accdb");
        UrunSatıs urun = new UrunSatıs();
        public Stok_Durumu()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
        }

        void urunAra()
        {
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = (new dbBaglanti()).baglantiKur();
            komut.CommandText = ("SElECT *from Urun where Urun_Ad like '%" + textBox1.Text + "%'");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Barkod_No"].ToString();
                ekle.SubItems.Add(oku["Urun_Ad"].ToString());
                ekle.SubItems.Add(oku["Urun_Acıklama"].ToString());
                ekle.SubItems.Add(oku["Kategori_No"].ToString());
                ekle.SubItems.Add(oku["Uretici_No"].ToString());
                ekle.SubItems.Add(oku["Stok_Adedi"].ToString());
                ekle.SubItems.Add(oku["Alis_Fiyati"].ToString());
                ekle.SubItems.Add(oku["Satis_Fiyati"].ToString());
                ekle.SubItems.Add(oku["Alis_Tarihi"].ToString());

                listView1.Items.Add(ekle);
            }
        }
        void urunAraB()
        {
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = (new dbBaglanti()).baglantiKur();
            komut.CommandText = ("SElECT *from Barkodsuz where Urun_Ad like '%" + textBox1.Text + "%'");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Urun_No"].ToString() + " Barkodsuz";
                ekle.SubItems.Add(oku["Urun_Ad"].ToString());
                ekle.SubItems.Add(oku["Urun_Acıklama"].ToString());
                ekle.SubItems.Add(oku["Kategori_No"].ToString());
                ekle.SubItems.Add(oku["Uretici_No"].ToString());
                ekle.SubItems.Add(oku["Stok_Adedi"].ToString());
                ekle.SubItems.Add(oku["Alis_Fiyati"].ToString());
                ekle.SubItems.Add(oku["Satis_Fiyati"].ToString());
                ekle.SubItems.Add(oku["Alis_Tarihi"].ToString());

                listView1.Items.Add(ekle);
            }

        }

        public void VerileriGuncelle()
        {
            
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = (new dbBaglanti()).baglantiKur();
            komut.CommandText = ("Select * from Urun ");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Barkod_No"].ToString();
                ekle.SubItems.Add(oku["Urun_Ad"].ToString());
                ekle.SubItems.Add(oku["Urun_Acıklama"].ToString());
                ekle.SubItems.Add(oku["Kategori_No"].ToString());
                ekle.SubItems.Add(oku["Uretici_No"].ToString());
                ekle.SubItems.Add(oku["Stok_Adedi"].ToString());
                ekle.SubItems.Add(oku["Alis_Fiyati"].ToString());
                ekle.SubItems.Add(oku["Satis_Fiyati"].ToString());
                ekle.SubItems.Add(oku["Alis_Tarihi"].ToString());

                listView1.Items.Add(ekle);




            }

        }
        public void VerileriGuncelle2()
        {

            OleDbCommand komut = new OleDbCommand();
            komut.Connection = (new dbBaglanti()).baglantiKur();
            komut.CommandText = ("Select * from Barkodsuz ");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Urun_No"].ToString() + " Barkodsuz";
                ekle.SubItems.Add(oku["Urun_Ad"].ToString());
                ekle.SubItems.Add(oku["Urun_Acıklama"].ToString());
                ekle.SubItems.Add(oku["Kategori_No"].ToString());
                ekle.SubItems.Add(oku["Uretici_No"].ToString());
                ekle.SubItems.Add(oku["Stok_Adedi"].ToString());
                ekle.SubItems.Add(oku["Alis_Fiyati"].ToString());
                ekle.SubItems.Add(oku["Satis_Fiyati"].ToString());
                ekle.SubItems.Add(oku["Alis_Tarihi"].ToString());

                listView1.Items.Add(ekle);


            }

        }
        private void Stok_Durumu_Load(object sender, EventArgs e)
        {

            VerileriGuncelle();
            VerileriGuncelle2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            OleDbCommand komut = new OleDbCommand("DELETE FROM Urun where Urun_Ad = '" + textBox1.Text+ "'", baglanti1);
            komut.ExecuteNonQuery();
            baglanti1.Close();
            MessageBox.Show("Test");



            //            if (listView1.SelectedIndices.Count > 0) 
            //            {
            //                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            //}
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void guncelle()
        {
            // listView1.SelectedItems[0].SubItems[1].Text = textBox1.Text;
            //  MessageBox.Show(label3.Text);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            guncelle();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //listView1.Items.Clear();
            //urunAra();
            //urunAraB();
            //if (textBox1.Text == "")
            //{
            //    listView1.Items.Clear();
            //    VerileriGuncelle();
            //    VerileriGuncelle2();
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {

                if (listView1.SelectedItems.Count > 0)

                {

                    ListViewItem item = listView1.SelectedItems[0];

                    textBox1.Text = item.SubItems[1].Text;



                }
                      }
        }
    }
}
