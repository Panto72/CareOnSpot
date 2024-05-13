using CareOnSpot.DBConncetion;
using CareOnSpot.Models;
using CareOnSpot.Services.Base;

namespace CareOnSpot.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(AppDbContext context) : base(context)
        {
        }
    }
}
