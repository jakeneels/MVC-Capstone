using Capstone.Web.Models.DAL;
using Capstone.Web.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models.DAL
{
  public interface IPark
  {
    List<Park> GetParks();
    Park GetPark(string parkCode);
    FiveDayForecast GetForecast(string parkCode);
    List<SurveyPost> GetSurveys();
    bool PostSurvey(SurveyPost survey);
    //List<SurveyPost> GetSurveyCount(string parkCode);
  }
}