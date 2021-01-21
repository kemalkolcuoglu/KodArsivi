using QRWebCMS.Web.App_Start;
using QRWebCMS.Web.Filters;
using QRWebCMS.Web.Models;
using QRWebCMS.Web.Models.EkModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Mvc;

namespace QRWebCMS.Web.Controllers
{
    [SayacFilter]
    //[HataFilter]
    public class EvController : Controller
    {
        [BakimFilter]
        public ActionResult Anasayfa()
        {
            Sayfa sayfa = Tanimlamalar.sayfaIslemleri.Bul("EkAlan1 = 'Anasayfa'");
            if (sayfa != null)
            {
                List<SayfaListe> sayfaListe = Tanimlamalar.sayfaListeIslemleri.VeriGetir("SayfaID = " + sayfa.SayfaID + " Order By GosterimSirasi");

                if (sayfaListe != null && sayfaListe.Count > 0)
                {
                    List<Icerik> icerik = Tanimlamalar.icerikIslemleri.VeriGetir("Etkin = 1 And SayfaID = " + sayfa.SayfaID);
                    List<GaleriKategori> galeriKategori = Tanimlamalar.galeriKategoriIslemleri.VeriGetirSQL("Select * From vGaleriKategori Where SayfaID = " + sayfa.SayfaID);
                    List<SlideKategori> slideKategori = Tanimlamalar.slideKategoriIslemleri.VeriGetirSQL("Select * From vSlideKategori Where SayfaID = " + sayfa.SayfaID);
                    List<UrunKategori> urunKategori = Tanimlamalar.urunKategoriIslemleri.VeriGetirSQL("Select * From vUrunKategori Where SayfaID = " + sayfa.SayfaID);

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
            }
            return View();

            throw new Exception();
        }

        [BakimFilter]
        public ActionResult Iletisim()
        {
            return View();
        }

        [BakimFilter]
        [HttpPost]
        public ActionResult Iletisim(Form form)
        {
            if (ModelState.IsValid)
            {
                form.GonderimTarihi = DateTime.Now;
                int durum = Tanimlamalar.formIslemleri.Ekle(form);
                if (durum == 1)
                {
                    ViewBag.Mesaj = "Mesaj ilettiğiniz için teşekkür ederiz. Mesajınız başarıyla kaydedilmiştir.";
                    try
                    {
                        TeknikAyarlar teknikAyarlar = Tanimlamalar.teknikAyarlarIslemleri.Bul("1 = 1");
                        GenelAyarlar genelAyarlar = Tanimlamalar.genelAyarlarIslemleri.Bul("1 = 1");
                        if (teknikAyarlar != null && teknikAyarlar.EPostaAdresi != null)
                        {
                            string body = String.Format(
                                            "İletişim Formu Gönderildi!<hr/>" +
                                            "Gönderen Ad Soyad: {0} <br/>" +
                                            "E-Posta: {1} <br/>" +
                                            "Konu: {2} <br/>" +
                                            "Mesaj: {3} <br/>"+
                                            "Gonderim Tarihi: {4} <br/>" , form.AdSoyad, form.EPosta, form.Konu, form.MesajIcerigi,form.GonderimTarihi
                                          );
                            Islemler.Helpers.MailHelper.SendMail(body, teknikAyarlar.EPostaAdresi, $"{genelAyarlar.SiteAdi} - İletişim Formu Gönderildi");
                        }
                    }
                    catch (Exception exp)
                    {
                        Console.WriteLine(exp.Message);

                    }
                    return View();
                }
            }
            ViewBag.Hata = "Mesajınız iletilemedi. Lütfen bilgileri kontrol ederek tekrar deneyiniz.";
            return View(form);
        }

        public ActionResult Hata()
        {
            string path = Path.Combine(Server.MapPath("~/Files"), "ErrorLog");

            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToString());
            sb.Append(" - ");
            sb.Append(TempData["SayfaHatasi"]);
            sb.Append(" - ");
            sb.Append((AnlikOturum.Kullanici != null) ? AnlikOturum.Kullanici.KullaniciAdi : "Ziyaretçi");

            string log = sb.ToString();
            sb.Clear();

            if (!System.IO.File.Exists(path))
                System.IO.File.Create(path).Dispose();

            using (StreamWriter sw = new StreamWriter(path: path, append: true, encoding: Encoding.GetEncoding("windows-1254")))
            {
                sw.WriteLine(log);
            }

            try
            {
                //Islemler.Helpers.MailHelper.SendMail(log, "destek@qryazilim.com", "QR Web CMS - Hata Oluştu");
            }
            catch (Exception) { }

            return View();
        }

        public ActionResult Bakim()
        {
            GenelAyarlar ga = Tanimlamalar.genelAyarlarIslemleri.Bul("1 = 1");
            if (!ga.Etkin)
                return View();
            else
                return RedirectToAction(nameof(Anasayfa));
        }
    }
}
