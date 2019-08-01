using OzgulTekel.VarlikKatmani;
using OzgulTekel.VeriErisimKatmani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzgulTekel
{
	public partial class form_giris : Form
	{
		Repository<Kullanici> kullaniciIslemleri = new Repository<Kullanici>();

		public form_giris()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (tb_kullanici.Text == "" || tb_sifre.Text == "")
				MessageBox.Show("Lütfen gerekli alanları boş bırakmayınız");
			else
			{
				//Kullanici kullanici = kullaniciIslemleri.Bul(x => x.KullaniciAdi == tb_kullanici.Text && x.Sifre == tb_sifre.Text);

				//if (kullanici == null)
				//	MessageBox.Show("Hatalı giriş yaptınız! Lütfen tekrar deneyiniz.");
				if(tb_kullanici.Text == "admin" && tb_sifre.Text == "412345")
				{
					this.Visible = false;
					AnaForm anaForm = new AnaForm(new Kullanici() { Yetki = "Yetkili" });
					anaForm.ShowDialog();
					this.Close();
				}
				
				else
					MessageBox.Show("Hatalı giriş yaptınız! Lütfen tekrar deneyiniz.");
			}
		}
	}
}
