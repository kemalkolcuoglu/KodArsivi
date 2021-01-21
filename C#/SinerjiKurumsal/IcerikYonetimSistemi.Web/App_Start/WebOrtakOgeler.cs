using IcerikYonetimSistemi.OrtakKatman;
using IcerikYonetimSistemi.VarlikKatmani;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IcerikYonetimSistemi.Web.App_Start
{
	public class WebOrtakOgeler : IKullanici
	{
		public string KullaniciAdiAl()
		{
			if(HttpContext.Current.Session["giris"] != null)
			{
				Kullanici kullanici = HttpContext.Current.Session["giris"] as Kullanici;
				return kullanici.KullaniciAdi;
			}
			return "system";
		}
	}
}