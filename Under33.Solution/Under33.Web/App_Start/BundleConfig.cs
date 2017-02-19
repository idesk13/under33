using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/vendor/jquery/jquery-3.1.1.min.js",
                        "~/Scripts/vendor/bootstrap/bootstrap.min.js",
                        "~/Scripts/vendor/remodal/remodal.min.js",
                        "~/Scripts/app/main.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/css/global.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
