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
	public class FotografGaleri
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity),  DisplayName("Görsel ID")]
		public int GorselID { get; set; }

		[Required, DisplayName("Görsel Başlığı"), MaxLength(50)]
		public string Baslik { get; set; }

		[Required, DisplayName("Görsel Açıklaması"), MaxLength(255)]
		public string Detay { get; set; }

		[Required, DisplayName("Görsel Adresi"), DataType(DataType.ImageUrl)]
		public string Adres { get; set; }

		[Required, DisplayName("Oluşturma Tarihi"), DataType(DataType.DateTime)]
		public DateTime OlusturmaTarihi { get; set; }

		[Required, DisplayName("Düzenleme Tarihi"), DataType(DataType.DateTime)]
		public DateTime DuzenlemeTarihi { get; set; }

		public bool Etkin { get; set; }
	}
}
