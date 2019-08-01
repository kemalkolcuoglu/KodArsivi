using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzgulTekel.VarlikKatmani
{
	public class Satis
	{
		[Key]
		public int SatisID { get; set; }

		public string Barkod { get; set; }

		[DisplayName("Ürün Adı")]
		public string UrunAdi { get; set; }

		public int Adet { get; set; }

		[DisplayName("Birim Fiyat")]
		public decimal BirimFiyat { get; set; }

		[DisplayName("Tutar")]
		public decimal Tutar { get; set; }

		[DisplayName("Ödeme Yöntemi")]
		public string OdemeYontemi { get; set; }

		[DisplayName("Satış Tarihi")]
		public DateTime SatisTarihi { get; set; }
	}
}
