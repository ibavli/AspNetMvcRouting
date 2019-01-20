using ASPNETMVCRouting.RouteConstraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPNETMVCRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");//.axd uzantılı isteklere erişimi engellemektir.

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                "Default", // Route name
                "",        // URL with parameters
                new { controller = "Site", action = "Anasayfa" }  // Parameter defaults
            );

            routes.MapRoute(
                name:"Anasayfa",
                url:"anasayfa",
                defaults: new { controller = "Site", action = "Anasayfa"});

            routes.MapRoute(
               name: "Arsiv",
               url: "arsiv",
               defaults: new { controller = "Site", action = "Arsiv" });

            routes.MapRoute(
               name: "ArsivTarih",
               url: "arsiv/{tarih}",
               defaults: new { controller = "Site", action = "ArsivTarih" });

            ////kategori/spor
            //routes.MapRoute(
            //    name: "Kategori",
            //    url: "kategori/{kategori}",
            //    defaults: new { controller = "HaberKategori", action = "Anasayfa" });


            //kategorilerin en yüksek kırılım sayısını veritabanından sorgulayıp öğrenmemiz gerekir. Fakat şimdilik biz 3 diyeceğiz.
            //kategori/{kategori0} : kategori/spor,  kategori/dunya
            //kategori/{kategori0}/{kategori1} : kategori/spor/futbol, kategori/dunya/ingiltere
            //kategori/{kategori0}/{kategori1}/{kategori2} : kategori/spor/futbol/fenerbahce, kategori/dunya/ingiltere/ekonomi
            int kategoriKirilimSayisi = 3;
            string kategoriUrl = "kategori";
            string haberUrl = "haber";
            string arsivUrl = "arsiv/{tarih}";
            for (int i = 0; i < kategoriKirilimSayisi; i++)
            {
                kategoriUrl += "/{kategori" + i + "}";
                routes.MapRoute(
                    name: "Kategori" + i,
                    url: kategoriUrl,
                    defaults: new { controller = "HaberKategori", action = "Anasayfa" });
                    //constraints: new { kategori = new KategoriRouteConstraints() });
                    //Bu metoda gidip gerçektende kategorimiz veritabanında var mı diye bakabiliriz. Kontrol edebiliriz.

                haberUrl += "/{kategori" + i + "}";
                routes.MapRoute(
                    name: "Haber" + i,
                    url: haberUrl + "/{haber}",
                    defaults: new { controller = "Haber", action = "Detay" });

                //kategori/spor/futbol/galatasaray
                arsivUrl += "/{kategori" + i + "}";
                routes.MapRoute(
                    name: "Arsiv" + i,
                    url: arsivUrl,
                    defaults: new { controller = "HaberKategori", action = "Arsiv" });
            }


            

        }
    }
}
