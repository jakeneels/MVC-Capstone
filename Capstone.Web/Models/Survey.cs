using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models.Weather
{
  public class Survey
  {
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    public string State { get; set; }

    public string ActivityLevel { get; set; }
  }
}