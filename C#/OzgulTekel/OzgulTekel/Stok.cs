using OzgulTekel.VarlikKatmani;
using OzgulTekel.VeriErisimKatmani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzgulTekel
{
	public partial class Stok : Form
	{
		Repository<Urun> urunIslemleri = new Repository<Urun>();
		int id;
		public Stok()
		{
			InitializeComponent();

			try
			{
				dataGridView1.DataSource = urunIslemleri.VeriListesi();

				if (dataGridView1.Rows[0].Cells[0].Value != null)
					id = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
			}
			catch (Exception)
			{ }
		}

		private void btn_excelVeriCek_Click(object sender, EventArgs e)
		{

			string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ozgultekel.xls;" +
  @"Extended Properties='Excel 8.0;HDR=Yes;'";
			// Create the connection object
			OleDbConnection oledbConn = new OleDbConnection(connString);
			try
			{
				// Open connection
				oledbConn.Open();

				// Create OleDbCommand object and select data from worksheet Sheet1
				OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", oledbConn);

				// Create new OleDbDataAdapter
				OleDbDataAdapter oleda = new OleDbDataAdapter();

				oleda.SelectCommand = cmd;

				// Create a DataSet which will hold the data extracted from the worksheet.
				DataSet ds = new DataSet();

				// Fill the DataSet from the data extracted from the worksheet.
				oleda.Fill(ds, "Stok");

				// Bind the data to the GridView
				dataGridView1.DataSource = ds.Tables[0].DefaultView;
				dataGridView1.Update();

				urunIslemleri.Ekle(new List<Urun>(ds.Tables.Cast<Urun>()));
			}
			catch (Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			finally
			{
				// Close connection
				oledbConn.Close();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

				Urun urun = urunIslemleri.Bul(x => x.UrunID == id);

				if (urun != null)
				{
					tb_barkod.Text = urun.Barkod;
					tb_urunAdi.Text = urun.UrunAdi;
					tb_birimFiyat.Text = urun.BirimFiyat.ToString();
					tb_adet.Text = urun.Adet.ToString();
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
				Urun urun = urunIslemleri.Bul(x => x.Barkod == tb_barkod.Text);

				if (urun != null)
				{
					urun.BirimFiyat = Convert.ToDecimal(tb_birimFiyat.Text);
					urun.Adet = Convert.ToInt32(tb_adet.Text);
					urun.Barkod = tb_barkod.Text;
					urun.UrunAdi = tb_urunAdi.Text;
					urun.KayitTarihi = DateTime.Now;
					urunIslemleri.Guncelle(urun);
				}
				else
				{
					Urun yeniUrun = new Urun()
					{
						Adet = Convert.ToInt32(tb_adet.Text),
						Barkod = tb_barkod.Text,
						BirimFiyat = Convert.ToDecimal(tb_birimFiyat.Text),
						KayitTarihi = DateTime.Now,
						UrunAdi = tb_urunAdi.Text
					};
					urunIslemleri.Ekle(yeniUrun);
				}
				dataGridView1.DataSource = urunIslemleri.VeriListesi();
				dataGridView1.Update();
				tb_adet.Text = "";
				tb_barkod.Text = "";
				tb_birimFiyat.Text = "";
				tb_urunAdi.Text = "";
			}
			catch (Exception)
			{
				MessageBox.Show("İşleminiz gerçekleştirilemedi. Lütfen tekrar deneyiniz.");
			}
		}

		private void btn_excelVeriYaz_Click(object sender, EventArgs e)
		{
			ExcelIslemleri.ExportToExcel(dataGridView1);
		}

		private void Stok_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Urun urun = urunIslemleri.Bul(x => x.Barkod == tb_barkod.Text);

				if(urun != null)
				{
					tb_adet.Text = urun.Adet.ToString();
					tb_birimFiyat.Text = urun.BirimFiyat.ToString();
					tb_urunAdi.Text = urun.UrunAdi;
				}
			}
		}
	}
}
