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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();

        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu{MenuAdi="Big King",            Fiyati=30.25m},
            new Menu{MenuAdi="Cheeseburger",        Fiyati=28.75m} ,
            new Menu{MenuAdi="Double King Chicken", Fiyati=50.80m},
            new Menu{MenuAdi="King Chicken",        Fiyati=40.80m},
            new Menu{MenuAdi="Whooper",             Fiyati=32.00m},
            new Menu{MenuAdi="Whooper Jr",          Fiyati=22.50m},
            new Menu{MenuAdi="SteakHouse",          Fiyati=68.5m},

        };
        public static List<Ekstra> ekstralar = new List<Ekstra>()
        {
            new Ekstra{EkstraMalzAd="Ketçap",        Fiyat=0.75m},
            new Ekstra{EkstraMalzAd="Ranch Sos",     Fiyat=0.50m},
            new Ekstra{EkstraMalzAd="Hardal",        Fiyat=0.50m},
            new Ekstra{EkstraMalzAd="Soğan Halkası", Fiyat=0.75m},
            new Ekstra{EkstraMalzAd="Acı Sos",       Fiyat=0.75m},
            new Ekstra{EkstraMalzAd="Mayonez",       Fiyat=0.50m},
            new Ekstra{EkstraMalzAd="Çıtır Tavuk",   Fiyat=5.50m},
        };

       
        public decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lblSiparisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lblSiparisler.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

            foreach (Menu item in Menuler)
            {
                cmbMenuler.Items.Add(item);
            }
            foreach (Ekstra item in ekstralar)
            {
                flpMalzemeSec.Controls.Add(new CheckBox() { Text = item.EkstraMalzAd, Tag = item }); //Tag propertysi object tutar.
            }
            foreach (Siparis item in mevcutSiparisler)
            {
                lblSiparisler.Items.Add(item);
            }

            rbKucukBoy.Checked = true;
            cmbMenuler.SelectedIndex = 0;
        }

        private void btnSiparisEkle_Click_1(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (Menu)cmbMenuler.SelectedItem;
            if (rbKucukBoy.Checked)
                yeniSiparis.Boyut = Boyut.Kucuk;
            else if (rbOrtaBoy.Checked)
                yeniSiparis.Boyut = Boyut.Orta;
            else
                yeniSiparis.Boyut = Boyut.Buyuk;

            yeniSiparis.EkstraMalzeme = new List<Ekstra>();
            foreach (CheckBox item in flpMalzemeSec.Controls)
            {
                if (item.Checked)
                    yeniSiparis.EkstraMalzeme.Add((Ekstra)item.Tag); //flowloyoutpaneldeki kontrollerden seçilenlerin her birinin tag propertysininde tutulan ekstra malz kopyasını verir.
            }
            yeniSiparis.Adet = Convert.ToInt32(nmrAdet.Value);
            yeniSiparis.Hesapla(); //Sipariş classındaki hesapla metodu oluşan yeni siparişin topla fiyatını hesaplar.
            tumSiparisler.Add(yeniSiparis);
            mevcutSiparisler.Add(yeniSiparis);
            lblSiparisler.Items.Add(yeniSiparis);
            TutarHesapla();
          
          
        }

        private void btnSiparisTamamla_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Ücreti: " + TutarHesapla().ToString("C2") + "\nSiparişi tamamlamak ister misiniz", "Sipariş Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                lblSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Siparişiniz Tamamlandı", "BİLGİ");
            }
            else
            {
                MessageBox.Show("İptal Edildi", "BİLGİ");
            }
            //ODEV:Fonksiyonlar isimli bir class oluşturun ve temizleme adında bir metot oluşturup bu metodu burada kontrolleri temizlemek için kullanılacak.
            Fonksiyon.Temizleme(Controls);

        }
    }
}
