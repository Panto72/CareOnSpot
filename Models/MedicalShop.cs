using CareOnSpot.Models.Base;

namespace CareOnSpot.Models
{
    public class MedicalShop : BaseEntity
    {
        public string? MedicineName { get; set; }
        public string? Category { get; set; }
        public double Price { get; set; }
    }
}
