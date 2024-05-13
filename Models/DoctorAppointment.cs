using CareOnSpot.Models.Base;

namespace CareOnSpot.Models
{
    public class DoctorAppointment:BaseEntity
    {
        public int SpecialitieId { get; set; }
        public Specialitie? Specialitie { get; set; }
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime PreferredDate { get; set; }
        public string? ConferenceLink { get; set; }
        public string? Status { get; set; }

    }
}
