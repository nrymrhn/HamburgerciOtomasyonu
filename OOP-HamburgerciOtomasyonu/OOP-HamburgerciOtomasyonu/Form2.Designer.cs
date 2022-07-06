
namespace OOP_HamburgerciOtomasyonu
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.grpBoyutlar = new System.Windows.Forms.GroupBox();
            this.rbBuyukBoy = new System.Windows.Forms.RadioButton();
            this.rbOrtaBoy = new System.Windows.Forms.RadioButton();
            this.rbKucukBoy = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.flpMalzemeSec = new System.Windows.Forms.FlowLayoutPanel();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.lblSiparisler = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoyutlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_HamburgerciOtomasyonu.Properties.Resources.ejfg_hero;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menü Seç:";
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(12, 266);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(271, 28);
            this.cmbMenuler.TabIndex = 2;
            // 
            // grpBoyutlar
            // 
            this.grpBoyutlar.Controls.Add(this.rbBuyukBoy);
            this.grpBoyutlar.Controls.Add(this.rbOrtaBoy);
            this.grpBoyutlar.Controls.Add(this.rbKucukBoy);
            this.grpBoyutlar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBoyutlar.ForeColor = System.Drawing.Color.Firebrick;
            this.grpBoyutlar.Location = new System.Drawing.Point(12, 305);
            this.grpBoyutlar.Name = "grpBoyutlar";
            this.grpBoyutlar.Size = new System.Drawing.Size(300, 87);
            this.grpBoyutlar.TabIndex = 3;
            this.grpBoyutlar.TabStop = false;
            this.grpBoyutlar.Text = "Boyut Seçiniz:";
            // 
            // rbBuyukBoy
            // 
            this.rbBuyukBoy.AutoSize = true;
            this.rbBuyukBoy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbBuyukBoy.ForeColor = System.Drawing.Color.Black;
            this.rbBuyukBoy.Location = new System.Drawing.Point(195, 42);
            this.rbBuyukBoy.Name = "rbBuyukBoy";
            this.rbBuyukBoy.Size = new System.Drawing.Size(98, 24);
            this.rbBuyukBoy.TabIndex = 2;
            this.rbBuyukBoy.TabStop = true;
            this.rbBuyukBoy.Text = "Büyük Boy";
            this.rbBuyukBoy.UseVisualStyleBackColor = true;
            // 
            // rbOrtaBoy
            // 
            this.rbOrtaBoy.AutoSize = true;
            this.rbOrtaBoy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbOrtaBoy.ForeColor = System.Drawing.Color.Black;
            this.rbOrtaBoy.Location = new System.Drawing.Point(105, 42);
            this.rbOrtaBoy.Name = "rbOrtaBoy";
            this.rbOrtaBoy.Size = new System.Drawing.Size(88, 24);
            this.rbOrtaBoy.TabIndex = 1;
            this.rbOrtaBoy.TabStop = true;
            this.rbOrtaBoy.Text = "Orta Boy";
            this.rbOrtaBoy.UseVisualStyleBackColor = true;
            // 
            // rbKucukBoy
            // 
            this.rbKucukBoy.AutoSize = true;
            this.rbKucukBoy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbKucukBoy.ForeColor = System.Drawing.Color.Black;
            this.rbKucukBoy.Location = new System.Drawing.Point(5, 42);
            this.rbKucukBoy.Name = "rbKucukBoy";
            this.rbKucukBoy.Size = new System.Drawing.Size(98, 24);
            this.rbKucukBoy.TabIndex = 0;
            this.rbKucukBoy.TabStop = true;
            this.rbKucukBoy.Text = "Küçük Boy";
            this.rbKucukBoy.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(12, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extra Malzeme Seçiniz:";
            // 
            // flpMalzemeSec
            // 
            this.flpMalzemeSec.Location = new System.Drawing.Point(12, 422);
            this.flpMalzemeSec.Name = "flpMalzemeSec";
            this.flpMalzemeSec.Size = new System.Drawing.Size(271, 125);
            this.flpMalzemeSec.TabIndex = 5;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(85, 558);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(197, 27);
            this.nmrAdet.TabIndex = 6;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(12, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adet:";
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSiparisEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiparisEkle.Location = new System.Drawing.Point(85, 597);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(197, 62);
            this.btnSiparisEkle.TabIndex = 8;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click_1);
            // 
            // lblSiparisler
            // 
            this.lblSiparisler.FormattingEnabled = true;
            this.lblSiparisler.ItemHeight = 20;
            this.lblSiparisler.Location = new System.Drawing.Point(336, 12);
            this.lblSiparisler.Name = "lblSiparisler";
            this.lblSiparisler.Size = new System.Drawing.Size(394, 544);
            this.lblSiparisler.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(321, 616);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Toplam Tutar:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTutar.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTutar.Location = new System.Drawing.Point(443, 617);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(20, 23);
            this.lblTutar.TabIndex = 11;
            this.lblTutar.Text = "0";
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSiparisTamamla.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiparisTamamla.Location = new System.Drawing.Point(532, 597);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(197, 61);
            this.btnSiparisTamamla.TabIndex = 12;
            this.btnSiparisTamamla.Text = "Siparişi Tamamla";
            this.btnSiparisTamamla.UseVisualStyleBackColor = false;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(775, 686);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSiparisler);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.flpMalzemeSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpBoyutlar);
            this.Controls.Add(this.cmbMenuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoyutlar.ResumeLayout(false);
            this.grpBoyutlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMenuler;
        private System.Windows.Forms.GroupBox grpBoyutlar;
        private System.Windows.Forms.RadioButton rbBuyukBoy;
        private System.Windows.Forms.RadioButton rbOrtaBoy;
        private System.Windows.Forms.RadioButton rbKucukBoy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpMalzemeSec;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.ListBox lblSiparisler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnSiparisTamamla;
    }
}