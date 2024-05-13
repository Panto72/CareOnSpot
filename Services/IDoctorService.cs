using CareOnSpot.Models;
using CareOnSpot.Services.Base;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CareOnSpot.Services
{
    public interface IDoctorService : IBaseService<Doctor>
    {
        IEnumerable<SelectListItem> Dropdown();
        IEnumerable<SelectListItem> Dropdown(int id);
    }
}
