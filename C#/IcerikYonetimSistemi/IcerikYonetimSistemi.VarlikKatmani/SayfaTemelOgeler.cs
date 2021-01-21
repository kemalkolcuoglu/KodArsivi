using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikYonetimSistemi.VarlikKatmani
{
	public class SayfaTemelOgeler
	{
		protected SayfaTemelOgeler()
		{ }

		[DisplayName("Sayfa ID")]
		public int SayfaID { get; set; }

		[Required, DisplayName("Oluşturma Tarihi"), DataType(DataType.DateTime)]
		public DateTime OlusturmaTarihi { get; set; }

		[Required, DisplayName("Düzenleme Tarihi"), DataType(DataType.DateTime)]
		public DateTime DuzenlemeTarihi { get; set; }

		[DisplayName("Öğe İkonu")]
		public string Ikon { get; set; }

		[Required, DefaultValue(0), DisplayName("Gösterim Sırası")]
		public int GosterimSirasi { get; set; }

		[DefaultValue(false)]
		public bool Etkin { get; set; }

		public virtual Sayfalar Sayfa { get; set; }
	}
}
