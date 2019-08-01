namespace OzgulTekel
{
	partial class Yetkili
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
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_onayla = new System.Windows.Forms.Button();
			this.lb_yetki = new System.Windows.Forms.Label();
			this.cb_yetki = new System.Windows.Forms.ComboBox();
			this.tb_sifre = new System.Windows.Forms.TextBox();
			this.lb_sifre = new System.Windows.Forms.Label();
			this.tb_kullaniciAdi = new System.Windows.Forms.TextBox();
			this.lb_kullanici = new System.Windows.Forms.Label();
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
			this.dataGridView1.Size = new System.Drawing.Size(535, 426);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.DarkOrange;
			this.label3.Location = new System.Drawing.Point(553, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(245, 37);
			this.label3.TabIndex = 11;
			this.label3.Text = "Yetkili İşlemleri";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_onayla);
			this.groupBox1.Controls.Add(this.lb_yetki);
			this.groupBox1.Controls.Add(this.cb_yetki);
			this.groupBox1.Controls.Add(this.tb_sifre);
			this.groupBox1.Controls.Add(this.lb_sifre);
			this.groupBox1.Controls.Add(this.tb_kullaniciAdi);
			this.groupBox1.Controls.Add(this.lb_kullanici);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
			this.groupBox1.Location = new System.Drawing.Point(560, 259);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(228, 179);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kullanıcı Ekle/Düzenle";
			// 
			// btn_onayla
			// 
			this.btn_onayla.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_onayla.ForeColor = System.Drawing.Color.Black;
			this.btn_onayla.Location = new System.Drawing.Point(68, 128);
			this.btn_onayla.Name = "btn_onayla";
			this.btn_onayla.Size = new System.Drawing.Size(93, 41);
			this.btn_onayla.TabIndex = 10;
			this.btn_onayla.Text = "Onayla";
			this.btn_onayla.UseVisualStyleBackColor = false;
			this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
			// 
			// lb_yetki
			// 
			this.lb_yetki.AutoSize = true;
			this.lb_yetki.Location = new System.Drawing.Point(56, 92);
			this.lb_yetki.Name = "lb_yetki";
			this.lb_yetki.Size = new System.Drawing.Size(47, 16);
			this.lb_yetki.TabIndex = 5;
			this.lb_yetki.Text = "Yetki:";
			// 
			// cb_yetki
			// 
			this.cb_yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_yetki.FormattingEnabled = true;
			this.cb_yetki.Items.AddRange(new object[] {
            "Yetkili",
            "Personel"});
			this.cb_yetki.Location = new System.Drawing.Point(109, 89);
			this.cb_yetki.Name = "cb_yetki";
			this.cb_yetki.Size = new System.Drawing.Size(113, 24);
			this.cb_yetki.TabIndex = 4;
			// 
			// tb_sifre
			// 
			this.tb_sifre.Location = new System.Drawing.Point(109, 61);
			this.tb_sifre.Name = "tb_sifre";
			this.tb_sifre.Size = new System.Drawing.Size(113, 22);
			this.tb_sifre.TabIndex = 3;
			// 
			// lb_sifre
			// 
			this.lb_sifre.AutoSize = true;
			this.lb_sifre.Location = new System.Drawing.Point(59, 64);
			this.lb_sifre.Name = "lb_sifre";
			this.lb_sifre.Size = new System.Drawing.Size(44, 16);
			this.lb_sifre.TabIndex = 2;
			this.lb_sifre.Text = "Şifre:";
			// 
			// tb_kullaniciAdi
			// 
			this.tb_kullaniciAdi.Location = new System.Drawing.Point(109, 33);
			this.tb_kullaniciAdi.Name = "tb_kullaniciAdi";
			this.tb_kullaniciAdi.Size = new System.Drawing.Size(113, 22);
			this.tb_kullaniciAdi.TabIndex = 1;
			// 
			// lb_kullanici
			// 
			this.lb_kullanici.AutoSize = true;
			this.lb_kullanici.Location = new System.Drawing.Point(6, 36);
			this.lb_kullanici.Name = "lb_kullanici";
			this.lb_kullanici.Size = new System.Drawing.Size(97, 16);
			this.lb_kullanici.TabIndex = 0;
			this.lb_kullanici.Text = "Kullanıcı Adı:";
			// 
			// btn_excelVeriYaz
			// 
			this.btn_excelVeriYaz.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_excelVeriYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_excelVeriYaz.Location = new System.Drawing.Point(582, 61);
			this.btn_excelVeriYaz.Name = "btn_excelVeriYaz";
			this.btn_excelVeriYaz.Size = new System.Drawing.Size(200, 41);
			this.btn_excelVeriYaz.TabIndex = 13;
			this.btn_excelVeriYaz.Text = "Excel\'e Veri Aktar";
			this.btn_excelVeriYaz.UseVisualStyleBackColor = false;
			// 
			// Yetkili
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_excelVeriYaz);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Yetkili";
			this.Text = "Yetkili";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lb_yetki;
		private System.Windows.Forms.ComboBox cb_yetki;
		private System.Windows.Forms.TextBox tb_sifre;
		private System.Windows.Forms.Label lb_sifre;
		private System.Windows.Forms.TextBox tb_kullaniciAdi;
		private System.Windows.Forms.Label lb_kullanici;
		private System.Windows.Forms.Button btn_onayla;
		private System.Windows.Forms.Button btn_excelVeriYaz;
	}
}