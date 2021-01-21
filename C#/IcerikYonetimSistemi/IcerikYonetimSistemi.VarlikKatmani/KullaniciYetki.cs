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
	public class KullaniciYetki
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public KullaniciYetki()
		{
			Kullanicilar = new HashSet<Kullanici>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), DisplayName("Yetki ID")]
		public int KullaniciYetkiID{ get; set; }

		[Required, MaxLength(20), DisplayName("Yetki Adı")]
		public string KullaniciYetkiAdi{ get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Kullanici> Kullanicilar{ get; set; }
	}
}
