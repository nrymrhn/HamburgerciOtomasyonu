using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerciOtomasyonu
{
    public class Siparis
    {
        public Menu SeciliMenu { get; set; }
        public Boyut Boyut { get; set; }
        public List<Ekstra> EkstraMalzeme { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        //Eğer küçük boy seçerse normal fiyat,orta boy seçerse ise menü fiyatından yüzde 10 fazlası ,büyük ise yüzde 25 fazlası olcak.

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;
            switch (Boyut)
            {
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10m;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.25m;
                    break;
            }
            foreach (Ekstra ekstra in EkstraMalzeme) //ketcap=0,25 mayonez=0,50 hardal=1,25...
            {
                ToplamTutar += ekstra.Fiyat;
            }
            ToplamTutar = ToplamTutar * Adet;
        }
        public override string ToString()
        {

            if (EkstraMalzeme.Count < 1) //Ekstra malzeme yoksa.
            {
                return string.Format("{0} Menü x {1} Adet {2} Boy Toplam {3}", SeciliMenu.MenuAdi, Adet, Boyut, ToplamTutar.ToString("C2")); //C2 dediğimiz parasal değer formatıdır.
            }
            else
            {
                string ekstraMalzeme = null;
                foreach (Ekstra ekxtra in EkstraMalzeme)
                {
                    ekstraMalzeme += ekxtra.EkstraMalzAd + ",";
                }
                ekstraMalzeme = ekstraMalzeme.Trim(','); //en son eklenen virgülü temizler.
                return string.Format("{0} Menü x {1} Adet {2} Boy {3} Toplam {4}", SeciliMenu.MenuAdi, Adet, Boyut, ekstraMalzeme, ToplamTutar.ToString("C2"));
            }
        }

    }
}
