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
	public partial class Rapor : Form
	{
		Repository<Satis> satisIslemleri = new Repository<Satis>();
		Repository<Urun> urunIslemleri = new Repository<Urun>();

		public Rapor()
		{
			InitializeComponent();
			dataGridView1.DataSource = satisIslemleri.VeriListesi();
		}

		private void btn_gunlukRapor_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = satisIslemleri.VeriListesi(x => x.SatisTarihi.DayOfYear == DateTime.Today.DayOfYear);
			dataGridView1.Update();
		}

		private void btn_aylikRapor_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = satisIslemleri.VeriListesi(x => x.SatisTarihi.Month == DateTime.Today.Month);
			dataGridView1.Update();
		}

		private void btn_donemlikRapor_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = satisIslemleri.VeriListesi(x => x.SatisTarihi <= dtp_bitisTarihi.Value && x.SatisTarihi >= dtp_baslangicTarihi.Value);
			dataGridView1.Update();
		}

		private void btn_stokHareketleri_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = satisIslemleri.VeriListesi();
			dataGridView1.Update();
		}

		private void btn_excelVeriYaz_Click(object sender, EventArgs e)
		{
			ExcelIslemleri.ExportToExcel(dataGridView1);
		}
	}
}
