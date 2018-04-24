using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models.PageModels
{
  public class SurveyPost
  {
    public string ParkCode { get; set; }
    [Display(Name = "Email address")]
    [Required(ErrorMessage = "The email address is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string EMail { get; set; }
    [Required]
    public string StateOfResidence { get; set; }
    [Required]
    public string PhysicalActivity { get; set; }

    public int Count { get; set; }
  }
}