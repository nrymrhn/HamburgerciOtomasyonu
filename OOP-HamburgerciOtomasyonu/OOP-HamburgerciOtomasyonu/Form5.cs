using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HamburgerciOtomasyonu
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
      
        private void btnExtraEkle_Click_1(object sender, EventArgs e)
        {
            Form2.ekstralar.Add(new Ekstra { EkstraMalzAd = txtEkstraMalz.Text, Fiyat = nmrEkstraFiyat.Value });
            //odevdeki temizleme metodu kullanarak buradaki form içinde kullanınız.
            MessageBox.Show("Ekstra Malzeme Eklendi.");
            Fonksiyon.Temizleme(Controls);
            
        }
    }
}
