using KursProgrami.Model;
using KursProgrami.Model.ViewModel;
using KursProgrami.Web.Filters;
using KursProgrami.Web.Islemler.EkIslemler;
using KursProgrami.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Mvc;
using static KursProgrami.Web.App_Start.Tanimlamalar;

namespace KursProgrami.Web.Controllers
{
    [YetkiFilter]
    [HataFilter]
    public class KisilerController : Controller
    {
        #region Ogrenci
        public ActionResult Ogrenciler()
        {
            List<Ogrenci> ogrenciListesi;

            ogrenciListesi = ogrenciIslemleri.VeriGetirSQL("Select * from vogrenci Where KursID = " + AnlikOturum.Kullanici.KurumID);
            ViewData["Durum"] = SelectListOlusturma.DurumListele();

            return View(ogrenciListesi);
        }

        // Parametreler (filtre: Get ile gelen form bilgileri)
        public ActionResult OgrenciFiltre(OgrenciFiltre filtre)
        {
            ViewData["Durum"] = SelectListOlusturma.DurumListele();
            if (filtre != null)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var prop in filtre.GetType().GetProperties())
                {
                    if (prop.GetValue(filtre, null) == null || prop.GetValue(filtre, null).Equals(-1) || prop.GetMethod.IsVirtual)
                        continue;
                    else if (prop.PropertyType == typeof(string))
                        sb.Append(prop.Name + " = '" + prop.GetValue(filtre, null) + "' And ");
                    else
                        sb.Append(prop.Name + " = " + prop.GetValue(filtre, null) + " And ");
                }

                string sart = sb.ToString();

                if (sart != null && sart != "")
                {
                    sb.Remove(sb.Length - 4, 4);
                    sart = sb.ToString();
                    sart = " Where " + sart;
                }

