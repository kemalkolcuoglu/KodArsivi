using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IcerikYonetimSistemi.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Sayfalar",
				url: "Sayfalar/{action}/{sayfaId}/{icerikId}",
				defaults: new { controller = "Sayfalar", action = "Sayfa", sayfaId = UrlParameter.Optional, icerikId = UrlParameter.Optional }
			);

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Ev", action = "Anasayfa", id = UrlParameter.Optional }
			);
        }
    }
}
