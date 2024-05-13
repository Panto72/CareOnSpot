using CareOnSpot.DBConncetion;
using CareOnSpot.Models;
using CareOnSpot.Services.Base;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CareOnSpot.Services;

public class HospitalService : BaseService<Hospital>, IHospitalService
{
    public HospitalService(AppDbContext context) : base(context)
    {
    }

    public IEnumerable<SelectListItem> Dropdown()
    {
        return GetAll().Select(x=> new SelectListItem { Text = x.Name, Value= x.Id.ToString() });
    }
}
