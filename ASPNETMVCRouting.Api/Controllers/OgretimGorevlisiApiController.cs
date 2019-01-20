using ASPNETMVCRouting.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASPNETMVCRouting.Api.Controllers
{
    [RoutePrefix("ogretimgorevlisi")]
    public class OgretimGorevlisiApiController : ApiController
    {
        private List<Ders> _dersler = new List<Ders>()
        {
            new Ders() { Id = 1, OgretimGorevlisi = "aliveli", Kod = "A123" },
            new Ders() { Id = 2, OgretimGorevlisi = "hasanhuseyin", Kod = "A124" },
            new Ders() { Id = 3, OgretimGorevlisi = "aysefatma", Kod = "A125" },
            new Ders() { Id = 4, OgretimGorevlisi = "alimert", Kod = "A126" },
            new Ders() { Id = 5, OgretimGorevlisi = "mehmethikmet", Kod = "A127" }
        };

        [HttpGet]
        //[Route("ogretimgorevlisi/{ad}/dersler")] //Yukarıya bir kere tanımladık bir daha bu controllerdakilerin hepsinin başına ogretimgorevlisi koyulmuş olacak. Tek tek yazmaktan kurtulduk.
        [Route("{ad}/dersler")]
        public IEnumerable<Ders> Dersler(string ad)
        {
            return _dersler.Where(o => o.OgretimGorevlisi == ad);
        }
    }
}
