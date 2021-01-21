using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikYonetimSistemi.VarlikKatmani
{
	public class SayfaIcerikYorum : SayfaTemelOgeler
	{
		[DisplayName("Sayfa İçerik ID")]
		public int SayfaIcerikID{ get; set; }

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), DisplayName("Yorum ID")]
		public int SayfaIcerikYorumID { get; set; }

		// Bu prop kullanıcı girişi yapılarak yorum yapabilme yetkisi sağlar.
		/*[DisplayName("Yorum Yapan Kullanici ID")]
		public int YorumYapanKullaniciID { get; set; }*/

		[Required, MaxLength(50), DisplayName("Ad Soyad") ]
		public string AdSoyad { get; set; }

		[Required, MaxLength(50), DisplayName("E-Posta"), EmailAddress()]
		public string EPosta { get; set; }

		[Required, MaxLength(255), DisplayName("Yorum Metni"), DataType(DataType.MultilineText)]
		public string YorumMetni { get; set; }

		// Bu prop kullanıcı girişi yapılarak yorum yapabilme yetkisi sağlar.
		//public virtual Kullanici Kullanici { get; set; }

		public virtual SayfaIcerik SayfaIcerik { get; set; }
	}
}
