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
      var hi = _dal.GetSurveys();

      return View("Index", model);
    }

    public ActionResult Detail(string parkCode)
    {
      var query = HttpContext.Request.QueryString;
      var qs = query.GetValues("parkCode");

      DetailPage model = new DetailPage();
      model.NatPark = _dal.GetPark(parkCode);
      model.Weather = _dal.GetForecast(parkCode);

      return View("Detail", model);
    }

    public ActionResult Surveys()
    {
      var model = new SurveyPage();
      model.Surveys = _dal.GetSurveys();
      model.Parks = _dal.GetParks();

      return View("Surveys", model);
    }

    public ActionResult PostSurvey()
    {
      var model = new SurveyPage();
      model.Parks = _dal.GetParks();

      return View("PostSurvey", model);
    }

    [HttpPost]
    public ActionResult PostSurvey(SurveyPost sur)
    {
      _dal.PostSurvey(sur);

      return RedirectToAction("Surveys");
    }
  }
}