namespace barkodOtomasyonSist
{
    partial class ŞirketBilgileri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.silBtn = new MetroFramework.Controls.MetroButton();
            this.guncelleBtn = new MetroFramework.Controls.MetroButton();
            this.ekleBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(401, 37);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(122, 79);
            this.silBtn.TabIndex = 1;
            this.silBtn.Text = "Sil";
            this.silBtn.UseSelectable = true;
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(401, 144);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(122, 79);
            this.guncelleBtn.TabIndex = 2;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseSelectable = true;
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(401, 257);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(122, 79);
            this.ekleBtn.TabIndex = 3;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseSelectable = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // ŞirketBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 407);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ŞirketBilgileri";
            this.Text = "d";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton silBtn;
        private MetroFramework.Controls.MetroButton guncelleBtn;
        private MetroFramework.Controls.MetroButton ekleBtn;
    }
}