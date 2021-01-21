using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IcerikYonetimSistemi.Web.Models
{
	public class KurumFormu
	{
		[MaxLength(100), Required, DisplayName("Firma Adı")]
		public string FirmaAdi { get; set; }

		[MaxLength(50), Required, DisplayName("Talepte Bulunan Kişi")]
		public string TalepteBulunanKisi { get; set; }

		[MaxLength(15), Required, DisplayName("Telefon No.")]
		public string Telefon { get; set; }

		[MaxLength(50), Required, DisplayName("E-Posta")]
		public string EPosta { get; set; }

		[MaxLength(250), Required, DisplayName("Firmanın Çalışma Alanı")]
		public string CalismaAlani { get; set; }

		[MaxLength(1000), Required, DisplayName("Talep")]
		public string Talep { get; set; }
	}
}