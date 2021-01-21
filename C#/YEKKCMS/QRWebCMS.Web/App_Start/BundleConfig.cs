using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace QRWebCMS.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Assets/vendor/bootstrap/css/bootstrap.min.css",
                "~/Assets/vendor/fontawesome-free/css/all.min.css",
                "~/Assets/vendor/animate/animate.min.css",
                "~/Assets/vendor/simple-line-icons/css/simple-line-icons.min.css",
                "~/Assets/vendor/owl.carousel/assets/owl.carousel.min.css",
                "~/Assets/vendor/owl.carousel/assets/owl.theme.default.min.css",
                "~/Assets/vendor/magnific-popup/magnific-popup.min.css",
                "~/Assets/Content/theme.css",
                "~/Assets/Content/theme-elements.css",
                "~/Assets/Content/theme-blog.css",
                "~/Assets/Content/theme-shop.css",
                "~/Assets/vendor/rs-plugin/css/settings.css",
                "~/Assets/vendor/rs-plugin/css/layers.css",
                "~/Assets/vendor/rs-plugin/css/navigation.css",
                "~/Assets/Content/skins/default.css",
                "~/Assets/Content/custom.css",
                "~/Stil/amaranjs/css/amaran.min.css"));

            bundles.Add(new ScriptBundle("~/Scripts/js").Include(
                "~/Assets/vendor/jquery/jquery.min.js",
                "~/Assets/vendor/modernizr/modernizr.min.js",
                "~/Assets/vendor/jquery.appear/jquery.appear.min.js",
                "~/Assets/vendor/jquery.easing/jquery.easing.min.js",
                "~/Assets/vendor/jquery.cookie/jquery.cookie.min.js",
                "~/Assets/vendor/popper/umd/popper.min.js",
                "~/Assets/vendor/bootstrap/js/bootstrap.min.js",
                "~/Assets/vendor/common/common.min.js",
                "~/Assets/vendor/jquery.validation/jquery.validate.min.js",
                "~/Assets/vendor/jquery.easy-pie-chart/jquery.easypiechart.min.js",
                "~/Assets/vendor/jquery.gmap/jquery.gmap.min.js",
                "~/Assets/vendor/jquery.lazyload/jquery.lazyload.min.js",
                "~/Assets/vendor/isotope/jquery.isotope.min.js",
                "~/Assets/vendor/owl.carousel/owl.carousel.min.js",
                "~/Assets/vendor/magnific-popup/jquery.magnific-popup.min.js",
                "~/Assets/vendor/vide/jquery.vide.min.js",
                "~/Assets/vendor/vivus/vivus.min.js",
                "~/Assets/Script/theme.js",
                "~/Assets/vendor/rs-plugin/js/jquery.themepunch.tools.min.js",
                "~/Assets/vendor/rs-plugin/js/jquery.themepunch.revolution.min.js",
                "~/Assets/Script/custom.js",
                "~/Assets/Script/theme.init.js",
                "~/Assets/Script/examples/examples.portfolio.js",
                "~/Stil/amaranjs/js/jquery.amaran.min.js"));



            BundleTable.EnableOptimizations = false;
        }
    }
}