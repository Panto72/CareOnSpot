using CareOnSpot.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace CareOnSpot.Models
{
    public class Ambulance : BaseEntity
    {
        [Display(Name = "Select Hospital")]
        [Required]
        public int? HospitalId { get; set; }
        public Hospital? Hospital { get; set; }
        [Display(Name = "Driver Name")]
        public string? DriverName { get; set; }
        [Display(Name = "Contac Number")]
        public string? ContacNumber { get; set; }
        [Display(Name = "Need Medical Support")]
        public bool IsMedicalSupport { get; set; }

        public ICollection<EmergencyHelp> EmergencyHelps { get; set; } = new HashSet<EmergencyHelp>();
    }
}