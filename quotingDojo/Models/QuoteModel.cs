using System;
using System.ComponentModel.DataAnnotations;

namespace quotingDojo.Models
{
    public class Quotes
    {
        [Required(ErrorMessage = "You must enter a name")]
        [MinLength(2, ErrorMessage ="You need at least  characters in your name")]
        [Display(Name = "Name: ")]
        public string name {get;set;}
        [Required(ErrorMessage = "You must enter a quote")]
        [MinLength(4, ErrorMessage ="You need at least 4 characters in your quote")]
        [Display(Name = "Quote: ")]
        public string userquote {get;set;}
    }
}