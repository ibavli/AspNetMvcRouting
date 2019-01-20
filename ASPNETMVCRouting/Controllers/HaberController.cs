using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVCRouting.Controllers
{
    public class HaberController : Controller
    {
        //haber/spor/turkiye-kupayi-aldi
        //haber/spor/futbol/galatasaray-bakin-hangi-oyuncuyu-aldi
        public ActionResult Detay(string haber)
        {
            ViewBag.HaberAdi = haber.Replace("-", " ");
            return View();
        }

        
    }
}