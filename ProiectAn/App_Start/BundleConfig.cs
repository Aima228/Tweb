using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace ProiectAn.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Assets/bundles")
                .Include(
                "~/Scripts/bar.js",
                "~/Scripts/bootstrap.bundle.js",
                "~/Scripts/bootstrap.esm.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/jquery-{version}.intellisense.js",
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery-{version}.slim.js",
                "~/Scripts/jquery-ui-{version}.js",
                "~/Scripts/jquery.nicescroll.js",
                "~/Scripts/linecharts.js",
                "~/Scripts/modernizr.js",
                "~/Scripts/script.js",
                "~/Scripts/utils.js"
                )
                .IncludeDirectory("~/Scripts", "*.js"));
            bundles.Add(new StyleBundle("~/Assets/bundles")
                .Include(
                "~/Assets/css/style-starter.css")
                .IncludeDirectory("~/Assets/css", "*.css"));
        }
    }
}