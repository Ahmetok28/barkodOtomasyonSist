using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using barkodOtomasyonSist.Forms;
using barkodOtomasyonSist.Service;

namespace barkodOtomasyonSist
{
    public partial class kullaniciGiris : Form
    {
        KullaniciService kulServ = new KullaniciService();
        
        
        public kullaniciGiris()
        {
            InitializeComponent();
        }

        private string yon;
        public string Yon { get => yon; set => yon = value; }

        KullanıcıDAL klnc = new KullanıcıDAL();
        
        private const int dropShadow = 0x00020000;

       
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= dropShadow;
                return cp;
            }
        }

      

        private void kullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kulServ.kullaniciGirisi(kullaniciAdTxt, sifreTxt)=="Onaylandı")

            {


                this.Hide();
                Form1 f1 = new Form1();
                f1.kulAdi = kullaniciAdTxt.Text;
                f1.FormClosing += f1_FormClosing;
                f1.ShowDialog();
                Close();
               
               
               
            }


           
            

        }

        private void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
