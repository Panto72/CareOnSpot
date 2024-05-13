using CareOnSpot.DBConncetion;
using CareOnSpot.Models;
using CareOnSpot.Services.Base;

namespace CareOnSpot.Services
{
    public class AmbulanceService : BaseService<Ambulance>, IAmbulanceService
    {
        public AmbulanceService(AppDbContext context) : base(context)
        {
        }
    }
}
