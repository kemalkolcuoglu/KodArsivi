using QRWebCMS.Web.Models.EkModel;
using System.Web.Mvc;

namespace QRWebCMS.Web.Filters
{
    public class YetkiFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (AnlikOturum.Kullanici == null)
                filterContext.Result = new RedirectResult("/Yonetici/Panel/KullaniciGiris");
        }
    }
}