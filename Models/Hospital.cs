using CareOnSpot.Core;
using CareOnSpot.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace CareOnSpot.Models;

public class Hospital : BaseEntity
{
    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Location { get; set; }

    [Required]
    public string? Address { get; set; }

    [Required]
    [Display(Name = "Contact Number")]
    public string? ContactNumber { get; set; }

    [Required]
    public HospitalType Type { get; set; }

    #region Navigation Properties
    public ICollection<Doctor> Doctors { get; set; } = new HashSet<Doctor>();
    public ICollection<MedicalTest> MedicalTests { get; set; } = new HashSet<MedicalTest>();
    public ICollection<Ambulance> Ambulances { get; set; } = new HashSet<Ambulance>(); 
    #endregion
}
