using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzgulTekel.VarlikKatmani
{
	public class Kullanici
	{
		[Key, DisplayName("Kullanıcı ID")]
		public int KullaniciID { get; set; }

		[DisplayName("Yetki")]
		public string Yetki { get; set; }

		[DisplayName("Kullanıcı Adı")]
		public string KullaniciAdi { get; set; }

		[DisplayName("Şifre")]
		public string Sifre { get; set; }
	}
}
