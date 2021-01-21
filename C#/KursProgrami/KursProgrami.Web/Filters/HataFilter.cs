namespace KursProgrami.Web.Filters
{
    public class HataFilter : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IExceptionFilter
    {
        public void OnException(System.Web.Mvc.ExceptionContext filterContext)
        {
            filterContext.Controller.TempData["SayfaHatasi"] = filterContext.Exception;

            filterContext.ExceptionHandled = true;
            filterContext.Result = new System.Web.Mvc.RedirectResult("/Panel/Hata");
        }
    }
}