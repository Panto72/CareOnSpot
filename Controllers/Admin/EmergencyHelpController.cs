using CareOnSpot.Models;
using CareOnSpot.Services;
using Microsoft.AspNetCore.Mvc;

namespace CareOnSpot.Controllers.Admin
{
    public class EmergencyHelpController : Controller
    {
        private readonly IEmergncyHelpService _emergencyHelpService;
        private readonly ILocationService _locationService;
        private readonly IHospitalService _hospitalService;

        public EmergencyHelpController(IEmergncyHelpService emergencyHelpService, ILocationService locationService, IHospitalService hospitalService)
        {
            _emergencyHelpService = emergencyHelpService;
            _locationService = locationService;
            _hospitalService = hospitalService;
        }

        public async Task<IActionResult> Index()
        {
            var EmergencyList = await _emergencyHelpService.GetAllAsync();
            return View(EmergencyList);
        }

        public async Task<ActionResult> Details(int id)
        {
            var EmergencyHelp = await _emergencyHelpService.FindAsync(id);
            return View(EmergencyHelp);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewData["LocationId"] = _locationService.Dropdown();
            ViewData["HospitalId"] = _hospitalService.Dropdown();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EmergencyHelp emergencyHelp)
        {
            if (ModelState.IsValid)
            {
                var result = await _emergencyHelpService.InsertAsync(emergencyHelp);
                if (result.Id > 0)
                {
                    TempData["success"] = $"patient {result.PaitentName} save successfully";
                    return RedirectToAction("Index");
                }
                TempData["error"] = $"Data not save.";
            }
            return View(emergencyHelp);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var EmergencyHelp = await _emergencyHelpService.FindAsync(id);
            return View(EmergencyHelp);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, EmergencyHelp emergencyHelp)
        {
            if (ModelState.IsValid)
            {
                var result = await _emergencyHelpService.UpdateAsync(id, emergencyHelp);
                TempData["success"] = $"patient {result.PaitentName} update successfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = $"Data not save.";
            return View(emergencyHelp);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var EmergencyHelp = await _emergencyHelpService.FindAsync(id);
            if (EmergencyHelp?.Id != null)
            {
                await _emergencyHelpService.DeleteAsync(EmergencyHelp);
                TempData["SuccessMessage"] = $" Item remove successfully";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = $"Error delete : Item not found";
            return RedirectToAction("Index");
        }
    }
}
