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
    }
}