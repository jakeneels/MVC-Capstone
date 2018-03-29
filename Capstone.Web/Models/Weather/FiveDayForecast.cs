using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
  public class FiveDayForecast
  {
    public string ParkCode { get; set; }
    public List<WeatherDay> WeatherDays { get; set; } = new List<WeatherDay>();
  }
}