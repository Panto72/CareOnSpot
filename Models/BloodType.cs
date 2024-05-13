using CareOnSpot.Models.Base;

namespace CareOnSpot.Models
{
    public class BloodType : BaseEntity
    {
        public string? BloodGroup { get; set; }

        public ICollection<BloodDonation> BloodDonations { get; set; } = new HashSet<BloodDonation>();
    }
}
