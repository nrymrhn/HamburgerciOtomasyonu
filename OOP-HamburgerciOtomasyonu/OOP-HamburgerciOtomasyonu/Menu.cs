using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerciOtomasyonu
{
    public class Menu
    {
        public string MenuAdi { get; set; }
        public decimal Fiyati { get; set; }
        public override string ToString() //menü adı+ menü şeklinde yazsın diye bu metodu oluşturduk.
        {
            return MenuAdi + " Menü";
        }
    }
}
