using QRWebCMS.Web.Models;
using System.Web.Mvc;

namespace QRWebCMS.Web.Filters
{
    public class SayacFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string action = filterContext.ActionDescriptor.ActionName;
            Sayac sayac = App_Start.Tanimlamalar.sayacIslemleri.Bul("Sayfa = '" + action + "'");
            //string parametreler = filterContext.ActionDescriptor.GetParameters().GetEnumerator().Current.ToString();

            if(sayac == null)
            {
                Sayac yeniSayac = new Sayac()
                {
                    Sayfa = action + "/" /*+ parametreler*/,
                    Sayi = 1
                };
                App_Start.Tanimlamalar.sayacIslemleri.Ekle(yeniSayac);
            }
            else
            {
                sayac.Sayi += 1;
                App_Start.Tanimlamalar.sayacIslemleri.Guncelle("SayacID = " + sayac.SayacID, sayac);
            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext) {  }
    }
}