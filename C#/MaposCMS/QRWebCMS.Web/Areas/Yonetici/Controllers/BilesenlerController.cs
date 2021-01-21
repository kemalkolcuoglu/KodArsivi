using QRWebCMS.Web.App_Start;
using QRWebCMS.Web.Filters;
using QRWebCMS.Web.Models;
using QRWebCMS.Web.Models.EkModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace QRWebCMS.Web.Areas.Yonetici.Controllers
{
    [YetkiFilter]
    [YoneticiHataFilter]
    public class BilesenlerController : Controller
    {
        #region MenuIslemleri

        public ActionResult Menu()
        {
            return View(Tanimlamalar.menuIslemleri.VeriGetir("1 = 1"));
        }

        public ActionResult MenuEkle()
        {
            return PartialView("_MenuEkle");
        }

        [HttpPost]
        public ActionResult MenuEkle(Menu menu)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    List<Menu> sonMenu = Tanimlamalar.menuIslemleri.VeriGetirSQL("Select Max(GoruntulemeSirasi) From Menu");
                    if (sonMenu != null && sonMenu.Count > 0)
                        menu.GoruntulemeSirasi = sonMenu[0].GoruntulemeSirasi + 1;
                    else
                        menu.GoruntulemeSirasi = 1;
                    if (!menu.Sayfa && menu.Link != null)
                    {
                        MenuListe menuListe = new MenuListe();
                        sonMenu = Tanimlamalar.menuIslemleri.VeriGetirSQL("Select Max(MenuID) From Menu");
                        if (sonMenu != null && sonMenu.Count > 0)
                            menuListe.MenuID = (sonMenu[0].MenuID + 1);
                        else
                            menuListe.MenuID = 1;

                        Tanimlamalar.menuListeIslemleri.Ekle(menuListe);
                    }
                    int durum = Tanimlamalar.menuIslemleri.Ekle(menu);
                    if (durum < 1)
                        throw new Exception();
                    return RedirectToAction(nameof(Menu));
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return PartialView("_MenuEkle", menu);
            }
        }

        public ActionResult MenuDuzenle(int id)
        {
            return View(Tanimlamalar.menuIslemleri.Bul("MenuID = " + id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MenuDuzenle(int id, Menu yeniMenu)
        {
            try
            {
                Menu menu = Tanimlamalar.menuIslemleri.Bul("MenuID = " + id);
                menu.Baslik = yeniMenu.Baslik;
                menu.Dropdown = yeniMenu.Dropdown;
                menu.Etkin = yeniMenu.Etkin;
                menu.Ikon = yeniMenu.Ikon;
                menu.Link = yeniMenu.Link;
                menu.Sayfa = yeniMenu.Sayfa;

                Tanimlamalar.menuIslemleri.Guncelle("MenuID = " + id, menu);

                return RedirectToAction(nameof(Menu));
            }
            catch
            {
                return PartialView(yeniMenu);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MenuSil(int id, int GelenId)
        {
            try
            {
                int durum = Tanimlamalar.menuIslemleri.Sil("MenuID = " + GelenId);
                if (durum < 1)
                    throw new Exception();
            }
            catch
            {
                ViewBag.Hata = "Silme İşlemi Gerçekleştirilemedi";
            }
            return RedirectToAction(nameof(Menu));
        }

        public ActionResult MenuSayfa(int id)
        {
            ViewData["Menu"] = Tanimlamalar.menuIslemleri.Bul("MenuID = " + id);

            List<MenuListe> menuListe = Tanimlamalar.menuListeIslemleri.VeriGetir("MenuID = " + id);
            List<Sayfa> sayfa = Tanimlamalar.sayfaIslemleri.VeriGetir("Etkin = 1");
            List<Sayfa> sayfaListesi = new List<Sayfa>();

            foreach (var item in sayfa)
            {
                if (menuListe.Any(x => x.SayfaID == item.SayfaID))
                    sayfaListesi.Add(item);
            }
            // TODO : Ekleme yapıldıktan sonra tekrar girildiğinde hiç yapılmamış gibi gösteriyor
            MultiSelectList SayfaSecici = new MultiSelectList(sayfa, "SayfaID", "Baslik", sayfaListesi);

            TempData["SayfaListesi"] = SayfaSecici;

            return View();
        }

        [HttpPost]
        public ActionResult MenuSayfa(int id, List<int> menuListe)
        {
            if (menuListe != null && menuListe.Count > 0)
            {
                foreach (var item in menuListe)
                {
                    MenuListe ml = new MenuListe()
                    {
                        MenuID = id,
                        SayfaID = item
                    };
                    Tanimlamalar.menuListeIslemleri.Ekle(ml);
                }
            }
            return RedirectToAction(nameof(Menu));
        }

        #endregion

        #region SayfaIslemleri

        public ActionResult Sayfa()
        {
            return View(Tanimlamalar.sayfaIslemleri.VeriGetir("1 = 1"));
        }

        public ActionResult SayfaEkle()
        {
            return PartialView("_SayfaEkle");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SayfaEkle(Sayfa sayfa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int durum = Tanimlamalar.sayfaIslemleri.Ekle(sayfa);
                    if (durum < 1)
                        throw new Exception();
                    return RedirectToAction(nameof(Sayfa));
                }
                throw new Exception();
            }
            catch
            {
                return PartialView("_SayfaEkle", sayfa);
            }
        }

        public ActionResult SayfaDuzenle(int id)
        {
            return View(Tanimlamalar.sayfaIslemleri.Bul("SayfaID = " + id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SayfaDuzenle(int id, Sayfa sayfa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Sayfa sayfaAsil = Tanimlamalar.sayfaIslemleri.Bul("SayfaID = " + id);
                    sayfaAsil.Baslik = sayfa.Baslik;
                    sayfaAsil.EkAlan1 = sayfa.EkAlan1;
                    sayfaAsil.EkAlan2 = sayfa.EkAlan2;
                    sayfaAsil.Etkin = sayfa.Etkin;
                    sayfaAsil.Ikon = sayfa.Ikon;
                    int durum = Tanimlamalar.sayfaIslemleri.Guncelle("SayfaID = " + id, sayfaAsil);
                    if (durum < 1)
                        throw new Exception();
                    return RedirectToAction(nameof(Sayfa));
                }
                throw new Exception();
            }
            catch
            {
                return View(sayfa);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SayfaSil(int id, Sayfa sayfa)
        {
            try
            {
                int durum = Tanimlamalar.sayfaIslemleri.Sil("SayfaID = " + id);
                if (durum < 1)
                    throw new Exception();
                int durum2 = Tanimlamalar.sayfaListeIslemleri.Sil("SayfaID = " + id);
                if (durum2 < 1)
                    throw new Exception();
            }
            catch
            {
                ViewBag.Hata = "Silme İşlemi Gerçekleştirilemedi";
            }
            return RedirectToAction(nameof(Sayfa));
        }

        public ActionResult SayfaIcerik(int id)
        {
            List<SayfaListe> sayfaListe = Tanimlamalar.sayfaListeIslemleri.VeriGetir("SayfaID = " + id);
            List<SayfaListe> galeriListesi = new List<SayfaListe>();
            List<SayfaListe> icerikListesi = new List<SayfaListe>();
            List<SayfaListe> urunListesi = new List<SayfaListe>();
            List<SayfaListe> slideListesi = new List<SayfaListe>();

            foreach (var item in sayfaListe)
            {
                switch (item.NitelikTablosu)
                {
                    case "Icerik": icerikListesi.Add(item); break;
                    case "GaleriKategori": galeriListesi.Add(item); break;
                    case "SlideKategori": slideListesi.Add(item); break;
                    case "UrunKategori": urunListesi.Add(item); break;
                }
            }

            MultiSelectList icerik = new MultiSelectList(Tanimlamalar.icerikIslemleri.VeriGetir("Etkin = 1"), "IcerikID", "Baslik", icerikListesi);
            MultiSelectList galeri = new MultiSelectList(Tanimlamalar.galeriKategoriIslemleri.VeriGetir("Etkin = 1"), "GaleriKategoriID", "Baslik", galeriListesi);
            MultiSelectList slide = new MultiSelectList(Tanimlamalar.slideKategoriIslemleri.VeriGetir("Etkin = 1"), "SlideKategoriID", "Baslik", slideListesi);
            MultiSelectList urun = new MultiSelectList(Tanimlamalar.urunKategoriIslemleri.VeriGetir("Etkin = 1"), "UrunKategoriID", "Baslik", urunListesi);

            TempData["Icerik"] = icerik;
            TempData["Galeri"] = galeri;
            TempData["Slide"] = slide;
            TempData["Urun"] = urun;
            TempData["SayfaListe"] = sayfaListe;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SayfaIcerik(int id, Models.EkModel.SayfaListeMV sayfaListeMV)
        {

            // TODO : Ekleme yapıldıktan sonra tekrar girildiğinde hiç yapılmamış gibi gösteriyor

            /* Açıklama Başlangıç ----------------------------------------------------------------------------------------------------------------------------------------------------------------- */
            // O SayfaListesine ait daha önce eklenmiş veri varsa gösterim sırasını ona göre düzenlemek için çağırılıyor.

            int i = Tanimlamalar.sayfaListeIslemleri.MaxDeger("SayfaID = " + id, "GosterimSirasi"); // Tablo değeri yoksa | return 0

            i++; // Gelen değer ne olursa olsun bize bir fazlası lazım olduğu için arttırma işlem yapıldı

            /* Açıklama Bitiş --------------------------------------------------------------------------------------------------------------------------------------------------------------------- */

            if (sayfaListeMV.GaleriListesi != null && sayfaListeMV.GaleriListesi.Count > 0)
            {
                foreach (var item in sayfaListeMV.GaleriListesi)
                {
                    SayfaListe kontrol = Tanimlamalar.sayfaListeIslemleri.Bul("NitelikTablosu = 'GaleriKategori' And NitelikID = " + item);
                    if (kontrol == null)
                    {
                        SayfaListe sayfaListe = new SayfaListe()
                        {
                            SayfaID = id,
                            NitelikID = item,
                            NitelikTablosu = "GaleriKategori",
                            GosterimSirasi = i++,
                        };
                        Tanimlamalar.sayfaListeIslemleri.Ekle(sayfaListe);
                        Tanimlamalar.galeriKategoriIslemleri.Guncelle("GaleriKategoriID = " + item, "SayfaID", id, id.GetType());
                    }
                }
            }
            if (sayfaListeMV.IcerikListesi != null && sayfaListeMV.IcerikListesi.Count > 0)
            {
                foreach (var item in sayfaListeMV.IcerikListesi)
                {
                    SayfaListe kontrol = Tanimlamalar.sayfaListeIslemleri.Bul("NitelikTablosu = 'Icerik' And NitelikID = " + item);
                    if (kontrol == null)
                    {
                        SayfaListe sayfaListe = new SayfaListe()
                        {
                            SayfaID = id,
                            NitelikID = item,
                            NitelikTablosu = "Icerik",
                            GosterimSirasi = i++
                        };
                        Tanimlamalar.sayfaListeIslemleri.Ekle(sayfaListe);
                        Tanimlamalar.icerikIslemleri.Guncelle("IcerikID = " + item, "SayfaID", id, id.GetType());
                    }
                }
            }
            if (sayfaListeMV.SlideListesi != null && sayfaListeMV.SlideListesi.Count > 0)
            {
                foreach (var item in sayfaListeMV.SlideListesi)
                {
                    SayfaListe kontrol = Tanimlamalar.sayfaListeIslemleri.Bul("NitelikTablosu = 'SlideKategori' And NitelikID = " + item);
                    if (kontrol == null)
                    {
                        SayfaListe sayfaListe = new SayfaListe()
                        {
                            SayfaID = id,
                            NitelikID = item,
                            NitelikTablosu = "SlideKategori",
                            GosterimSirasi = i++
                        };
                        Tanimlamalar.sayfaListeIslemleri.Ekle(sayfaListe);
                        Tanimlamalar.slideKategoriIslemleri.Guncelle("SlideKategoriID = " + item, "SayfaID", id, id.GetType());
                    }
                }
            }
            if (sayfaListeMV.UrunListesi != null && sayfaListeMV.UrunListesi.Count > 0)
            {
                foreach (var item in sayfaListeMV.UrunListesi)
                {
                    SayfaListe kontrol = Tanimlamalar.sayfaListeIslemleri.Bul("NitelikTablosu = 'UrunKategori' And NitelikID = " + item);
                    if (kontrol == null)
                    {
                        SayfaListe sayfaListe = new SayfaListe()
                        {
                            SayfaID = id,
                            NitelikID = item,
                            NitelikTablosu = "UrunKategori",
                            GosterimSirasi = i++
                        };
                        Tanimlamalar.sayfaListeIslemleri.Ekle(sayfaListe);
                        Tanimlamalar.urunKategoriIslemleri.Guncelle("UrunKategoriID = " + item, "SayfaID", id, id.GetType());
                    }
                }
            }
            return RedirectToAction(nameof(Sayfa));
        }

        public ActionResult SayfaDuzeni(int? id)
        {
            if (id == null)
                return RedirectToAction(nameof(Sayfa));

            List<SayfaListe> sayfaListe = Tanimlamalar.sayfaListeIslemleri.VeriGetir("SayfaID = 2");

            if (sayfaListe == null && sayfaListe.Count < 0)
                return HttpNotFound();

            return View(sayfaListe);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SayfaDuzeni(int id, string duzen)
        {
            // TODO : Hala Drag-Drop yapılamadı.

            List<SayfaListe> sayfaListesi = Tanimlamalar.sayfaListeIslemleri.VeriGetir("SayfaID = " + id);
            List<int> itemIdList = new List<int>();
            itemIdList = duzen.Split(",".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int sira = 1;
            foreach (var i in itemIdList)
            {
                SayfaListe sl = sayfaListesi.Where(x => x.SayfaListeID == i).FirstOrDefault();
                sl.GosterimSirasi = sira;

                Tanimlamalar.sayfaListeIslemleri.Guncelle("SayfaListeID = " + sl.SayfaListeID, sl);
                sira++;
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region IcerikIslemleri

        public ActionResult Icerik()
        {
            return View(Tanimlamalar.icerikIslemleri.VeriGetir("1 = 1"));
        }

        public ActionResult IcerikEkle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult IcerikEkle(Icerik icerik)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    icerik.DuzenlemeTarihi = DateTime.Now;
                    icerik.Duzenleyen = AnlikOturum.Kullanici.KullaniciAdi;
                    icerik.EklemeTarihi = DateTime.Now;
                    icerik.Ekleyen = AnlikOturum.Kullanici.KullaniciAdi;
                    int durum = Tanimlamalar.icerikIslemleri.Ekle(icerik);
                    if (durum < 1)
                        throw new Exception();
                    return RedirectToAction(nameof(Icerik));
                }
                throw new Exception();
            }
            catch
            {
                ViewBag.Hata = "Ekleme İşlemi Gerçekleştirilemedi";
                return View(icerik);
            }
        }

        public ActionResult IcerikDuzenle(int id)
        {
            return View(Tanimlamalar.icerikIslemleri.Bul("IcerikID = " + id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult IcerikDuzenle(int id, Icerik yeniIcerik)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Icerik icerik = Tanimlamalar.icerikIslemleri.Bul("IcerikID = " + id);
                    icerik.Baslik = yeniIcerik.Baslik;
                    icerik.Detay = yeniIcerik.Detay;
                    icerik.DuzenlemeTarihi = DateTime.Now;
                    icerik.Duzenleyen = AnlikOturum.Kullanici.KullaniciAdi;
                    icerik.EkAlan1 = yeniIcerik.EkAlan1;
                    icerik.EkAlan2 = yeniIcerik.EkAlan2;
                    icerik.Etkin = yeniIcerik.Etkin;
                    icerik.Gorsel = yeniIcerik.Gorsel;
                    int durum = Tanimlamalar.icerikIslemleri.Guncelle("IcerikID = " + id, icerik);
                    if (durum < 1)
                        throw new Exception();
                    return RedirectToAction(nameof(Icerik));
                }
                throw new Exception();
            }
            catch (Exception exp)
            {
                return View(yeniIcerik);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IcerikSil(int id, Icerik icerik)
        {
            try
            {
                List<SayfaListe> sayfaListe = Tanimlamalar.sayfaListeIslemleri.VeriGetir("NitelikTablosu = 'Icerik' And NitelikID = " + id);
                if (sayfaListe.Count > 0)
                {
                    foreach (var item in sayfaListe)
                    {
                        Tanimlamalar.sayfaListeIslemleri.Sil("SayfaListeID = " + item.SayfaListeID);
                    }
                }

                int durum = Tanimlamalar.icerikIslemleri.Sil("IcerikID = " + id);
                if (durum < 1)
                    throw new Exception();
            }
            catch (Exception exp)
            {
                ViewBag.Hata = "Silme İşlemi Gerçekleştirilemedi";
            }
            return RedirectToAction(nameof(Icerik));
        }

        #endregion

        #region GaleriIslemleri

        public ActionResult Galeri(int? id)
        {
            ViewData["Kategori"] = GaleriKategoriListesi();

            if (id == null)
                return View();
            ViewBag.Durum = true;
            return View(Tanimlamalar.galeriIslemleri.VeriGetir("GaleriKategoriID = " + id));
        }

        public ActionResult GaleriEkle()
        {
            ViewData["Kategori"] = GaleriKategoriListesi();
            return PartialView("_GaleriEkle");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GaleriEkle(Galeri galeri)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    galeri.DuzenlemeTarihi = DateTime.Now;
                    galeri.Duzenleyen = AnlikOturum.Kullanici.KullaniciAdi;
                    galeri.EklemeTarihi = DateTime.Now;
                    galeri.Ekleyen = AnlikOturum.Kullanici.KullaniciAdi;
                    int durum = Tanimlamalar.galeriIslemleri.Ekle(galeri);
                    if (durum < 1)
                        throw new Exception();
                    return RedirectToAction(nameof(Galeri), new { id = galeri.GaleriKategoriID });
                }
                throw new Exception();

            }
            catch
            {
                ViewData["Kategori"] = GaleriKategoriListesi();
                ViewBag.Hata = "Ekleme İşlemi Gerçekleştirilemedi";
                return PartialView("_GaleriEkle", galeri);
            }
        }

        public ActionResult GaleriDuzenle(int id)
        {
            ViewData["Kategori"] = GaleriKategoriListesi();
            return View(Tanimlamalar.galeriIslemleri.Bul("GaleriID = " + id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GaleriDuzenle(int id, Galeri yeniGaleri)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Galeri galeri = Tanimlamalar.galeriIslemleri.Bul("GaleriID = " + id);
                    galeri.Baslik = yeniGaleri.Baslik;
                    galeri.Detay = yeniGaleri.Detay;
                    galeri.DuzenlemeTarihi = DateTime.Now;
                    galeri.Duzenleyen = AnlikOturum.Kullanici.KullaniciAdi;
                    galeri.Etkin = yeniGaleri.Etkin;
                    galeri.GaleriKategoriID = yeniGaleri.GaleriKategoriID;
                    galeri.Gorsel = yeniGaleri.Gorsel;

                    int durum = Tanimlamalar.galeriIslemleri.Guncelle("GaleriID = " + id, galeri);
                    if (durum < 1)
                        throw new Exception();
                    return RedirectToAction(nameof(Galeri), new { id = galeri.GaleriKategoriID });
                }
                throw new Exception();
            }
            catch
            {
                ViewData["Kategori"] = GaleriKategoriListesi();
                return PartialView("_GaleriDuzenle", yeniGaleri);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GaleriSil(int id, Galeri galeri)
        {
            try
            {
                int durum = Tanimlamalar.galeriIslemleri.Sil("GaleriID = " + id);
                if (durum < 1)
                    throw new Exception();
            }
            catch
            {
                ViewBag.Hata = "Silme İşlemi Gerçekleştirilemedi";
            }
            return RedirectToAction(nameof(Galeri), new { id = galeri.GaleriKategoriID });
        }

        #endregion

        #region UrunIslemleri

        public ActionResult Urun(int? id)
        {
            ViewData["Kategori"] = UrunKategoriListesi();

            if (id == null)
                return View();
            ViewBag.Durum = true;
            return View(Tanimlamalar.urunIslemleri.VeriGetir("UrunKategoriID = " + id));
        }

        public ActionResult UrunEkle()
        {
            ViewData["Kategori"] = UrunKategoriListesi();
            return PartialView("_UrunEkle");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult UrunEkle(Urun urun)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    urun.DuzenlemeTarihi = DateTime.Now;
                    urun.Duzenleyen = "sytem";
                    urun.EklemeTarihi = DateTime.Now;
                    urun.Ekleyen = AnlikOturum.Kullanici.KullaniciAdi;
                    int durum = Tanimlamalar.urunIslemleri.Ekle(urun);
                    if (durum < 1)
                        throw new Exception();
                    return RedirectToAction(nameof(Urun), new { id = urun.UrunKategoriID });
                }
                throw new Exception();
            }
            catch (Exception exp)
            {
                ViewData["Kategori"] = UrunKategoriListesi();
                ViewBag.Hata = "Ekleme İşlemi Gerçekleştirilemedi";
                return PartialView("_UrunEkle", urun);
            }
        }

        public ActionResult UrunDuzenle(int id)
        {
            ViewData["Kategori"] = UrunKategoriListesi();
            return View(Tanimlamalar.urunIslemleri.Bul("UrunID = " + id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult UrunDuzenle(int id, Urun yeniUrun)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Urun urun = Tanimlamalar.urunIslemleri.Bul("UrunID = " + id);
                    urun.Baslik = yeniUrun.Baslik;
                    urun.Detay = yeniUrun.Detay;
                    urun.EkAlan1 = yeniUrun.EkAlan1;
                    urun.EkAlan2 = yeniUrun.EkAlan2;
                    urun.Etkin = yeniUrun.Etkin;
                    urun.Gorsel = yeniUrun.Gorsel;
                    urun.Ucret = yeniUrun.Ucret;
                    urun.Vitrin = yeniUrun.Vitrin;
                    urun.DuzenlemeTarihi = DateTime.Now;
                    urun.UrunKategoriID = yeniUrun.UrunKategoriID;
                    urun.Duzenleyen = AnlikOturum.Kullanici.KullaniciAdi;

                    int durum = Tanimlamalar.urunIslemleri.Guncelle("UrunID = " + id, urun);
                    if (durum < 1)
                        throw new Exception();
                    return RedirectToAction(nameof(Urun), new { id = urun.UrunKategoriID });
                }
                throw new Exception();
            }
            catch (Exception exp)
            {
                ViewData["Kategori"] = UrunKategoriListesi();
                ViewBag.Hata = "Düzenle İşlemi Gerçekleştirilemedi";
                return View(yeniUrun);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UrunSil(int id, Urun urun)
        {
            try
            {
                int durum = Tanimlamalar.urunIslemleri.Sil("UrunID = " + id);
                if (durum < 1)
                    throw new Exception();
            }
            catch (Exception exp)
            {
                ViewBag.Hata = "Silme İşlemi Gerçekleştirilemedi";
            }
            return RedirectToAction(nameof(Urun), new { id = urun.UrunKategoriID });
        }

        #endregion

        #region SlideIslemleri

        public ActionResult Slide(int? id)
        {
            ViewData["Kategori"] = SlideKategoriListesi();

            if (id == null)
                return View();
            ViewBag.Durum = true;
            return View(Tanimlamalar.slideIslemleri.VeriGetir("SlideKategoriID = " + id));
        }

        public ActionResult SlideEkle()
        {
            ViewData["Kategori"] = SlideKategoriListesi();
            return PartialView("_SlideEkle");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SlideEkle(Slide slide)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    slide.DuzenlemeTarihi = DateTime.Now;
                    slide.Duzenleyen = AnlikOturum.Kullanici.KullaniciAdi;
                    slide.EklemeTarihi = DateTime.Now;
                    slide.Ekleyen = AnlikOturum.Kullanici.KullaniciAdi;
                    int durum = Tanimlamalar.slideIslemleri.Ekle(slide);
                    if (durum < 1)
                        throw new Exception();
                    return RedirectToAction(nameof(Slide), new { id = slide.SlideKategoriID });
                }
                throw new Exception();
            }
            catch
            {
                ViewData["Kategori"] = SlideKategoriListesi();
                ViewBag.Hata = "Ekleme İşlemi Gerçekleştirilemedi";
                return PartialView("_SlideEkle", slide);
            }
        }

        public ActionResult SlideDuzenle(int id)
        {
            ViewData["Kategori"] = SlideKategoriListesi();
            return View(Tanimlamalar.slideIslemleri.Bul("SlideID = " + id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SlideDuzenle(int id, Slide yeniSlide)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Slide slide = Tanimlamalar.slideIslemleri.Bul("SlideID = " + id);
                    slide.Baslik = yeniSlide.Baslik;
                    slide.Etkin = yeniSlide.Etkin;
                    slide.Gorsel = yeniSlide.Gorsel;
                    slide.SlideKategoriID = yeniSlide.SlideKategoriID;
                    slide.DuzenlemeTarihi = DateTime.Now;
                    slide.Duzenleyen = AnlikOturum.Kullanici.KullaniciAdi;

                    int durum = Tanimlamalar.slideIslemleri.Guncelle("SlideID = " + id, slide);
                    if (durum < 1)
                        throw new Exception();
                    return RedirectToAction(nameof(Slide), new { id = slide.SlideKategoriID });
                }
                throw new Exception();
            }
            catch
            {
                ViewData["Kategori"] = SlideKategoriListesi();
                ViewBag.Hata = "Düzenle İşlemi Gerçekleştirilemedi";
                return View(yeniSlide);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SlideSil(int id, Slide slide)
        {
            try
            {
                int durum = Tanimlamalar.slideIslemleri.Sil("SlideID = " + id);
                if (durum < 1)
                    throw new Exception();
            }
            catch
            {
                ViewBag.Hata = "Silme İşlemi Gerçekleştirilemedi";
            }
            return RedirectToAction(nameof(Slide), new { id = slide.SlideKategoriID });
        }

        #endregion

        #region SosyalMedyaIslemleri

        public ActionResult SosyalMedya()
        {
            return View(Tanimlamalar.sosyalMedyaIslemleri.VeriGetir("1 = 1"));
        }

        public ActionResult SosyalMedyaEkle()
        {
            return PartialView("_SosyalMedyaEkle");
        }
        [HttpPost]
        public ActionResult SosyalMedyaEkle(SosyalMedya sosyalMedya)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int durum = Tanimlamalar.sosyalMedyaIslemleri.Ekle(sosyalMedya);
                    if (durum < 1)
                        throw new Exception();
                    return RedirectToAction(nameof(SosyalMedya));
                }
                throw new Exception();
            }
            catch
            {
                ViewBag.Hata = "Ekleme İşlemi Gerçekleştirilemedi";
                return PartialView("_SosyalMedyaEkle", sosyalMedya);
            }
        }

        public ActionResult SosyalMedyaDuzenle(int id)
        {
            return View(Tanimlamalar.sosyalMedyaIslemleri.Bul("SosyalMedyaID = " + id));
        }

        [HttpPost]
        public ActionResult SosyalMedyaDuzenle(int id, SosyalMedya yeniSosyalMedya)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    SosyalMedya sosyalMedya = Tanimlamalar.sosyalMedyaIslemleri.Bul("SosyalMedyaID = " + id);
                    sosyalMedya.Baslik = yeniSosyalMedya.Baslik;
                    sosyalMedya.Ikon = yeniSosyalMedya.Ikon;
                    sosyalMedya.Link = yeniSosyalMedya.Link;

                    int durum = Tanimlamalar.sosyalMedyaIslemleri.Guncelle("SosyalMedyaID = " + id, sosyalMedya);
                    if (durum < 1)
                        throw new Exception();
                    return RedirectToAction(nameof(SosyalMedya));
                }
                throw new Exception();
            }
            catch
            {
                return View(yeniSosyalMedya);
            }
        }

        [HttpPost]
        public ActionResult SosyalMedyaSil(int id, SosyalMedya sosyalMedya)
        {
            try
            {
                int durum = Tanimlamalar.sosyalMedyaIslemleri.Sil("SosyalMedyaID = " + id);
                if (durum < 1)
                    throw new Exception();
            }
            catch
            {
                ViewBag.Hata = "Silme İşlemi Gerçekleştirilemedi";
            }
            return RedirectToAction(nameof(SosyalMedya));
        }

        #endregion

        public ActionResult Ikonlar()
        {
            return View();
        }

        public ActionResult GorselEkle()
        {
            return View(Tanimlamalar.gorselIslemleri.VeriGetir("1 = 1").OrderByDescending(x => x.EklemeTarihi).ToList());
        }

        [HttpPost]
        public ActionResult GorselEkle(IEnumerable<HttpPostedFileBase> file)
        {
            try
            {
                foreach (var enctype in file)
                {
                    if (enctype != null && (enctype.ContentType == "image/jpeg" || enctype.ContentType == "image/jpg" || enctype.ContentType == "image/png"))
                    {
                        string filename = Path.GetFileName(enctype.FileName);
                        string _path = Path.Combine(Server.MapPath("~/Assets/Image/Gorseller"), filename);
                        enctype.SaveAs(_path);
                        Gorsel yeniGorsel = new Gorsel()
                        {
                            EklemeTarihi = DateTime.Now,
                            GorselAdres = "Assets/Image/Gorseller/" + filename
                        };
                        Tanimlamalar.gorselIslemleri.Ekle(yeniGorsel);
                        ViewBag.Message = "Görsel Yükleme İşlemi Başarılı!";
                    }
                    else
                        throw new Exception();
                }
            }
            catch
            {
                ViewBag.Hata = "Dosya Yükleme İşlemi Başarısız!";
            }
            return View(Tanimlamalar.gorselIslemleri.VeriGetir("1 = 1").OrderByDescending(x => x.EklemeTarihi).ToList());
        }

        #region SelectListOlusturucu

        public SelectList SayfaListesi()
        {
            List<Sayfa> sayfalar = Tanimlamalar.sayfaIslemleri.VeriGetir("1 = 1");

            if (sayfalar.Count == 0)
                return new SelectList(sayfalar);
            List<SelectListItem> sli = new List<SelectListItem>();
            foreach (var item in sayfalar)
            {
                if (item.Etkin)
                {
                    SelectListItem li = new SelectListItem()
                    {
                        Text = item.Baslik,
                        Value = item.SayfaID.ToString()
                    };
                    sli.Add(li);
                }
            }
            return new SelectList(sli, "Value", "Text");
        }

        public SelectList GaleriKategoriListesi()
        {
            List<GaleriKategori> kategori = Tanimlamalar.galeriKategoriIslemleri.VeriGetir("1 = 1");

            if (kategori.Count == 0)
                return new SelectList(kategori);

            List<SelectListItem> sli = new List<SelectListItem>();
            foreach (var item in kategori)
            {
                if (item.Etkin)
                {
                    SelectListItem li = new SelectListItem()
                    {
                        Text = item.Baslik,
                        Value = item.GaleriKategoriID.ToString()
                    };
                    sli.Add(li);
                }
            }
            return new SelectList(sli, "Value", "Text");
        }

        public SelectList UrunKategoriListesi()
        {
            List<UrunKategori> kategori = Tanimlamalar.urunKategoriIslemleri.VeriGetir("1 = 1");

            if (kategori.Count == 0)
                return new SelectList(kategori);

            List<SelectListItem> sli = new List<SelectListItem>();
            foreach (var item in kategori)
            {
                if (item.Etkin)
                {
                    SelectListItem li = new SelectListItem()
                    {
                        Text = item.Baslik,
                        Value = item.UrunKategoriID.ToString()
                    };
                    sli.Add(li);
                }
            }
            return new SelectList(sli, "Value", "Text");
        }

        public SelectList SlideKategoriListesi()
        {
            List<SlideKategori> kategori = Tanimlamalar.slideKategoriIslemleri.VeriGetir("1 = 1");

            if (kategori.Count == 0)
                return new SelectList(kategori);

            List<SelectListItem> sli = new List<SelectListItem>();
            foreach (var item in kategori)
            {
                if (item.Etkin)
                {
                    SelectListItem li = new SelectListItem()
                    {
                        Text = item.Baslik,
                        Value = item.SlideKategoriID.ToString()
                    };
                    sli.Add(li);
                }
            }
            return new SelectList(sli, "Value", "Text");
        }

        #endregion
    }
}
