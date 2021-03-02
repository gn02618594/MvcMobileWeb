using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.WebPages;

namespace MvcMobileWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        
        protected void Application_Start()
        {
            //¥Nªí xxx.iPhone.cshtml ÀËµøÀÉ
            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("iPhone") { 
            ContextCondition=(context => context.GetOverriddenUserAgent().IndexOf("iPhone",StringComparison.OrdinalIgnoreCase) >= 0)
            });
            DisplayModeProvider.Instance.Modes.Insert(1, new DefaultDisplayMode("Android")
            {
                ContextCondition=(context => context.GetOverriddenUserAgent().IndexOf("Android",StringComparison.OrdinalIgnoreCase) >= 0)
            });
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
