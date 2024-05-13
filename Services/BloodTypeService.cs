using CareOnSpot.DBConncetion;
using CareOnSpot.Models;
using CareOnSpot.Services.Base;

namespace CareOnSpot.Services
{
    public class BloodTypeService : BaseService<BloodType>, IBloodTypeService
    {
        public BloodTypeService(AppDbContext context) : base(context)
        {
        }
    }
}
