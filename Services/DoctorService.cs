using CareOnSpot.DBConncetion;
using CareOnSpot.Models;
using CareOnSpot.Services.Base;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CareOnSpot.Services
{
    public class DoctorService : BaseService<Doctor>, IDoctorService
    {

        public DoctorService(AppDbContext context) : base(context)
        {           
        }

        public IEnumerable<SelectListItem> Dropdown(int? selected = 0)
        {
            return GetAll().Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected = x.Id == selected,
            });
        }

        public IEnumerable<SelectListItem> Dropdown()
        {
            return GetAll().Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
        }
    }
}
