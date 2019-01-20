using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVCRouting.Controllers
{
    public class HaberKategoriController : Controller
    {
        //public ActionResult Anasayfa(string kategori)
        //{
        //    ViewBag.KategoriAdi = kategori;
        //    return View();
        //}

        //kategori/spor
        //kategori/spor/futbol
        //kategori/spor/futbol/galatasaray
        public ActionResult Anasayfa()
        {
            int routeSirasi = this.RouteData.Values.Count - 3;
            string kategori = this.RouteData.Values["kategori" + routeSirasi].ToString();
            ViewBag.KategoriAdi = kategori;
            return View();
        }
    }
}