using System.Web.Mvc;

namespace QRWebCMS.Web.Filters
{
    public class HataFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.Controller.TempData["SayfaHatasi"] = filterContext.Exception;

            filterContext.ExceptionHandled = true;
            filterContext.Result = new RedirectResult("/Ev/Hata");
        }
    }
}