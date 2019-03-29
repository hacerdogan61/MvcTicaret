using OrganikTicaret.Entity;
using OrganikTicaret.Identitiy;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OrganikTicaret
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer(new DataInitilizer());
            Database.SetInitializer(new IdentityInitilizer());
        }
    }
}
