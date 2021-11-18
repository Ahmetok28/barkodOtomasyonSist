using barkodOtomasyonSist.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barkodOtomasyonSist.Formlar
{
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        string yoneticimi;

        public string Yoneticimi { get => yoneticimi; set => yoneticimi = value; }

        private void KullaniciKayit_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox1.Text!="" && metroTextBox2.Text!="")
                {
                    new KullaniciService().kullaniciKayit(metroTextBox1.Text, metroTextBox2.Text, Yoneticimi);
                    MessageBox.Show("Kayıt başarıyla gerçekleşti.");
                }
                else
                {
                    MessageBox.Show("Lütfen kullanıcı adı ya da şifre kısmını boş bırakmadığınızdan emin olun");
                }
                
            }
            catch (Exception ee)
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu .\n" + ee);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                yoneticimi = "Evet";
            }
            else
            {
                yoneticimi = "Hayır";
            }
        }
    }
}
