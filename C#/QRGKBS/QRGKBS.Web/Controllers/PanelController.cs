using QRGKBS.Varlik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static QRGKBS.Web.App_Start.Tanimlamalar;

namespace QRGKBS.Web.Controllers
{
    public class PanelController : Controller
    {
        public ActionResult Anasayfa()
        {
            List<Kisi> kisiler = kisiIslemleri.VeriGetir();

            return View(kisiler);
        }

        public ActionResult Action()
        {
            return View();
        }
    }
}