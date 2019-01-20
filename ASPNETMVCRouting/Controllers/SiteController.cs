using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVCRouting.Controllers
{
    public class SiteController : Controller
    {
        public ActionResult Anasayfa()
        {
            return View();
        }

        //arsiv
        public ActionResult Arsiv()
        {
            return View();
        }

        //arsiv/28-05-2018
        public ActionResult ArsivTarih(string tarih)
        {
            ViewBag.tarih = tarih;
            return View();
        }


    }
}