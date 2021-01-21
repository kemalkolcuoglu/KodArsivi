using QRWebCMS.Web.App_Start;
using QRWebCMS.Web.Areas.Yonetici.Models.EkModel;
using QRWebCMS.Web.Filters;
using QRWebCMS.Web.Islemler;
using QRWebCMS.Web.Models;
using QRWebCMS.Web.Models.EkModel;
using System;
using System.IO;
using System.Text;
using System.Web.Mvc;

namespace QRWebCMS.Web.Areas.Yonetici.Controllers
{
    public class PanelController : Controller
    {
        [YoneticiHataFilter]
        [YetkiFilter]
        public ActionResult Anasayfa()
        {
            return View();
        }

        public ActionResult KullaniciGiris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KullaniciGiris(KullaniciGiris kullaniciGiris)
        {
            if (ModelState.IsValid)
            {
                IslemKatmaniOgesi<Kullanici> iko = Tanimlamalar.kullaniciIslemleri.KullaniciGirisIslemleri(kullaniciGiris);

                if (iko.Hatalar.Count > 0)
                    ViewBag.Hata = iko.Hatalar;
                else
                {
                    Session["Kullanici"] = iko.Varlik;
                    return RedirectToAction("Anasayfa");
                }
            }
            return View(kullaniciGiris);
        }

        [YoneticiHataFilter]
        [YetkiFilter]
        public ActionResult GenelAyarlar()
        {
            return View(Tanimlamalar.genelAyarlarIslemleri.Bul("1 = 1"));
        }

        [YoneticiHataFilter]
        [YetkiFilter]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult GenelAyarlar(GenelAyarlar genelAyarlar)
        {
            try
            {
                int durum;
                GenelAyarlar genel = Tanimlamalar.genelAyarlarIslemleri.Bul("1 = 1");

                if (genel == null)
                    durum = Tanimlamalar.genelAyarlarIslemleri.Ekle(genelAyarlar);
                else
                {
                    genelAyarlar.GenelAyarlarID = 1;
                    durum = Tanimlamalar.genelAyarlarIslemleri.Guncelle("GenelAyarlarID = 1", genelAyarlar);
                }

                if (durum < 1)
                    throw new Exception();
                return RedirectToAction(nameof(Anasayfa));
            }
            catch (Exception)
            {
                ViewBag.Hata = "Düzenleme İşlemi Gerçekleştirilemedi";
                return View(genelAyarlar);
            }
        }

        [YoneticiHataFilter]
        [YetkiFilter]
        public ActionResult TeknikAyarlar()
        {
            return View(Tanimlamalar.teknikAyarlarIslemleri.Bul("1 = 1"));
        }

        [YoneticiHataFilter]
        [YetkiFilter]
        [HttpPost]
        public ActionResult TeknikAyarlar(TeknikAyarlar teknikAyarlar)
        {
            try
            {
                int durum;
                TeknikAyarlar teknik = Tanimlamalar.teknikAyarlarIslemleri.Bul("1 = 1");
                if(teknik == null)
                    durum = Tanimlamalar.teknikAyarlarIslemleri.Ekle(teknikAyarlar);
                else
                {
                    teknikAyarlar.TeknikAyarlarID = 1;
                    durum = Tanimlamalar.teknikAyarlarIslemleri.Guncelle("TeknikAyarlarID = 1", teknikAyarlar);
                }
                               
                if (durum < 1)
                    throw new Exception();
                return RedirectToAction(nameof(Anasayfa));
            }
            catch (Exception)
            {
                ViewBag.Hata = "Düzenleme İşlemi Gerçekleştirilemedi";
                return View(teknikAyarlar);
            }
        }

        public ActionResult Hata()
        {
            string path = Path.Combine(Server.MapPath("~/Files"), "YoneticiErrorLog");

            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToString());
            sb.Append(" - ");
            sb.Append(TempData["SayfaHatasi"]);
            sb.Append(" - ");
            sb.Append((AnlikOturum.Kullanici != null) ? AnlikOturum.Kullanici.KullaniciAdi : "system");

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
                //Islemler.Helpers.MailHelper.SendMail(log, "destek@qryazilim.com", "Hata Oluştu");
            }
            catch (Exception) { }

            return View();
        }

        [YoneticiHataFilter]
        [YetkiFilter]
        public ActionResult Formlar()
        {
            return View(Tanimlamalar.formIslemleri.VeriGetir("1 = 1 Order By GonderimTarihi Desc"));
        }

        [YoneticiHataFilter]
        [YetkiFilter]
        public ActionResult Form(int id)
        {
            return View(Tanimlamalar.formIslemleri.Bul("FormID = " + id));
        }
    }
}
