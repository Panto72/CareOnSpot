using CareOnSpot.DBConncetion;
using CareOnSpot.Models;
using CareOnSpot.Services.Base;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CareOnSpot.Services
{
    public class SpecialitieService : BaseService<Specialitie>, ISpecialitieService
    {

        public SpecialitieService(AppDbContext context) : base(context)
        {
        }


        public IEnumerable<SelectListItem> Dropdown()
        {
            return GetAll().Select(x => new SelectListItem { Text = x.Title, Value = x.Id.ToString() });
        }
    }
}
