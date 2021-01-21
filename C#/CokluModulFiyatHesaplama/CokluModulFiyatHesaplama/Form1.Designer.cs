namespace CokluModulFiyatHesaplama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.rb_siber = new System.Windows.Forms.RadioButton();
            this.rb_ag = new System.Windows.Forms.RadioButton();
            this.gb_moduller = new System.Windows.Forms.GroupBox();
            this.lb_gosterge = new System.Windows.Forms.Label();
            this.lb_toplam_fiyat = new System.Windows.Forms.Label();
            this.lb_araToplamYazisi = new System.Windows.Forms.Label();
            this.nud_kisi = new System.Windows.Forms.NumericUpDown();
            this.lb_araToplam = new System.Windows.Forms.Label();
            this.lb_kisi = new System.Windows.Forms.Label();
            this.lb_kisiIndirimi = new System.Windows.Forms.Label();
            this.nud_kisiIndirimi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_toplamIndirimMiktari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kisiIndirimi)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_siber
            // 
            this.rb_siber.AutoSize = true;
            this.rb_siber.Location = new System.Drawing.Point(12, 25);
            this.rb_siber.Name = "rb_siber";
            this.rb_siber.Size = new System.Drawing.Size(142, 17);
            this.rb_siber.TabIndex = 0;
            this.rb_siber.TabStop = true;
            this.rb_siber.Text = "Siber Güvenlik Uzmanlığı";
            this.rb_siber.UseVisualStyleBackColor = true;
            this.rb_siber.CheckedChanged += new System.EventHandler(this.rb_siber_CheckedChanged);
            // 
            // rb_ag
            // 
            this.rb_ag.AutoSize = true;
            this.rb_ag.Location = new System.Drawing.Point(175, 25);
            this.rb_ag.Name = "rb_ag";
            this.rb_ag.Size = new System.Drawing.Size(159, 17);
            this.rb_ag.TabIndex = 1;
            this.rb_ag.TabStop = true;
            this.rb_ag.Text = "Ağ ve Bulut Bilişim Uzmanlığı";
            this.rb_ag.UseVisualStyleBackColor = true;
            this.rb_ag.CheckedChanged += new System.EventHandler(this.rb_ag_CheckedChanged);
            // 
            // gb_moduller
            // 
            this.gb_moduller.Location = new System.Drawing.Point(12, 67);
            this.gb_moduller.Name = "gb_moduller";
            this.gb_moduller.Size = new System.Drawing.Size(548, 423);
            this.gb_moduller.TabIndex = 2;
            this.gb_moduller.TabStop = false;
            this.gb_moduller.Text = "Modüller";
            // 
            // lb_gosterge
            // 
            this.lb_gosterge.AutoSize = true;
            this.lb_gosterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_gosterge.Location = new System.Drawing.Point(379, 515);
            this.lb_gosterge.Name = "lb_gosterge";
            this.lb_gosterge.Size = new System.Drawing.Size(181, 26);
            this.lb_gosterge.TabIndex = 3;
            this.lb_gosterge.Text = "TOPLAM FİYAT";
            // 
            // lb_toplam_fiyat
            // 
            this.lb_toplam_fiyat.AutoSize = true;
            this.lb_toplam_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_toplam_fiyat.Location = new System.Drawing.Point(444, 543);
            this.lb_toplam_fiyat.Name = "lb_toplam_fiyat";
            this.lb_toplam_fiyat.Size = new System.Drawing.Size(45, 24);
            this.lb_toplam_fiyat.TabIndex = 4;
            this.lb_toplam_fiyat.Text = "0,00";
            // 
            // lb_araToplamYazisi
            // 
            this.lb_araToplamYazisi.AutoSize = true;
            this.lb_araToplamYazisi.Location = new System.Drawing.Point(12, 515);
            this.lb_araToplamYazisi.Name = "lb_araToplamYazisi";
            this.lb_araToplamYazisi.Size = new System.Drawing.Size(62, 13);
            this.lb_araToplamYazisi.TabIndex = 5;
            this.lb_araToplamYazisi.Text = "Eğitim Fiyatı";
            // 
            // nud_kisi
            // 
            this.nud_kisi.Location = new System.Drawing.Point(99, 541);
            this.nud_kisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_kisi.Name = "nud_kisi";
            this.nud_kisi.Size = new System.Drawing.Size(72, 20);
            this.nud_kisi.TabIndex = 6;
            this.nud_kisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_kisi.ValueChanged += new System.EventHandler(this.nud_kisi_ValueChanged);
            // 
            // lb_araToplam
            // 
            this.lb_araToplam.AutoSize = true;
            this.lb_araToplam.Location = new System.Drawing.Point(21, 543);
            this.lb_araToplam.Name = "lb_araToplam";
            this.lb_araToplam.Size = new System.Drawing.Size(28, 13);
            this.lb_araToplam.TabIndex = 7;
            this.lb_araToplam.Text = "0,00";
            // 
            // lb_kisi
            // 
            this.lb_kisi.AutoSize = true;
            this.lb_kisi.Location = new System.Drawing.Point(96, 515);
            this.lb_kisi.Name = "lb_kisi";
            this.lb_kisi.Size = new System.Drawing.Size(100, 13);
            this.lb_kisi.TabIndex = 8;
            this.lb_kisi.Text = "Katılacak Kişi Sayısı";
            // 
            // lb_kisiIndirimi
            // 
            this.lb_kisiIndirimi.AutoSize = true;
            this.lb_kisiIndirimi.Location = new System.Drawing.Point(208, 515);
            this.lb_kisiIndirimi.Name = "lb_kisiIndirimi";
            this.lb_kisiIndirimi.Size = new System.Drawing.Size(114, 13);
            this.lb_kisiIndirimi.TabIndex = 9;
            this.lb_kisiIndirimi.Text = "Yüzdelik İndirim Miktarı";
            // 
            // nud_kisiIndirimi
            // 
            this.nud_kisiIndirimi.Location = new System.Drawing.Point(211, 541);
            this.nud_kisiIndirimi.Name = "nud_kisiIndirimi";
            this.nud_kisiIndirimi.Size = new System.Drawing.Size(72, 20);
            this.nud_kisiIndirimi.TabIndex = 10;
            this.nud_kisiIndirimi.ValueChanged += new System.EventHandler(this.nud_kisiIndirimi_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Toplu Katılımdan Kazanılan İndirim Miktarı: ";
            // 
            // lb_toplamIndirimMiktari
            // 
            this.lb_toplamIndirimMiktari.AutoSize = true;
            this.lb_toplamIndirimMiktari.Location = new System.Drawing.Point(222, 575);
            this.lb_toplamIndirimMiktari.Name = "lb_toplamIndirimMiktari";
            this.lb_toplamIndirimMiktari.Size = new System.Drawing.Size(28, 13);
            this.lb_toplamIndirimMiktari.TabIndex = 12;
            this.lb_toplamIndirimMiktari.Text = "0,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 612);
            this.Controls.Add(this.lb_toplamIndirimMiktari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_kisiIndirimi);
            this.Controls.Add(this.lb_kisiIndirimi);
            this.Controls.Add(this.lb_kisi);
            this.Controls.Add(this.lb_araToplam);
            this.Controls.Add(this.nud_kisi);
            this.Controls.Add(this.lb_araToplamYazisi);
            this.Controls.Add(this.lb_toplam_fiyat);
            this.Controls.Add(this.lb_gosterge);
            this.Controls.Add(this.gb_moduller);
            this.Controls.Add(this.rb_ag);
            this.Controls.Add(this.rb_siber);
            this.MaximumSize = new System.Drawing.Size(596, 651);
            this.MinimumSize = new System.Drawing.Size(596, 651);
            this.Name = "Form1";
            this.Text = "Bilişim Academy - Fiyat Hesaplama Otomasyonu";
            ((System.ComponentModel.ISupportInitialize)(this.nud_kisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kisiIndirimi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_siber;
        private System.Windows.Forms.RadioButton rb_ag;
        private System.Windows.Forms.GroupBox gb_moduller;
        private System.Windows.Forms.Label lb_gosterge;
        private System.Windows.Forms.Label lb_toplam_fiyat;
        private System.Windows.Forms.Label lb_araToplamYazisi;
        private System.Windows.Forms.NumericUpDown nud_kisi;
        private System.Windows.Forms.Label lb_araToplam;
        private System.Windows.Forms.Label lb_kisi;
        private System.Windows.Forms.Label lb_kisiIndirimi;
        private System.Windows.Forms.NumericUpDown nud_kisiIndirimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_toplamIndirimMiktari;
    }
}

