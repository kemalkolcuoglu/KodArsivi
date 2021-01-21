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
	public class Sayfalar
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Sayfalar()
		{
			SayfaIcerik = new HashSet<SayfaIcerik>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), DisplayName("Sayfa ID")]
		public int SayfaID { get; set; }

		[Required, MaxLength(25), DisplayName("Sayfa Başlığı")]
		public string SayfaBasligi{ get; set; }

		[DisplayName("Sayfa İkonu")]
		public string Ikon{ get; set; }

		public bool Etkin { get; set; }

		[Required, DefaultValue(0), DisplayName("Gösterim Sırası")]
		public int GosterimSirasi { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<SayfaIcerik> SayfaIcerik { get; set; }
	}
}
