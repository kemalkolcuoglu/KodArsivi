using KursProgrami.Model;
using System.Web.Mvc;

namespace KursProgrami.Web.Filters
{
    public class BakimFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            GenelAyarlar ga = App_Start.Tanimlamalar.genelAyarlarIslemleri.Bul("1 = 1");

            // TODO : Siteye Etkin olması eklenecek

            if (!ga.SMSGonderimEtkin)
                filterContext.Result = new RedirectResult("/Ev/Bakim");
        }
    }
}