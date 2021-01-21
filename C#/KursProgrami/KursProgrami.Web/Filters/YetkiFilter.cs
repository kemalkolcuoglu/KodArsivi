using KursProgrami.Web.Models;
using System.Web.Mvc;

namespace KursProgrami.Web.Filters
{
    public class YetkiFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (AnlikOturum.Kullanici == null)
                filterContext.Result = new RedirectResult("/Panel/Giris");
        }
    }
}