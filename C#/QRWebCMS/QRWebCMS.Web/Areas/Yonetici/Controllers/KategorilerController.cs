using QRWebCMS.Web.App_Start;
using QRWebCMS.Web.Filters;
using QRWebCMS.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QRWebCMS.Web.Areas.Yonetici.Controllers
{
    [YetkiFilter]
    [YoneticiHataFilter]
    public class KategorilerController : Controller
    {
        public ActionResult Anasayfa()
        {
            ViewData["GaleriKategorileri"] = Tanimlamalar.galeriKategoriIslemleri.VeriGetir("1 = 1");
            ViewData["SlideKategorileri"] = Tanimlamalar.slideKategoriIslemleri.VeriGetir("1 = 1");
            ViewData["UrunKategorileri"] = Tanimlamalar.urunKategoriIslemleri.VeriGetir("1 = 1");
            return View();
        }

        public JsonResult GaleriKategori()
        { 
            return Json(Tanimlamalar.galeriIslemleri.VeriGetir("1 = 1"));
        }

        public JsonResult SlideKategori()
        {
            return Json(Tanimlamalar.slideKategoriIslemleri.VeriGetir("1 = 1"));
        }

        public JsonResult UrunKategori()
        {
            return Json(Tanimlamalar.urunKategoriIslemleri.VeriGetir("1 = 1"));
        }

        #region Ekleme

        public ActionResult GaleriKategoriEkle()
        {
            return PartialView("_GaleriKategoriEkle");
        }

        public ActionResult SlideKategoriEkle()
        {
            return PartialView("_SlideKategoriEkle");
        }

        public ActionResult UrunKategoriEkle()
        {
            return PartialView("_UrunKategoriEkle");
        }

        [HttpPost]
        public ActionResult GaleriKategoriEkle(GaleriKategori galeriKategori)
        {
            try
            {
                Tanimlamalar.galeriKategoriIslemleri.Ekle(galeriKategori);

                return RedirectToAction(nameof(Anasayfa));
            }
            catch
            {
                return PartialView("_GaleriKategoriEkle", galeriKategori);
            }
        }

        [HttpPost]
        public ActionResult SlideKategoriEkle(SlideKategori slideKategori)
        {
            try
            {
                Tanimlamalar.slideKategoriIslemleri.Ekle(slideKategori);

                return RedirectToAction(nameof(Anasayfa));
            }
            catch
            {
                return PartialView("_SlideKategoriEkle", slideKategori);
            }
        }

        [HttpPost]
        public ActionResult UrunKategoriEkle(UrunKategori urunKategori)
        {
            try
            {
                Tanimlamalar.urunKategoriIslemleri.Ekle(urunKategori);

                return RedirectToAction(nameof(Anasayfa));
            }
            catch
            {
                return PartialView("_UrunKategoriEkle", urunKategori);
            }
        }

        #endregion

        #region Duzenleme

        public ActionResult GaleriKategoriDuzenle(int id)
        {
            return View(Tanimlamalar.galeriKategoriIslemleri.Bul("GaleriKategoriID = " + id));
        }

        public ActionResult SlideKategoriDuzenle(int id)
        {
            return View(Tanimlamalar.slideKategoriIslemleri.Bul("SlideKategoriID = " + id));
        }
        public ActionResult UrunKategoriDuzenle(int id)
        {
            return View(Tanimlamalar.urunKategoriIslemleri.Bul("UrunKategoriID = " + id));
        }

        [HttpPost]
        public ActionResult GaleriKategoriDuzenle(int id, GaleriKategori yeniKategori)
        {
            try
            {
                yeniKategori.GaleriKategoriID = id;
                Tanimlamalar.galeriKategoriIslemleri.Guncelle("GaleriKategoriID = " + id, yeniKategori);

                return RedirectToAction(nameof(Anasayfa));
            }
            catch
            {
                return View(yeniKategori);
            }
        }

        [HttpPost]
        public ActionResult SlideKategoriDuzenle(int id, SlideKategori yeniKategori)
        {
            try
            {
                yeniKategori.SlideKategoriID = id;
                Tanimlamalar.slideKategoriIslemleri.Guncelle("SlideKategoriID = " + id, yeniKategori);

                return RedirectToAction(nameof(Anasayfa));
            }
            catch
            {
                return View(yeniKategori);
            }
        }

        [HttpPost]
        public ActionResult UrunKategoriDuzenle(int id, UrunKategori yeniKategori)
        {
            try
            {
                yeniKategori.UrunKategoriID = id;
                Tanimlamalar.urunKategoriIslemleri.Guncelle("UrunKategoriID = " + id, yeniKategori);

                return RedirectToAction(nameof(Anasayfa));
            }
            catch
            {
                return View(yeniKategori);
            }
        }

        #endregion

        #region Silme

        public ActionResult GaleriKategoriSil(int id)
        {
            List<Galeri> galeri = Tanimlamalar.galeriIslemleri.VeriGetir("GaleriKategoriID = " + id);
            ViewBag.Sayi = galeri.Count;
            return PartialView("_GaleriKategoriSil");
        }

        [HttpPost]
        public ActionResult GaleriKategoriSil(int id, GaleriKategori kategori)
        {
            try
            {
                List<SayfaListe> sayfaListe = Tanimlamalar.sayfaListeIslemleri.VeriGetir("NitelikTablosu = 'GaleriKategori' And NitelikID = " + id);
                if (sayfaListe.Count > 0)
                {
                    foreach (var item in sayfaListe)
                    {
                        Tanimlamalar.sayfaListeIslemleri.Sil("SayfaListeID = " + item.SayfaListeID);
                    }
                }

                Tanimlamalar.galeriKategoriIslemleri.Sil("GaleriKategoriID = " + id);
            }
            catch
            {
                ViewBag.Hata = "Silme İşlemi Gerçekleştirilemedi";
            }
            return RedirectToAction(nameof(Anasayfa));
        }

        public ActionResult SlideKategoriSil(int id)
        {
            List<Slide> slide = Tanimlamalar.slideIslemleri.VeriGetir("SlideKategoriID = " + id);
            ViewBag.Sayi = slide.Count;
            return PartialView("_SlideKategoriSil");
        }

        [HttpPost]
        public ActionResult SlideKategoriSil(int id, SlideKategori kategori)
        {
            try
            {
                List<SayfaListe> sayfaListe = Tanimlamalar.sayfaListeIslemleri.VeriGetir("NitelikTablosu = 'SlideKategori' And NitelikID = " + id);
                if (sayfaListe.Count > 0)
                {
                    foreach (var item in sayfaListe)
                    {
                        Tanimlamalar.sayfaListeIslemleri.Sil("SayfaListeID = " + item.SayfaListeID);
                    }
                }

                Tanimlamalar.slideKategoriIslemleri.Sil("SlideKategoriID = " + id);
            }
            catch
            {
                ViewBag.Hata = "Silme İşlemi Gerçekleştirilemedi";
            }
            return RedirectToAction(nameof(Anasayfa));
        }

        public ActionResult UrunKategoriSil(int id)
        {
            List<Urun> urun = Tanimlamalar.urunIslemleri.VeriGetir("UrunKategoriID = " + id);
            ViewBag.Sayi = urun.Count;
            return PartialView("_UrunKategoriSil");
        }

        [HttpPost]
        public ActionResult UrunKategoriSil(int id, UrunKategori kategori)
        {
            try
            {
                List<SayfaListe> sayfaListe = Tanimlamalar.sayfaListeIslemleri.VeriGetir("NitelikTablosu = 'UrunKategori' And NitelikID = " + id);
                if (sayfaListe.Count > 0)
                {
                    foreach (var item in sayfaListe)
                    {
                        Tanimlamalar.sayfaListeIslemleri.Sil("SayfaListeID = " + item.SayfaListeID);
                    }
                }

                Tanimlamalar.urunKategoriIslemleri.Sil("UrunKategoriID = " + id);
            }
            catch
            {
                ViewBag.Hata = "Silme İşlemi Gerçekleştirilemedi";
            }
            return RedirectToAction(nameof(Anasayfa));
        }

        #endregion
    }
}
