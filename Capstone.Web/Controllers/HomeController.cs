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
      Session["parkCode"] = parkCode;
      string code = Session["parkCode"].ToString();

      DetailPage model = GetDetailPage(code.ToString());

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


    public ActionResult SurveyCount()
    {
      var model = new SurveyPost();
      //model.Count = _dal.GetSurveyCount();

      return View("SurveyCount", model);

    }

    [HttpPost]
    public ActionResult PostSurvey(SurveyPost sur)
    {
      _dal.PostSurvey(sur);

      return RedirectToAction("Surveys");
    }




    public ActionResult ChangeTemp()
    {
      var test = !TempInC();
      Session["TempInC"] = test;
      var model = GetDetailPage(Session["parkCode"].ToString());

      //just changed this
      return Redirect(Request.UrlReferrer.ToString());
    }

    public bool TempInC()
    {
      if (Session["TempInC"] == null)
      {
        Session["TempInC"] = false;
      }
      else
      {
        var test = (bool)Session["TempInC"];
        Session["TempInC"] = (bool)Session["TempInC"];
      }

      return (bool)Session["TempInC"];
    }

    public DetailPage GetDetailPage(string parkCode)
    {
      var model = new DetailPage();
      model.NatPark = _dal.GetPark(parkCode);
      model.Weather = _dal.GetForecast(parkCode);
      model.Weather.InCelcius = TempInC();

      return model;
    }
  }
}