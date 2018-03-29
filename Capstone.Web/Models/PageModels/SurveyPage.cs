
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models.PageModels
{
  public class SurveyPage
  {

    public List<SurveyPost> Surveys { get; set; } = new List<SurveyPost>();

    public List<Park> Parks { get; set; } = new List<Park>();

  }
}



