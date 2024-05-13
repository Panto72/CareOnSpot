using CareOnSpot.DBConncetion;
using CareOnSpot.Models;
using CareOnSpot.Services.Base;

namespace CareOnSpot.Services
{
    public class MedicalTestService : BaseService<MedicalTest>, IMedicalTestService
    {
        public MedicalTestService(AppDbContext context) : base(context)
        {
        }
    }
}
