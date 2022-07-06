﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HamburgerciOtomasyonu
{
    public static class Fonksiyon
    {

        public static void Temizleme(Control.ControlCollection kontroller)
        {
            foreach (Control kontrol in kontroller)
            {
                if (kontrol is ComboBox)
                    ((ComboBox)kontrol).SelectedIndex = -1;
                else if (kontrol is RadioButton)
                {
                    if (((RadioButton)kontrol).Name == "rbKucukBoy")
                        ((RadioButton)kontrol).Checked = true;
                    else ((RadioButton)kontrol).Checked = false;
                }
                else if (kontrol is CheckBox)
                    ((CheckBox)kontrol).Checked = false;
                else if (kontrol is NumericUpDown)
                    ((NumericUpDown)kontrol).Value = ((NumericUpDown)kontrol).Minimum;
                else if(kontrol is TextBox)
                    ((TextBox)kontrol).Text = "";
                else if (kontrol is GroupBox)
                    Temizleme(((GroupBox)kontrol).Controls);
                else if (kontrol is FlowLayoutPanel)
                    Temizleme(((FlowLayoutPanel)kontrol).Controls);

            }
        }
    }
}
