using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
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

      //kernel.Bind<>.To<>();

      throw new NotImplementedException();
    }
  }
}
