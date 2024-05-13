using CareOnSpot.Models;
using CareOnSpot.Services.Base;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CareOnSpot.Services
{
    public interface ISpecialitieService : IBaseService<Specialitie>
    {
        IEnumerable<SelectListItem> Dropdown();
    }
}