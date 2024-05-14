using CareOnSpot.Models;
using CareOnSpot.Services.Base;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CareOnSpot.Services
{
    public interface ILocationService : IBaseService<Location>
    {
        IEnumerable<SelectListItem> Dropdown();
    }
}
