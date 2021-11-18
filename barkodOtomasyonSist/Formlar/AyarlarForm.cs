using barkodOtomasyonSist.Formlar;
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

namespace barkodOtomasyonSist
{
    public partial class AyarlarForm : Form 
    {
        public AyarlarForm()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
        private void menuGizle()
        {
            if (panel1.Visible == true) panel1.Visible = false;
            if (panel2.Visible == true) panel2.Visible = false;
            if (panel3.Visible == true) panel3.Visible = false;
        }

        private void menuGoster(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                menuGizle();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
            
        }

        private void AyarlarForm_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuGoster(panel1);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            menuGoster(panel2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            menuGoster(panel3);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new KullaniciKayit());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new ŞirketBilgileri());
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
