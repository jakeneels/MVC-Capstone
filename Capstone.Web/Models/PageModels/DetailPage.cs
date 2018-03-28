using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models.PageModels
{
  public class DetailPage
  {

    public FiveDayForecast Weather { get; set; }
    public Park Park { get; set; }

  }
}