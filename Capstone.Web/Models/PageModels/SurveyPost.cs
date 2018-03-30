using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models.PageModels
{
  public class SurveyPost
  {
    public string ParkCode { get; set; }
    public string EMail { get; set; }
    public string StateOfResidence { get; set; }
    public string PhysicalActivity { get; set; }
    public int Count { get; set; }
  }
}