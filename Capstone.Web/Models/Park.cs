using Capstone.Web.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{ 
  public class Park
  {
    public string ParkCode { get; set; }
    public string ParkName { get; set; }
    public string State { get; set; }
    public int Acreage { get; set; }
    public int ElevationInFeet { get; set; }
    public double MilesOfTrail { get; set; }
    public int NumCampsites { get; set; }
    public string Climate { get; set; }
    public DateTime YearFounded { get; set; }
    public int AnnualVisitorCount { get; set; }
    public string Quote { get; set; }
    public string QuoteSource { get; set; }
    public string ParkDescription { get; set; }
    public decimal EntryFee { get; set; }
    public int NumSpecies { get; set; }
    public string ImageName => (ParkCode + ".jpg");
    public int SurveyCount { get; set; }
    public List<SurveyPost> Surveys { get; set; } = new List<SurveyPost>();




  }
}