namespace OzgulTekel
{
	partial class form_giris
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
			this.tb_kullanici = new System.Windows.Forms.TextBox();
			this.tb_sifre = new System.Windows.Forms.TextBox();
			this.lb_baslik = new System.Windows.Forms.Label();
			this.lb_kullanici = new System.Windows.Forms.Label();
			this.lb_sifre = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tb_kullanici
			// 
			this.tb_kullanici.Location = new System.Drawing.Point(147, 89);
			this.tb_kullanici.Name = "tb_kullanici";
			this.tb_kullanici.Size = new System.Drawing.Size(126, 20);
			this.tb_kullanici.TabIndex = 0;
			// 
			// tb_sifre
			// 
			this.tb_sifre.Location = new System.Drawing.Point(147, 115);
			this.tb_sifre.Name = "tb_sifre";
			this.tb_sifre.PasswordChar = '*';
			this.tb_sifre.Size = new System.Drawing.Size(126, 20);
			this.tb_sifre.TabIndex = 1;
			// 
			// lb_baslik
			// 
			this.lb_baslik.AutoSize = true;
			this.lb_baslik.BackColor = System.Drawing.Color.DarkOrange;
			this.lb_baslik.Font = new System.Drawing.Font("Cooper Black", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_baslik.ForeColor = System.Drawing.Color.Black;
			this.lb_baslik.Location = new System.Drawing.Point(22, 20);
			this.lb_baslik.Name = "lb_baslik";
			this.lb_baslik.Size = new System.Drawing.Size(265, 38);
			this.lb_baslik.TabIndex = 2;
			this.lb_baslik.Text = "ÖZGÜL TEKEL";
			// 
			// lb_kullanici
			// 
			this.lb_kullanici.AutoSize = true;
			this.lb_kullanici.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_kullanici.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lb_kullanici.Location = new System.Drawing.Point(35, 91);
			this.lb_kullanici.Name = "lb_kullanici";
			this.lb_kullanici.Size = new System.Drawing.Size(106, 15);
			this.lb_kullanici.TabIndex = 3;
			this.lb_kullanici.Text = "Kullanıcı Adı:";
			// 
			// lb_sifre
			// 
			this.lb_sifre.AutoSize = true;
			this.lb_sifre.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_sifre.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lb_sifre.Location = new System.Drawing.Point(98, 117);
			this.lb_sifre.Name = "lb_sifre";
			this.lb_sifre.Size = new System.Drawing.Size(43, 15);
			this.lb_sifre.TabIndex = 4;
			this.lb_sifre.Text = "Şifre:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkOrange;
			this.button1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(91, 154);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 38);
			this.button1.TabIndex = 5;
			this.button1.Text = "Giriş Yap";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// form_giris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(309, 203);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lb_sifre);
			this.Controls.Add(this.lb_kullanici);
			this.Controls.Add(this.lb_baslik);
			this.Controls.Add(this.tb_sifre);
			this.Controls.Add(this.tb_kullanici);
			this.MaximumSize = new System.Drawing.Size(325, 242);
			this.MinimumSize = new System.Drawing.Size(325, 242);
			this.Name = "form_giris";
			this.Text = "ÖZGÜR TEKEL";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_kullanici;
		private System.Windows.Forms.TextBox tb_sifre;
		private System.Windows.Forms.Label lb_baslik;
		private System.Windows.Forms.Label lb_kullanici;
		private System.Windows.Forms.Label lb_sifre;
		private System.Windows.Forms.Button button1;
	}
}

