using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
  public class WeatherDay
  {
    public bool InCelcius { get; set; } = false;
    public int Lo { get; set; }
    public int Hi { get; set; }
    public string Forecast { get; set; }
    public string Advisory
    {
      get
      {
        
        if (InCelcius)
        {
          return "";
        }
        else
        {
          return "";
        }

      }
    }
  }
}