using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models.DAL
{
  public class ParkDAL : IPark
  {
    private string connectionString;

    public ParkDAL(string connectionString)
    {
      this.connectionString = connectionString;
    }

    #region park

    public Park GetPark(string parkCode)
    {
      parkCode = parkCode.ToUpper();
      const string getParkSql = @"select * from park where parkCode = @parkCode";
      using (SqlConnection conn = new SqlConnection(connectionString))
      {
        conn.Open();
        SqlCommand cmd = new SqlCommand(getParkSql, conn);
        cmd.Parameters.AddWithValue("@parkCode", parkCode);

        var reader = cmd.ExecuteReader();

        if (reader.Read())
        {
          return AssignPark(reader);
        }
        else
        {
          throw new Exception();
        }
      }
    }

    public List<Park> GetParks()
    {
      List<Park> parks = new List<Park>();

      const string getParkSql = @"select * from park";
      using (SqlConnection conn = new SqlConnection(connectionString))
      {
        conn.Open();
        SqlCommand cmd = new SqlCommand(getParkSql, conn);

        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
          parks.Add(AssignPark(reader));
        }

        return parks;
      }
    }

    private Park AssignPark(SqlDataReader reader)
    {
      var park = new Park();
      if (reader.Read())
      {
        try
        {
          park.ParkCode = reader["parkCode"].ToString();
          park.ParkName = reader["parkName"].ToString();
          park.State = reader["state"].ToString();
          park.Acreage = int.Parse(reader["acreage"].ToString());
          park.ElevationInFeet = int.Parse(reader["elevationInFeet"].ToString());
          park.MilesOfTrail = double.Parse(reader["milesOfTrail"].ToString());
          park.NumCampsites = int.Parse(reader["numberOfCampsites"].ToString());
          park.Climate = reader["climate"].ToString();
          park.YearFounded = DateTime.Parse("01/01/" + reader["yearFounded"].ToString());
          park.AnnualVisitorCount = int.Parse(reader["annualVisitorCount"].ToString());
          park.Quote = reader["inspirationalQuote"].ToString();
          park.QuoteSource = reader["inspirationalQuoteSource"].ToString();
          park.ParkDescription = reader["parkDescription"].ToString();
          park.EntryFee = decimal.Parse(reader["entryFee"].ToString());
          park.NumSpecies = int.Parse(reader["numberOfAnimalSpecies"].ToString());

        }
        catch (Exception) { }
      }

      return park;
    }
    #endregion

    #region weather

    public FiveDayForecast GetForecast(string parkCode)
    {
      FiveDayForecast forecast = new FiveDayForecast();
      parkCode = parkCode.ToUpper();
      const string getWeatherQuery = @"select * from weather where parkCode = @parkCode";
      using (SqlConnection conn = new SqlConnection(connectionString))
      {
        conn.Open();
        SqlCommand cmd = new SqlCommand(getWeatherQuery, conn);
        cmd.Parameters.AddWithValue("@parkCode", parkCode);

        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
          forecast.WeatherDays.Add(AssignWeatherDay(reader));
          forecast.ParkCode = reader["parkCode"].ToString();
        }

        return forecast;
      }
    }

    private WeatherDay AssignWeatherDay(SqlDataReader reader)
    {
      var weatherDay = new WeatherDay();

        try
        {
          weatherDay.Hi = int.Parse(reader["high"].ToString());
          weatherDay.Lo = int.Parse(reader["low"].ToString());
          weatherDay.Forecast = reader["forecast"].ToString();
          weatherDay.Index = int.Parse(reader["fiveDayForecastValue"].ToString());
        }
        catch (Exception) { }

      return weatherDay;
    }


    #endregion
  }
}