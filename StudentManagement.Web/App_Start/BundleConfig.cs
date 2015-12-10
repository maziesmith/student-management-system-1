using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace StudentManagement.Web.App_Start
{
   public class BundleConfig
   {
      public static void RegisterBundles(BundleCollection bundles)
      {
         bundles.Add(new ScriptBundle("~/Scripts/jquery").Include(
            "~/Scripts/Lib/jquery-{version}.js"
            )
         );

         bundles.Add(new ScriptBundle("~/Scripts/jqueryval").Include(
            "~/Scripts/Lib/jquery-validate*"
            )
         );

         // All custom JS files will begin with [app] prefix
         bundles.Add(new ScriptBundle("~/Scripts/app").Include(
            "~/Scripts/app*"
            )
         );

         bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
      }
   }
}