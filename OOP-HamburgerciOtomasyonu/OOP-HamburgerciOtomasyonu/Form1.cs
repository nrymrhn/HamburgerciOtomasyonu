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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Formların üst üste açılmaması ve textinin başlığa yazılmasını yap.
        void ChildForm(Form childForm)
        {

            //panel1.Controls.Clear();
            this.Width = childForm.Width + 20;
            this.Height = childForm.Height + 65;
            //childForm.MdiParent = this;
            //panel1.Width = childForm.Width;
            //panel1.Height = childForm.Height;
            //panel1.Controls.Add(childForm);
            //childForm.Show();

            //2.YOL:
            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == childForm.Text)
                {
                    durum = true;
                    childForm.Dock = DockStyle.Fill; //startposition kısmında manuel ayarladığımızda form ekranını tam dolduruyor.
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }
            if (durum == false)
            {
                childForm.MdiParent = this;
                childForm.Dock = DockStyle.Fill;
                childForm.Show();
            }
        }
     
        private void tsmSiparisOlustur_Click_1(object sender, EventArgs e)
        {
            ChildForm(new Form2());
            this.Text = "Sipariş Oluştur";
        }

        private void tsmSiparisBilgileri_Click_1(object sender, EventArgs e)
        {
            ChildForm(new Form3());
            this.Text = "Sipariş Bilgileri";
        }

        private void tsmMenuEkle_Click_1(object sender, EventArgs e)
        {
            ChildForm(new Form4());
            this.Text = "Menüye Ekle";
        }

        private void tsmExMalzEkle_Click_1(object sender, EventArgs e)
        {
            ChildForm(new Form5());
            this.Text = "Ekstra Malzeme";
        }
    }
}
