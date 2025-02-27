using System.ComponentModel.DataAnnotations;

namespace ValidationAttributesASPCore.Models
{
   public class Student
    {
        [Required(ErrorMessage = "Name is Must")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Name must be in 3 to 15 letters")]
        [Display(Name = "Enter The Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Must")]
        //[EmailAddress]
        //[RegularExpression(@"[\w.-]+@[a-zA-Z]+\.[a-zA-Z]{2,}")]
        [RegularExpression(@"^[\w.-]+@[a-zA-Z]+\.[a-zA-Z]{2,6}$", ErrorMessage = "Invalid Email Address")]

        public string Email { get; set; }


        [Required(ErrorMessage = "Age is Must")]
        [Range(10, 50, ErrorMessage = "Age but between 10 and 50")]
        public int? Age { get; set; }       //int? can now hold null value

        //[Required(ErrorMessage = "Password is Must")]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
        //ErrorMessage = "Password must be at least 8 characters long and contain an uppercase letter, a number, and a special character.")]

        //public string Password { get; set; }

        //[Required(ErrorMessage = "Confirm Password is Must")]
        //[Compare("Password", ErrorMessage = "Password DO not Match")]
        //[Display(Name = "Enter Confirm Password")]
        //public string ConfirmPassword { get; set; }

        //[Required(ErrorMessage = "URL is Must")]
        //[Url(ErrorMessage = "Please Provide Valid Ulr")]
        //public string URL { get; set; }

        //[MinLength(20, ErrorMessage = "Please Provide Description more that 20 words")]
        //[MaxLength(100, ErrorMessage = "Please Provide Description less that 100 words")]
        //public string Description { get; set; }
    }


}
