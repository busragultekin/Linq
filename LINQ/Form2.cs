using LINQ.Properties;
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
    public partial class Form2 : Form
    {
        internal List<Personel> liste = new List<Personel>();//public olursa personel classı da public yapmak lazım. sadece form 2 olduğu için private de yapılabilir
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_yeniPers_Click(object sender, EventArgs e)
        {
            liste.Add(new Personel());
            string pSayi = liste.Count.ToString();
            lbl_personel_sayi.Text = Properties.Resources.sablon1.Replace("0",pSayi);
            string ortMaas = liste.Average(x => x.Maas).ToString("C");
            lbl_ort_maas.Text = Resources.sablon2.Replace("0", ortMaas);
            /*
            var sonYas = liste.Last().Yas.ToString();
            lbl_yas.Text = Resources.sablon3.Replace("0", sonYas);
            var sonMaas = liste.Last().Maas.ToString();
            lbl_maas.Text = Resources.sablon4.Replace("0", sonMaas);
            */
            Personel p1 = liste.Last();
            lbl_yas.Text = Resources.sablon3.Replace("0", p1.Yas.ToString());
            lbl_maas.Text = Resources.sablon3.Replace("0", p1.Maas.ToString());
        }
    }
}
