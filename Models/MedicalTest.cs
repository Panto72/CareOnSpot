using CareOnSpot.Models.Base;

namespace CareOnSpot.Models
{
    public class MedicalTest : BaseEntity
    {
        public string? TestName { get; set; }
        public Double? Price { get; set; }

        public int HospitalId { get; set; }
        public Hospital? Hospital { get; set; }
        public string? Status { get; set; }
        public string? PaymentStatus { get; set; }
    }
}