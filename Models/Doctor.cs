using CareOnSpot.Models.Base;

namespace CareOnSpot.Models
{
    public class Doctor : BaseEntity
    {
        public string? Name { get; set; }
        public int HospitalId { get; set; }
        public Hospital? Hospital { get; set; }
        public string? Designation {  get; set; }
        public int? SpecialtyId { get; set; }
        public Specialitie? Specialitie { get; set; }
        public string? Experience { get; set; }
        public double VisitFee { get; set; }

        public ICollection<DoctorAppointment> DoctorAppointment { get; set; } = new HashSet<DoctorAppointment>();
    }
}
