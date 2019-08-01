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
	public partial class AnaForm : Form
	{
		Repository<Satis> satisIslemleri = new Repository<Satis>();
		Repository<Urun> urunIslemleri = new Repository<Urun>();
		string barkod;
		string temp_barkod;
		decimal tutar = 0;
		int id;

		#region EtkinDegiskenler

		int etkinUrunAdedi;
		int etkinSatisSirasi;
		int urunAdetiSatis1 = 0;
		int urunAdetiSatis2 = 0;
		int urunAdetiSatis3 = 0;
		int satisSirasiSatis1 = 0;
		int satisSirasiSatis2 = 0;
		int satisSirasiSatis3 = 0;
		List<Satis> satis1 = new List<Satis>();
		List<Satis> satis2 = new List<Satis>();
		List<Satis> satis3 = new List<Satis>();
		List<Satis> etkinSatis;

		#endregion

		public AnaForm(Kullanici kullanici)
		{
			InitializeComponent();
			StartTimer();
			if(kullanici.Yetki != "Yetkili")
			{
				btn_stok.Visible = false;
				btn_rapor.Visible = false;
				btn_yetkili.Visible = false;
			}

			dataGridView1.DataSource = satis1;
			dataGridView1.Update();
			etkinSatis = satis1;
			etkinSatisSirasi = satisSirasiSatis1;
			etkinUrunAdedi = urunAdetiSatis1;
			statusStrip1.Text = "Hazır";
		}

		private void btn_cikisYap_Click(object sender, EventArgs e) => this.Close();

		#region Saat-Takvim

		Timer t = null;
		private void StartTimer()
		{
			t = new Timer
			{
				Interval = 1000
			};
			t.Tick += new EventHandler(t_Tick);
			t.Enabled = true;
		}

		void t_Tick(object sender, EventArgs e)
		{
			lb_saat.Text = String.Format("{0}.{1}", DateTime.Now.Hour, DateTime.Now.Minute);
			lb_tarih.Text = String.Format("{0}/{1}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
		}

		#endregion

		#region Diger Formlarin Acilmasi

		private void btn_stok_Click(object sender, EventArgs e)
		{
			statusStrip1.Text = "Stok İşlemlerine Girildi!";
			Stok stok = new Stok();
			stok.ShowDialog();
		}

		private void btn_rapor_Click(object sender, EventArgs e)
		{
			statusStrip1.Text = "Rapor İşlemlerine Girildi!";
			Rapor rapor = new Rapor();
			rapor.ShowDialog();
		}

		private void btn_yetkili_Click(object sender, EventArgs e)
		{
			statusStrip1.Text = "Yetkili İşlemlerine Girildi!";
			Yetkili yetkili = new Yetkili();
			yetkili.ShowDialog();
		}

		private void btn_fatura_Click(object sender, EventArgs e)
		{

		}

		private void btn_genelAyarlar_Click(object sender, EventArgs e)
		{

		}

		#endregion

		private void tb_barkod_TextChanged(object sender, EventArgs e)
		{

		}

		#region Bekleyenler Listesi İşlemleri

		private void btn_bekleyen1_Click(object sender, EventArgs e)
		{
			if(etkinSatis == satis2)
			{
				satisSirasiSatis2 = etkinSatisSirasi;
				urunAdetiSatis2 = etkinUrunAdedi;
			}
			else if(etkinSatis == satis3)
			{
				satisSirasiSatis3 = etkinSatisSirasi;
				urunAdetiSatis3 = etkinUrunAdedi;
			}

			etkinSatis = satis1;
			etkinSatisSirasi = satisSirasiSatis1;
			etkinUrunAdedi = urunAdetiSatis1;
			dataGridView1.DataSource = satis1;
			dataGridView1.Update();
			statusStrip1.Text = "Birinci Listeye Geçildi";
		}

		private void btn_bekleyen2_Click(object sender, EventArgs e)
		{
			if (etkinSatis == satis1)
			{
				satisSirasiSatis1 = etkinSatisSirasi;
				urunAdetiSatis1 = etkinUrunAdedi;
			}
			else if (etkinSatis == satis3)
			{
				satisSirasiSatis3 = etkinSatisSirasi;
				urunAdetiSatis3 = etkinUrunAdedi;
			}

			etkinSatis = satis2;
			etkinSatisSirasi = satisSirasiSatis2;
			etkinUrunAdedi = urunAdetiSatis2;
			dataGridView1.DataSource = satis2;
			dataGridView1.Update();
			statusStrip1.Text = "İkinci Listeye Geçildi";
		}

		private void btn_bekleyen3_Click(object sender, EventArgs e)
		{
			if (etkinSatis == satis1)
			{
				satisSirasiSatis1 = etkinSatisSirasi;
				urunAdetiSatis1 = etkinUrunAdedi;
			}
			else if (etkinSatis == satis2)
			{
				satisSirasiSatis2 = etkinSatisSirasi;
				urunAdetiSatis2 = etkinUrunAdedi;
			}

			etkinSatis = satis3;
			etkinSatisSirasi = satisSirasiSatis3;
			etkinUrunAdedi = urunAdetiSatis3;
			dataGridView1.DataSource = satis3;
			dataGridView1.Update();
			statusStrip1.Text = "Üçüncü Listeye Geçildi";
		}

		#endregion

		#region Ödeme İşlemleri

		private void btn_nakit_Click(object sender, EventArgs e)
		{
			statusStrip1.Text = "Nakit Ödeme Seçildi";
			if (etkinSatis.Count < 1)
				MessageBox.Show("Ödeme işlemi için ürün bulunamadı!");
			else
			{
				foreach (var items in etkinSatis)
				{
					items.SatisTarihi = DateTime.Now;
					items.OdemeYontemi = "Nakit";
				}
				int onay = satisIslemleri.Ekle(etkinSatis);
				if (onay > 0)
				{
					foreach (var items in etkinSatis)
					{
						Urun urun = urunIslemleri.Bul(x => x.Barkod == items.Barkod);
						urun.Adet -= items.Adet;
						urunIslemleri.Guncelle(urun);
					}
					etkinSatis.Clear();
					etkinSatisSirasi = 0;
					etkinUrunAdedi = 0;
					statusStrip1.Text = "Satış İşlemi Gerçekleşmiştir";
					MessageBox.Show("Satış İşlemi Gerçekleşmiştir");
					dataGridView1.DataSource = satisIslemleri.VeriListesi(x => x.SatisID == 0);
					dataGridView1.Update();
					return;
				}
				dataGridView1.DataSource = satisIslemleri.VeriListesi(x => x.SatisID == 0);
				lb_tutar.Text = "0.0";
				dataGridView1.Update();
			}
		}

		private void btn_iptal_Click(object sender, EventArgs e)
		{
			DialogResult dialog = MessageBox.Show("İşlemi iptal etmek istediğinizden emin misiniz?", "İşlem İptal Edilecek", MessageBoxButtons.OKCancel);

			if(dialog == DialogResult.OK)
			{
				etkinSatis.Clear();
				etkinSatisSirasi = 0;
				etkinUrunAdedi = 0;
				lb_tutar.Text = "0.0";
				statusStrip1.Text = "Satış İşlemi İptal Edildi";
				dataGridView1.DataSource = satisIslemleri.VeriListesi(x => x.SatisID == 0);
				dataGridView1.Update();
			}
		}

		private void btn_pos_Click(object sender, EventArgs e)
		{
			statusStrip1.Text = "Pos Ödeme Seçildi";
			if (etkinSatis.Count < 1)
				MessageBox.Show("Ödeme işlemi için ürün bulunamadı!");
			else
			{
				foreach (var items in etkinSatis)
				{
					items.SatisTarihi = DateTime.Now;
					items.OdemeYontemi = "Pos";
				}
				int onay = satisIslemleri.Ekle(etkinSatis);
				if (onay > 0)
				{
					foreach (var items in etkinSatis)
					{
						Urun urun = urunIslemleri.Bul(x => x.Barkod == items.Barkod);
						urun.Adet -= items.Adet;
						urunIslemleri.Guncelle(urun);
					}
					etkinSatis.Clear();
					etkinSatisSirasi = 0;
					etkinUrunAdedi = 0;
					statusStrip1.Text = "Satış İşlemi Gerçekleşmiştir";
					lb_tutar.Text = "0.0";
					dataGridView1.DataSource = satisIslemleri.VeriListesi(x => x.SatisID == 0);
					dataGridView1.Update();
					return;
				}
				MessageBox.Show("Satış İşlemi Gerçekleştirilemedi!");
				dataGridView1.DataSource = satisIslemleri.VeriListesi(x => x.SatisID == 0);
				dataGridView1.Update();
			}
		}

		private void btn_veresiye_Click(object sender, EventArgs e)
		{
			statusStrip1.Text = "Veresiye Ödeme Seçildi";
			if (etkinSatis.Count < 1)
				MessageBox.Show("Ödeme işlemi için ürün bulunamadı!");
			else
			{
				foreach (var items in etkinSatis)
				{
					items.SatisTarihi = DateTime.Now;
					items.OdemeYontemi = "Veresiye";
				}
				int onay = satisIslemleri.Ekle(etkinSatis);
				if (onay > 0)
				{
					foreach (var items in etkinSatis)
					{
						Urun urun = urunIslemleri.Bul(x => x.Barkod == items.Barkod);
						urun.Adet -= items.Adet;
						urunIslemleri.Guncelle(urun);
					}
					etkinSatis.Clear();
					etkinSatisSirasi = 0;
					etkinUrunAdedi = 0;
					statusStrip1.Text = "Satış İşlemi Gerçekleşmiştir";
					lb_tutar.Text = "0.0";
					dataGridView1.DataSource = satisIslemleri.VeriListesi(x => x.SatisID == 0);
					dataGridView1.Update();
					return;
				}
				MessageBox.Show("Satış İşlemi Gerçekleştirilemedi!");
				dataGridView1.DataSource = satisIslemleri.VeriListesi(x => x.SatisID == 0);
				dataGridView1.Update();
			}
		}

		private void btn_nakitPos_Click(object sender, EventArgs e)
		{
			statusStrip1.Text = "Nakit + Pos Ödeme Seçildi";
			if (etkinSatis.Count < 1)
				MessageBox.Show("Ödeme işlemi için ürün bulunamadı!");
			else
			{
				foreach (var items in etkinSatis)
				{
					items.SatisTarihi = DateTime.Now;
					items.OdemeYontemi = "Nakit + Pos";
				}
				int onay = satisIslemleri.Ekle(etkinSatis);
				if (onay > 0)
				{
					foreach (var items in etkinSatis)
					{
						Urun urun = urunIslemleri.Bul(x => x.Barkod == items.Barkod);
						urun.Adet -= items.Adet;
						urunIslemleri.Guncelle(urun);
					}
					etkinSatis.Clear();
					etkinSatisSirasi = 0;
					etkinUrunAdedi = 0;
					statusStrip1.Text = "Satış İşlemi Gerçekleşmiştir";
					lb_tutar.Text = "0.0";
					dataGridView1.DataSource = satisIslemleri.VeriListesi(x => x.SatisID == 0);
					dataGridView1.Update();
					return;
				}
				MessageBox.Show("Satış İşlemi Gerçekleştirilemedi!");
				dataGridView1.DataSource = satisIslemleri.VeriListesi(x => x.SatisID == 0);
				dataGridView1.Update();
			}
		}

		#endregion

		private void btn_sonUrunIptal_Click(object sender, EventArgs e)
		{
			try
			{
				Satis satis = new Satis()
				{
					Tutar = etkinSatis[etkinSatisSirasi].Tutar,
					Adet = etkinSatis[etkinSatisSirasi].Adet,
					Barkod = etkinSatis[etkinSatisSirasi].Barkod,
					BirimFiyat = etkinSatis[etkinSatisSirasi].BirimFiyat,
					UrunAdi = etkinSatis[etkinSatisSirasi].UrunAdi
				};
				satis.BirimFiyat = satis.BirimFiyat * (-1);
				satis.Tutar = satis.Tutar * (-1);
				etkinSatisSirasi++;
				etkinSatis.Add(satis);
				tutar = 0;
				foreach (var items in etkinSatis)
				{
					tutar += items.Tutar;
				}
				lb_tutar.Text = tutar.ToString();
				dataGridView1.DataSource = etkinSatis;
				dataGridView1.Update();
			}
			catch (Exception exp)
			{
				MessageBox.Show("İptal Edilecek Ürün Bulunamadı");
			}
			
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				id = dataGridView1.CurrentRow.Index;
			}
			catch (Exception)
			{
				MessageBox.Show("İşlem Gerçekleştirilemedi!");
			}
		}

		private void tb_barkod_KeyDown(object sender, KeyEventArgs e)

		{
			if (e.KeyCode == Keys.Enter)
			{
				try
				{
					Satis satis;
					if (barkod == null)
					{
						barkod = tb_barkod.Text;
						Urun urun = urunIslemleri.Bul(x => x.Barkod == tb_barkod.Text);

						if (urun == null)
						{
							statusStrip1.Text = "Ürün Bulunamadı";
							barkod = null;

							return;
						}
						else
						{
							tb_urunAdi.Text = urun.UrunAdi;
							tb_fiyat.Text = urun.BirimFiyat.ToString();
							etkinUrunAdedi++;
							satis = new Satis()
							{
								Adet = etkinUrunAdedi,
								Barkod = barkod,
								BirimFiyat = urun.BirimFiyat,
								UrunAdi = urun.UrunAdi,
								Tutar = urun.BirimFiyat * etkinUrunAdedi
							};
							etkinSatis.Add(satis);
						}
					}
					else if (barkod == tb_barkod.Text)
					{
						etkinUrunAdedi++;
						etkinSatis[etkinSatisSirasi].Adet = etkinUrunAdedi;
						satis1[etkinSatisSirasi].Tutar = etkinUrunAdedi * etkinSatis[etkinSatisSirasi].BirimFiyat;
					}

					else if (barkod != tb_barkod.Text)
					{
						etkinSatisSirasi++;
						etkinUrunAdedi = 1;

						barkod = tb_barkod.Text;
						Urun urun = urunIslemleri.Bul(x => x.Barkod == tb_barkod.Text);

						if (urun == null)
						{
							statusStrip1.Text = "Ürün Bulunamadı";

							return;
						}
						else
						{
							bool kontrol = false;
							foreach (var items in etkinSatis)
							{
								if (urun.Barkod == items.Barkod)
								{
									items.Adet++;
									kontrol = true;
									break;
								}

							}
							tb_urunAdi.Text = urun.UrunAdi;
							tb_fiyat.Text = urun.BirimFiyat.ToString();
							if (!kontrol)
							{
								satis = new Satis()
								{
									Adet = etkinUrunAdedi,
									Barkod = barkod,
									BirimFiyat = urun.BirimFiyat,
									UrunAdi = urun.UrunAdi,
									Tutar = urun.BirimFiyat * etkinUrunAdedi
								};
								etkinSatis.Add(satis);
							}
						}
					}
					tutar = 0;
					foreach (var items in etkinSatis)
					{
						tutar += items.Tutar;
					}

					lb_tutar.Text = tutar.ToString();
					dataGridView1.DataSource = etkinSatis.ToList();
					dataGridView1.Update();

					statusStrip1.Text = "Ürün Eklendi";
				}
				catch (Exception)
				{
					MessageBox.Show("Ürün bulunamadı!");
				}
				finally
				{
					tb_barkod.Text = "";
				}
			}
		}
	}
}
