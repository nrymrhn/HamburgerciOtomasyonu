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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
     
        private void btnMenuEkle_Click_1(object sender, EventArgs e)
        {
            Form2.Menuler.Add(new Menu { MenuAdi = txtMenuAdi.Text, Fiyati = nmrMenuFiyati.Value });
            //odevdeki temizleme metodu kullanarak buradaki form içinde kullanınız.
            MessageBox.Show("Menü Başarılı Şekilde Eklendi.");
            Fonksiyon.Temizleme(Controls);

        }
    }
}
