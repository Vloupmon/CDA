using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApp {

    public class Global : HttpApplication {

        private void Application_Start(object sender, EventArgs e) {
            // Code qui s’exécute au démarrage de l’application
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}