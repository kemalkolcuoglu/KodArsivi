using System.Web.Mvc;

namespace QRWebCMS.Web.Areas.Yonetici
{
    public class YoneticiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Yonetici";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Yonetici_default",
                "Yonetici/{controller}/{action}/{id}/{altid}",
                new { action = "Anasayfa", id = UrlParameter.Optional, altid = UrlParameter.Optional }
            );
        }
    }
}