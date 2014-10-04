using System.Web.Optimization;

namespace MusicOrganiser.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

#if !DEBUG
                BundleTable.EnableOptimizations = true;
#endif


//            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
//#if DEBUG
//                "~/Scripts/AlertOnError.js",
//#endif
//                "~/Scripts/Vendor/require.js",
//                "~/Scripts/RequireConfig.js"
//            ).IncludeDirectory(
//                "~/Scripts/Songs/", "*.js"
//            ));

            bundles.Add(new StyleBundle("~/content/css").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/site.css"
                )
            );
        }
    }
}
