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
    public partial class Uretici : Form
    {
        public Uretici()
        {
            InitializeComponent();
        }
        private const int dropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle|= dropShadow;
                return cp;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Uretici_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
