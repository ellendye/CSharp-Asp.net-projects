using System;
using System.ComponentModel.DataAnnotations;


namespace FormSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage = "You must enter a first name")]
        [MinLength(4, ErrorMessage ="You need at least 4 characters in your first name")]
        [Display(Name = "First Name: ")]
        public string FirstName {get; set;}

        [Required(ErrorMessage = "You must enter a last name")]
        [MinLength(4, ErrorMessage ="You need at least 4 characters in your last name")]
        [Display(Name = "Last Name: ")]
        public string LastName {get; set;}

        [Required(ErrorMessage = "You must enter your age")]
        [Range(0,110, ErrorMessage = "You must enter a valid age")]
        [Display(Name = "Age: ")]
        public string Age {get; set;}

        [Required(ErrorMessage = "You must enter your email address")]
        [RegularExpression(@"^[^@]+@[^@]+\.[^@]+$", ErrorMessage ="Must be a valid email address")]
        [Display(Name = "Email Adddress: ")]
        public string EmailAddress {get; set;}

        [Required(ErrorMessage = "You must enter a password")]
        [MinLength(8, ErrorMessage ="You need an 8 character password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string Password {get; set;}

    }
}