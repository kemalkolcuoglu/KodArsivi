using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IcerikYonetimSistemi.Web.Models
{
	public class OgrenciFormu
	{
		[MaxLength(100), Required, DisplayName("Adın Soyadın")]
		public string OgrenciAdi { get; set; }

		[MaxLength(15), Required, DisplayName("Telefon No.")]
		public string Telefon { get; set; }

		[MaxLength(50), Required, DisplayName("E-Posta")]
		public string EPosta { get; set; }

		[MaxLength(40), Required, DisplayName("Bağlı Bulunan Üniversite")]
		public string Universite { get; set; }

		[MaxLength(40), Required, DisplayName("Bölüm")]
		public string Bolum { get; set; }

		[MaxLength(2), Required, DisplayName("Sınıf")]
		public string Sinif { get; set; }

		[MaxLength(1000), Required, DisplayName("Kısaca Kendinden Bahseder Misin?")]
		public string Talep { get; set; }
	}
}