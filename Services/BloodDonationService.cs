using CareOnSpot.DBConncetion;
using CareOnSpot.Models;
using CareOnSpot.Services.Base;

namespace CareOnSpot.Services
{
    public class BloodDonationService : BaseService<BloodDonation>, IBloodDonationService
    {
        public BloodDonationService(AppDbContext context) : base(context)
        {
        }
    }
}
