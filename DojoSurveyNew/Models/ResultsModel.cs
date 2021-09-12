using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyNew.Models
{
    public class Results
    {
        [Required(ErrorMessage = "You must enter a name")]
        [MinLength(2, ErrorMessage ="You need at least 2 characters in a name")]
        [Display(Name = "Your Name: ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must choose your location")]
        [Display(Name = "Your location: ")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Choose your favorite language")]
        [Display(Name = "Your favorite language: ")]
        public string Language { get; set; }
        [MinLength(20, ErrorMessage ="You need at least 20 characters to submit a comment")]
        [Display(Name  = "Comments(optional): ")]
        public string Comment {get; set; }
    }
}