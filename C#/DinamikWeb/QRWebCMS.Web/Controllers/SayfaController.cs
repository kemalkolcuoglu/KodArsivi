using QRWebCMS.Web.App_Start;
using QRWebCMS.Web.Models.EkModel;
using QRWebCMS.Web.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using QRWebCMS.Web.Filters;
using System;

namespace QRWebCMS.Web.Controllers
{
    //[SayacFilter]
    [BakimFilter]
    //[HataFilter]
    public class SayfaController : Controller
    {
        public ActionResult Sayfa(int? id)
        {
            if (id == null)
                return RedirectToAction("Anasayfa", "Ev");

            Sayfa sayfa = Tanimlamalar.sayfaIslemleri.Bul("SayfaID = " + id);

            if (sayfa == null)
                return HttpNotFound();

            List<SayfaListe> sayfaListe = Tanimlamalar.sayfaListeIslemleri.VeriGetir("SayfaID = " + id + " Order By GosterimSirasi");

            if (sayfaListe != null && sayfaListe.Count > 0)
            {
                List<Icerik> icerik = Tanimlamalar.icerikIslemleri.VeriGetir("Etkin = 1 And SayfaID = " + id);
                List<GaleriKategori> galeriKategori = Tanimlamalar.galeriKategoriIslemleri.VeriGetirSQL("Select * From galerikategori Where SayfaID = " + id);
                List<SlideKategori> slideKategori = Tanimlamalar.slideKategoriIslemleri.VeriGetirSQL("Select * From vSlideKategori Where SayfaID = " + id);
                List<UrunKategori> urunKategori = Tanimlamalar.urunKategoriIslemleri.VeriGetirSQL("Select * From vUrunKategori Where SayfaID = " + id);

                SayfaListeMV sayfaListeMV = new SayfaListeMV()
                {
                    Sayfa = sayfa,
                    SayfaListe = sayfaListe,
                    Icerikler = icerik,
                    Galeriler = galeriKategori,
                    Slidelar = slideKategori,
                    Urunler = urunKategori
                };

                return View(sayfaListeMV);
            }
            return RedirectToAction("Anasayfa", "Ev");
        }

        public ActionResult Icerik(int? id)
        {
            if (id == null)
                return RedirectToAction("Anasayfa", "Ev");

            Icerik icerik = Tanimlamalar.icerikIslemleri.Bul("Etkin = 1 And IcerikID = " + id);

            if (icerik == null)
                return HttpNotFound();

            return View(icerik);
        }

        public ActionResult Galeriler()
        {
            List<GaleriKategori> galeriKategori = Tanimlamalar.galeriKategoriIslemleri.VeriGetir("Etkin = 1");

            if (galeriKategori == null)
                return RedirectToAction("Anasayfa", "Ev");

            return View(galeriKategori);
        }

        public ActionResult Galeri(int? id)
        {
            if (id == null)
                return RedirectToAction(nameof(Galeriler));

            List<Galeri> galeri = Tanimlamalar.galeriIslemleri.VeriGetir("Etkin = 1 And GaleriKategoriID = " + id);

            if (galeri == null)
                return HttpNotFound();

            return View(galeri);
        }

        public ActionResult UrunKategorileri()
        {
            List<UrunKategori> urunKategori = Tanimlamalar.urunKategoriIslemleri.VeriGetir("Etkin = 1");

            if (urunKategori == null)
                return HttpNotFound();

            return View(urunKategori);
        }

        public ActionResult Urunler(int? id)
        {
            if (id == null)
                return RedirectToAction(nameof(UrunKategorileri));

            List<Urun> urun = Tanimlamalar.urunIslemleri.VeriGetir("Etkin = 1 And UrunKategoriID = " + id);

            if (urun == null)
                return HttpNotFound();

            return View(urun);
        }

        public ActionResult UrunDetay(int? id)
        {
            if (id == null)
                return RedirectToAction(nameof(Urunler));

            Urun urun = Tanimlamalar.urunIslemleri.Bul("Etkin = 1 And UrunID = " + id);

            if (urun == null)
                return HttpNotFound();

            return View(urun);
        }

        public ActionResult Demo()
        {
            List<Urun> urun = Tanimlamalar.urunIslemleri.VeriGetir("1 = 1");
            List<SelectListItem> sli = new List<SelectListItem>();
            foreach (var item in urun)
            {
                SelectListItem selectListItem = new SelectListItem()
                {
                    Text = item.Baslik,
                    Value = item.Baslik
                };
                sli.Add(selectListItem);
            }
            ViewData["Urunler"] = new SelectList(sli, "Text", "Value");

            return View();
        }

        [HttpPost]
        public ActionResult Demo(DemoTalebi demoFormu)
        {
            if (ModelState.IsValid)
            {
                Form form = new Form()
                {
                    AdSoyad = demoFormu.AdSoyad,
                    EPosta = demoFormu.EPosta,
                    Konu = "Demo Talebi",
                    MesajIcerigi = $"Ad Soyad: {demoFormu.AdSoyad} <br/>" +
                                    $"E-Posta: {demoFormu.EPosta} <br/>" +
                                    $"Telefon: {demoFormu.Telefon} <br/>" +
                                    $"Bulunduğu İl: {demoFormu.BulunduguIl} <br/>" +
                                    $"Bulunduğu İlçe: {demoFormu.BulunduguIlce} <br/>" +
                                    $"Kurum Adı: {demoFormu.KurumAdi} <br/>" +
                                    $"Talep Ürün: {demoFormu.TalepUrun} <br/>",
                    GonderimTarihi = DateTime.Now
                };

                int durum = Tanimlamalar.formIslemleri.Ekle(form);
                if (durum > 0)
                {
                    ViewBag.Mesaj = "Kayıt bilgileriniz başarıyla tarafımıza iletilmiştir. Bilgiler incelenip size geri dönüş sağlanacaktır.";
                    return View();
                }
            }
            ViewBag.Hata = "Demo talebiniz gerçekleştirilemedi. Lütfen bilgileri kontrol ederek tekrar deneyiniz.";
            return View(demoFormu);
        }
    }
}