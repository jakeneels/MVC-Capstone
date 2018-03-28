using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
  public class FiveDayForecast
  {
    public string ParkCode { get; set; }
    public WeatherDay[] WeatherDays { get; set; } = new WeatherDay[5];
  }
}