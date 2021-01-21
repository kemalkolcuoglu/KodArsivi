using KursProgrami.Model;
using KursProgrami.Web.Filters;
using KursProgrami.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static KursProgrami.Web.App_Start.Tanimlamalar;

namespace KursProgrami.Web.Controllers
{
    [YetkiFilter]
    [HataFilter]
    public class KursTanimController : Controller
    {
        #region Donem

        public ActionResult Donemler() => View(donemIslemleri.VeriGetir("KursID = " + AnlikOturum.Kullanici.KurumID));

        // Parametreler (ID: DonemID)
        public ActionResult DonemDetay(int id)
        {
            Donem donem = donemIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And DonemID = " + id);
            return Json(donem, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DonemEkle() => View("DonemIslemleri");

        // Parametreler (donem: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DonemEkle(Donem donem)
        {
            if (ModelState.IsValid)
            {
                int durum = donemIslemleri.Ekle(donem);

                if (durum > 0)
                    return RedirectToAction(nameof(Donemler));
            }
            return View("DonemIslemleri", donem);
        }

        // Parametreler (ID: DonemID)
        public ActionResult DonemDuzenle(int id)
        {
            Donem donem = donemIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And DonemID = " + id);
            return View("DonemIslemleri", donem);
        }

        // Parametreler (ID: DonemID, gelenDonem: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DonemDuzenle(int id, Donem gelenDonem)
        {
            if (ModelState.IsValid)
            {
                Donem donem = donemIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And DonemID = " + id);
                donem.BaslangicTarihi = gelenDonem.BaslangicTarihi;
                donem.BitisTarihi = gelenDonem.BitisTarihi;
                donem.DonemAdi = gelenDonem.DonemAdi;
                donem.Etkin = gelenDonem.Etkin;
                donem.Konteyjan = gelenDonem.Konteyjan;

                int durum = donemIslemleri.Guncelle("DonemID = " + id, donem);

                if (durum > 0)
                    return RedirectToAction(nameof(Donemler));
            }
            return View("DonemIslemleri", gelenDonem);
        }

        // Parametreler (ID: DonemID)
        public ActionResult DonemSil(int id)
        {
            Donem donem = donemIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And DonemID = " + id);
            return Json(donem, JsonRequestBehavior.AllowGet);
        }

        // Parametreler (ID: DonemID, donem: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DonemSil(int id, Donem donem)
        {
            int durum = donemIslemleri.Sil("DonemID = " + id);

            if (durum > 0)
                return RedirectToAction(nameof(Donemler));

            throw new Exception("Dönem silme işlemi gerçekleştirilemedi. Lütfen tekrar deneyiniz.");
        }

        #endregion

        #region Sinif

        public ActionResult Siniflar()
        {
            return View(sinifIslemleri.VeriGetirSQL("Select * From vsinif Where KursID = " + AnlikOturum.Kullanici.KurumID));
        }

        public ActionResult SinifEkle()
        {
            ViewData["Egitmen"] = SelectListOlusturma.EgitmenListele();
            return View("SinifIslemleri");
        }

        // Parametreler (sinif: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SinifEkle(Sinif sinif)
        {
            int durum = sinifIslemleri.Ekle(sinif);

            if (durum > 0)
                return RedirectToAction(nameof(Siniflar));

            ViewData["Egitmen"] = SelectListOlusturma.EgitmenListele();
            return View("SinifIslemleri", sinif);
        }

        // Parametreler (ID: SinifID)
        public ActionResult SinifDuzenle(int id)
        {
            Sinif sinif = sinifIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And SinifID = " + id);
            ViewData["Egitmen"] = SelectListOlusturma.EgitmenListele();
            return View("SinifIslemleri", sinif);
        }

        // Parametreler (ID: SinifID, gelenSinif: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SinifDuzenle(int id, Sinif gelenSinif)
        {
            if (ModelState.IsValid)
            {
                Sinif sinif = sinifIslemleri.Bul("SinifID = " + id);
                sinif.Etkin = gelenSinif.Etkin;
                sinif.Konteyjan = gelenSinif.Konteyjan;
                sinif.KursID = gelenSinif.KursID;
                sinif.SinifAciklama = gelenSinif.SinifAciklama;
                sinif.SinifAdi = gelenSinif.SinifAdi;

                sinifIslemleri.Guncelle("SinifID = " + id, sinif);
                return RedirectToAction(nameof(Siniflar));
            }
            ViewData["Egitmen"] = SelectListOlusturma.EgitmenListele();
            return View("SinifIslemleri", gelenSinif);
        }

        // Parametreler (ID: SinifID)
        public ActionResult SinifSil(int id)
        {
            Sinif sinif = sinifIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And SinifID = " + id);
            return View("SinifIslemleri", sinif);
        }

        // Parametreler (ID: SinifID, sinif: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SinifSil(int id, Sinif sinif)
        {
            int durum = sinifIslemleri.Sil("SinifID = " + id);

            if (durum > 0)
                return RedirectToAction(nameof(Siniflar));

            throw new Exception("Sınıf silme işlemi gerçekleştirilemedi. Lütfen tekrar deneyiniz.");
        }

        #endregion

        #region Ders

        public ActionResult Dersler() => View(dersIslemleri.VeriGetir("KursID = " + AnlikOturum.Kullanici.KurumID));

        // Parametreler (ID: DersID)
        public ActionResult DersDetay(int id)
        {
            Ders ders = dersIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And DersID = " + id);
            return Json(ders, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DersEkle() => View("DersIslemleri");

        // Parametreler (ders: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DersEkle(Ders ders)
        {
            if (ModelState.IsValid)
            {
                int durum = dersIslemleri.Ekle(ders);

                if (durum > 0)
                    return RedirectToAction(nameof(Donemler));
            }
            return View("DersIslemleri", ders);
        }

        // Parametreler (ID: DersID)
        public ActionResult DersDuzenle(int id)
        {
            Ders ders = dersIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And DersID = " + id);
            return View("DersIslemleri", ders);
        }

        // Parametreler (ID: DersID, gelenDers: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DersDuzenle(int id, Ders gelenDers)
        {
            if (ModelState.IsValid)
            {
                Ders ders = dersIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And DersID = " + id);
                ders.DersAciklamasi = gelenDers.DersAciklamasi;
                ders.DersAdi = gelenDers.DersAdi;
                ders.Etkin = gelenDers.Etkin;

                int durum = dersIslemleri.Guncelle("DersID = " + id, ders);

                if (durum > 0)
                    return RedirectToAction(nameof(Donemler));
            }
            return View("DersIslemleri", gelenDers);
        }

        // Parametreler (ID: DersID)
        public ActionResult DersSil(int id)
        {
            Ders ders = dersIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And DersID = " + id);
            return View("DersIslemleri", ders);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DersSil(int id, Ders ders)
        {
            int durum = dersIslemleri.Sil("DersID = " + id);

            if (durum > 0)
                return RedirectToAction(nameof(Dersler));

            throw new Exception("Ders silme işlemi gerçekleştirilemedi. Lütfen tekrar deneyiniz.");
        }

        #endregion

        #region GunlukProgram

        public ActionResult GunlukProgramlar()
        {
            List<GunlukProgram> gunlukProgram = gunlukProgramIslemleri.VeriGetir("KursID = " + AnlikOturum.Kullanici.KurumID);
            return View(gunlukProgram);
        }

        public ActionResult GunlukProgramEkle()
        {
            return View("GunlukProgramIslemleri");
        }

        // Parametreler (gunlukProgram: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GunlukProgramEkle(GunlukProgram gunlukProgram)
        {
            if (ModelState.IsValid)
            {
                gunlukProgram.EklemeTarihi = DateTime.Now;
                gunlukProgram.DuzenlemeTarihi = DateTime.Now;
                gunlukProgram.KursID = AnlikOturum.Kullanici.KurumID;

                int durum = gunlukProgramIslemleri.Ekle(gunlukProgram);

                if (durum > 0)
                    return RedirectToAction(nameof(GunlukProgramlar));
            }
            ViewBag.Hata = "Ekleme İşlemi Gerçekleştirilemedi. Lütfen Bilgileri İnceleyerek Tekrar Deneyiniz.";
            return View("GunlukProgramIslemleri", gunlukProgram);
        }

        // Parametreler (ID: GunlukProgramID)
        public ActionResult GunlukProgramDuzenle(int id)
        {
            GunlukProgram gunlukProgram = gunlukProgramIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And GunlukProgramID = " + id);

            if (gunlukProgram == null)
                return HttpNotFound();

            return View("GunlukProgramIslemleri", gunlukProgram);
        }

        // Parametreler (ID: GunlukProgramID, yeniProgram: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GunlukProgramDuzenle(int id, GunlukProgram yeniProgram)
        {
            if (ModelState.IsValid)
            {
                GunlukProgram gunlukProgram = gunlukProgramIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And GunlukProgramID = " + id);

                gunlukProgram.DuzenlemeTarihi = DateTime.Now;
                gunlukProgram.Etkin = yeniProgram.Etkin;
                gunlukProgram.GunlukProgramAciklamasi = yeniProgram.GunlukProgramAciklamasi;
                gunlukProgram.GunlukProgramAdi = yeniProgram.GunlukProgramAdi;

                int durum = gunlukProgramIslemleri.Guncelle("GunlukProgramID = " + id, gunlukProgram);

                if (durum > 0)
                    return RedirectToAction(nameof(GunlukProgramlar));
            }
            ViewBag.Hata = "Düzenleme İşlemi Gerçekleştirilemedi. Lütfen Bilgileri İnceleyerek Tekrar Deneyiniz.";
            return View(yeniProgram);
        }

        // Parametreler (ID: GunlukProgramID)
        public ActionResult GunlukProgramSil(int id)
        {
            GunlukProgram gunlukProgram = gunlukProgramIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And GunlukProgramID = " + id);

            if (gunlukProgram == null)
                return HttpNotFound();

            return Json(gunlukProgram);
        }

        #endregion


        #region SaatlikProgram

        // Parametreler (ID: GunlukProgramID)
        public ActionResult SaatlikProgramlar(int id)
        {
            List<SaatlikProgram> saatlikProgram = saatlikProgramIslemleri.VeriGetir("KursID = " + AnlikOturum.Kullanici.KurumID + " And GunlukProgramID = " + id + " Order By BaslangicSaati");
            ViewData["id"] = id;
            return View(saatlikProgram);
        }

        // Parametreler (ID: GunlukProgramID)
        public ActionResult SaatlikProgramEkle(int id)
        {
            GunlukProgram gunlukProgram = gunlukProgramIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And GunlukProgramID = " + id);

            if (gunlukProgram == null)
                return HttpNotFound();

            ViewData["Egitmen"] = SelectListOlusturma.EgitmenListele();
            return View("SaatlikProgramIslemleri");
        }

        // Parametreler (ID: GunlukProgramID, saatlikProgram: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaatlikProgramEkle(int id, SaatlikProgram saatlikProgram)
        {
            if (ModelState.IsValid)
            {
                saatlikProgram.EklemeTarihi = DateTime.Now;
                saatlikProgram.DuzenlemeTarihi = DateTime.Now;
                saatlikProgram.KursID = AnlikOturum.Kullanici.KurumID;
                saatlikProgram.GunlukProgramID = id;

                int durum = saatlikProgramIslemleri.Ekle(saatlikProgram);

                if (durum > 0)
                    return RedirectToAction(nameof(SaatlikProgramlar), new { id = id });
            }
            ViewData["Egitmen"] = SelectListOlusturma.EgitmenListele();
            ViewBag.Hata = "Ekleme İşlemi Gerçekleştirilemedi. Lütfen Bilgileri İnceleyerek Tekrar Deneyiniz.";
            return View("SaatlikProgramIslemleri", saatlikProgram);
        }


        // Parametreler (ID: GunlukProgramID, programId: SaatlikProgramID)
        public ActionResult SaatlikProgramDuzenle(int id, int programId)
        {
            SaatlikProgram saatlikProgram = saatlikProgramIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And GunlukProgramID = " + id + " And SaatlikProgramID = " + programId);

            if (saatlikProgram == null)
                return HttpNotFound();

            ViewData["Egitmen"] = SelectListOlusturma.EgitmenListele();
            return View("SaatlikProgramIslemleri", saatlikProgram);
        }

        // Parametreler (ID: GunlukProgramID, programId: SaatlikProgramID, yeniProgram: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaatlikProgramDuzenle(int id, int programId, SaatlikProgram yeniProgram)
        {
            if (ModelState.IsValid)
            {
                SaatlikProgram saatlikProgram = saatlikProgramIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And GunlukProgramID = " + id + " And SaatlikProgramID = " + programId);

                saatlikProgram.BaslangicSaati = yeniProgram.BaslangicSaati;
                saatlikProgram.BitisSaati = yeniProgram.BitisSaati;
                saatlikProgram.DuzenlemeTarihi = DateTime.Now;
                saatlikProgram.ProgramAciklamasi = yeniProgram.ProgramAciklamasi;
                saatlikProgram.ProgramAdi = yeniProgram.ProgramAdi;
                saatlikProgram.Yoklama = yeniProgram.Yoklama;

                int durum = saatlikProgramIslemleri.Guncelle("SaatlikProgramID = " + programId, saatlikProgram);

                if (durum > 0)
                    return RedirectToAction(nameof(SaatlikProgramlar), new { id = id });
            }
            ViewData["Egitmen"] = SelectListOlusturma.EgitmenListele();
            ViewBag.Hata = "Düzenleme İşlemi Gerçekleştirilemedi. Lütfen Bilgileri İnceleyerek Tekrar Deneyiniz.";
            return View("SaatlikProgramIslemleri", yeniProgram);
        }

        // Parametreler (ID: GunlukProgramID, programId: SaatlikProgramID)
        public ActionResult SaatlikProgramSil(int id, int programId)
        {
            return View();
        }

        #endregion

        #region Tanim

        public ActionResult Tanimlar => View();

        #endregion
    }
}
