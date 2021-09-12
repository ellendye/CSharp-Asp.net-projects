using System;
using System.ComponentModel.DataAnnotations;

namespace LoginReg.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[^@]+@[^@]+\.[^@]+$", ErrorMessage ="Must be a valid email address")]
        [Display(Name="Email: ")]
        public string Email {get;set;}

        [Required(ErrorMessage = "You must enter your password")]
        [MinLength(8, ErrorMessage ="You need an 8 character password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string LoginPassword {get; set;}
    }
}