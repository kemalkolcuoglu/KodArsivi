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
	public partial class Yetkili : Form
	{
		Repository<Kullanici> kullaniciIslemleri = new Repository<Kullanici>();
		int id;
		public Yetkili()
		{
			InitializeComponent();

			try
			{
				dataGridView1.DataSource = kullaniciIslemleri.VeriListesi();

				if (dataGridView1.Rows[0].Cells[0].Value != null)
					id = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
			}
			catch (Exception)
			{ }
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

				Kullanici kullanici = kullaniciIslemleri.Bul(x => x.KullaniciID == id);

				if (kullanici != null)
				{
					tb_kullaniciAdi.Text = kullanici.KullaniciAdi;
					tb_sifre.Text = kullanici.Sifre;
					cb_yetki.Text = kullanici.Yetki;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("İşlem Gerçekleştirilemedi!");
			}
		}

		private void btn_onayla_Click(object sender, EventArgs e)
		{
			try
			{
				Kullanici kullanici = kullaniciIslemleri.Bul(x => x.KullaniciID == id);

				if(kullanici != null)
				{
					kullanici.KullaniciAdi = tb_kullaniciAdi.Text;
					kullanici.Sifre = tb_sifre.Text;
					kullanici.Yetki = cb_yetki.Text;

					kullaniciIslemleri.Guncelle(kullanici);
				}
				else
				{
					Kullanici yeniKullanici = new Kullanici()
					{
						KullaniciAdi = tb_kullaniciAdi.Text,
						Sifre = tb_sifre.Text,
						Yetki = cb_yetki.Text
					};

					kullaniciIslemleri.Ekle(yeniKullanici);
				}
				dataGridView1.Update();
			}
			catch (Exception)
			{
				MessageBox.Show("İşleminiz gerçekleştirilemedi. Lütfen tekrar deneyiniz.");
			}
		}
	}
}
