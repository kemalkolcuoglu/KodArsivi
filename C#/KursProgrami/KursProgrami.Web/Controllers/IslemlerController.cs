using KursProgrami.Model;
using KursProgrami.Model.Enum;
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
    public class IslemlerController : Controller
    {
        #region Devamsizlik

        public ActionResult Devamsizliklar()
        {
            List<Sinif> siniflar = sinifIslemleri.VeriGetir("KursID = " + AnlikOturum.Kullanici.KurumID);

            return View(siniflar);
        }

        // Parametreler (ID: SinifID)
        public ActionResult DevamsizlikListesi(int id)
        {
            Dictionary<string, bool> model = new Dictionary<string, bool>();
            List<OgrenciKursSinif> ogrenciler = ogrenciKursSinifIslemleri.VeriGetirSQL("Select * From vsinifogrenci Where SinifID = " + id);
            List<SaatlikProgram> saatlikProgram = saatlikProgramIslemleri.VeriGetir("KursID = " + AnlikOturum.Kullanici.KurumID + " And Yoklama = 1 Order By BaslangicSaati");
            ViewData["ogrenciler"] = ogrenciler;
            ViewData["program"] = saatlikProgram;

            foreach (var item in ogrenciDevamsizlikIslemleri.VeriGetir("Tarih = '" + DateTime.Today.ToString("yyyy-MM-dd") + "'"))
            {
                if (!item.DevamDurumu)
                    model.Add($"{item.OgrenciID}_{item.ProgramID}", !item.DevamDurumu);
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DevamsizlikListesi(int id, Dictionary<string, bool> model)
        {
            foreach (var item in model)
            {
                if (item.Value)
                {
                    string[] degerler = item.Key.ToString().Split('_');

                    OgrenciDevamsizlik devamTakip = ogrenciDevamsizlikIslemleri.Bul("OgrenciID = " + degerler[0] + " And ProgramID = " + degerler[1] + " And Tarih = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'");

                    if (devamTakip == null && devamTakip.DevamDurumu == item.Value)
                    {
                        OgrenciDevamsizlik ogrenciDevamsizlik = new OgrenciDevamsizlik()
                        {
                            Tarih = DateTime.Today,
                            KursID = AnlikOturum.Kullanici.KurumID,
                            DevamDurumu = false,
                            DevamsizlikNedeni = (int)DevamsizlikNedeni.Gelmedi,
                            ProgramID = Convert.ToInt32(degerler[1]),
                            OgrenciID = Convert.ToInt32(degerler[0]),
                            DonemID = AnlikOturum.Kullanici.DonemID
                        };
                        ogrenciDevamsizlikIslemleri.Ekle(ogrenciDevamsizlik);
                    }
                    else
                    {
                        devamTakip.DevamDurumu = !item.Value;
                        ogrenciDevamsizlikIslemleri.Guncelle("OgrenciDevamsizlikID = " + devamTakip.OgrenciDevamsizlikID, devamTakip);
                    }
                }
            }

            ViewData["ogrenciler"] = ogrenciKursSinifIslemleri.VeriGetirSQL("Select * From vsinifogrenci Where SinifID = " + id);
            ViewData["program"] = saatlikProgramIslemleri.VeriGetir("KursID = " + AnlikOturum.Kullanici.KurumID + " And Yoklama = 1 Order By BaslangicSaati");
            return View(model);
        }

        public ActionResult DevamsizlikTakip(int? id, string tarih)
        {
            if (string.IsNullOrEmpty(tarih))
                tarih = DateTime.Now.ToString("yyyy-MM-dd");

            Dictionary<string, bool> model = new Dictionary<string, bool>();
            List<OgrenciKursSinif> ogrenciler;
            if (AnlikOturum.Kullanici.YetkiID == 1)
                ogrenciler = ogrenciKursSinifIslemleri.VeriGetirSQL("Select * From vsinifogrenci Where SinifID = " + id);
            else
                ogrenciler = ogrenciKursSinifIslemleri.VeriGetirSQL("Select * From vsinifogrenci Where SinifID = " + AnlikOturum.Kullanici.SinifID);

            List<SaatlikProgram> saatlikProgram = saatlikProgramIslemleri.VeriGetir("KursID = " + AnlikOturum.Kullanici.KurumID + " And Yoklama = 1 Order By BaslangicSaati");
            ViewData["ogrenciler"] = ogrenciler;
            ViewData["program"] = saatlikProgram;

            foreach (var item in ogrenciDevamsizlikIslemleri.VeriGetir("Tarih = '" + tarih + "'"))
            {
                if (!item.DevamDurumu)
                    model.Add($"{item.OgrenciID}_{item.ProgramID}", !item.DevamDurumu);
            }

            return View("DevamsizlikListesi", model);
        }

        #endregion

        #region Ders Notu

        //Parametreler (ID: SinifID)
        public ActionResult DersNotlari(int id)
        {
            Dictionary<string, string> model = new Dictionary<string, string>();
            List<OgrenciKursSinif> ogrenciler = ogrenciKursSinifIslemleri.VeriGetirSQL("Select * From vsinifogrenci Where SinifID = " + id);
            List<SaatlikProgram> saatlikProgram = saatlikProgramIslemleri.VeriGetir("KursID = " + AnlikOturum.Kullanici.KurumID + " And NotDegerlendirme = 1 Order By BaslangicSaati");
            ViewData["ogrenciler"] = ogrenciler;
            ViewData["program"] = saatlikProgram;

            foreach (var item in ogrenciNotIslemleri.VeriGetir("Tarih = '" + DateTime.Today.ToString("yyyy-MM-dd") + "'"))
            {
                model.Add($"{item.OgrenciID}_{item.ProgramID}", item.NotDurumu);
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DersNotlari(int id, Dictionary<string, string> model)
        {
            foreach (var item in model)
            {
                if (!String.IsNullOrEmpty(item.Value))
                {
                    string[] degerler = item.Key.ToString().Split('_');

                    OgrenciNot notTakip = ogrenciNotIslemleri.Bul("OgrenciID = " + degerler[0] + " And ProgramID = " + degerler[1] + " And Tarih = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'");

                    if (notTakip == null && notTakip.NotDurumu == item.Value)
                    {
                        OgrenciNot ogrenciNot = new OgrenciNot()
                        {
                            Tarih = DateTime.Today,
                            KursID = AnlikOturum.Kullanici.KurumID,
                            NotDurumu = item.Value,
                            ProgramID = Convert.ToInt32(degerler[1]),
                            OgrenciID = Convert.ToInt32(degerler[0]),
                            DonemID = AnlikOturum.Kullanici.DonemID
                        };
                        ogrenciNotIslemleri.Ekle(ogrenciNot);
                    }
                    else
                    {
                        notTakip.NotDurumu = item.Value;
                        ogrenciNotIslemleri.Guncelle("OgrenciNotID = " + notTakip.OgrenciNotID, notTakip);
                    }
                }
            }

            ViewData["ogrenciler"] = ogrenciKursSinifIslemleri.VeriGetirSQL("Select * From vsinifogrenci Where SinifID = " + id);
            ViewData["program"] = saatlikProgramIslemleri.VeriGetir("KursID = " + AnlikOturum.Kullanici.KurumID + " And NotDegerlendirme = 1 Order By BaslangicSaati");
            return View(model);
        }

        public ActionResult DersNotTakip(int? id, string tarih)
        {
            if (String.IsNullOrEmpty(tarih))
                tarih = DateTime.Now.ToString("yyyy-MM-dd");

            Dictionary<string, string> model = new Dictionary<string, string>();
            List<OgrenciKursSinif> ogrenciler;
            List<SaatlikProgram> saatlikProgram;
            if (AnlikOturum.Kullanici.YetkiID == 1)
            {
                ogrenciler = ogrenciKursSinifIslemleri.VeriGetirSQL("Select * From vsinifogrenci Where SinifID = " + id);

                //TODO : EgitmenID için yeni bir yol düşünülecek
                saatlikProgram = saatlikProgramIslemleri.VeriGetir("KursID = " + AnlikOturum.Kullanici.KurumID + " And EgitmenID = " + AnlikOturum.Kullanici.NitelikID + " And NotDegerlendirme = 1 Order By BaslangicSaati");
            }
            else
            {
                ogrenciler = ogrenciKursSinifIslemleri.VeriGetirSQL("Select * From vsinifogrenci Where SinifID = " + AnlikOturum.Kullanici.SinifID);
                saatlikProgram = saatlikProgramIslemleri.VeriGetir("KursID = " + AnlikOturum.Kullanici.KurumID + " And EgitmenID = " + AnlikOturum.Kullanici.NitelikID + " And NotDegerlendirme = 1 Order By BaslangicSaati");
            }
            
            ViewData["ogrenciler"] = ogrenciler;
            ViewData["program"] = saatlikProgram;

            foreach (var item in ogrenciNotIslemleri.VeriGetir("Tarih = '" + tarih + "'"))
            {
                model.Add($"{item.OgrenciID}_{item.ProgramID}", item.NotDurumu);
            }

            return View(model);
        }

        #endregion
    }
}
