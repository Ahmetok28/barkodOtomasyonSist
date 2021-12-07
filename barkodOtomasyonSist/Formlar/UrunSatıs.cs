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
using System.Collections;

namespace barkodOtomasyonSist
{
    public partial class UrunSatıs : Form
    {
        public UrunSatıs()
        {
            InitializeComponent();
        }

        UrunService urnServ = new UrunService();
        int dataGridSırası = 0;
        int urunAdedi = 1;
        
        
        List<double> barkodlar = new List<double>();
        List<int> adetler = new List<int>();
        ListBox liste = new ListBox();
       
        
       
        
        /////////////////////////////////////// Barkodsuz ürünleri TabControle ekleme /////////////////////////////////////////// 
        private void butonOlustur()
        {
            int sayi = urnServ.barkodsuzUrunOku().Count;

            int sayi1 = -1;
            int sayi2 = 0;
            bool flag = true;
            ArrayList okunanUrunler = new UrunService().barkodsuzUrunOku();
            liste.Items.Clear();
            foreach (Barkodsuz b in okunanUrunler)
            {
                
                liste.Items.Add(b);
            }

            try
            {
                for (int i = 0; i < sayi - 1; i++)
                {
                    sayi1++;
                    sayi2 = 0;
                    flag = true;
                    for (int j = 1; j < 5; j++)
                    {
                        sayi2++;
                        int kontrolcu = ((i * 4) + j);


                        if (kontrolcu % 28 == 0)
                        {
                            Button yeniButon = new Button();
                            yeniButon.Text = liste.Items[kontrolcu - 1].ToString();
                            yeniButon.Location = new Point((sayi2 * 110) - 80, (sayi1 * 90) + 30);
                            yeniButon.Width = 100;
                            yeniButon.Height = 70;
                            yeniButon.Click += NewButton_Click;
                            tabControl1.SelectedTab.Controls.Add(yeniButon);
                            ///////////////////////////////////////Yeni TabPage Ekleme///////////////////////////////////////////////////
                            string title = "Borkodsuzlar " + (tabControl1.TabCount + 1).ToString();
                            TabPage newTab = new TabPage(title);
                            tabControl1.TabPages.Add(newTab);
                            tabControl1.SelectTab(newTab);
                            //////////////////////////////////////Yeni TabPage Ekleme////////////////////////////////////////////////////
                            sayi1 = -1;
                            sayi2 = 0;
                            flag = false;

                        }

                        if (flag)
                        {
                           
                            Button yeniButon = new Button();

                            yeniButon.Text = liste.Items[kontrolcu - 1].ToString();
                            /////////////////////////////////////////////this.Controls.Add(yeniButon);//////////////////////////////////////////
                            yeniButon.Location = new Point((sayi2 * 110) - 80, (sayi1 * 90) + 30);
                            yeniButon.Width = 100;
                            yeniButon.Height = 70;
                            yeniButon.Click += NewButton_Click;
                            tabControl1.SelectedTab.Controls.Add(yeniButon);
                        }
                    }
                }
            }
            catch (Exception)
            {

               
            }
                      
        }
        //////////////////////////////////Dinamik butonların tıklamasını Yakalayan kod////////////////////////////////////////////
        private void NewButton_Click(object sender, EventArgs e)
        {
            Button isimler = (Button)sender;
            textBox2.Text += isimler.Text.ToString();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            
        }
              
        private void UrunSatıs_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            panel3.Visible = false;
            butonOlustur();
            tabControl1.SelectTab(tabPage1);
            radioButton1.Checked = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tarihLbl.Text= DateTime.Now.ToLongDateString()+" " + DateTime.Now.ToLongTimeString();

        }
   
