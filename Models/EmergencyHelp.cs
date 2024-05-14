using CareOnSpot.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace CareOnSpot.Models
{
    public class EmergencyHelp : BaseEntity
    {
        [Required]
        [Display(Name = "Paitent Name")]
        public string? PaitentName { get; set; }
        public string? Age {  get; set; }
        [Required]
        [Display(Name = "Mobile Number")]
        public string? MobileNumber { get; set; }
        public string? Gender { get; set; }
        [Display(Name = "Select Area")]
        public int? LocationId { get; set; }
        public Location? Location { get; set; }
        public string? Description { get; set; }
        [Required]
        [Display(Name = "")]
        public string? PickUpSopt {  get; set; }
        public string? ConfirmStatus { get; set; }
        public double? Amount { get; set; }
        public int HospitalId {  get; set; }
        public Hospital? Hospital { get; set; }
        public int AmbulanceId { get; set; }
        public Ambulance? Ambulance { get; set; }
    }
}
