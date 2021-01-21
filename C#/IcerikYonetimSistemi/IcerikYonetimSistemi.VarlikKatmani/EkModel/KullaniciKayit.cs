using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikYonetimSistemi.VarlikKatmani.EkModel
{
	public class KullaniciKayit
	{
		[Required, MaxLength(15), DisplayName("Kullanıcı Adı")]
		public string KullaniciAdi { get; set; }

		[Required, MaxLength(50), DisplayName("E-Posta Adresi"), EmailAddress()]
		public string EPosta { get; set; }

		[Required, MaxLength(25), DisplayName("Şifre"), DataType(DataType.Password)]
		public string Sifre { get; set; }

		[Required, MaxLength(25), DisplayName("Şifre(Tekrar)"), Compare(nameof(Sifre)), DataType(DataType.Password)]
		public string SifreTekrar { get; set; }
	}
}
