using httpswww.themoviedb.orgdocumentationapimvc.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace httpswww.themoviedb.orgdocumentationapimvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ////26.7.2021.I use website https://github.com/tonykaralis/TmdbEasy as help and add // Typically get these options from IConfiguration, Environment variables etc
            //var options = new TmdbEasyOptions();

            //// Adds TmdbEasy to your app
            //services.AddTmdbEasy(options);
            // Typically get these options from IConfiguration, Environment variables etc
            var options = new TmdbEasyOptions();

            // Adds TmdbEasy to your app
//            services.AddTmdbEasy(options); gives me error CS0103: 
//                Severity  Code Description Project File    Line Suppression State
//Error   CS0103 The name 'services' does not exist in the current context 
//                  ahttpswww.themoviedb.orgdocumentationapimvc C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc\httpswww.themoviedb.orgdocumentationapimvc\Global.asax.cs   29  Active

        }
    }
}
