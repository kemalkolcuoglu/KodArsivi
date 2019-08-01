namespace OzgulTekel
{
	partial class Stok
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
			this.tb_barkod = new System.Windows.Forms.TextBox();
			this.lb_barkod = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_urunAdi = new System.Windows.Forms.TextBox();
			this.lb_adet = new System.Windows.Forms.Label();
			this.tb_adet = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_birimFiyat = new System.Windows.Forms.TextBox();
			this.btn_onayla = new System.Windows.Forms.Button();
			this.btn_excelVeriCek = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_excelVeriYaz = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// tb_barkod
			// 
			this.tb_barkod.Location = new System.Drawing.Point(99, 31);
			this.tb_barkod.Name = "tb_barkod";
			this.tb_barkod.Size = new System.Drawing.Size(104, 22);
			this.tb_barkod.TabIndex = 1;
			// 
			// lb_barkod
			// 
			this.lb_barkod.AutoSize = true;
			this.lb_barkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_barkod.Location = new System.Drawing.Point(31, 34);
			this.lb_barkod.Name = "lb_barkod";
			this.lb_barkod.Size = new System.Drawing.Size(62, 16);
			this.lb_barkod.TabIndex = 2;
			this.lb_barkod.Text = "Barkod:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(22, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Ürün Adı:";
			// 
			// tb_urunAdi
			// 
			this.tb_urunAdi.Location = new System.Drawing.Point(99, 59);
			this.tb_urunAdi.Name = "tb_urunAdi";
			this.tb_urunAdi.Size = new System.Drawing.Size(104, 22);
			this.tb_urunAdi.TabIndex = 4;
			// 
			// lb_adet
			// 
			this.lb_adet.AutoSize = true;
			this.lb_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_adet.Location = new System.Drawing.Point(49, 90);
			this.lb_adet.Name = "lb_adet";
			this.lb_adet.Size = new System.Drawing.Size(44, 16);
			this.lb_adet.TabIndex = 5;
			this.lb_adet.Text = "Adet:";
			// 
			// tb_adet
			// 
			this.tb_adet.Location = new System.Drawing.Point(99, 87);
			this.tb_adet.Name = "tb_adet";
			this.tb_adet.Size = new System.Drawing.Size(104, 22);
			this.tb_adet.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(6, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Birim Fiyatı:";
			// 
			// tb_birimFiyat
			// 
			this.tb_birimFiyat.Location = new System.Drawing.Point(99, 115);
			this.tb_birimFiyat.Name = "tb_birimFiyat";
			this.tb_birimFiyat.Size = new System.Drawing.Size(104, 22);
			this.tb_birimFiyat.TabIndex = 8;
			// 
			// btn_onayla
			// 
			this.btn_onayla.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_onayla.ForeColor = System.Drawing.Color.Black;
			this.btn_onayla.Location = new System.Drawing.Point(58, 148);
			this.btn_onayla.Name = "btn_onayla";
			this.btn_onayla.Size = new System.Drawing.Size(93, 41);
			this.btn_onayla.TabIndex = 9;
			this.btn_onayla.Text = "Onayla";
			this.btn_onayla.UseVisualStyleBackColor = false;
			this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
			// 
			// btn_excelVeriCek
			// 
			this.btn_excelVeriCek.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_excelVeriCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_excelVeriCek.ForeColor = System.Drawing.Color.Black;
			this.btn_excelVeriCek.Location = new System.Drawing.Point(588, 52);
			this.btn_excelVeriCek.Name = "btn_excelVeriCek";
			this.btn_excelVeriCek.Size = new System.Drawing.Size(200, 41);
			this.btn_excelVeriCek.TabIndex = 10;
			this.btn_excelVeriCek.Text = "Excel\'den Veri Al";
			this.btn_excelVeriCek.UseVisualStyleBackColor = false;
			this.btn_excelVeriCek.Click += new System.EventHandler(this.btn_excelVeriCek_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.DarkOrange;
			this.label3.Location = new System.Drawing.Point(581, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(221, 37);
			this.label3.TabIndex = 10;
			this.label3.Text = "Stok İşlemleri";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_onayla);
			this.groupBox1.Controls.Add(this.tb_birimFiyat);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tb_adet);
			this.groupBox1.Controls.Add(this.lb_adet);
			this.groupBox1.Controls.Add(this.tb_urunAdi);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tb_barkod);
			this.groupBox1.Controls.Add(this.lb_barkod);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
			this.groupBox1.Location = new System.Drawing.Point(579, 236);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(209, 202);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ürün Ekle/Düzenle";
			// 
			// btn_excelVeriYaz
			// 
			this.btn_excelVeriYaz.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_excelVeriYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_excelVeriYaz.ForeColor = System.Drawing.Color.Black;
			this.btn_excelVeriYaz.Location = new System.Drawing.Point(588, 99);
			this.btn_excelVeriYaz.Name = "btn_excelVeriYaz";
			this.btn_excelVeriYaz.Size = new System.Drawing.Size(200, 41);
			this.btn_excelVeriYaz.TabIndex = 11;
			this.btn_excelVeriYaz.Text = "Excel\'e Veri Aktar";
			this.btn_excelVeriYaz.UseVisualStyleBackColor = false;
			this.btn_excelVeriYaz.Click += new System.EventHandler(this.btn_excelVeriYaz_Click);
			// 
			// Stok
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_excelVeriYaz);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_excelVeriCek);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Stok";
			this.Text = "Stok";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stok_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox tb_barkod;
		private System.Windows.Forms.Label lb_barkod;
		private System.Windows.Forms.TextBox tb_birimFiyat;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_adet;
		private System.Windows.Forms.Label lb_adet;
		private System.Windows.Forms.TextBox tb_urunAdi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_onayla;
		private System.Windows.Forms.Button btn_excelVeriCek;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_excelVeriYaz;
	}
}