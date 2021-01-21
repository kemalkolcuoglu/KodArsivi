using IcerikYonetimSistemi.IslemKatmani;
using IcerikYonetimSistemi.VarlikKatmani;
using IcerikYonetimSistemi.Web.Filters;
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
		FotografGaleriIslemleri fotografGaleriIslemleri = new FotografGaleriIslemleri();
		SayfaAltIcerikIslemleri sayfaAltIcerikIslemleri = new SayfaAltIcerikIslemleri();
		SayfaIcerikGaleriIslemleri sayfaIcerikGaleriIslemleri = new SayfaIcerikGaleriIslemleri();
		SayfaIcerikYorumIslemleri sayfaIcerikYorumIslemleri = new SayfaIcerikYorumIslemleri();
		SayfaIcerikIslemleri sayfaIcerikIslemleri = new SayfaIcerikIslemleri();
		SayfaIslemleri sayfaIslemleri = new SayfaIslemleri();

		public ActionResult Sayfa(int? id)
		{
			if (id == null)
				return RedirectToAction("Anasayfa", "Ev");

			Sayfalar sayfa = sayfaIslemleri.Bul(x => x.SayfaID == id);
			List<SayfaIcerik> icerik = sayfaIcerikIslemleri.VeriListesi(x => x.SayfaID == id);

			if (sayfa == null)
				return HttpNotFound();

			if(icerik.Count == 1)
				return RedirectToAction("SayfaIcerik", new { icerik[0].SayfaIcerikID });

			return View(sayfa);
		}

		public ActionResult SayfaIcerik(int? id)
		{
			if (id == null)
				return RedirectToAction("Anasayfa", "Ev");

			SayfaIcerik sayfaIcerik = sayfaIcerikIslemleri.Bul(x => x.SayfaIcerikID == id);

			if (sayfaIcerik == null)
				return HttpNotFound();

			return View(sayfaIcerik);
		}

		public ActionResult SayfaAltIcerik(int? id)
		{
			if (id == null )
				return RedirectToAction("Anasayfa", "Ev");

			List<SayfaAltIcerik> sayfaAltIcerik = sayfaAltIcerikIslemleri.VeriListesi(x => x.SayfaIcerikID == id);

			if (sayfaAltIcerik == null)
				return HttpNotFound();

			return PartialView("_SayfaAltIcerikPartial", sayfaAltIcerik);
		}

		public ActionResult SayfaIcerikGaleri(int? id)
		{
			if (id == null)
				return RedirectToAction("Anasayfa", "Ev");

			List<SayfaIcerikGaleri> sayfaIcerikGaleri = sayfaIcerikGaleriIslemleri.VeriListesi(x => x.SayfaIcerikID == id);

			if (sayfaIcerikGaleri == null)
				return HttpNotFound();

			return PartialView("_SayfaIcerikGaleriPartial", sayfaIcerikGaleri);
		}

		public ActionResult SayfaIcerikYorum(int? id)
		{
			if (id == null )
				return RedirectToAction("Anasayfa", "Ev");

			List<SayfaIcerikYorum> sayfaIcerikYorum = sayfaIcerikYorumIslemleri.VeriListesi(x => x.SayfaIcerikID == id);

			if (sayfaIcerikYorum == null)
				return HttpNotFound();

			return PartialView("_SayfaIcerikYorumPartial", sayfaIcerikYorum);
		}

		public ActionResult FotografGaleri()
		{
			List<FotografGaleri> foto = fotografGaleriIslemleri.VeriListesi();

			if (foto == null)
				return HttpNotFound();

			return View(foto);
		}
	}
}