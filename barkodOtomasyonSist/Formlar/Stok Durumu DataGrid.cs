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
    public partial class Stok_Durumu_DataGrid : Form
    {
        public Stok_Durumu_DataGrid()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        UrunService urnserv = new UrunService();

        private void kayitGetir()
        {
           
            string kayit = "SELECT * from Urun";
            string kayit2 = "SELECT * from Barkodsuz";

            OleDbCommand komut = new OleDbCommand(kayit, (new dbBaglanti()).baglantiKur());
            OleDbCommand komut2 = new OleDbCommand(kayit2, (new dbBaglanti()).baglantiKur());

            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            OleDbDataAdapter da2 = new OleDbDataAdapter(komut2);

            
           

            da.Fill(dt);
            da2.Fill(dt);

            
            dataGridView1.DataSource = dt;


        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stok_Durumu_DataGrid_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            urnserv.urunSil(Convert.ToDouble(dataGridView1.CurrentRow.Cells[0].Value));

            MessageBox.Show("Kayıt Silindi");

            //OleDbCommand komut = new OleDbCommand("DELETE FROM Urun WHERE Barkod_No ='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", (new dbBaglanti()).baglantiKur());
            //komut.ExecuteNonQuery();

        }
    }
}
