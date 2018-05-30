using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using IServices.Configuration;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace Appa_Exploration
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// 
        /// </summary>
        protected void Application_Start()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            // Register your types, for instance using the scoped lifestyle:
            // Since the interfaces and models exisit in a service project, we will set them up there...
            DependencyConfig.Setup(container);

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
