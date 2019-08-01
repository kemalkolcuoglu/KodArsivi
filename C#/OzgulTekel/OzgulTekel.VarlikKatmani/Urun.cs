using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzgulTekel.VarlikKatmani
{
	public class Urun
	{
		[Key]
		public int UrunID { get; set; }

		public string Barkod { get; set; }

		[DisplayName("Ürün Adı")]
		public string UrunAdi { get; set; }

		public int Adet { get; set; }

		[DisplayName("Birim Fiyat")]
		public decimal BirimFiyat { get; set; }

		[DisplayName("Kayıt Tarihi")]
		public DateTime KayitTarihi { get; set; }
	}
}
