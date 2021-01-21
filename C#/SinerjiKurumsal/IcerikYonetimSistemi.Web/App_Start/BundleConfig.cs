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
			// Base Style Bundles
			BundleTable.Bundles.Add(new StyleBundle("~/Styles/Base")
				.Include(
					"~/Content/style.css",
					"~/Content/css.css",
					"~/Content/bootstrap.css",
					"~/Content/animsition.css",
					"~/Content/themify-icons.css",
					"~/Content/owl.carousel.css",
					"~/Content/cubeportfolio.css",
					"~/Content/magnific-popup.css",
					"~/Content/flexslider.css",
					"~/Content/nouislider.css",
					"~/Content/zoomove.css",
					"~/Content/shop.css",
					"~/Content/shortcodes.css",
					"~/Content/settings.css",
					"~/Content/layers.css",
					"~/Content/navigation.css",
					"~/Content/color-1.css"
				)
			);

			// Base Script Bundles
			BundleTable.Bundles.Add(new ScriptBundle("~/Scripts/Base")
				.Include(
					"~/Scripts/jquery.min.js",
					"~/Scripts/bootstrap.min.js",
					"~/Scripts/animsition.js",
					"~/Scripts/waypoint.js",
					"~/Scripts/parallax.js",
					"~/Scripts/matchMedia.js",
					"~/Scripts/fitvids.js",
					"~/Scripts/easing.js",
					"~/Scripts/countTo.js",
					"~/Scripts/owl.carousel.min.js",
					"~/Scripts/cubeportfolio.js",
					"~/Scripts/magnific.popup.min.js",
					"~/Scripts/shortcodes.js",
					"~/Scripts/main.js",
					"~/Scripts/jquery.themepunch.tools.min.js",
					"~/Scripts/jquery.themepunch.revolution.min.js"
				)
			);

			// Yonetici Style Bundles
			BundleTable.Bundles.Add(new StyleBundle("~/Styles/Yonetici")
				.Include(
					"~/Content/Yonetici/bootstrap.min.css",
					"~/Content/Yonetici/dataTables.bootstrap4.css",
					"~/Content/Yonetici/sb-admin.css"
				)
			);

			// Yonetici Script Bundles
			BundleTable.Bundles.Add(new ScriptBundle("~/Scripts/Yonetici")
				.Include(
					"~/Scripts/Yonetici/jquery.min.js",
					"~/Scripts/Yonetici/bootstrap.bundle.min.js",
					"~/Scripts/Yonetici/jquery.easing.min.js",
					"~/Scripts/Yonetici/Chart.min.js",
					"~/Scripts/Yonetici/jquery.dataTables.js",
					"~/Scripts/Yonetici/dataTables.bootstrap4.js",
					"~/Scripts/Yonetici/sb-admin.min.js"
				)
			);

			BundleTable.EnableOptimizations = true;
		}
	}
}