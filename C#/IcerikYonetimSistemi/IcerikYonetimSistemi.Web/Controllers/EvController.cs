using IcerikYonetimSistemi.IslemKatmani;
using IcerikYonetimSistemi.VarlikKatmani;
using IcerikYonetimSistemi.VarlikKatmani.EkModel;
using IcerikYonetimSistemi.Web.Filters;
using IcerikYonetimSistemi.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IcerikYonetimSistemi.Web.Controllers
{
	[HataFilter]
    public class EvController : Controller
    {
		KullaniciIslemleri ki = new KullaniciIslemleri();
		SayfaIslemleri si = new SayfaIslemleri();
		SayfaIcerikIslemleri sii = new SayfaIcerikIslemleri();

		public ActionResult Anasayfa()
        {
			si.VeriListesi();
            return View();
        }

		public ActionResult Profil()
		{
			Kullanici k = Session["giris"] as Kullanici;
			IslemKatmaniOgesi<Kullanici> iko = ki.KullaniciyiGetir(k.KullaniciID);

			if(iko.Hatalar.Count > 0)
			{
				iko.Hatalar.ForEach(x => ModelState.AddModelError("",x));
			}
			return View(iko.Varlik);
		}

		public ActionResult ProfiliDuzenle()
		{
			return View();
		}

		public ActionResult KullaniciGirisi()
		{
			if (Session["giris"] != null)
				return RedirectToAction("ProfiliDuzenle");

			return View();
		}

		[HttpPost]
		public ActionResult KullaniciGirisi(KullaniciGiris kullaniciGiris)
		{
			if (ModelState.IsValid)
			{
				IslemKatmaniOgesi<Kullanici> iko = ki.KullaniciGirisIslemleri(kullaniciGiris);

				if(iko.Hatalar.Count > 0)
				{
					iko.Hatalar.ForEach(x => ModelState.AddModelError("", x));
					return View(kullaniciGiris);
				}
				Session["giris"] = iko.Varlik as Kullanici;

				return RedirectToAction("Anasayfa");
			}
			return View(kullaniciGiris);
		}

		public ActionResult KayitOl()
		{
			if (Session["giris"] != null)
				return RedirectToAction("ProfiliDuzenle");

			return View();
		}

		[HttpPost]
		public ActionResult KayitOl(KullaniciKayit kullaniciKayit)
		{
			if(ModelState.IsValid)
			{
				IslemKatmaniOgesi<Kullanici> iko = ki.KullaniciKayitIslemleri(kullaniciKayit);

				if (iko.Hatalar.Count > 0)
				{
					iko.Hatalar.ForEach(x => ModelState.AddModelError("", x));
					return View(kullaniciKayit);
				}

				NotifyPageModel npm = new NotifyPageModel
				{
					Header = "Kayıt İşlemi Başarılı",
					SayfaBasligi = "Kullanıcı Kaydı Gerçekleşti!",
					SayfaMetni = "E-Posta adresinize gelen aktivasyon maili ile hesabınızı aktive edebilirsiniz",
					Ikon = "glyphicon glyphicon-ok",
					YonlendirmeEtkin = true,
					YonlendirmeUri = "/Ev/Anasayfa",
					Liste = iko.Hatalar
				};

				TempData["npm"] = npm as NotifyPageModel;

				return RedirectToAction("NotifyPage");
			}

			return View(kullaniciKayit);
		}

		public ActionResult NotifyPage()
		{
			if (TempData["npm"] == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			NotifyPageModel model = TempData["npm"] as NotifyPageModel;
			return View(model);
		}

		public ActionResult KullaniciAktivasyonu(Guid id)
		{
			NotifyPageModel npm;
			IslemKatmaniOgesi<Kullanici> iko = ki.KullaniciAktivasyonIslemleri(id);
			
			if(iko.Hatalar.Count > 0)
			{
				npm = new NotifyPageModel
				{
					Liste = iko.Hatalar,
					Header = "Hatalı İşlem!",
					SayfaBasligi = "Geçersiz Aktivasyon Kodu",
					SayfaMetni = "İşlem sürdürülemedi. Oluşan hatalar aşağıda listelenmiştir.",
					Ikon = "glyphicon glyphicon-remove",
					YonlendirmeEtkin = true,
					YonlendirmeUri = "/Ev/Anasayfa",
					SayfaRengi = "danger"
				};

				TempData["npm"] = npm as NotifyPageModel;

				return RedirectToAction("NotifyPage");
			}
			
			npm = new NotifyPageModel
			{
				Liste = iko.Hatalar,
				Header = "Aktivasyon Başarılı!",
				SayfaBasligi = "Aktivasyon",
				SayfaMetni = "Aktivasyon işleminiz başarıyla gerçekleşmiştir. Lütfen giriş yapınız",
				Ikon = "glyphicon glyphicon-ok",
				YonlendirmeEtkin = true,
				YonlendirmeUri = "/Ev/Anasayfa"
			};

			TempData["npm"] = npm as NotifyPageModel;

			return RedirectToAction("NotifyPage");
		}

		public ActionResult CikisYap()
		{
			Session.Clear();
			return RedirectToAction("Anasayfa");
		}

		public ActionResult Hata()
		{
			return View();
		}
	}
}