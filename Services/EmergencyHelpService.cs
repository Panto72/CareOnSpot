using CareOnSpot.DBConncetion;
using CareOnSpot.Models;
using CareOnSpot.Services.Base;

namespace CareOnSpot.Services
{
    public class EmergencyHelpService : BaseService<EmergencyHelp>, IEmergncyHelpService
    {
        public EmergencyHelpService(AppDbContext context) : base(context)
        {
        }
    }
}
