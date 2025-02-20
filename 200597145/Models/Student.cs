using System.ComponentModel.DataAnnotations;

namespace _200597145.Models
{
    public class Student
    {
        [Required]
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}
