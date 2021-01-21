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
	public class Kullanici
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), DisplayName("Kullanıcı ID")]
		public int KullaniciID { get; set; }

		[DisplayName("Kullanıcı Yetkisi")]
		public int KullaniciYetkiID { get; set; }

		[Required, MaxLength(50), DisplayName("E-Posta Adresi"), EmailAddress()]
		public string EPosta { get; set; }

		[Required, MaxLength(25), DisplayName("Şifre"), DataType(DataType.Password)]
		public string Sifre { get; set; }

		[Required, MaxLength(15), DisplayName("Kullanıcı Adı")]
		public string KullaniciAdi { get; set; }

		[DisplayName("Profil Fotoğrafı"), DataType(DataType.ImageUrl)]
		public string ProfilFotografi { get; set; }

		[MaxLength(25), DisplayName("Ad")]
		public string Ad { get; set; }

		[MaxLength(25), DisplayName("Soyad")]
		public string Soyad { get; set; }

		[DisplayName("Kayıt Olma Tarihi")]
		public DateTime KayitTarihi { get; set; }

		public bool Etkin { get; set; }

		public Guid Guid { get; set; }

		public virtual KullaniciYetki KullaniciYetki { get; set; }
	}
}
