using System.Web.Mvc;

namespace QRWebCMS.Web.Filters
{
    public class BakimFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            Models.GenelAyarlar ga = App_Start.Tanimlamalar.genelAyarlarIslemleri.Bul("1 = 1");

            if(!ga.Etkin)
                filterContext.Result = new RedirectResult("/Ev/Bakim");
        }
    }
}