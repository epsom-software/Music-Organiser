// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="">
//   Copyright © 2014 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.MusicOrganiser.Spa
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/css/app").Include("~/content/app.css"));

            bundles.Add(
                new ScriptBundle("~/js/app").Include(
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
                    "~/scripts/app.js"
                 )
             );
        }
    }


    //TODO: Need to figure out some way of specifying that modules should come first.
    //public static class BundleExtensions
    //{
    //    public static Bundle IncludeAngularModule(this Bundle bundle, string directory)
    //    {
    //        return bundle
    //            .IncludeDirectory(directory, @"*\.module\.js")
    //            .IncludeDirectory(directory, @"*\.(?<!module)\.js");
    //    }
    //}
}
