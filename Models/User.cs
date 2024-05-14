using CareOnSpot.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareOnSpot.Models
{
    public class User : BaseEntity
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        [NotMapped]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="Password not match")]   
        public string? ConfirmPassword { get; set; }
        public string? UserType { get; set; }
    }
}
