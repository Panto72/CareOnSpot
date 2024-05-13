using CareOnSpot.DBConncetion;
using CareOnSpot.Models;
using CareOnSpot.Services.Base;

namespace CareOnSpot.Services
{
    public class MedicalShopService : BaseService<MedicalShop>, IMedicalShopService
    {
        public MedicalShopService(AppDbContext context) : base(context)
        {
        }
    }
}
