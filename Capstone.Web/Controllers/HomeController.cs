using Capstone.Web.Models;
using Capstone.Web.Models.DAL;
using Capstone.Web.Models.PageModels;
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

    public ActionResult Detail(string parkCode)
    {
      parkCode = "ENP";
      DetailPage model = new DetailPage();
      model.NatPark = _dal.GetPark(parkCode);
      model.Weather = _dal.GetForecast(parkCode);
      //model.Weather.WeatherDays[0].Forecast;

      return View("Detail", model);
    }
  }
}