using KursProgrami.Model;
using KursProgrami.Model.EkModel;
using KursProgrami.Web.Filters;
using KursProgrami.Web.Islemler;
using KursProgrami.Web.Islemler.Helpers;
using KursProgrami.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Mvc;
using static KursProgrami.Web.App_Start.Tanimlamalar;

namespace KursProgrami.Web.Controllers
{
    public class PanelController : Controller
    {
        [YetkiFilter]
        [HataFilter]
        public ActionResult Anasayfa() => View();

        [YetkiFilter]
        public ActionResult GenelAyarlar()
        {
            GenelAyarlar genelAyarlar = genelAyarlarIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID);

            if (genelAyarlar == null)
                return HttpNotFound();

            return View(genelAyarlar);
        }

        [YetkiFilter]
        [HataFilter]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GenelAyarlar(GenelAyarlar yeniGenelAyarlar)
        {
            if (ModelState.IsValid)
            {
                GenelAyarlar genelAyarlar = genelAyarlarIslemleri.Bul("KursID = " + AnlikOturum.Kullanici.KurumID);
                genelAyarlar.EPostaAdresi = yeniGenelAyarlar.EPostaAdresi;
                genelAyarlar.EPostaPort = yeniGenelAyarlar.EPostaPort;
                genelAyarlar.EPostaSifresi = yeniGenelAyarlar.EPostaSifresi;
                genelAyarlar.EPostaSunucusu = yeniGenelAyarlar.EPostaSunucusu;
                genelAyarlar.SMSBaslik = yeniGenelAyarlar.SMSBaslik;
                genelAyarlar.SMSGonderimEtkin = yeniGenelAyarlar.SMSGonderimEtkin;
                genelAyarlar.SMSSifre = yeniGenelAyarlar.SMSSifre;
                genelAyarlar.SMSTelefon = yeniGenelAyarlar.SMSTelefon;

                int durum = genelAyarlarIslemleri.Guncelle("KursID = " + AnlikOturum.Kullanici.KurumID, genelAyarlar);

                if (durum > 0)
                    return RedirectToAction(nameof(Anasayfa));
            }
            return View(yeniGenelAyarlar);
        }

        [HataFilter]
        public ActionResult Giris()
        {
            if (AnlikOturum.Kullanici != null)
                return RedirectToAction(nameof(Anasayfa));
            return View();
        }

        [HataFilter]
        public ActionResult Cikis()
        {
            if (AnlikOturum.Kullanici != null)
                AnlikOturum.Clear();
            return RedirectToAction(nameof(Giris));
        }

        [HataFilter]
        public ActionResult EgitmenGirisi()
        {
            if (AnlikOturum.Kullanici != null)
                return RedirectToAction(nameof(Anasayfa));
            return View();
        }

        [HataFilter]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EgitmenGirisi(KullaniciGirisi kullanici)
        {
            if (ModelState.IsValid)
            {
                IslemKatmaniOgesi<Kullanici> iko = kullaniciIslemleri.KullaniciGirisIslemleri(kullanici);
                if (iko.Hatalar.Count == 0)
                {
                    Session["Kullanici"] = iko.Varlik;
                    AnlikOturum.Kullanici.DonemID = donemIslemleri.Bul("Etkin = 1").DonemID;
                    return RedirectToAction(nameof(Anasayfa));
                }
                ViewBag.Hata = iko.Hatalar;
            }
            return View(kullanici);
        }

        [HataFilter]
        public ActionResult VeliGirisi()
        {
            if (AnlikOturum.Kullanici != null)
                return RedirectToAction(nameof(Anasayfa));
            return View();
        }

        [HataFilter]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VeliGirisi(string TCKNO)
        {
            Ogrenci ogrenci = ogrenciIslemleri.Bul("TCKNO = '" + TCKNO + "'");

            if (ogrenci == null)
                ViewBag.Hata = "Girmiş olduğunuz T.C. Kimlik No. kayıtlı öğrenci bulunamamıştır.";
            else
            {
                return RedirectToAction("DevamsizlikRapor", "Veli", new { TCKNO });
            }

            return View();
        }

        [HataFilter]
        public ActionResult IleGoreIlce(int id)
        {
            List<Ilce> ilceler = ilceIslemleri.VeriGetir("IlKodu = " + id);
            return Json(ilceler, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Hata()
        {
            string path = Path.Combine(Server.MapPath("~/Files"), "ErrorLog");

            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToString());
            sb.Append(" - ");
            sb.Append(TempData["SayfaHatasi"]);
            sb.Append(" - ");
            sb.Append((AnlikOturum.Kullanici != null) ? (AnlikOturum.Kullanici.Ad + " " + AnlikOturum.Kullanici.Soyad) : "Ziyaretçi");

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
                MailHelper.SendMail(log, "destek@qryazilim.com", "Hata Oluştu");
            }
            catch (Exception) { }

            return View();
        }

