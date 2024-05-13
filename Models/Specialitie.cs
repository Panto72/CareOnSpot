using CareOnSpot.Models.Base;

namespace CareOnSpot.Models
{
    public class Specialitie:BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }

        public ICollection<DoctorAppointment> DoctorAppointment { get; set; } = new HashSet<DoctorAppointment>();
        public ICollection<Doctor> Doctors { get; set; } = new HashSet<Doctor>();
    }
}
