namespace OzgulTekel
{
	partial class AnaForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_cikisYap = new System.Windows.Forms.Button();
			this.btn_rapor = new System.Windows.Forms.Button();
			this.btn_stok = new System.Windows.Forms.Button();
			this.gb_bekleyen = new System.Windows.Forms.GroupBox();
			this.btn_bekleyen3 = new System.Windows.Forms.Button();
			this.btn_bekleyen2 = new System.Windows.Forms.Button();
			this.btn_bekleyen1 = new System.Windows.Forms.Button();
			this.btn_yetkili = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lb_urunAdi = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tb_fiyat = new System.Windows.Forms.TextBox();
			this.tb_urunAdi = new System.Windows.Forms.TextBox();
			this.tb_barkod = new System.Windows.Forms.TextBox();
			this.lb_barkod = new System.Windows.Forms.Label();
			this.lb_fiyat = new System.Windows.Forms.Label();
			this.lb_saat = new System.Windows.Forms.Label();
			this.btn_nakit = new System.Windows.Forms.Button();
			this.btn_pos = new System.Windows.Forms.Button();
			this.btn_veresiye = new System.Windows.Forms.Button();
			this.btn_iptal = new System.Windows.Forms.Button();
			this.btn_nakitPos = new System.Windows.Forms.Button();
			this.lb_toplam = new System.Windows.Forms.Label();
			this.lb_tutar = new System.Windows.Forms.Label();
			this.lb_tl = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lb_tarih = new System.Windows.Forms.Label();
			this.gb_tarihSaat = new System.Windows.Forms.GroupBox();
			this.btn_sonUrunIptal = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.gb_bekleyen.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gb_tarihSaat.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(220, 91);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(860, 352);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// btn_cikisYap
			// 
			this.btn_cikisYap.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_cikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_cikisYap.Location = new System.Drawing.Point(849, 12);
			this.btn_cikisYap.Name = "btn_cikisYap";
			this.btn_cikisYap.Size = new System.Drawing.Size(188, 73);
			this.btn_cikisYap.TabIndex = 1;
			this.btn_cikisYap.Text = "Çıkış Yap";
			this.btn_cikisYap.UseVisualStyleBackColor = false;
			this.btn_cikisYap.Click += new System.EventHandler(this.btn_cikisYap_Click);
			// 
			// btn_rapor
			// 
			this.btn_rapor.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_rapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_rapor.Location = new System.Drawing.Point(655, 12);
			this.btn_rapor.Name = "btn_rapor";
			this.btn_rapor.Size = new System.Drawing.Size(188, 73);
			this.btn_rapor.TabIndex = 3;
			this.btn_rapor.Text = "Rapor";
			this.btn_rapor.UseVisualStyleBackColor = false;
			this.btn_rapor.Click += new System.EventHandler(this.btn_rapor_Click);
			// 
			// btn_stok
			// 
			this.btn_stok.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_stok.Location = new System.Drawing.Point(460, 12);
			this.btn_stok.Name = "btn_stok";
			this.btn_stok.Size = new System.Drawing.Size(189, 73);
			this.btn_stok.TabIndex = 4;
			this.btn_stok.Text = "Stok";
			this.btn_stok.UseVisualStyleBackColor = false;
			this.btn_stok.Click += new System.EventHandler(this.btn_stok_Click);
			// 
			// gb_bekleyen
			// 
			this.gb_bekleyen.Controls.Add(this.btn_bekleyen3);
			this.gb_bekleyen.Controls.Add(this.btn_bekleyen2);
			this.gb_bekleyen.Controls.Add(this.btn_bekleyen1);
			this.gb_bekleyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gb_bekleyen.ForeColor = System.Drawing.Color.DarkOrange;
			this.gb_bekleyen.Location = new System.Drawing.Point(1086, 92);
			this.gb_bekleyen.Name = "gb_bekleyen";
			this.gb_bekleyen.Size = new System.Drawing.Size(190, 237);
			this.gb_bekleyen.TabIndex = 7;
			this.gb_bekleyen.TabStop = false;
			this.gb_bekleyen.Text = "Bekleyen Ödemeler";
			// 
			// btn_bekleyen3
			// 
			this.btn_bekleyen3.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_bekleyen3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_bekleyen3.ForeColor = System.Drawing.Color.Black;
			this.btn_bekleyen3.Location = new System.Drawing.Point(6, 167);
			this.btn_bekleyen3.Name = "btn_bekleyen3";
			this.btn_bekleyen3.Size = new System.Drawing.Size(178, 60);
			this.btn_bekleyen3.TabIndex = 10;
			this.btn_bekleyen3.Text = "3";
			this.btn_bekleyen3.UseVisualStyleBackColor = false;
			this.btn_bekleyen3.Click += new System.EventHandler(this.btn_bekleyen3_Click);
			// 
			// btn_bekleyen2
			// 
			this.btn_bekleyen2.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_bekleyen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_bekleyen2.ForeColor = System.Drawing.Color.Black;
			this.btn_bekleyen2.Location = new System.Drawing.Point(6, 101);
			this.btn_bekleyen2.Name = "btn_bekleyen2";
			this.btn_bekleyen2.Size = new System.Drawing.Size(178, 60);
			this.btn_bekleyen2.TabIndex = 9;
			this.btn_bekleyen2.Text = "2";
			this.btn_bekleyen2.UseVisualStyleBackColor = false;
			this.btn_bekleyen2.Click += new System.EventHandler(this.btn_bekleyen2_Click);
			// 
			// btn_bekleyen1
			// 
			this.btn_bekleyen1.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_bekleyen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_bekleyen1.ForeColor = System.Drawing.Color.Black;
			this.btn_bekleyen1.Location = new System.Drawing.Point(6, 35);
			this.btn_bekleyen1.Name = "btn_bekleyen1";
			this.btn_bekleyen1.Size = new System.Drawing.Size(178, 60);
			this.btn_bekleyen1.TabIndex = 8;
			this.btn_bekleyen1.Text = "1";
			this.btn_bekleyen1.UseVisualStyleBackColor = false;
			this.btn_bekleyen1.Click += new System.EventHandler(this.btn_bekleyen1_Click);
			// 
			// btn_yetkili
			// 
			this.btn_yetkili.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_yetkili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_yetkili.Location = new System.Drawing.Point(265, 12);
			this.btn_yetkili.Name = "btn_yetkili";
			this.btn_yetkili.Size = new System.Drawing.Size(189, 73);
			this.btn_yetkili.TabIndex = 8;
			this.btn_yetkili.Text = "Yetkili";
			this.btn_yetkili.UseVisualStyleBackColor = false;
			this.btn_yetkili.Click += new System.EventHandler(this.btn_yetkili_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkOrange;
			this.label1.Location = new System.Drawing.Point(61, 428);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 54);
			this.label1.TabIndex = 9;
			this.label1.Text = "ÖZGÜL\r\nTEKEL";
			// 
			// lb_urunAdi
			// 
			this.lb_urunAdi.AutoSize = true;
			this.lb_urunAdi.Location = new System.Drawing.Point(6, 82);
			this.lb_urunAdi.Name = "lb_urunAdi";
			this.lb_urunAdi.Size = new System.Drawing.Size(60, 13);
			this.lb_urunAdi.TabIndex = 10;
			this.lb_urunAdi.Text = "Ürün Adı:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tb_fiyat);
			this.groupBox1.Controls.Add(this.tb_urunAdi);
			this.groupBox1.Controls.Add(this.tb_barkod);
			this.groupBox1.Controls.Add(this.lb_barkod);
			this.groupBox1.Controls.Add(this.lb_fiyat);
			this.groupBox1.Controls.Add(this.lb_urunAdi);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
			this.groupBox1.Location = new System.Drawing.Point(27, 91);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(187, 186);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ürün Bilgileri";
			// 
			// tb_fiyat
			// 
			this.tb_fiyat.Enabled = false;
			this.tb_fiyat.Location = new System.Drawing.Point(6, 153);
			this.tb_fiyat.Name = "tb_fiyat";
			this.tb_fiyat.Size = new System.Drawing.Size(175, 20);
			this.tb_fiyat.TabIndex = 15;
			// 
			// tb_urunAdi
			// 
			this.tb_urunAdi.Enabled = false;
			this.tb_urunAdi.Location = new System.Drawing.Point(5, 101);
			this.tb_urunAdi.Name = "tb_urunAdi";
			this.tb_urunAdi.Size = new System.Drawing.Size(176, 20);
			this.tb_urunAdi.TabIndex = 14;
			// 
			// tb_barkod
			// 
			this.tb_barkod.Location = new System.Drawing.Point(5, 50);
			this.tb_barkod.Name = "tb_barkod";
			this.tb_barkod.Size = new System.Drawing.Size(176, 20);
			this.tb_barkod.TabIndex = 13;
			this.tb_barkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_barkod_KeyDown);
			// 
			// lb_barkod
			// 
			this.lb_barkod.AutoSize = true;
			this.lb_barkod.Location = new System.Drawing.Point(6, 34);
			this.lb_barkod.Name = "lb_barkod";
			this.lb_barkod.Size = new System.Drawing.Size(51, 13);
			this.lb_barkod.TabIndex = 12;
			this.lb_barkod.Text = "Barkod:";
			// 
			// lb_fiyat
			// 
			this.lb_fiyat.AutoSize = true;
			this.lb_fiyat.Location = new System.Drawing.Point(6, 137);
			this.lb_fiyat.Name = "lb_fiyat";
			this.lb_fiyat.Size = new System.Drawing.Size(41, 13);
			this.lb_fiyat.TabIndex = 11;
			this.lb_fiyat.Text = "Fiyatı:";
			// 
			// lb_saat
			// 
			this.lb_saat.AutoSize = true;
			this.lb_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_saat.Location = new System.Drawing.Point(36, 59);
			this.lb_saat.Name = "lb_saat";
			this.lb_saat.Size = new System.Drawing.Size(33, 13);
			this.lb_saat.TabIndex = 12;
			this.lb_saat.Text = "Saat";
			// 
			// btn_nakit
			// 
			this.btn_nakit.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_nakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_nakit.Location = new System.Drawing.Point(279, 590);
			this.btn_nakit.Name = "btn_nakit";
			this.btn_nakit.Size = new System.Drawing.Size(144, 70);
			this.btn_nakit.TabIndex = 14;
			this.btn_nakit.Text = "Nakit (F7)";
			this.btn_nakit.UseVisualStyleBackColor = false;
			this.btn_nakit.Click += new System.EventHandler(this.btn_nakit_Click);
			// 
			// btn_pos
			// 
			this.btn_pos.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_pos.Location = new System.Drawing.Point(429, 590);
			this.btn_pos.Name = "btn_pos";
			this.btn_pos.Size = new System.Drawing.Size(144, 70);
			this.btn_pos.TabIndex = 15;
			this.btn_pos.Text = "Pos (F8)";
			this.btn_pos.UseVisualStyleBackColor = false;
			this.btn_pos.Click += new System.EventHandler(this.btn_pos_Click);
			// 
			// btn_veresiye
			// 
			this.btn_veresiye.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_veresiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_veresiye.Location = new System.Drawing.Point(729, 590);
			this.btn_veresiye.Name = "btn_veresiye";
			this.btn_veresiye.Size = new System.Drawing.Size(144, 70);
			this.btn_veresiye.TabIndex = 16;
			this.btn_veresiye.Text = "Veresiye (F9)";
			this.btn_veresiye.UseVisualStyleBackColor = false;
			this.btn_veresiye.Click += new System.EventHandler(this.btn_veresiye_Click);
			// 
			// btn_iptal
			// 
			this.btn_iptal.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_iptal.Location = new System.Drawing.Point(879, 590);
			this.btn_iptal.Name = "btn_iptal";
			this.btn_iptal.Size = new System.Drawing.Size(144, 70);
			this.btn_iptal.TabIndex = 17;
			this.btn_iptal.Text = "Fatura İptal (F10)";
			this.btn_iptal.UseVisualStyleBackColor = false;
			this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
			// 
			// btn_nakitPos
			// 
			this.btn_nakitPos.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_nakitPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_nakitPos.Location = new System.Drawing.Point(579, 590);
			this.btn_nakitPos.Name = "btn_nakitPos";
			this.btn_nakitPos.Size = new System.Drawing.Size(144, 70);
			this.btn_nakitPos.TabIndex = 18;
			this.btn_nakitPos.Text = "Nakit + Pos (F11)";
			this.btn_nakitPos.UseVisualStyleBackColor = false;
			this.btn_nakitPos.Click += new System.EventHandler(this.btn_nakitPos_Click);
			// 
			// lb_toplam
			// 
			this.lb_toplam.AutoSize = true;
			this.lb_toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_toplam.ForeColor = System.Drawing.Color.White;
			this.lb_toplam.Location = new System.Drawing.Point(738, 494);
			this.lb_toplam.Name = "lb_toplam";
			this.lb_toplam.Size = new System.Drawing.Size(94, 24);
			this.lb_toplam.TabIndex = 20;
			this.lb_toplam.Text = "TOPLAM";
			// 
			// lb_tutar
			// 
			this.lb_tutar.AutoSize = true;
			this.lb_tutar.BackColor = System.Drawing.Color.Red;
			this.lb_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_tutar.ForeColor = System.Drawing.Color.White;
			this.lb_tutar.Location = new System.Drawing.Point(842, 482);
			this.lb_tutar.Name = "lb_tutar";
			this.lb_tutar.Size = new System.Drawing.Size(65, 37);
			this.lb_tutar.TabIndex = 21;
			this.lb_tutar.Text = "0.0";
			// 
			// lb_tl
			// 
			this.lb_tl.AutoSize = true;
			this.lb_tl.BackColor = System.Drawing.Color.Black;
			this.lb_tl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_tl.ForeColor = System.Drawing.Color.White;
			this.lb_tl.Location = new System.Drawing.Point(971, 494);
			this.lb_tl.Name = "lb_tl";
			this.lb_tl.Size = new System.Drawing.Size(39, 25);
			this.lb_tl.TabIndex = 22;
			this.lb_tl.Text = "TL";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 727);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1302, 22);
			this.statusStrip1.TabIndex = 23;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lb_tarih
			// 
			this.lb_tarih.AutoSize = true;
			this.lb_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_tarih.Location = new System.Drawing.Point(15, 29);
			this.lb_tarih.Name = "lb_tarih";
			this.lb_tarih.Size = new System.Drawing.Size(36, 13);
			this.lb_tarih.TabIndex = 24;
			this.lb_tarih.Text = "Tarih";
			// 
			// gb_tarihSaat
			// 
			this.gb_tarihSaat.Controls.Add(this.lb_tarih);
			this.gb_tarihSaat.Controls.Add(this.lb_saat);
			this.gb_tarihSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Inch, ((byte)(162)));
			this.gb_tarihSaat.ForeColor = System.Drawing.Color.DarkOrange;
			this.gb_tarihSaat.Location = new System.Drawing.Point(1121, 482);
			this.gb_tarihSaat.Name = "gb_tarihSaat";
			this.gb_tarihSaat.Size = new System.Drawing.Size(105, 100);
			this.gb_tarihSaat.TabIndex = 25;
			this.gb_tarihSaat.TabStop = false;
			// 
			// btn_sonUrunIptal
			// 
			this.btn_sonUrunIptal.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_sonUrunIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_sonUrunIptal.Location = new System.Drawing.Point(33, 283);
			this.btn_sonUrunIptal.Name = "btn_sonUrunIptal";
			this.btn_sonUrunIptal.Size = new System.Drawing.Size(177, 46);
			this.btn_sonUrunIptal.TabIndex = 26;
			this.btn_sonUrunIptal.Text = "Ürün İptal";
			this.btn_sonUrunIptal.UseVisualStyleBackColor = false;
			this.btn_sonUrunIptal.Click += new System.EventHandler(this.btn_sonUrunIptal_Click);
			// 
			// AnaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1302, 749);
			this.Controls.Add(this.btn_sonUrunIptal);
			this.Controls.Add(this.gb_tarihSaat);
			this.Controls.Add(this.btn_cikisYap);
			this.Controls.Add(this.btn_stok);
			this.Controls.Add(this.btn_rapor);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.lb_tl);
			this.Controls.Add(this.lb_tutar);
			this.Controls.Add(this.lb_toplam);
			this.Controls.Add(this.btn_nakitPos);
			this.Controls.Add(this.btn_iptal);
			this.Controls.Add(this.btn_veresiye);
			this.Controls.Add(this.btn_pos);
			this.Controls.Add(this.btn_nakit);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_yetkili);
			this.Controls.Add(this.gb_bekleyen);
			this.Controls.Add(this.dataGridView1);
			this.KeyPreview = true;
			this.MaximumSize = new System.Drawing.Size(2000, 2000);
			this.MinimumSize = new System.Drawing.Size(816, 520);
			this.Name = "AnaForm";
			this.Text = "ÖZGÜL TEKEL";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.gb_bekleyen.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gb_tarihSaat.ResumeLayout(false);
			this.gb_tarihSaat.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_cikisYap;
		private System.Windows.Forms.Button btn_rapor;
		private System.Windows.Forms.Button btn_stok;
		private System.Windows.Forms.GroupBox gb_bekleyen;
		private System.Windows.Forms.Button btn_bekleyen3;
		private System.Windows.Forms.Button btn_bekleyen2;
		private System.Windows.Forms.Button btn_bekleyen1;
		private System.Windows.Forms.Button btn_yetkili;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lb_urunAdi;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lb_fiyat;
		private System.Windows.Forms.Label lb_saat;
		private System.Windows.Forms.Button btn_nakit;
		private System.Windows.Forms.Button btn_pos;
		private System.Windows.Forms.Button btn_veresiye;
		private System.Windows.Forms.Button btn_iptal;
		private System.Windows.Forms.Button btn_nakitPos;
		private System.Windows.Forms.Label lb_toplam;
		private System.Windows.Forms.Label lb_tutar;
		private System.Windows.Forms.TextBox tb_fiyat;
		private System.Windows.Forms.TextBox tb_urunAdi;
		private System.Windows.Forms.TextBox tb_barkod;
		private System.Windows.Forms.Label lb_barkod;
		private System.Windows.Forms.Label lb_tl;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Label lb_tarih;
		private System.Windows.Forms.GroupBox gb_tarihSaat;
		private System.Windows.Forms.Button btn_sonUrunIptal;
	}
}