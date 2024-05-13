using CareOnSpot.Models;
using CareOnSpot.Services.Base;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CareOnSpot.Services;

public interface IHospitalService : IBaseService<Hospital>
{
    //Task GetHospitalDropdown();
    IEnumerable<SelectListItem> Dropdown();
}