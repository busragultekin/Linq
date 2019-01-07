namespace LINQ
{
    partial class Form1
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
            this.tum_sayilar = new System.Windows.Forms.Button();
            this.tum_siparis = new System.Windows.Forms.Button();
            this.tum_isim = new System.Windows.Forms.Button();
            this.negatif_sayilar = new System.Windows.Forms.Button();
            this.pozitif_sayilar = new System.Windows.Forms.Button();
            this.cift_sayilar = new System.Windows.Forms.Button();
            this.tek_sayilar = new System.Windows.Forms.Button();
            this.sayilar_en_buyuk = new System.Windows.Forms.Button();
            this.sayilar_en_kucuk = new System.Windows.Forms.Button();
            this.kac_tane = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.alfabetik = new System.Windows.Forms.Button();
            this.ters_alfabetik = new System.Windows.Forms.Button();
            this.uzunluk = new System.Windows.Forms.Button();
            this.i_barindiran = new System.Windows.Forms.Button();
            this.a_ile_baslayan = new System.Windows.Forms.Button();
            this.sadece_tarih = new System.Windows.Forms.Button();
            this.ilk_5 = new System.Windows.Forms.Button();
            this.son_5 = new System.Windows.Forms.Button();
            this.yang_wang = new System.Windows.Forms.Button();
            this.siparis_sayisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // tum_sayilar
            // 
            this.tum_sayilar.Location = new System.Drawing.Point(12, 12);
            this.tum_sayilar.Name = "tum_sayilar";
            this.tum_sayilar.Size = new System.Drawing.Size(91, 42);
            this.tum_sayilar.TabIndex = 1;
            this.tum_sayilar.Text = "Tüm Sayılar";
            this.tum_sayilar.UseVisualStyleBackColor = true;
            this.tum_sayilar.Click += new System.EventHandler(this.tum_sayilar_Click);
            // 
            // tum_siparis
            // 
            this.tum_siparis.Location = new System.Drawing.Point(12, 105);
            this.tum_siparis.Name = "tum_siparis";
            this.tum_siparis.Size = new System.Drawing.Size(91, 42);
            this.tum_siparis.TabIndex = 2;
            this.tum_siparis.Text = "TümSiparişler";
            this.tum_siparis.UseVisualStyleBackColor = true;
            this.tum_siparis.Click += new System.EventHandler(this.tum_siparis_Click);
            // 
            // tum_isim
            // 
            this.tum_isim.Location = new System.Drawing.Point(12, 57);
            this.tum_isim.Name = "tum_isim";
            this.tum_isim.Size = new System.Drawing.Size(91, 42);
            this.tum_isim.TabIndex = 3;
            this.tum_isim.Text = "Tüm İsimler";
            this.tum_isim.UseVisualStyleBackColor = true;
            // 
            // negatif_sayilar
            // 
            this.negatif_sayilar.Location = new System.Drawing.Point(109, 12);
            this.negatif_sayilar.Name = "negatif_sayilar";
            this.negatif_sayilar.Size = new System.Drawing.Size(53, 42);
            this.negatif_sayilar.TabIndex = 4;
            this.negatif_sayilar.Text = "Negatif";
            this.negatif_sayilar.UseVisualStyleBackColor = true;
            this.negatif_sayilar.Click += new System.EventHandler(this.negatif_sayilar_Click);
            // 
            // pozitif_sayilar
            // 
            this.pozitif_sayilar.Location = new System.Drawing.Point(168, 12);
            this.pozitif_sayilar.Name = "pozitif_sayilar";
            this.pozitif_sayilar.Size = new System.Drawing.Size(48, 42);
            this.pozitif_sayilar.TabIndex = 5;
            this.pozitif_sayilar.Text = "Pozitif";
            this.pozitif_sayilar.UseVisualStyleBackColor = true;
            this.pozitif_sayilar.Click += new System.EventHandler(this.pozitif_sayilar_Click);
            // 
            // cift_sayilar
            // 
            this.cift_sayilar.Location = new System.Drawing.Point(262, 12);
            this.cift_sayilar.Name = "cift_sayilar";
            this.cift_sayilar.Size = new System.Drawing.Size(36, 42);
            this.cift_sayilar.TabIndex = 6;
            this.cift_sayilar.Text = "Çift";
            this.cift_sayilar.UseVisualStyleBackColor = true;
            this.cift_sayilar.Click += new System.EventHandler(this.cift_sayilar_Click);
            // 
            // tek_sayilar
            // 
            this.tek_sayilar.Location = new System.Drawing.Point(221, 12);
            this.tek_sayilar.Name = "tek_sayilar";
            this.tek_sayilar.Size = new System.Drawing.Size(35, 42);
            this.tek_sayilar.TabIndex = 7;
            this.tek_sayilar.Text = "Tek";
            this.tek_sayilar.UseVisualStyleBackColor = true;
            this.tek_sayilar.Click += new System.EventHandler(this.tek_sayilar_Click);
            // 
            // sayilar_en_buyuk
            // 
            this.sayilar_en_buyuk.Location = new System.Drawing.Point(304, 12);
            this.sayilar_en_buyuk.Name = "sayilar_en_buyuk";
            this.sayilar_en_buyuk.Size = new System.Drawing.Size(67, 42);
            this.sayilar_en_buyuk.TabIndex = 8;
            this.sayilar_en_buyuk.Text = "En büyük";
            this.sayilar_en_buyuk.UseVisualStyleBackColor = true;
            this.sayilar_en_buyuk.Click += new System.EventHandler(this.sayilar_en_buyuk_Click);
            // 
            // sayilar_en_kucuk
            // 
            this.sayilar_en_kucuk.Location = new System.Drawing.Point(377, 9);
            this.sayilar_en_kucuk.Name = "sayilar_en_kucuk";
            this.sayilar_en_kucuk.Size = new System.Drawing.Size(55, 42);
            this.sayilar_en_kucuk.TabIndex = 9;
            this.sayilar_en_kucuk.Text = "En küçük";
            this.sayilar_en_kucuk.UseVisualStyleBackColor = true;
            this.sayilar_en_kucuk.Click += new System.EventHandler(this.sayilar_en_kucuk_Click);
            // 
            // kac_tane
            // 
            this.kac_tane.Location = new System.Drawing.Point(438, 9);
            this.kac_tane.Name = "kac_tane";
            this.kac_tane.Size = new System.Drawing.Size(65, 42);
            this.kac_tane.TabIndex = 10;
            this.kac_tane.Text = "Kaç tane";
            this.kac_tane.UseVisualStyleBackColor = true;
            this.kac_tane.Click += new System.EventHandler(this.kac_tane_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(91, 225);
            this.listBox1.TabIndex = 11;
            // 
            // alfabetik
            // 
            this.alfabetik.Location = new System.Drawing.Point(109, 57);
            this.alfabetik.Name = "alfabetik";
            this.alfabetik.Size = new System.Drawing.Size(63, 42);
            this.alfabetik.TabIndex = 12;
            this.alfabetik.Text = "Alfabetik";
            this.alfabetik.UseVisualStyleBackColor = true;
            this.alfabetik.Click += new System.EventHandler(this.alfabetik_Click);
            // 
            // ters_alfabetik
            // 
            this.ters_alfabetik.Location = new System.Drawing.Point(178, 57);
            this.ters_alfabetik.Name = "ters_alfabetik";
            this.ters_alfabetik.Size = new System.Drawing.Size(63, 42);
            this.ters_alfabetik.TabIndex = 13;
            this.ters_alfabetik.Text = "Alfabetik ters";
            this.ters_alfabetik.UseVisualStyleBackColor = true;
            this.ters_alfabetik.Click += new System.EventHandler(this.ters_alfabetik_Click);
            // 
            // uzunluk
            // 
            this.uzunluk.Location = new System.Drawing.Point(247, 57);
            this.uzunluk.Name = "uzunluk";
            this.uzunluk.Size = new System.Drawing.Size(63, 42);
            this.uzunluk.TabIndex = 14;
            this.uzunluk.Text = "Uzunluk";
            this.uzunluk.UseVisualStyleBackColor = true;
            this.uzunluk.Click += new System.EventHandler(this.uzunluk_Click);
            // 
            // i_barindiran
            // 
            this.i_barindiran.Location = new System.Drawing.Point(316, 57);
            this.i_barindiran.Name = "i_barindiran";
            this.i_barindiran.Size = new System.Drawing.Size(63, 42);
            this.i_barindiran.TabIndex = 15;
            this.i_barindiran.Text = "i barındıran";
            this.i_barindiran.UseVisualStyleBackColor = true;
            this.i_barindiran.Click += new System.EventHandler(this.i_barindiran_Click);
            // 
            // a_ile_baslayan
            // 
            this.a_ile_baslayan.Location = new System.Drawing.Point(385, 57);
            this.a_ile_baslayan.Name = "a_ile_baslayan";
            this.a_ile_baslayan.Size = new System.Drawing.Size(63, 42);
            this.a_ile_baslayan.TabIndex = 16;
            this.a_ile_baslayan.Text = "A ile başlayan";
            this.a_ile_baslayan.UseVisualStyleBackColor = true;
            this.a_ile_baslayan.Click += new System.EventHandler(this.a_ile_baslayan_Click);
            // 
            // sadece_tarih
            // 
            this.sadece_tarih.Location = new System.Drawing.Point(109, 105);
            this.sadece_tarih.Name = "sadece_tarih";
            this.sadece_tarih.Size = new System.Drawing.Size(63, 42);
            this.sadece_tarih.TabIndex = 17;
            this.sadece_tarih.Text = "Sadece Tarihler";
            this.sadece_tarih.UseVisualStyleBackColor = true;
            this.sadece_tarih.Click += new System.EventHandler(this.sadece_tarih_Click);
            // 
            // ilk_5
            // 
            this.ilk_5.Location = new System.Drawing.Point(178, 105);
            this.ilk_5.Name = "ilk_5";
            this.ilk_5.Size = new System.Drawing.Size(63, 42);
            this.ilk_5.TabIndex = 18;
            this.ilk_5.Text = "ilk 5";
            this.ilk_5.UseVisualStyleBackColor = true;
            this.ilk_5.Click += new System.EventHandler(this.ilk_5_Click);
            // 
            // son_5
            // 
            this.son_5.Location = new System.Drawing.Point(247, 105);
            this.son_5.Name = "son_5";
            this.son_5.Size = new System.Drawing.Size(63, 42);
            this.son_5.TabIndex = 19;
            this.son_5.Text = "son 5";
            this.son_5.UseVisualStyleBackColor = true;
            this.son_5.Click += new System.EventHandler(this.son_5_Click);
            // 
            // yang_wang
            // 
            this.yang_wang.Location = new System.Drawing.Point(316, 105);
            this.yang_wang.Name = "yang_wang";
            this.yang_wang.Size = new System.Drawing.Size(63, 42);
            this.yang_wang.TabIndex = 20;
            this.yang_wang.Text = "yang wang";
            this.yang_wang.UseVisualStyleBackColor = true;
            this.yang_wang.Click += new System.EventHandler(this.yang_wang_Click);
            // 
            // siparis_sayisi
            // 
            this.siparis_sayisi.Location = new System.Drawing.Point(385, 105);
            this.siparis_sayisi.Name = "siparis_sayisi";
            this.siparis_sayisi.Size = new System.Drawing.Size(63, 42);
            this.siparis_sayisi.TabIndex = 21;
            this.siparis_sayisi.Text = "sipariş sayısı";
            this.siparis_sayisi.UseVisualStyleBackColor = true;
            this.siparis_sayisi.Click += new System.EventHandler(this.siparis_sayisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 387);
            this.Controls.Add(this.siparis_sayisi);
            this.Controls.Add(this.yang_wang);
            this.Controls.Add(this.son_5);
            this.Controls.Add(this.ilk_5);
            this.Controls.Add(this.sadece_tarih);
            this.Controls.Add(this.a_ile_baslayan);
            this.Controls.Add(this.i_barindiran);
            this.Controls.Add(this.uzunluk);
            this.Controls.Add(this.ters_alfabetik);
            this.Controls.Add(this.alfabetik);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.kac_tane);
            this.Controls.Add(this.sayilar_en_kucuk);
            this.Controls.Add(this.sayilar_en_buyuk);
            this.Controls.Add(this.tek_sayilar);
            this.Controls.Add(this.cift_sayilar);
            this.Controls.Add(this.pozitif_sayilar);
            this.Controls.Add(this.negatif_sayilar);
            this.Controls.Add(this.tum_isim);
            this.Controls.Add(this.tum_siparis);
            this.Controls.Add(this.tum_sayilar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button tum_sayilar;
        private System.Windows.Forms.Button tum_siparis;
        private System.Windows.Forms.Button tum_isim;
        private System.Windows.Forms.Button negatif_sayilar;
        private System.Windows.Forms.Button pozitif_sayilar;
        private System.Windows.Forms.Button cift_sayilar;
        private System.Windows.Forms.Button tek_sayilar;
        private System.Windows.Forms.Button sayilar_en_buyuk;
        private System.Windows.Forms.Button sayilar_en_kucuk;
        private System.Windows.Forms.Button kac_tane;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button alfabetik;
        private System.Windows.Forms.Button ters_alfabetik;
        private System.Windows.Forms.Button uzunluk;
        private System.Windows.Forms.Button i_barindiran;
        private System.Windows.Forms.Button a_ile_baslayan;
        private System.Windows.Forms.Button sadece_tarih;
        private System.Windows.Forms.Button ilk_5;
        private System.Windows.Forms.Button son_5;
        private System.Windows.Forms.Button yang_wang;
        private System.Windows.Forms.Button siparis_sayisi;
    }
}

