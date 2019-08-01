namespace OzgulTekel
{
	partial class Rapor
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
			this.lb_raporIslemleri = new System.Windows.Forms.Label();
			this.btn_excelVeriYaz = new System.Windows.Forms.Button();
			this.btn_gunlukRapor = new System.Windows.Forms.Button();
			this.btn_aylikRapor = new System.Windows.Forms.Button();
			this.btn_donemlikRapor = new System.Windows.Forms.Button();
			this.btn_stokHareketleri = new System.Windows.Forms.Button();
			this.dtp_baslangicTarihi = new System.Windows.Forms.DateTimePicker();
			this.dtp_bitisTarihi = new System.Windows.Forms.DateTimePicker();
			this.lb_baslangicTarihi = new System.Windows.Forms.Label();
			this.lb_bitisTarihi = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(561, 426);
			this.dataGridView1.TabIndex = 0;
			// 
			// lb_raporIslemleri
			// 
			this.lb_raporIslemleri.AutoSize = true;
			this.lb_raporIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_raporIslemleri.ForeColor = System.Drawing.Color.DarkOrange;
			this.lb_raporIslemleri.Location = new System.Drawing.Point(582, 12);
			this.lb_raporIslemleri.Name = "lb_raporIslemleri";
			this.lb_raporIslemleri.Size = new System.Drawing.Size(211, 31);
			this.lb_raporIslemleri.TabIndex = 11;
			this.lb_raporIslemleri.Text = "Rapor İşlemleri";
			// 
			// btn_excelVeriYaz
			// 
			this.btn_excelVeriYaz.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_excelVeriYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_excelVeriYaz.Location = new System.Drawing.Point(588, 75);
			this.btn_excelVeriYaz.Name = "btn_excelVeriYaz";
			this.btn_excelVeriYaz.Size = new System.Drawing.Size(200, 41);
			this.btn_excelVeriYaz.TabIndex = 12;
			this.btn_excelVeriYaz.Text = "Excel\'e Veri Aktar";
			this.btn_excelVeriYaz.UseVisualStyleBackColor = false;
			this.btn_excelVeriYaz.Click += new System.EventHandler(this.btn_excelVeriYaz_Click);
			// 
			// btn_gunlukRapor
			// 
			this.btn_gunlukRapor.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_gunlukRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_gunlukRapor.Location = new System.Drawing.Point(588, 158);
			this.btn_gunlukRapor.Name = "btn_gunlukRapor";
			this.btn_gunlukRapor.Size = new System.Drawing.Size(200, 41);
			this.btn_gunlukRapor.TabIndex = 13;
			this.btn_gunlukRapor.Text = "Günlük Kasa Raporu";
			this.btn_gunlukRapor.UseVisualStyleBackColor = false;
			this.btn_gunlukRapor.Click += new System.EventHandler(this.btn_gunlukRapor_Click);
			// 
			// btn_aylikRapor
			// 
			this.btn_aylikRapor.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_aylikRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_aylikRapor.Location = new System.Drawing.Point(588, 205);
			this.btn_aylikRapor.Name = "btn_aylikRapor";
			this.btn_aylikRapor.Size = new System.Drawing.Size(200, 41);
			this.btn_aylikRapor.TabIndex = 14;
			this.btn_aylikRapor.Text = "Aylık Kasa Raporu";
			this.btn_aylikRapor.UseVisualStyleBackColor = false;
			this.btn_aylikRapor.Click += new System.EventHandler(this.btn_aylikRapor_Click);
			// 
			// btn_donemlikRapor
			// 
			this.btn_donemlikRapor.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_donemlikRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_donemlikRapor.Location = new System.Drawing.Point(588, 252);
			this.btn_donemlikRapor.Name = "btn_donemlikRapor";
			this.btn_donemlikRapor.Size = new System.Drawing.Size(200, 41);
			this.btn_donemlikRapor.TabIndex = 15;
			this.btn_donemlikRapor.Text = "Dönemsel Hareket Raporu";
			this.btn_donemlikRapor.UseVisualStyleBackColor = false;
			this.btn_donemlikRapor.Click += new System.EventHandler(this.btn_donemlikRapor_Click);
			// 
			// btn_stokHareketleri
			// 
			this.btn_stokHareketleri.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_stokHareketleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_stokHareketleri.Location = new System.Drawing.Point(588, 299);
			this.btn_stokHareketleri.Name = "btn_stokHareketleri";
			this.btn_stokHareketleri.Size = new System.Drawing.Size(200, 41);
			this.btn_stokHareketleri.TabIndex = 16;
			this.btn_stokHareketleri.Text = "Stok Hareket Raporu";
			this.btn_stokHareketleri.UseVisualStyleBackColor = false;
			this.btn_stokHareketleri.Click += new System.EventHandler(this.btn_stokHareketleri_Click);
			// 
			// dtp_baslangicTarihi
			// 
			this.dtp_baslangicTarihi.Location = new System.Drawing.Point(620, 359);
			this.dtp_baslangicTarihi.Name = "dtp_baslangicTarihi";
			this.dtp_baslangicTarihi.Size = new System.Drawing.Size(168, 20);
			this.dtp_baslangicTarihi.TabIndex = 17;
			// 
			// dtp_bitisTarihi
			// 
			this.dtp_bitisTarihi.Location = new System.Drawing.Point(620, 385);
			this.dtp_bitisTarihi.Name = "dtp_bitisTarihi";
			this.dtp_bitisTarihi.Size = new System.Drawing.Size(168, 20);
			this.dtp_bitisTarihi.TabIndex = 18;
			// 
			// lb_baslangicTarihi
			// 
			this.lb_baslangicTarihi.AutoSize = true;
			this.lb_baslangicTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_baslangicTarihi.ForeColor = System.Drawing.Color.White;
			this.lb_baslangicTarihi.Location = new System.Drawing.Point(585, 365);
			this.lb_baslangicTarihi.Name = "lb_baslangicTarihi";
			this.lb_baslangicTarihi.Size = new System.Drawing.Size(32, 13);
			this.lb_baslangicTarihi.TabIndex = 19;
			this.lb_baslangicTarihi.Text = "Baş.";
			// 
			// lb_bitisTarihi
			// 
			this.lb_bitisTarihi.AutoSize = true;
			this.lb_bitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_bitisTarihi.ForeColor = System.Drawing.Color.White;
			this.lb_bitisTarihi.Location = new System.Drawing.Point(591, 391);
			this.lb_bitisTarihi.Name = "lb_bitisTarihi";
			this.lb_bitisTarihi.Size = new System.Drawing.Size(26, 13);
			this.lb_bitisTarihi.TabIndex = 20;
			this.lb_bitisTarihi.Text = "Bit.";
			// 
			// Rapor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lb_bitisTarihi);
			this.Controls.Add(this.lb_baslangicTarihi);
			this.Controls.Add(this.dtp_bitisTarihi);
			this.Controls.Add(this.dtp_baslangicTarihi);
			this.Controls.Add(this.btn_stokHareketleri);
			this.Controls.Add(this.btn_donemlikRapor);
			this.Controls.Add(this.btn_aylikRapor);
			this.Controls.Add(this.btn_gunlukRapor);
			this.Controls.Add(this.btn_excelVeriYaz);
			this.Controls.Add(this.lb_raporIslemleri);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Rapor";
			this.Text = "Rapor";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label lb_raporIslemleri;
		private System.Windows.Forms.Button btn_excelVeriYaz;
		private System.Windows.Forms.Button btn_gunlukRapor;
		private System.Windows.Forms.Button btn_aylikRapor;
		private System.Windows.Forms.Button btn_donemlikRapor;
		private System.Windows.Forms.Button btn_stokHareketleri;
		private System.Windows.Forms.DateTimePicker dtp_baslangicTarihi;
		private System.Windows.Forms.DateTimePicker dtp_bitisTarihi;
		private System.Windows.Forms.Label lb_baslangicTarihi;
		private System.Windows.Forms.Label lb_bitisTarihi;
	}
}