using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        int[] sayilar = { -9, -5, 3, 8, 12, 25 };
        List<string> isimler = new List<string>();
        public Form1()
        {
            InitializeComponent();
            isimler.Add("Büşra");
            isimler.Add("Ayşe");
            isimler.Add("Fatma");
            isimler.Add("Hayriye");
            isimler.Add("Mesut");
            isimler.Add("Caner");
        }

        private void tum_sayilar_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.ToList();
        }

        private void negatif_sayilar_Click(object sender, EventArgs e)
        {
            //lambda expression =>
            //foreach ile dolaşabildiğimiz generic bir interface
            IEnumerable<int> n = sayilar.Where(x => x < 0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void pozitif_sayilar_Click(object sender, EventArgs e)
        {
            IEnumerable<int> p = sayilar.Where(x => x > 0);
            listBox1.DataSource = null;
            listBox1.DataSource = p.ToList();
        }

        private void tek_sayilar_Click(object sender, EventArgs e)
        {
            IEnumerable<int> tek = sayilar.Where(x => (x % 2)!=0);
          //  IEnumerable<int> tek = sayilar.Where(x => (x % 2) == 1 || x => (x % 2) == -1);
            listBox1.DataSource = null;
            listBox1.DataSource = tek.ToList();
        }

        private void cift_sayilar_Click(object sender, EventArgs e)
        {
            IEnumerable<int> cift = sayilar.Where(x => (x % 2) == 0);
            listBox1.DataSource = null;
            listBox1.DataSource = cift.ToList();
        }

        private void sayilar_en_buyuk_Click(object sender, EventArgs e)
        {
            int eb = sayilar.Max();
            MessageBox.Show(eb.ToString());
            
        }

        private void sayilar_en_kucuk_Click(object sender, EventArgs e)
        {
            int ek = sayilar.Min();
            MessageBox.Show(ek.ToString());
        }

        private void kac_tane_Click(object sender, EventArgs e)
        {
            int kactane = sayilar.Length;//daha hızlı 
            int count = sayilar.Count();
            MessageBox.Show(kactane.ToString());
        }

        private void alfabetik_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            //IOrderedEnumerable<string> sirali = isimler.OrderBy(x => x);
            listBox1.DataSource = isimler.OrderBy(x => x).ToList() ;
        }

        private void ters_alfabetik_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.OrderByDescending(x => x).ToList();
        }

        private void uzunluk_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;//IE<int>
            listBox1.DataSource = isimler.Select(x => x.Length).ToList();
        }

        private void i_barindiran_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Where(x => x.Contains("i")||  x.Contains("İ")).ToList();
        }

        private void a_ile_baslayan_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Where(x => x.StartsWith("a")|| x.StartsWith("A")).ToList();
        }

        private void tum_siparis_Click(object sender, EventArgs e)
        {
            var gorunen = Order.GetOrders().Select(satir => new
            {
                SiparisNo = satir.OrderID,
                Tarih = satir.OrderDate,
                Musteri = satir.Customer.ContactName
            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gorunen.ToList();
        }

        private void sadece_tarih_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Order.GetOrders().Select(x => x.OrderDate).ToList();
        }

        private void ilk_5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            //Skip(10).Take(5)// 10 kayıt atla sıradaki 5 kaydı al
            dataGridView1.DataSource = Order.GetOrders().Take(5).Select(x=>new { x.OrderID, x.Customer.ContactName, x.OrderDate }).ToList();
        }

        private void son_5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            //Skip(10).Take(5)// 10 kayıt atla sıradaki 5 kaydı al
            dataGridView1.DataSource = Order.GetOrders().OrderByDescending(x=>x.OrderID).Take(5).ToList();
        }

        private void yang_wang_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Order.GetOrders().Where(x => x.Customer.ContactName == "Yang Wang").ToList();
        }

        private void siparis_sayisi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            MessageBox.Show(Order.GetOrders().Count.ToString());
        }
    }
}
