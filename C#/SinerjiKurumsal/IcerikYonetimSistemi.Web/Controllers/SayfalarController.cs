using IcerikYonetimSistemi.IslemKatmani;
using IcerikYonetimSistemi.VarlikKatmani;
using IcerikYonetimSistemi.Web.Filters;
using IcerikYonetimSistemi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IcerikYonetimSistemi.Web.Controllers
{
	[HataFilter]
	public class SayfalarController : Controller
	{

		FormIslemleri formIslemleri = new FormIslemleri();
		FotografGaleriIslemleri fotografGaleriIslemleri = new FotografGaleriIslemleri();
		SayfaAltIcerikIslemleri sayfaAltIcerikIslemleri = new SayfaAltIcerikIslemleri();
		SayfaIcerikGaleriIslemleri sayfaIcerikGaleriIslemleri = new SayfaIcerikGaleriIslemleri();
		SayfaIcerikYorumIslemleri sayfaIcerikYorumIslemleri = new SayfaIcerikYorumIslemleri();
		SayfaIcerikIslemleri sayfaIcerikIslemleri = new SayfaIcerikIslemleri();
		SayfaIslemleri sayfaIslemleri = new SayfaIslemleri();

		public ActionResult Iletisim()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Iletisim(Formlar form)
		{
			if(ModelState.IsValid)
			{
				formIslemleri.Ekle(form);
				ViewBag.Mesaj = "Mesajınız İletilmiştir!";
			}
			return View(form);
		}

		public ActionResult Basvurular()
		{
			return View();
		}

		public ActionResult OgrenciBasvuru()
		{
			return PartialView("OgrenciBasvuru");
		}

		[HttpPost]
		public ActionResult OgrenciBasvuru(OgrenciFormu ogrenci)
		{
			return PartialView("OgrenciBasvuru");
		}

		public ActionResult KulupBasvuru()
		{
			return PartialView("KulupBasvuru");
		}

		[HttpPost]
		public ActionResult KulupBasvuru(KulupFormu kulup)
		{
			return PartialView("KulupBasvuru");
		}

		public ActionResult KurumBasvuru()
		{
			return PartialView("KurumBasvuru");
		}

		[HttpPost]
		public ActionResult KurumBasvuru(KurumFormu kurum)
		{
			return PartialView("KurumBasvuru");
		}

		public ActionResult Sayfa(int? id)
		{
			if (id == null)
				return RedirectToAction("Anasayfa", "Ev");

			Sayfalar sayfa = sayfaIslemleri.Bul(x => x.SayfaID == id);

			if (sayfa != null || sayfa.Etkin)
			{
				List<SayfaIcerik> icerik = sayfaIcerikIslemleri.VeriListesi(x => x.SayfaID == id);

				if (icerik.Count == 1)
					return RedirectToAction("Icerik", new { id = icerik[0].SayfaIcerikID });

				return View(sayfa);
			}
			return RedirectToAction("Anasayfa", "Ev");
		}

		public ActionResult Icerik(int? id)
		{
			if (id == null)
				return RedirectToAction("Anasayfa", "Ev");

			SayfaIcerik sayfaIcerik = sayfaIcerikIslemleri.Bul(x => x.SayfaIcerikID == id);

			if(sayfaIcerik != null || sayfaIcerik.Etkin)
				return View("SayfaIcerik", sayfaIcerik);

			return RedirectToAction("Anasayfa", "Ev");
		}

		private ActionResult SayfaAltIcerik(int? id)
		{
			if (id == null )
				return RedirectToAction("Anasayfa", "Ev");

			List<SayfaAltIcerik> sayfaAltIcerik = sayfaAltIcerikIslemleri.VeriListesi(x => x.SayfaIcerikID == id && x.Etkin);

			if (sayfaAltIcerik == null)
				return HttpNotFound();

			return PartialView("_SayfaAltIcerikPartial", sayfaAltIcerik);
		}

		private ActionResult SayfaIcerikGaleri(int? id)
		{
			if (id == null)
				return RedirectToAction("Anasayfa", "Ev");

			List<SayfaIcerikGaleri> sayfaIcerikGaleri = sayfaIcerikGaleriIslemleri.VeriListesi(x => x.SayfaIcerikID == id && x.Etkin);

			if (sayfaIcerikGaleri == null)
				return HttpNotFound();

			return PartialView("_SayfaIcerikGaleriPartial", sayfaIcerikGaleri);
		}

		private ActionResult SayfaIcerikYorum(int? id)
		{
			if (id == null )
				return RedirectToAction("Anasayfa", "Ev");

			List<SayfaIcerikYorum> sayfaIcerikYorum = sayfaIcerikYorumIslemleri.VeriListesi(x => x.SayfaIcerikID == id && x.Etkin);

			if (sayfaIcerikYorum == null)
				return HttpNotFound();

			return PartialView("_SayfaIcerikYorumPartial", sayfaIcerikYorum);
		}

		public ActionResult FotografGaleri(int? id)
		{
			List<SayfaAltIcerik> foto = sayfaAltIcerikIslemleri.VeriListesi(x => x.SayfaIcerikID == id && x.Etkin);

			if (foto == null)
				return HttpNotFound();

			return View(foto);
		}
	}
}