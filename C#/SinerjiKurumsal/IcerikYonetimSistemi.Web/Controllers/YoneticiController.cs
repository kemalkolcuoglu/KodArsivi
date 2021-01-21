using IcerikYonetimSistemi.IslemKatmani;
using IcerikYonetimSistemi.VarlikKatmani;
using IcerikYonetimSistemi.Web.Filters;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IcerikYonetimSistemi.Web.Controllers
{
	[SiteYoneticisi]
	[HataFilter]
	public class YoneticiController : Controller
	{
		FormIslemleri formIslemleri = new FormIslemleri();
		FotografGaleriIslemleri fotografGaleriIslemleri = new FotografGaleriIslemleri();
		KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
		KullaniciYetkiIslemleri kullaniciYetkiIslemleri = new KullaniciYetkiIslemleri();
		SayfaAltIcerikIslemleri sayfaAltIcerikIslemleri = new SayfaAltIcerikIslemleri();
		SayfaIcerikGaleriIslemleri sayfaIcerikGaleriIslemleri = new SayfaIcerikGaleriIslemleri();
		SayfaIcerikIslemleri sayfaIcerikIslemleri = new SayfaIcerikIslemleri();
		SayfaIcerikYorumIslemleri sayfaIcerikYorumIslemleri = new SayfaIcerikYorumIslemleri();
		SayfaIslemleri sayfaIslemleri = new SayfaIslemleri();

		public ActionResult Anasayfa()
		{
			return View();
		}

		public ActionResult DosyaYukle()
		{
			return View();
		}

		[HttpPost]
		public ActionResult DosyaYukle(HttpPostedFileBase file)
		{
			try
			{
				if (file.ContentLength > 0)
				{
					string _FileName = Path.GetFileName(file.FileName);
					string _path = Path.Combine(Server.MapPath("~/Files"), _FileName);
					file.SaveAs(_path);
				}
				ViewBag.Message = "Dosya Yükleme İşlemi Başarılı!";
				return View();
			}
			catch
			{
				ViewBag.Hata = "Dosya Yükleme İşlemi Başarısız!";
				return View();
			}
		}

		public ActionResult GorselYukle()
		{
			return View(fotografGaleriIslemleri.VeriListesi());
		}

		[HttpPost]
		public ActionResult GorselYukle(HttpPostedFileBase fotograf)
		{
			try
			{
				if (fotograf != null && (fotograf.ContentType == "image/jpeg" || fotograf.ContentType == "image/jpg" || fotograf.ContentType == "image/png"))
				{
					string filename = Path.GetFileName(fotograf.FileName);
					string _path = Path.Combine(Server.MapPath("~/Images/blog"), filename);
					fotograf.SaveAs(_path);
					FotografGaleri foto = new FotografGaleri()
					{
						OlusturmaTarihi = DateTime.Now,
						DuzenlemeTarihi = DateTime.Now,
						Adres = "Images/blog/" + filename,
						Baslik = filename,
						Detay = filename,
						Etkin = true
					};
					fotografGaleriIslemleri.Ekle(foto);
					ViewBag.Message = "Dosya Yükleme İşlemi Başarılı!";
				}
				else
					throw new Exception();
			}
			catch
			{
				ViewBag.Hata = "Dosya Yükleme İşlemi Başarısız!";
			}
			return View(fotografGaleriIslemleri.VeriListesi());
		}

		public ActionResult GorselSil(int? id)
		{
			try
			{
				if (id != null)
				{
					FotografGaleri foto = fotografGaleriIslemleri.Bul(x => x.GorselID == id);
					System.IO.File.Delete("~/" + foto.Adres);
					fotografGaleriIslemleri.Sil(foto);
					TempData["Mesaj"] = "Görsel silme işlemi başarıyla gerçekleştirildi";
				}
				else
					throw new Exception();
			}
			catch (Exception exp)
			{
				TempData["Mesaj"] = "İşlem Gerçekleştirilemedi! Lütfen Tekrar Deneyiniz.";
			}

			return RedirectToAction("GorselYukle");
		}

		public ActionResult KullaniciYetki()
		{
			return View(kullaniciYetkiIslemleri.VeriListesi());
		}

		public ActionResult KullaniciYetkiEkle()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult KullaniciYetkiEkle(KullaniciYetki kullaniciYetki)
		{
			if (ModelState.IsValid)
			{
				kullaniciYetkiIslemleri.Ekle(kullaniciYetki);
				return RedirectToAction("KullaniciYetki");
			}

			return View(kullaniciYetki);
		}

		public ActionResult KullaniciYetkiGuncelle(int? id)
		{
			if (id == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			KullaniciYetki kullaniciYetki = kullaniciYetkiIslemleri.Bul(x => x.KullaniciYetkiID == id);

			if (kullaniciYetki == null)
				return HttpNotFound();

			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult KullaniciYetkiGuncelle(KullaniciYetki kullaniciYetki)
		{
			if (ModelState.IsValid)
			{
				kullaniciYetkiIslemleri.Guncelle(kullaniciYetki);
				return RedirectToAction("KullaniciYetki");
			}

			return View(kullaniciYetki);
		}

		public ActionResult KullaniciYetkiSil(int? id)
		{
			if (id == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			KullaniciYetki kullaniciYetki = kullaniciYetkiIslemleri.Bul(x => x.KullaniciYetkiID == id);

			if (kullaniciYetki == null)
				return HttpNotFound();

			return View();
		}

		[HttpPost, ActionName("KullaniciYetkiSil")]
		[ValidateAntiForgeryToken]
		public ActionResult KullaniciYetkiSil(int id)
		{
			kullaniciYetkiIslemleri.Sil(kullaniciYetkiIslemleri.Bul(x => x.KullaniciYetkiID == id));
			return RedirectToAction("KullaniciYetki");
		}

		public ActionResult Kullanici()
		{
			return View(kullaniciIslemleri.VeriListesi());
		}

		public ActionResult KullaniciEkle()
		{
			ViewData["kullaniciYetki"] = kullaniciIslemleri.Sorgu().Include(k => k.KullaniciYetki);
			SelectList yetkiler = new SelectList(kullaniciIslemleri.Sorgu().Include(k => k.KullaniciYetki), "KullaniciYetkiID", "KullaniciYetkiAdi");
			ViewData["kullaniciYetki"] = yetkiler;
			return View("KullaniciIslemi");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult KullaniciEkle(Kullanici kullanici)
		{
			if (ModelState.IsValid)
			{
				kullanici.Guid = Guid.NewGuid();
				kullaniciIslemleri.Ekle(kullanici);
				return RedirectToAction("Kullanici");
			}
			SelectList yetkiler = new SelectList(kullaniciIslemleri.Sorgu().Include(k => k.KullaniciYetki), "KullaniciYetkiID", "KullaniciYetkiAdi");
			ViewData["kullaniciYetki"] = yetkiler;

			return View("KullaniciIslemi", kullanici);
		}

		public ActionResult KullaniciDuzenle(int? id)
		{
			if (id == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			Kullanici kullanici = kullaniciIslemleri.Bul(x => x.KullaniciID == id);
			SelectList yetkiler = new SelectList(kullaniciIslemleri.Sorgu().Include(k => k.KullaniciYetki), "KullaniciYetkiID", "KullaniciYetkiAdi");
			ViewData["kullaniciYetki"] = yetkiler;

			if (kullanici == null)
				return HttpNotFound();

			return View("KullaniciIslemi", kullanici);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult KullaniciDuzenle(Kullanici kullanici)
		{
			if (ModelState.IsValid)
			{
				kullaniciIslemleri.Guncelle(kullanici);
				return RedirectToAction("Kullanici");
			}
			SelectList yetkiler = new SelectList(kullaniciIslemleri.Sorgu().Include(k => k.KullaniciYetki), "KullaniciYetkiID", "KullaniciYetkiAdi");
			ViewData["kullaniciYetki"] = yetkiler;

			return View("KullaniciIslemi", kullanici);
		}

		public ActionResult KullaniciSil(int? id)
		{
			if (id == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			Kullanici kullanici = kullaniciIslemleri.Bul(x => x.KullaniciID == id);

			if (kullanici == null)
				return HttpNotFound();

			return View();
		}

		[HttpPost, ActionName("KullaniciSil")]
		[ValidateAntiForgeryToken]
		public ActionResult KullaniciSil(int id)
		{
			kullaniciIslemleri.Sil(kullaniciIslemleri.Bul(x => x.KullaniciID == id));
			return RedirectToAction("Kullanici");
		}

		public ActionResult Sayfalar()
		{
			return View(sayfaIslemleri.VeriListesi());
		}

		public ActionResult Sayfa(int? sayfaId)
		{
			if (sayfaId == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			Sayfalar sayfa = sayfaIslemleri.Bul(x => x.SayfaID == sayfaId);

			if (sayfa == null)
				return HttpNotFound();

			return View(sayfa);
		}

		public ActionResult SayfaOlustur()
		{
			return View("SayfaIslemleri");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult SayfaOlustur(Sayfalar sayfalar)
		{
			if (ModelState.IsValid)
			{
				sayfaIslemleri.Ekle(sayfalar);
				return RedirectToAction("Sayfalar");
			}

			return View("SayfaIslemleri", sayfalar);
		}

		public ActionResult SayfaDuzenle(int? sayfaId)
		{
			if (sayfaId == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			Sayfalar sayfa = sayfaIslemleri.Bul(x => x.SayfaID == sayfaId);

			if (sayfa == null)
				return HttpNotFound();

			return View("SayfaIslemleri", sayfa);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult SayfaDuzenle(Sayfalar sayfalar)
		{
			if (ModelState.IsValid)
			{
				Sayfalar sayfa = sayfaIslemleri.Bul(x => x.SayfaID == sayfalar.SayfaID);
				sayfa.Ikon = sayfalar.Ikon;
				sayfa.SayfaBasligi = sayfalar.SayfaBasligi;
				sayfa.Etkin = sayfalar.Etkin;
				sayfaIslemleri.Guncelle(sayfa);
				return RedirectToAction("Sayfalar");
			}

			return View("SayfaIslemleri", sayfalar);
		}

		public ActionResult SayfaSil(int? sayfaId)
		{
			if (sayfaId == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			Sayfalar sayfa = sayfaIslemleri.Bul(x => x.SayfaID == sayfaId);

			if (sayfa == null)
				return HttpNotFound();
			// TODO : JQUERY ve AJAX ile görüntülemeden Düzeltme İşlemi
			return View(sayfa);
		}

		[HttpPost, ActionName("SayfaSil")]
		[ValidateAntiForgeryToken]
		public ActionResult SayfaSilOnay(int sayfaId)
		{
			sayfaIslemleri.Sil(sayfaIslemleri.Bul(x => x.SayfaID == sayfaId));
			return RedirectToAction("Sayfalar");
		}

		public ActionResult SayfaIcerik(int? sayfaId, int? icerikId)
		{
			if (sayfaId == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			ViewBag.sayfaId = sayfaId;

			if (icerikId == null)
				return PartialView("_SayfaIcerikPartial", sayfaIcerikIslemleri.VeriListesi(x => x.SayfaID == sayfaId));

			SayfaIcerik icerik = sayfaIcerikIslemleri.Bul(x => x.SayfaID == sayfaId && x.SayfaIcerikID == icerikId);

			return View(icerik);
		}

		public ActionResult SayfaIcerikOlustur(int? sayfaId)
		{
			return View("SayfaIcerikIslemleri");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[ValidateInput(false)]
		public ActionResult SayfaIcerikOlustur(int sayfaId, SayfaIcerik sayfaIcerik)
		{
			if (ModelState.IsValid)
			{
				Sayfalar sayfa = sayfaIslemleri.Bul(x => x.SayfaID == sayfaId);
				sayfaIcerik.SayfaID = sayfaId;
				sayfaIcerik.Sayfa = sayfa;
				sayfaIcerik.GosterimSirasi = sayfa.SayfaIcerik.Count + 1;
				sayfaIcerik.DuzenlemeTarihi = DateTime.Now;
				sayfaIcerik.OlusturmaTarihi = DateTime.Now;
				sayfaIcerikIslemleri.Ekle(sayfaIcerik);
				sayfa.SayfaIcerik.Add(sayfaIcerik);
				sayfaIslemleri.Kaydet();
				return RedirectToAction("Sayfa", new { sayfaId });
			}

			return View("SayfaIcerikIslemleri", sayfaIcerik);
		}

		public ActionResult SayfaIcerikDuzenle(int? sayfaId, int? icerikId)
		{
			if (sayfaId == null || icerikId == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			SayfaIcerik syficerik = sayfaIcerikIslemleri.Bul(x => x.SayfaID == sayfaId && x.SayfaIcerikID == icerikId);

			if (syficerik == null)
				return HttpNotFound();

			return View("SayfaIcerikIslemleri", syficerik);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[ValidateInput(false)]
		public ActionResult SayfaIcerikDuzenle(int? sayfaId, int? icerikId, SayfaIcerik sayfaIcerik)
		{
			if (ModelState.IsValid)
			{
				SayfaIcerik icerik = sayfaIcerikIslemleri.Bul(x => x.SayfaIcerikID == icerikId);
				icerik.DuzenlemeTarihi = DateTime.Now;
				icerik.Baslik = sayfaIcerik.Baslik;
				icerik.Detay = sayfaIcerik.Detay;
				icerik.Etkin = sayfaIcerik.Etkin;
				icerik.Gorsel = sayfaIcerik.Gorsel;
				icerik.Ikon = sayfaIcerik.Ikon;
				icerik.EkAlan1 = sayfaIcerik.EkAlan1;
				icerik.EkAlan2 = sayfaIcerik.EkAlan2;
				icerik.Yorum = sayfaIcerik.Yorum;
				sayfaIcerikIslemleri.Guncelle(icerik);
				return RedirectToAction("Sayfa", new { sayfaId = icerik.SayfaID });
			}

			return View("SayfaIcerikIslemleri", sayfaIcerik);
		}

		public ActionResult SayfaIcerikSil(int? sayfaId, int? icerikId)
		{   // TODO : JQUERY ve AJAX ile görüntülemeden Düzeltme İşlemi
			if (sayfaId == null || icerikId == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			SayfaIcerik syficerik = sayfaIcerikIslemleri.Bul(x => x.SayfaID == sayfaId && x.SayfaIcerikID == icerikId);

			if (syficerik == null)
				return HttpNotFound();

			return View(syficerik);
		}

		[HttpPost, ActionName("SayfaIcerikSil")]
		[ValidateAntiForgeryToken]
		public ActionResult SayfaIcerikSilOnay(int sayfaId, int icerikId)
		{
			SayfaIcerik sayfaIcerik = sayfaIcerikIslemleri.Bul(x => x.SayfaID == sayfaId && x.SayfaIcerikID == icerikId);
			sayfaIcerikIslemleri.Sil(sayfaIcerik);
			return RedirectToAction("Sayfa", new { sayfaId = sayfaId });
		}

		public ActionResult SayfaAltIcerik(int? sayfaId, int? icerikId, int? altId)
		{
			if (sayfaId == null || icerikId == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			ViewBag.sayfaId = sayfaId;
			ViewBag.icerikId = icerikId;

			if (altId == null)
				return PartialView("_SayfaAltIcerikPartial", sayfaAltIcerikIslemleri.VeriListesi(x => x.SayfaID == sayfaId && x.SayfaIcerikID == icerikId));

			SayfaAltIcerik altIcerik = sayfaAltIcerikIslemleri.Bul(x => x.SayfaID == sayfaId && x.SayfaIcerikID == icerikId && x.SayfaAltIcerikID == altId);

			return View(altIcerik);
		}

		public ActionResult SayfaAltIcerikOlustur(int? sayfaId, int? icerikId)
		{
			return View("SayfaAltIcerikIslemleri");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[ValidateInput(false)]
		public ActionResult SayfaAltIcerikOlustur(int sayfaId, int icerikId, SayfaAltIcerik sayfaAltIcerik)
		{
			if (ModelState.IsValid)
			{
				Sayfalar sayfa = sayfaIslemleri.Bul(x => x.SayfaID == sayfaId);
				SayfaIcerik icerik = sayfaIcerikIslemleri.Bul(x => x.SayfaID == sayfaId && x.SayfaIcerikID == icerikId);
				sayfaAltIcerik.OlusturmaTarihi = DateTime.Now;
				sayfaAltIcerik.DuzenlemeTarihi = DateTime.Now;
				sayfaAltIcerik.SayfaID = sayfaId;
				sayfaAltIcerik.Sayfa = sayfa;
				sayfaAltIcerik.SayfaIcerikID = icerikId;
				sayfaAltIcerik.SayfaIcerik = icerik;
				sayfaAltIcerikIslemleri.Ekle(sayfaAltIcerik);
				icerik.SayfaAltIcerik.Add(sayfaAltIcerik);
				sayfaIcerikIslemleri.Kaydet();
				return RedirectToAction("SayfaIcerik", new { sayfaId = sayfaId, icerikId = icerikId });
			}

			return View("SayfaAltIcerikIslemleri", sayfaAltIcerik);
		}

		public ActionResult SayfaAltIcerikDuzenle(int? sayfaId, int? icerikId, int? altId)
		{
			if (sayfaId == null || icerikId == null || altId == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			SayfaAltIcerik syficerik = sayfaAltIcerikIslemleri.Bul(x => x.SayfaID == sayfaId && x.SayfaIcerikID == icerikId && x.SayfaAltIcerikID == altId);

			if (syficerik == null)
				return HttpNotFound();

			return View("SayfaAltIcerikIslemleri", syficerik);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[ValidateInput(false)]
		public ActionResult SayfaAltIcerikDuzenle(int? sayfaId, int? icerikId, int? altId, SayfaAltIcerik sayfaAltIcerik)
		{
			if (ModelState.IsValid)
			{
				SayfaAltIcerik altIcerik = sayfaAltIcerikIslemleri.Bul(x => x.SayfaAltIcerikID == altId);
				altIcerik.Baslik = sayfaAltIcerik.Baslik;
				altIcerik.Detay = sayfaAltIcerik.Detay;
				altIcerik.Etkin = sayfaAltIcerik.Etkin;
				altIcerik.Gorsel = sayfaAltIcerik.Gorsel;
				altIcerik.Ikon = sayfaAltIcerik.Ikon;
				altIcerik.EkAlan1 = sayfaAltIcerik.EkAlan1;
				altIcerik.EkAlan2 = sayfaAltIcerik.EkAlan2;
				altIcerik.DuzenlemeTarihi = DateTime.Now;
				sayfaAltIcerikIslemleri.Guncelle(sayfaAltIcerik);
				return RedirectToAction("SayfaIcerik", new { sayfaId = sayfaId, icerikId = icerikId });
			}

			return View("SayfaAltIcerikIslemleri", sayfaAltIcerik);
		}

		public ActionResult SayfaAltIcerikSil(int? sayfaId, int? icerikId, int? altId)
		{
			if (sayfaId == null || icerikId == null || altId == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			SayfaAltIcerik syficerik = sayfaAltIcerikIslemleri.Bul(x => x.SayfaID == sayfaId && x.SayfaIcerikID == icerikId && x.SayfaAltIcerikID == altId);

			if (syficerik == null)
				return HttpNotFound();
			// TODO : JQUERY ve AJAX ile görüntülemeden Düzeltme İşlemi
			return View(syficerik);
		}

		[HttpPost, ActionName("SayfaAltIcerikSil")]
		[ValidateAntiForgeryToken]
		public ActionResult SayfaAltIcerikSilOnay(int sayfaId, int icerikId, int altId)
		{// TODO : JQUERY ve AJAX ile görüntülemeden Düzeltme İşlemi
			sayfaAltIcerikIslemleri.Sil(sayfaAltIcerikIslemleri.Bul(x => x.SayfaAltIcerikID == altId));
			return RedirectToAction("SayfaIcerik", new { sayfaId = sayfaId, icerikId = icerikId });
		}

		public ActionResult SayfaIcerikYorum(int? sayfaId, int? icerikId)
		{
			if (sayfaId == null || icerikId == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			List<SayfaIcerikYorum> yorum = sayfaIcerikYorumIslemleri.VeriListesi(x => x.SayfaID == sayfaId && x.SayfaIcerikID == icerikId);

			return PartialView("_SayfaIcerikYorumPartial", yorum);
		}

		public ActionResult SayfaIcerikYorumDuzenle(int? sayfaId, int? icerikId, int? yorumId)
		{
			if (sayfaId == null || icerikId == null || yorumId == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			SayfaIcerikYorum yorum = sayfaIcerikYorumIslemleri.Bul(x => x.SayfaID == sayfaId && x.SayfaIcerikID == icerikId && x.SayfaIcerikYorumID == yorumId);

			// TODO : JQUERY ve AJAX ile görüntülemeden Düzeltme İşlemi
			return Content(yorum.YorumMetni);
		}

		public ActionResult FotografGaleri()
		{
			return View(fotografGaleriIslemleri.VeriListesi());
		}

		public ActionResult FotografEkle()
		{
			return View("FotografIslemleri");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult FotografEkle(FotografGaleri fotogaleri)
		{
			if (ModelState.IsValid)
			{
				fotogaleri.OlusturmaTarihi = DateTime.Now;
				fotogaleri.DuzenlemeTarihi = DateTime.Now;
				fotografGaleriIslemleri.Ekle(fotogaleri);
			}

			return View("FotografIslemleri", fotogaleri);
		}

		public ActionResult FotografDuzenle(int? id)
		{
			if (id == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			FotografGaleri foto = fotografGaleriIslemleri.Bul(x => x.GorselID == id);

			if (foto == null)
				return HttpNotFound();

			return View("FotografIslemleri", foto);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult FotografDuzenle(FotografGaleri fotoGaleri)
		{
			if (ModelState.IsValid)
			{
				FotografGaleri foto = fotografGaleriIslemleri.Bul(x => x.GorselID == fotoGaleri.GorselID);
				foto.Baslik = fotoGaleri.Baslik;
				foto.Detay = fotoGaleri.Detay;
				foto.Adres = fotoGaleri.Adres;
				foto.Etkin = fotoGaleri.Etkin;
				foto.DuzenlemeTarihi = DateTime.Now;
				fotografGaleriIslemleri.Guncelle(foto);
				return RedirectToAction("FotografGaleri");
			}

			return View("FotografIslemleri", fotoGaleri);
		}

		public ActionResult FotografSil(int? id)
		{
			if (id == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			FotografGaleri foto = fotografGaleriIslemleri.Bul(x => x.GorselID == id);

			if (foto == null)
				return HttpNotFound();

			return View(foto);
		}

		[HttpPost, ActionName("FotografSil")]
		[ValidateAntiForgeryToken]
		public ActionResult FotografSilOnay(int id)
		{
			fotografGaleriIslemleri.Sil(fotografGaleriIslemleri.Bul(x => x.GorselID == id));
			return RedirectToAction("FotografGaleri");
		}

		public ActionResult GelenFormlar()
		{
			return View();
		}

		public ActionResult FormSil(int? id)
		{
			if (id == null)
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			FotografGaleri foto = fotografGaleriIslemleri.Bul(x => x.GorselID == id);
			Formlar formlar = formIslemleri.Bul(x => x.FormID == id);

			if (foto == null)
				return HttpNotFound();

			return View();
		}

		[HttpPost, ActionName("FormSil")]
		[ValidateAntiForgeryToken]
		public ActionResult FormSil(int id)
		{
			formIslemleri.Sil(formIslemleri.Bul(x => x.FormID == id));
			return RedirectToAction("GelenFormlar");
		}

		//public ActionResult SMSGonder()
		//{
		//	return View();
		//}

		//[HttpPost]
		//public ActionResult SMSGonder(string telNo, string mesaj)
		//{
		//	mesaj = mesaj.Replace(" ", "%20");
		//	return Redirect("https://api.netgsm.com.tr/sms/send/get/?usercode=8503051430&password=SELCUK&gsmno=" + telNo + "&message=" + mesaj + "&msgheader=INOVATEK&dil=TR");
		//}
	}
}