using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Capstone.Web.Models.DAL;
using Ninject;
using Ninject.Web.Common.WebHost;

namespace Capstone.Web
{
  public class MvcApplication : NinjectHttpApplication
  {
    //protected void Application_Start()
    //{
    //  AreaRegistration.RegisterAllAreas();
    //  RouteConfig.RegisterRoutes(RouteTable.Routes);
    //}

    protected override void OnApplicationStarted()
    {
      base.OnApplicationStarted();

      AreaRegistration.RegisterAllAreas();
      RouteConfig.RegisterRoutes(RouteTable.Routes);
    }

    protected override IKernel CreateKernel()
    {
      var kernel = new StandardKernel();

      string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

      kernel.Bind<IPark>().To<ParkDAL>().WithConstructorArgument("connectionString", connectionString);

      return kernel;
    }
  }
}
