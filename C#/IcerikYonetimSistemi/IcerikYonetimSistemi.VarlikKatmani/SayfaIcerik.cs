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
	public class SayfaIcerik : SayfaTemelOgeler
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public SayfaIcerik()
		{
			SayfaAltIcerik = new HashSet<SayfaAltIcerik>();
			SayfaIcerikGaleri = new HashSet<SayfaIcerikGaleri>();
			SayfaIcerikYorum = new HashSet<SayfaIcerikYorum>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), DisplayName("Sayfa İçerik ID")]
		public int SayfaIcerikID { get; set; }

		[Required, MaxLength(50), DisplayName("Sayfa İçerik Başlığı")]
		public string Baslik { get; set; }

		[DisplayName("Sayfa İçerik Açıklaması"), DataType(DataType.MultilineText)]
		public string Detay { get; set; }

		[DisplayName("Sayfa İçerik Görseli"), DataType(DataType.ImageUrl)]
		public string Gorsel { get; set; }

		[Required, DisplayName("Yoruma Açık")]
		public bool Yorum { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<SayfaAltIcerik> SayfaAltIcerik { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<SayfaIcerikGaleri> SayfaIcerikGaleri { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<SayfaIcerikYorum> SayfaIcerikYorum { get; set; }
	}
}
