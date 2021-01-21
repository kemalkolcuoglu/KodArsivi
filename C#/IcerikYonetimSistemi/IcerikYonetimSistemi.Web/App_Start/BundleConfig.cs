using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace IcerikYonetimSistemi.Web.App_Start
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new StyleBundle("~/css/all").Include(
				"~/Content/*.css",
				"~/Content/*.scss"
				));

			bundles.Add(new ScriptBundle("~/js/all").Include(
				"~/Scripts/*.js"
				));

			BundleTable.EnableOptimizations = true;
		}
	}
}