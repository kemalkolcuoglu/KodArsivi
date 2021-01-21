using KursProgrami.Model;
using KursProgrami.Web.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static KursProgrami.Web.App_Start.Tanimlamalar;

namespace KursProgrami.Web.Controllers
{
    [HataFilter]
    public class VeliController : Controller
    {
        public ActionResult DevamsizlikRapor(string TCKNO)
        {
            if (String.IsNullOrEmpty(TCKNO))
                throw new Exception();
            Ogrenci ogrenci = ogrenciIslemleri.Bul("TCKNO = '" + TCKNO + "'");
            List<OgrenciDevamsizlik> ogrenciDevamsizlik = ogrenciDevamsizlikIslemleri.VeriGetirSQL("Select * From ogrencidevamsizlik Where OgrenciID = " + ogrenci.OgrenciID);
            Kurs kurs = kursIslemleri.Bul("1 = 1");

            ViewData["Ogrenci"] = ogrenci;
            ViewData["OgrenciDevamsizlik"] = ogrenciDevamsizlik;
            ViewData["Kurs"] = kurs;

            return View();
        }

        public ActionResult NotRaporu(string TCKNO)
        {
            if (String.IsNullOrEmpty(TCKNO))
                throw new Exception();
            Ogrenci ogrenci = ogrenciIslemleri.Bul("TCKNO = '" + TCKNO + "'");
            List<OgrenciNot> ogrenciNot = ogrenciNotIslemleri.VeriGetirSQL("Select * From ogrencinot Where OgrenciID = " + ogrenci.OgrenciID);
            Kurs kurs = kursIslemleri.Bul("1 = 1");

            ViewData["Ogrenci"] = ogrenci;
            ViewData["OgrenciNot"] = ogrenciNot;
            ViewData["Kurs"] = kurs;

            return View();
        }
    }
}