        public void urunSat()
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridSırası].Cells[0].Value = urnServ.UrunAra(Convert.ToDouble(textBox1.Text)).BarkodNo;           
            dataGridView1.Rows[dataGridSırası].Cells[1].Value = urnServ.UrunAra(Convert.ToDouble(textBox1.Text)).UrunAd.ToString();
            dataGridView1.Rows[dataGridSırası].Cells[2].Value = urnServ.UrunAra(Convert.ToDouble(textBox1.Text)).UrunAciklam.ToString();
            dataGridView1.Rows[dataGridSırası].Cells[3].Value = urnServ.UrunAra(Convert.ToDouble(textBox1.Text)).SatisFiyati;
            dataGridView1.Rows[dataGridSırası].Cells[4].Value = 1;
        }
        public void labeleYazdir()
        {
            urunAdedi = 1;
            double lblDeger = Convert.ToDouble(label3.Text);
            lblDeger += urunAdedi* Convert.ToDouble(dataGridView1.Rows[dataGridSırası - 1].Cells[3].Value.ToString());

            label3.Text = lblDeger.ToString();
            
        }
       /////////////////////////////////////Satış yap butonu///////////////////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength ==13)
            {

            
            if (radioButton1.Checked||radioButton2.Checked||radioButton3.Checked)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    adetler.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value));
                }
                try
                {
                    if (radioButton1.Checked)
                    {
                        new Nakit().satisYap(barkodlar, adetler);
                        
                        MessageBox.Show("Satış başarılı bir şekilde yapıldı.", "Nakit Satış");
                        dataGridView1.Rows.Clear();
                        label3.Text = "00.00";
                        barkodlar.Clear();
                        adetler.Clear();

                    }
                        else if (radioButton2.Checked)
                        {
                            MessageBox.Show("Bu özellik şu anda kullanılamıyor.");
                        }
                        else if (radioButton3.Checked)
                        {
                            MessageBox.Show("Bu özellik şu anda kullanılamıyor.");
                        }
                }
                catch (Exception ee)
                {

                    MessageBox.Show("Lütfen tekrar deneyin" + ee, "Bir Şeyler Yanlış Gitti", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
            else
            {
                MessageBox.Show("Lütfen satış türünü seçip tekrar deneyin" , "Satış Türü Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows.RemoveAt(i);
                
            }
            dataGridView1.Refresh();
            dataGridSırası--;

            }
            else
            {
                MessageBox.Show("Lütfen 13 haneli bir barkod numarasını giriniz.");
            }

        }
        /////////////////////////////////////////////// Ürün dataGride Eklendiği yer///////////////////////////////////////////////
        private void textBox1_TextChanged(object sender, EventArgs e)
        {            
            try
            {
                if (textBox1.Text.Length == 13)
                {
                    //Ürün DataGridView'e ekli ise ürünün adedini ve fiyatını arttırır.
                    bool urunVarmi = barkodlar.Contains(Convert.ToDouble(textBox1.Text));                   
                    if (urunVarmi)
                    {
                        int arananIndex= barkodlar.IndexOf(Convert.ToDouble(textBox1.Text));
                        
                        urunAdedi = Convert.ToInt32((dataGridView1.Rows[arananIndex].Cells[4].Value));
                        urunAdedi++;
                        double fiyat = Convert.ToDouble(dataGridView1.Rows[arananIndex].Cells[3].Value);
                        double labelDegeri = Convert.ToDouble(label3.Text);
                        double sonuc = 0;
                        sonuc += fiyat;
                        labelDegeri = labelDegeri + sonuc;
                        label3.Text = labelDegeri + "";                      
                        
                        dataGridView1.Rows[arananIndex].Cells[4].Value = urunAdedi;
                        urunAdedi = 1;

                    }
                    //Ürün DataGridView'e ekli değil ise ürünü dataGride ekler.
                    else
                    {
                        urunSat();

                        barkodlar.Add(urnServ.UrunAra(Convert.ToDouble(textBox1.Text)).BarkodNo);
                        dataGridSırası++;
                        labeleYazdir();
                      
                    }                    
                }
            }
            catch (Exception )
            {
                
                DialogResult YesNo= MessageBox.Show("Eklemek İster misiniz ? ", "Böyle Bir Ürün Yok", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (YesNo == DialogResult.Yes)
                {
                    UrunEkle urn = new UrunEkle();
                    urn.Show();
                    urn.barkodNoTxt.Text = textBox1.Text;
                }
                
            }
        }

       
        //////////////////////////////////////// Adet onay butonu/////////////////////////////////////////////////////////////////
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                urunAdedi = Convert.ToInt32(label4.Text);
                double labelDegeri = Convert.ToDouble(label3.Text);
                double fiyat = Convert.ToDouble(dataGridView1.Rows[dataGridSırası - 1].Cells[3].Value.ToString());
                double sonuc = 0;

                dataGridView1.Rows[dataGridSırası - 1].Cells[4].Value = urunAdedi;
                sonuc = urunAdedi * fiyat;
                labelDegeri = labelDegeri + sonuc - fiyat;

                label3.Text = labelDegeri + "";
                label4.Text = "";
                urunAdedi = 1;
            }
            catch (Exception)
            {

                MessageBox.Show("Tüm satırın seçili olduğunu ya da adet sayısını doğru girdiğinizden emin olun", "Bir Şeyler Yanlış Gitti", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            
            
            
            
        }

       
        /////////////////////////////////////Seçili olan ürünün adedini eksiltme butonu///////////////////////////////////////////
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                int seciliIndex = dataGridView1.CurrentCell.RowIndex;
                if (seciliIndex > -1)
                {
                    int adet = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["birimAdetColumn"].Value.ToString());
                    adet--;
                    dataGridView1.SelectedRows[0].Cells["birimAdetColumn"].Value = adet;
                    double barkod = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells["barkodNoColumn"].Value.ToString());
                    double fiyat = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells["fiyatColumn"].Value.ToString());
                    double labelDegeri = Convert.ToDouble(label3.Text);
                    label3.Text = (labelDegeri - fiyat) + "";
                    int indexAra = barkodlar.IndexOf(barkod);


                    if (adet == 0)
                    {
                        barkodlar.RemoveAt(indexAra);
                        dataGridView1.Rows.RemoveAt(seciliIndex);                       
                        dataGridView1.Refresh();
                        dataGridSırası--;
                        
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Tüm satırın seçili olduğundan emin olun", "Bir Şeyler Yanlış Gitti", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

            


        }
        ///////////////////////////////////Seçili olan ürünü dataGridden silme ve fiyatı düşürme butonu///////////////////////////
        private void button16_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bu Ürünü Tamamen Silmek istediğinize emin misiniz?","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int seciliIndex = dataGridView1.CurrentCell.RowIndex;
                    if (seciliIndex > -1)
                    {
                        int adet = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["birimAdetColumn"].Value.ToString());
                        double barkod = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells["barkodNoColumn"].Value.ToString());
                        double fiyat = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells["fiyatColumn"].Value.ToString());
                        double labelDegeri = Convert.ToDouble(label3.Text);
                        double sonuc = 0;
                        sonuc = adet * fiyat;
                        label3.Text = (labelDegeri - sonuc) + "";

                        int indexAra = barkodlar.IndexOf(barkod);
                        barkodlar.RemoveAt(indexAra);
                        dataGridView1.Rows.RemoveAt(seciliIndex);
                        dataGridView1.Refresh();
                        dataGridSırası--;


                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Tüm satırın seçili olduğundan emin olun", "Bir Şeyler Yanlış Gitti", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        /////////////////////////////////////adet sil butonu//////////////////////////////////////////////////////////////////////
        private void button13_Click(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            button18.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            button18.Visible = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            label4.Text += 3 + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text += 1 + "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text += 2 + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text += 4 + "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label4.Text += 5 + "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label4.Text += 6 + "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text += 7 + "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Text += 8 + "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label4.Text += 9 + "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label4.Text += 0 + "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
