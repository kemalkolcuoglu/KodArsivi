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
	public class SayfaIcerikGaleri : SayfaTemelOgeler
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), DisplayName("Sayfa İçerik Görsel ID")]
		public int SayfaIcerikGorselID { get; set; }

		[Required, DisplayName("Üst İçerik ID")]
		public int SayfaIcerikID { get; set; }

		[DisplayName("Görsel Adresi"), DataType(DataType.ImageUrl)]
		public string Gorsel { get; set; }

		[Required, MaxLength(25), DisplayName("Görsel Başlığı")]
		public string Baslik { get; set; }

		[DisplayName("Görsel Açıklaması"), DataType(DataType.MultilineText), MaxLength(1000)]
		public string Detay { get; set; }

		public virtual SayfaIcerik SayfaIcerik { get; set; }
	}
}