        //public ActionResult SahteVeriYaz()
        //{
        //    Random random = new Random();

        //    List<Ogrenci> ogrenciler = new List<Ogrenci>();
        //    List<OgrenciIletisim> ogrenciIletisimler = new List<OgrenciIletisim>();
        //    List<Sinif> siniflar = new List<Sinif>();
        //    List<Egitmen> egitmenler = new List<Egitmen>();

        //    for (int i = 0; i < 8; i++)
        //    {
        //        Egitmen egitmen = new Egitmen()
        //        {
        //            Ad = FakeData.NameData.GetMaleFirstName(),
        //            Soyad = NameData.GetSurname(),
        //            TCKNO = "58095774566",
        //            KursID = AnlikOturum.Kullanici.KurumID,
        //            Telefon = FakeData.PhoneNumberData.GetPhoneNumber()
        //        };
        //        egitmenler.Add(egitmen);
        //        egitmenIslemleri.Ekle(egitmen);

        //        Sinif sinif = new Sinif()
        //        {
        //            KursID = AnlikOturum.Kullanici.KurumID,
        //            SinifAdi = egitmen.Ad + " " + egitmen.Soyad + " Sınıfı",
        //            Konteyjan = 15,
        //            Etkin = true
        //        };

        //        siniflar.Add(sinif);
        //        sinifIslemleri.Ekle(sinif);
        //    }

        //    for (int i = 4; i >= 0; i--)
        //    {
        //        DateTime dt = DateTime.Today.AddYears(i * (-1));
        //        Donem donem = new Donem()
        //        {
        //            KursID = AnlikOturum.Kullanici.KurumID,
        //            DonemAdi = dt.Year + "-" + dt.AddYears(1).Year + " Dönemi",
        //            BaslangicTarihi = dt,
        //            BitisTarihi = dt.AddMonths(8),
        //            Konteyjan = 100,
        //            Etkin = true
        //        };
        //        donemIslemleri.Ekle(donem);
        //    }

        //    for (int i = 0; i < 100; i++)
        //    {
        //        il = ilIslemleri.Bul("IlKodu = " + random.Next(1, 81));
        //        ilce = ilceIslemleri.VeriGetir("IlKodu = " + il.IlKodu);
        //        Ogrenci ogrenci = new Ogrenci()
        //        {
        //            TCKNO = "17109603186",
        //            Durum = (int)Model.Enum.Durum.Aktif,
        //            Ad = NameData.GetMaleFirstName(),
        //            Soyad = NameData.GetSurname(),
        //            Cinsiyet = "E",
        //            DogumYeri = il.IlAdi,
        //            DogumTarihi = Convert.ToDateTime(FakeData.DateTimeData.GetDatetime(DateTime.Today.AddYears(-18), DateTime.Today.AddYears(-8))),
        //            AnneAdi = NameData.GetFemaleFirstName(),
        //            BabaAdi = NameData.GetMaleFirstName(),
        //            EngelDurumu = false,
        //            Guid = Guid.NewGuid().ToString(),
        //            KayitTarihi = DateTime.Now,
        //            Ekleyen = AnlikOturum.Kullanici.TCKNO,
        //            Etkin = true,
        //            EklemeTarihi = DateTime.Now,
        //            AnneMeslegi = "Ev Hanımı",
        //            BabaMeslegi = "İşçi",
        //        };
        //        ogrenciler.Add(ogrenci);
        //        ogrenciIslemleri.Ekle(ogrenci);
        //    }

        //    foreach (var item in ogrenciIslemleri.VeriGetir("1 = 1"))
        //    {
        //        il = ilIslemleri.Bul("IlAdi = '" + item.DogumYeri + "'");
        //        ilce = ilceIslemleri.VeriGetir("IlKodu = " + il.IlKodu);
        //        OgrenciIletisim ogrenciIletisim = new OgrenciIletisim()
        //        {
        //            OgrenciID = item.OgrenciID,
        //            Telefon1 = FakeData.PhoneNumberData.GetPhoneNumber(),
        //            Telefon2 = PhoneNumberData.GetPhoneNumber(),
        //            EPosta = NetworkData.GetEmail(item.Ad, item.Soyad),
        //            Il = il.IlKodu,
        //            Ilce = ilce[random.Next(ilce.Count - 1)].IlceKodu,
        //            Adres = PlaceData.GetAddress()
        //        };
        //        ogrenciIletisimIslemleri.Ekle(ogrenciIletisim);

        //        OgrenciKursSinif ogrenciKursSinif = new OgrenciKursSinif()
        //        {
        //            OgrenciID = item.OgrenciID,
        //            KursID = AnlikOturum.Kullanici.KurumID,
        //            SinifID = siniflar[random.Next(siniflar.Count - 1)].SinifID
        //        };
        //        ogrenciKursSinifIslemleri.Ekle(ogrenciKursSinif);
        //    }

        //    return RedirectToAction(nameof(Anasayfa));
        //}
    }
}