                List<Ogrenci> ogrenciler = ogrenciIslemleri.VeriGetirSQL("Select * From vogrenci " + sart);
                return View("Ogrenciler", ogrenciler);
            }
            return View("Ogrenciler");
        }

        // Parametreler (ID: OgrenciID)
        public JsonResult OgrenciDetay(int? id)
        {
            if (id == null) return null;

            Ogrenci ogrenci = ogrenciIslemleri.Bul("OgrenciID = " + id);
            OgrenciIletisim iletisim = ogrenciIletisimIslemleri.Bul("OgrenciID = " + id);

            OgrenciMV omv = new OgrenciMV()
            {
                Ogrenci = ogrenci,
                OgrenciIletisim = iletisim,
                KursID = AnlikOturum.Kullanici.KurumID
            };

            return Json(omv);
        }

        public ActionResult OgrenciEkle()
        {
            ViewData["Il"] = SelectListOlusturma.IlListele();
            ViewData["Ilce"] = SelectListOlusturma.IlceListele();
            ViewData["Durum"] = SelectListOlusturma.DurumListele();

            return View("OgrenciIslemleri");
        }

        // Parametreler (model: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OgrenciEkle(OgrenciMV model)
        {
            if (ModelState.IsValid)
            {
                if (model.OgrenciFoto != null && (model.OgrenciFoto.ContentType == "image/jpeg" || model.OgrenciFoto.ContentType == "image/jpg" || model.OgrenciFoto.ContentType == "image/png"))
                {
                    string filename = Path.GetFileName(model.OgrenciFoto.FileName);
                    string _path = Path.Combine(Server.MapPath("~/Assets/Image/Ogrenciler"), filename);
                    model.OgrenciFoto.SaveAs(_path);
                    model.Ogrenci.Fotograf = filename;
                }

                model.Ogrenci.EklemeTarihi = DateTime.Now;
                model.Ogrenci.Ekleyen = AnlikOturum.Kullanici.TCKNO.ToString();
                model.Ogrenci.Guid = Guid.NewGuid().ToString();

                try
                {
                    int durum = ogrenciIslemleri.Ekle(model.Ogrenci);
                    if (durum > 0) ogrenciIletisimIslemleri.Ekle(model.OgrenciIletisim); else throw new Exception();

                    return RedirectToAction(nameof(Ogrenciler));
                }
                catch (Exception)
                {
                    ViewBag.Hata = "Ekleme işlemi gerçekleştirilemedi. Bilgileri kontrol ederek tekrar deneyiniz.";
                }
            }
            ViewData["Il"] = SelectListOlusturma.IlListele();
            ViewData["Ilce"] = SelectListOlusturma.IlceListele();
            ViewData["Durum"] = SelectListOlusturma.DurumListele();
            return View("OgrenciIslemleri", model);
        }

        // Parametreler (ID: OgrenciID)
        public ActionResult OgrenciDuzenle(int id)
        {
            Ogrenci ogrenci = ogrenciIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And OgrenciID = " + id);

            if (ogrenci == null)
                return HttpNotFound();
            
            OgrenciIletisim ogrenciIletisim = ogrenciIletisimIslemleri.Bul("OgrenciID = " + id);

            OgrenciMV model = new OgrenciMV()
            {
                Ogrenci = ogrenci,
                OgrenciIletisim = ogrenciIletisim,
                KursID = AnlikOturum.Kullanici.KurumID
            };
            ViewData["Il"] = SelectListOlusturma.IlListele();
            ViewData["Ilce"] = SelectListOlusturma.IlceListele();
            ViewData["Durum"] = SelectListOlusturma.DurumListele();

            return View("OgrenciIslemleri", model);
        }

        // Parametreler (ID: OgrenciID, model: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OgrenciDuzenle(int id, OgrenciMV model)
        {
            if (ModelState.IsValid)
            {
                if (model.OgrenciFoto != null && (model.OgrenciFoto.ContentType == "image/jpeg" || model.OgrenciFoto.ContentType == "image/jpg" || model.OgrenciFoto.ContentType == "image/png"))
                {
                    string filename = Path.GetFileName(model.OgrenciFoto.FileName);
                    
                    if (model.Ogrenci.Fotograf == null ||  model.Ogrenci.Fotograf != filename)
                    {
                        string _path = Path.Combine(Server.MapPath("~/Assets/Image/Ogrenciler"), filename);
                        model.OgrenciFoto.SaveAs(_path);
                        model.Ogrenci.Fotograf = filename;
                    }
                }

                Ogrenci ogrenci = ogrenciIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And OgrenciID = " + id);

                ogrenci.Aciklama = model.Ogrenci.Aciklama;
                ogrenci.Ad = model.Ogrenci.Ad;
                ogrenci.AnneAdi = model.Ogrenci.AnneAdi;
                ogrenci.AnneMeslegi = model.Ogrenci.AnneMeslegi;
                ogrenci.BabaAdi = model.Ogrenci.BabaAdi;
                ogrenci.BabaMeslegi = model.Ogrenci.BabaMeslegi;
                ogrenci.Cinsiyet = model.Ogrenci.Cinsiyet;
                ogrenci.DogumTarihi = model.Ogrenci.DogumTarihi;
                ogrenci.DogumYeri = model.Ogrenci.DogumYeri;
                ogrenci.Durum = model.Ogrenci.Durum;
                ogrenci.EngelDurumu = model.Ogrenci.EngelDurumu;
                ogrenci.Engeli = model.Ogrenci.Engeli;
                ogrenci.Etkin = model.Ogrenci.Etkin;
                ogrenci.Fotograf = model.Ogrenci.Fotograf;
                ogrenci.Soyad = model.Ogrenci.Soyad;
                ogrenci.TCKNO = model.Ogrenci.TCKNO;

                int durum = ogrenciIslemleri.Guncelle("OgrenciID = " + id, ogrenci);
                if(durum > 0)
                {
                    OgrenciIletisim ogrenciIletisim = ogrenciIletisimIslemleri.Bul("OgrenciID = " + id);
                    ogrenciIletisim.Adres = model.OgrenciIletisim.Adres;
                    ogrenciIletisim.EPosta = model.OgrenciIletisim.EPosta;
                    ogrenciIletisim.Il = model.OgrenciIletisim.Il;
                    ogrenciIletisim.Ilce = model.OgrenciIletisim.Ilce;
                    ogrenciIletisim.Telefon1 = model.OgrenciIletisim.Telefon1;
                    ogrenciIletisim.Telefon2 = model.OgrenciIletisim.Telefon2;

                    durum = ogrenciIletisimIslemleri.Guncelle("OgrenciID = " + id, ogrenciIletisim);

                    if(durum > 0)
                        return RedirectToAction(nameof(Ogrenciler));
                }
            }
            ViewBag.Hata = "İşleminiz gerçekleştirilemedi. Lütfen tekrar deneyiniz.";
            ViewData["Il"] = SelectListOlusturma.IlListele();
            ViewData["Ilce"] = SelectListOlusturma.IlceListele();
            return View("OgrenciIslemleri", model);
        }

        // Parametreler (ID: OgrenciID)
        public ActionResult OgrenciSil(int id)
        {
            Ogrenci ogrenci = ogrenciIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID + " And OgrenciID = " + id);

            return Json(ogrenci, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OgrenciSil(int id, Ogrenci ogrenci)
        {
            int durum;
            durum = ogrenciIslemleri.Sil("KursID = " + AnlikOturum.Kullanici.KurumID + " And OgrenciID = " + id);


            if (durum < 0)
                throw new Exception("Silme İşlemi gerçekleştirilemedi. Lütfen tekrar deniyiniz.");

            durum = ogrenciIletisimIslemleri.Sil("OgrenciID = " + id);

            if (durum < 0)
                throw new Exception("Silme İşlemi gerçekleştirilemedi. Lütfen tekrar deniyiniz.");

            return RedirectToAction(nameof(Ogrenciler));
        }

        // Parametreler (ID: OgrenciID)
        public ActionResult OgrenciRapor(int id)
        {
            return View();
        }

        #endregion

        #region Egitmen

        public ActionResult Egitmenler()
        {
            List<Egitmen> egitmenListesi = egitmenIslemleri.VeriGetir("KursID = " + AnlikOturum.Kullanici.KurumID);

            return View(egitmenListesi);
        }

        // Parametreler (ID: EgitmenID)
        public ActionResult EgitmenDetay(int? id)
        {
            if (id == null) return null;

            Egitmen egitmen = egitmenIslemleri.Bul("EgitmenID = " + id);

            return Json(egitmen);
        }

        public ActionResult EgitmenEkle()
        {
            return View("EgitmenIslemleri");
        }

        // Parametreler (egitmen: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EgitmenEkle(Egitmen egitmen)
        {
            if (ModelState.IsValid)
            {
                int durum = egitmenIslemleri.Ekle(egitmen);
                if(durum > 0)
                    return RedirectToAction(nameof(Egitmenler));
            }
            return View("EgitmenIslemleri", egitmen);
        }

        // Parametreler (ID: EgitmenID)
        public ActionResult EgitmenDuzenle(int id)
        {
            Egitmen egitmen = egitmenIslemleri.Bul("EgitmenID = " + id);

            return View("EgitmenIslemleri", egitmen);
        }

        // Parametreler (ID: EgitmenID, gelenEgitmen: Post ile gelen form bilgileri)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EgitmenDuzenle(int id, Egitmen gelenEgitmen)
        {
            if (ModelState.IsValid)
            {
                Egitmen egitmen = egitmenIslemleri.Bul("EgitmenID = " + id);
                egitmen.Aciklama = gelenEgitmen.Aciklama;
                egitmen.Ad = gelenEgitmen.Ad;
                egitmen.OzelKod = gelenEgitmen.OzelKod;
                egitmen.Soyad = gelenEgitmen.Soyad;
                egitmen.TCKNO = gelenEgitmen.TCKNO;
                egitmen.Telefon = gelenEgitmen.Telefon;

                egitmenIslemleri.Guncelle("EgitmenID = " + id, egitmen);
            }
            return View("EgitmenIslemleri", gelenEgitmen);
        }

        // Parametreler (ID: EgitmenID)
        public ActionResult EgitmenSil(int id)
        {
            Egitmen egitmen = egitmenIslemleri.Bul("EgitmenID = " + id);

            return Json(egitmen, JsonRequestBehavior.AllowGet);
        }

        #endregion
    }
}
