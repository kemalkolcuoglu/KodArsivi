using IcerikYonetimSistemi.VarlikKatmani;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IcerikYonetimSistemi.Web.Models
{
	public class EtkinlikBasvuru
	{
		[Required, MaxLength(50), DisplayName("Ad Soyad")]
		public string AdSoyad { get; set; }

		[Required, MaxLength(50), EmailAddress(), DisplayName("E-Posta Adresi")]
		public string EPosta { get; set; }

		[Required, MaxLength(15), DisplayName("Telefon No.")]
		public string TelefonNo { get; set; }

		[DisplayName("Öğrenci/Sivil")]
		public string OgrenciSivil { get; set; }

		[DisplayName("Hangi Okul")]
		public string HangiOkul { get; set; }

		[DisplayName("Hangi Bölüm")]
		public string HangiBolum { get; set; }

		public string Meslek { get; set; }

		public DateTime BasvuruTarihi { get; set; }
	}
}
