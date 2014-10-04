using System.Web.Optimization;

namespace App.MusicOrganiser.Spa
{

    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/css/app").Include("~/content/app.css"));

            bundles.Add(
                new ScriptBundle("~/js/app") { Orderer = new AngularModuleBundleOrderer() }
                .Include(
                    "~/scripts/vendor/jquery-{version}.js",
                    "~/scripts/vendor/angular.js",
                    "~/scripts/vendor/bootstrap.js",
                    "~/scripts/vendor/angular-resource.js",
                    "~/scripts/vendor/angular-ui-router.js",
                    "~/scripts/filters.js",
                    "~/scripts/services.js",
                    "~/scripts/directives.js",
                    "~/scripts/controllers.js"
                 ).IncludeDirectory(
                    "~/scripts/app/songs/", "*.js"
                 ).Include(
                    "~/Scripts/app.js"
                 )
             );
        }
    }
}
