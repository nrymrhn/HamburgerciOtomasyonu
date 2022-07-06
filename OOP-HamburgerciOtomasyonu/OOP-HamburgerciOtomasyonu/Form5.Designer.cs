
namespace OOP_HamburgerciOtomasyonu
{
    partial class Form5
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
            this.grpMalzemeBilgileri = new System.Windows.Forms.GroupBox();
            this.btnExtraEkle = new System.Windows.Forms.Button();
            this.nmrEkstraFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraMalz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMalzemeBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMalzemeBilgileri
            // 
            this.grpMalzemeBilgileri.BackColor = System.Drawing.Color.PeachPuff;
            this.grpMalzemeBilgileri.Controls.Add(this.btnExtraEkle);
            this.grpMalzemeBilgileri.Controls.Add(this.nmrEkstraFiyat);
            this.grpMalzemeBilgileri.Controls.Add(this.txtEkstraMalz);
            this.grpMalzemeBilgileri.Controls.Add(this.label2);
            this.grpMalzemeBilgileri.Controls.Add(this.label1);
            this.grpMalzemeBilgileri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpMalzemeBilgileri.ForeColor = System.Drawing.Color.Firebrick;
            this.grpMalzemeBilgileri.Location = new System.Drawing.Point(12, 26);
            this.grpMalzemeBilgileri.Name = "grpMalzemeBilgileri";
            this.grpMalzemeBilgileri.Size = new System.Drawing.Size(394, 223);
            this.grpMalzemeBilgileri.TabIndex = 0;
            this.grpMalzemeBilgileri.TabStop = false;
            this.grpMalzemeBilgileri.Text = "MALZEME EKLE:";
            // 
            // btnExtraEkle
            // 
            this.btnExtraEkle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExtraEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExtraEkle.ForeColor = System.Drawing.Color.Black;
            this.btnExtraEkle.Location = new System.Drawing.Point(160, 147);
            this.btnExtraEkle.Name = "btnExtraEkle";
            this.btnExtraEkle.Size = new System.Drawing.Size(148, 55);
            this.btnExtraEkle.TabIndex = 4;
            this.btnExtraEkle.Text = "Extra Malzeme Kaydet";
            this.btnExtraEkle.UseVisualStyleBackColor = false;
            this.btnExtraEkle.Click += new System.EventHandler(this.btnExtraEkle_Click_1);
            // 
            // nmrEkstraFiyat
            // 
            this.nmrEkstraFiyat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmrEkstraFiyat.Location = new System.Drawing.Point(160, 101);
            this.nmrEkstraFiyat.Name = "nmrEkstraFiyat";
            this.nmrEkstraFiyat.Size = new System.Drawing.Size(148, 30);
            this.nmrEkstraFiyat.TabIndex = 3;
            // 
            // txtEkstraMalz
            // 
            this.txtEkstraMalz.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEkstraMalz.Location = new System.Drawing.Point(160, 49);
            this.txtEkstraMalz.Name = "txtEkstraMalz";
            this.txtEkstraMalz.Size = new System.Drawing.Size(148, 30);
            this.txtEkstraMalz.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(92, 101);
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
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ex.Malzeme Ekle:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 270);
            this.Controls.Add(this.grpMalzemeBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.grpMalzemeBilgileri.ResumeLayout(false);
            this.grpMalzemeBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMalzemeBilgileri;
        private System.Windows.Forms.NumericUpDown nmrEkstraFiyat;
        private System.Windows.Forms.TextBox txtEkstraMalz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExtraEkle;
    }
}