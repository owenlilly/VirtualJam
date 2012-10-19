using System.Web;
using System.Web.Optimization;

namespace VirtualJA
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.*"));

            // bootstrap
            bundles.Add(new StyleBundle("~/Scripts/bootstrap/css/bootstrap").Include(
                        "~/Scripts/bootstrap/css/bootstrap.css",
                        "~/Scripts/bootstrap/css/bootstrap-responsive.css"));

            bundles.Add(new ScriptBundle("~/Scripts/bootstrap/js/bootstrap.js").Include(
                        "~/Scripts/bootstrap/js/bootstrap.js"));

            // Custom styles & scripts
            bundles.Add(new StyleBundle("~/css").Include(
                        "~/css/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/scripts.js"));

            // Other
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
        }
    }
}