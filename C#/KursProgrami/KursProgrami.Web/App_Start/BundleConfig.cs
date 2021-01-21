using System.Web.Optimization;

namespace KursProgrami.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Assets/bower_components/bootstrap/css/bootstrap.min.css",
                "~/Assets/css/component.css",
                "~/Assets/css/style.css",
                "~/Assets/pages/waves/css/waves.min.css",
                "~/Assets/css/widget.css",
                "~/Assets/css/pages.css"));

            bundles.Add(new ScriptBundle("~/Scripts/js").Include(
                "~/Assets/js/jquery-3.3.1.min.js",
                "~/Assets/js/pace.min.js",
                "~/Assets/bower_components/jquery-ui/js/jquery-ui.min.js",
                "~/Assets/bower_components/popper.js/js/popper.min.js",
                "~/Assets/bower_components/bootstrap/js/bootstrap.min.js",
                "~/Assets/bower_components/modernizr/js/modernizr.js",
                "~/Assets/pages/waves/js/waves.min.js",
                "~/Assets/js/pcoded.min.js",
                "~/Assets/js/vertical/vertical-layout.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/veliJS").Include(
                "~/Assets/js/jquery-3.3.1.min.js",
                "~/Assets/js/pace.min.js",
                "~/Assets/bower_components/jquery-ui/js/jquery-ui.min.js",
                "~/Assets/bower_components/popper.js/js/popper.min.js",
                "~/Assets/bower_components/bootstrap/js/bootstrap.min.js",
                "~/Assets/pages/waves/js/waves.min.js",
                "~/Assets/bower_components/jquery-slimscroll/js/jquery.slimscroll.js",
                "~/Assets/bower_components/modernizr/js/modernizr.js",
                "~/Assets/bower_components/modernizr/js/css-scrollbars.js",
                "~/Assets/js/pcoded.min.js",
                "~/Assets/js/vertical/vertical-layout.min.js",
                "~/Assets/js/jquery.mCustomScrollbar.concat.min.js"));

            BundleTable.EnableOptimizations = false;
        }
    }
}