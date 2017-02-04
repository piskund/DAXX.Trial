// -------------------------------------------------------------------------------------------------------------
//  Global.asax.cs created by DEP on 2017/02/04
// -------------------------------------------------------------------------------------------------------------

using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Daxx.Trial.MVC.Controllers;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity.Mvc;

namespace Daxx.Trial.MVC
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Unity initialization.
            var unityContainer = new UnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(unityContainer));
            unityContainer.LoadConfiguration();
            unityContainer.RegisterType<IController, HomeController>("Home");
        }
    }
}