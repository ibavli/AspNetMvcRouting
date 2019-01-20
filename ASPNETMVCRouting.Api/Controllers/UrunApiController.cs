using ASPNETMVCRouting.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASPNETMVCRouting.Api.Controllers
{
    public class UrunApiController : ApiController
    {
        private List<Urun> _urunler = new List<Urun>()
        {
            new Urun(){ Id = 1, Ad = "Bilgisayar", Fiyat = 4750},
            new Urun(){ Id = 2, Ad = "Telefon", Fiyat = 3730},
            new Urun(){ Id = 3, Ad = "Mouse", Fiyat = 2540},
            new Urun(){ Id = 4, Ad = "Klavye", Fiyat = 420},
            new Urun(){ Id = 5, Ad = "Monitör", Fiyat = 1240}
        };

        [HttpGet]
        public IEnumerable<Urun> TumUrunler()
        {
            return _urunler;
        }
    }
}
