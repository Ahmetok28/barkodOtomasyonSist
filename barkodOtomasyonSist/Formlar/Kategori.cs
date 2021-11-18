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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                
                OleDbCommand komut = new OleDbCommand("insert into Kategori(Kategori_Adı,KDV_Oranı) values ('" + textBox2.Text + "','" + textBox3.Text + "')", (new dbBaglanti()).baglantiKur() );
                komut.Connection = (new dbBaglanti()).baglantiKur();

                komut.ExecuteNonQuery();
               
                MessageBox.Show("Kategori Başarıyla Eklendi");
            }
        }

        private void Kategori_Load(object sender, EventArgs e)
        {

        }
    }
}
