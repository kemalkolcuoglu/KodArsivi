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
	public class SayfaAltIcerik : SayfaTemelOgeler
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), DisplayName("Alt İçerik ID")]
		public int SayfaAltIcerikID{ get; set; }

		[Required, DisplayName("Üst İçerik ID")]
		public int SayfaIcerikID { get; set; }

		[Required, MaxLength(100), DisplayName("Alt İçerik Başlığı")]
		public string Baslik{ get; set; }

		[DisplayName("Alt İçerik Detayı"), DataType(DataType.MultilineText)]
		public string Detay { get; set; }

		[DisplayName("Alt İçerik Görseli"), DataType(DataType.ImageUrl)]
		public string Gorsel { get; set; }

		public virtual SayfaIcerik SayfaIcerik { get; set; }
	}
}
