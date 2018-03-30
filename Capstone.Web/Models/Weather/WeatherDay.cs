using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
  public class WeatherDay
  {
    private int _lo;
    private int _hi;

    public string Forecast { get; set; }

    //fiveDayForecastValue
    public int Index { get; set; }
    public bool InCelcius { get; set; } = false;

    public string LoStr
    {
      get
      {
        return (InCelcius) ? (Lo.ToString() + "°C") : (Lo.ToString() + "°F");
      }
    }

    public string HiStr
    {
      get
      {
        return (InCelcius) ? (Hi.ToString() + "°C") : (Hi.ToString() + "°F");
      }
    }

    //returns either F or C depending on bool inCelcius
    public int Lo
    {
      get
      {
        return (InCelcius) ? ((int)Math.Round((((double)_lo - 32) * 5 / 9), 0)) : _lo;
      }
      set
      {
        _lo = value;
      }
    }

    //returns either F or C depending on bool inCelcius
    public int Hi
    {
      get
      {
        return (InCelcius) ? ((int)Math.Round((((double)_hi - 32) * 5 / 9), 0)) : _hi;
      }
      set
      {
        _hi = value;
      }
    }

    public string ImageName
    {
      get
      {
        switch (Forecast)
        {
          case "partly cloudy":
            return "partlyCloudy.png";

          case "sunny":
            return "sunny.png";

          case "snow":
            return "snow.png";

          case "cloudy":
            return "cloudy.png";

          case "rain":
            return "rain.png";

          case "thunderstorms":
            return "thunderstorms.png";

          default:
            return "sunny.png";
        }
      }
    }

    public string Advisory
    {
      get
      {
        string _advisory = "";
        if (Forecast.Contains("snow"))
        {
          _advisory += "Bring snowshoes. ";
        }
        if (Forecast.Contains("rain"))
        {
          _advisory += "Pack raingear and bring waterproof shoes. ";
        }
        if (Forecast.Contains("thunderstorms"))
        {
          _advisory += "Seek shelter and avoid hiking on exposed ridges. ";
        }
        if (Forecast.Contains("sunny"))
        {
          _advisory += "Pack sunblock. ";
        }
        if (_hi > 75 || _lo > 75)
        {
          _advisory += "High temperature! bring and extra gallon of water. ";
        }
        if ((_hi - _lo) > 20)
        {
          _advisory += "Wear breathable layers. ";
        }
        if (_hi < 20 || _lo < 20)
        {
          _advisory += "Low temperature! avoid prolonged exposure. ";
        }

        return _advisory;
      }
    }
  }
}