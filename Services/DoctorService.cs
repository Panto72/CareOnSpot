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

        public IEnumerable<SelectListItem> Dropdown()
        {
            return GetAll().Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
        }

        public IEnumerable<SelectListItem> Dropdown(int id)
        {
            return GetAll(x=>x.Id==id).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected = true,
            });
        }
    }
}
