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
	public class Formlar
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), DisplayName("Form ID")]
		public int FormID{ get; set; }

		[Required, DisplayName("Ad Soyad")]
		public string AdSoyad { get; set; }

		[Required, DisplayName("E-Posta Adresi"), EmailAddress()]
		public string EPosta { get; set; }

		[Required, DisplayName("Mesaj İçeriği"), MaxLength(1000)]
		public string MesajIcerigi { get; set; }
	}
}
