namespace _32AdoNetDemo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxStokAdet = new System.Windows.Forms.TextBox();
            this.tbxUrunFiyat = new System.Windows.Forms.TextBox();
            this.tbxUrunAdi = new System.Windows.Forms.TextBox();
            this.btnKadet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxGuncelleUrunFiyat = new System.Windows.Forms.TextBox();
            this.tbxGuncelleStokAdet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxGuncelleUrunAdi = new System.Windows.Forms.TextBox();
            this.btnSilme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUrunler
            // 
            this.dgwUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunler.Location = new System.Drawing.Point(27, 32);
            this.dgwUrunler.Name = "dgwUrunler";
            this.dgwUrunler.Size = new System.Drawing.Size(740, 202);
            this.dgwUrunler.TabIndex = 0;
            this.dgwUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrunler_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxStokAdet);
            this.groupBox1.Controls.Add(this.tbxUrunFiyat);
            this.groupBox1.Controls.Add(this.tbxUrunAdi);
            this.groupBox1.Controls.Add(this.btnKadet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekleme İşlemi";
            // 
            // tbxStokAdet
            // 
            this.tbxStokAdet.Location = new System.Drawing.Point(102, 102);
            this.tbxStokAdet.Name = "tbxStokAdet";
            this.tbxStokAdet.Size = new System.Drawing.Size(100, 20);
            this.tbxStokAdet.TabIndex = 6;
            // 
            // tbxUrunFiyat
            // 
            this.tbxUrunFiyat.Location = new System.Drawing.Point(102, 70);
            this.tbxUrunFiyat.Name = "tbxUrunFiyat";
            this.tbxUrunFiyat.Size = new System.Drawing.Size(100, 20);
            this.tbxUrunFiyat.TabIndex = 5;
            // 
            // tbxUrunAdi
            // 
            this.tbxUrunAdi.Location = new System.Drawing.Point(102, 34);
            this.tbxUrunAdi.Name = "tbxUrunAdi";
            this.tbxUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.tbxUrunAdi.TabIndex = 4;
            // 
            // btnKadet
            // 
            this.btnKadet.Location = new System.Drawing.Point(152, 134);
            this.btnKadet.Name = "btnKadet";
            this.btnKadet.Size = new System.Drawing.Size(75, 23);
            this.btnKadet.TabIndex = 3;
            this.btnKadet.Text = "Kaydet";
            this.btnKadet.UseVisualStyleBackColor = true;
            this.btnKadet.Click += new System.EventHandler(this.btnKadet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Adet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tbxGuncelleUrunFiyat);
            this.groupBox2.Controls.Add(this.tbxGuncelleStokAdet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxGuncelleUrunAdi);
            this.groupBox2.Location = new System.Drawing.Point(355, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 177);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Düzenleme İşlemi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxGuncelleUrunFiyat
            // 
            this.tbxGuncelleUrunFiyat.Location = new System.Drawing.Point(94, 67);
            this.tbxGuncelleUrunFiyat.Name = "tbxGuncelleUrunFiyat";
            this.tbxGuncelleUrunFiyat.Size = new System.Drawing.Size(100, 20);
            this.tbxGuncelleUrunFiyat.TabIndex = 7;
            // 
            // tbxGuncelleStokAdet
            // 
            this.tbxGuncelleStokAdet.Location = new System.Drawing.Point(94, 102);
            this.tbxGuncelleStokAdet.Name = "tbxGuncelleStokAdet";
            this.tbxGuncelleStokAdet.Size = new System.Drawing.Size(100, 20);
            this.tbxGuncelleStokAdet.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Stok Adet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ürün Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün Adı";
            // 
            // tbxGuncelleUrunAdi
            // 
            this.tbxGuncelleUrunAdi.Location = new System.Drawing.Point(94, 31);
            this.tbxGuncelleUrunAdi.Name = "tbxGuncelleUrunAdi";
            this.tbxGuncelleUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.tbxGuncelleUrunAdi.TabIndex = 7;
            // 
            // btnSilme
            // 
            this.btnSilme.Location = new System.Drawing.Point(666, 261);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(101, 23);
            this.btnSilme.TabIndex = 3;
            this.btnSilme.Text = "Seçilen Kaydı Sil";
            this.btnSilme.UseVisualStyleBackColor = true;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxStokAdet;
        private System.Windows.Forms.TextBox tbxUrunFiyat;
        private System.Windows.Forms.TextBox tbxUrunAdi;
        private System.Windows.Forms.Button btnKadet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxGuncelleUrunFiyat;
        private System.Windows.Forms.TextBox tbxGuncelleStokAdet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxGuncelleUrunAdi;
        private System.Windows.Forms.Button btnSilme;
    }
}

