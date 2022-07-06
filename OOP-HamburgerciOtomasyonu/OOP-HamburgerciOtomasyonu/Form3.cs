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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdedi = 0;
            foreach (Siparis siparis in Form2.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;
                foreach (Ekstra extraMalz in siparis.EkstraMalzeme)
                {
                    ekstraMalzemeGeliri += extraMalz.Fiyat;
                }
                satisAdedi += siparis.Adet;
                lbxTumSiparisler.Items.Add(siparis);
                lblToplamSiparisSayisi.Text = lbxTumSiparisler.Items.Count.ToString();
                lblCiro.Text = ciro.ToString("C2");
                lblExMalzGeliri.Text = ekstraMalzemeGeliri.ToString("C2");
                lblSatilanUrunAdedi.Text = satisAdedi.ToString();

            }
        }
    }
}
