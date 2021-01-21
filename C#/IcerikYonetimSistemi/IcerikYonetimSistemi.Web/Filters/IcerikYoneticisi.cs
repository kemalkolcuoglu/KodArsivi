using IcerikYonetimSistemi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IcerikYonetimSistemi.Web.Filters
{
	public class IcerikYoneticisi : FilterAttribute, IAuthorizationFilter
	{
		public void OnAuthorization(AuthorizationContext filterContext)
		{
			if (AnlikOturum.User != null && AnlikOturum.User.KullaniciYetkiID != 2)
				filterContext.Result = new RedirectResult("/Ev/KullaniciGirisi");
		}
	}
}