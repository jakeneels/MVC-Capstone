using Capstone.Web.Models;
using Capstone.Web.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.Web.Controllers
{
  public class HomeController : Controller
  {
    private IPark _dal;
    public HomeController(IPark dal)
    {
      _dal = dal;
    }
    // GET: Home
    public ActionResult Index()
    {
      List<Park> model = _dal.GetParks();
      return View("Index", model);
    }
  }
}