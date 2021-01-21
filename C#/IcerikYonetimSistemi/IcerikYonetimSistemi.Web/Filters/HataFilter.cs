using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IcerikYonetimSistemi.Web.Filters
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