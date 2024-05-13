using CareOnSpot.Models.Base;

namespace CareOnSpot.Models
{
    public class BloodDonation : BaseEntity
    {
        public string? DonorName { get; set; }

        public int BloodTypeId { get; set; }

        public BloodType BloodType { get; set; }

        public string? ContactNumber { get; set; }

        public string? location { get; set; }

        public DateTime LastDonationDate { get; set; }


    }
}
