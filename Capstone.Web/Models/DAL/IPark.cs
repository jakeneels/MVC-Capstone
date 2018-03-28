using Capstone.Web.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models.DAL
{
  public interface IPark
  {
    List<Park> GetParks();
    Park GetPark(string parkCode);
  }
}