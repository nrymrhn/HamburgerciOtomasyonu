
namespace OOP_HamburgerciOtomasyonu
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMenuBilgileri = new System.Windows.Forms.GroupBox();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.nmrMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMenuBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuBilgileri
            // 
            this.grpMenuBilgileri.BackColor = System.Drawing.Color.PeachPuff;
            this.grpMenuBilgileri.Controls.Add(this.btnMenuEkle);
            this.grpMenuBilgileri.Controls.Add(this.txtMenuAdi);
            this.grpMenuBilgileri.Controls.Add(this.nmrMenuFiyati);
            this.grpMenuBilgileri.Controls.Add(this.label2);
            this.grpMenuBilgileri.Controls.Add(this.label1);
            this.grpMenuBilgileri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpMenuBilgileri.ForeColor = System.Drawing.Color.Firebrick;
            this.grpMenuBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpMenuBilgileri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenuBilgileri.Name = "grpMenuBilgileri";
            this.grpMenuBilgileri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenuBilgileri.Size = new System.Drawing.Size(356, 214);
            this.grpMenuBilgileri.TabIndex = 0;
            this.grpMenuBilgileri.TabStop = false;
            this.grpMenuBilgileri.Text = "MENÜ BİLGİLERİ:";
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMenuEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuEkle.ForeColor = System.Drawing.Color.Black;
            this.btnMenuEkle.Location = new System.Drawing.Point(128, 141);
            this.btnMenuEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(149, 52);
            this.btnMenuEkle.TabIndex = 4;
            this.btnMenuEkle.Text = "Menü Kaydet";
            this.btnMenuEkle.UseVisualStyleBackColor = false;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click_1);
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMenuAdi.Location = new System.Drawing.Point(129, 52);
            this.txtMenuAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(149, 30);
            this.txtMenuAdi.TabIndex = 3;
            // 
            // nmrMenuFiyati
            // 
            this.nmrMenuFiyati.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmrMenuFiyati.Location = new System.Drawing.Point(128, 98);
            this.nmrMenuFiyati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrMenuFiyati.Name = "nmrMenuFiyati";
            this.nmrMenuFiyati.Size = new System.Drawing.Size(150, 30);
            this.nmrMenuFiyati.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 238);
            this.Controls.Add(this.grpMenuBilgileri);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.grpMenuBilgileri.ResumeLayout(false);
            this.grpMenuBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenuBilgileri;
        private System.Windows.Forms.TextBox txtMenuAdi;
        private System.Windows.Forms.NumericUpDown nmrMenuFiyati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuEkle;
    }
}