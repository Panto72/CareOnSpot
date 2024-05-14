using CareOnSpot.DBConncetion;
using CareOnSpot.Models;
using CareOnSpot.Services.Base;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CareOnSpot.Services
{
    public class LocationService : BaseService<Location>, ILocationService
    {
        public LocationService(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<SelectListItem> Dropdown()
        {
            return GetAll().Select(x => new SelectListItem
            {
                Text = x.LocationName,
                Value = x.Id.ToString(),
            });
        }
    }
}
