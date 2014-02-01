using System.Web;
using System.Web.Optimization;

namespace cadeteditor.com
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/bower_components/jquery/jquery.min.js",
                "~/bower_components/bootstrap/dist/js/bootstrap.js",      
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/bower_components/bootstrap/dist/css/bootstrap.css",
                      "~/bower_components/bootstrap/dist/css/bootstrap-theme.css",
                      "~/Content/site.css"));
        }
    }
}
