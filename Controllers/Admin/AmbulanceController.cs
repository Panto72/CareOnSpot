using CareOnSpot.Models;
using CareOnSpot.Services;
using Microsoft.AspNetCore.Mvc;

namespace CareOnSpot.Controllers.Admin
{
    public class AmbulanceController : Controller
    {
        private readonly IAmbulanceService _ambulance;
        private readonly IHospitalService _hospitalService;

        public AmbulanceController(IAmbulanceService ambulanceService, IHospitalService hospitalService)
        {
            _ambulance = ambulanceService;
            _hospitalService = hospitalService;
        }

        public async Task<IActionResult> Index()
        {
            var AmbulanceList = await _ambulance.GetAllAsync(x=>x.Hospital);
            return View(AmbulanceList);
        }


        public async Task<ActionResult> Details(int id)
        {
            var Ambulance = await _ambulance.FindAsync(id);
            return View(Ambulance);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewData["HospitalId"] = _hospitalService.Dropdown();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Ambulance ambulance)
        {
            if (ModelState.IsValid)
            {
                var result = await _ambulance.InsertAsync(ambulance);
                if (result.Id > 0)
                {
                    TempData["success"] = $"Ambulance {result.DriverName} save successfully";
                    return RedirectToAction("Index");
                }
                TempData["error"] = $"Data not save.";
            }
            ViewData["HospitalId"] = _hospitalService.Dropdown();
            return View(ambulance);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var Ambulance = await _ambulance.FindAsync(id);
            return View(Ambulance);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, Ambulance ambulance)
        {
            if (ModelState.IsValid)
            {
                var result = await _ambulance.UpdateAsync(id, ambulance);
                TempData["success"] = $"Ambulance {result.DriverName} update successfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = $"Data not save.";
            return View(ambulance);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var Ambulance = await _ambulance.FindAsync(id);
            if (Ambulance?.Id != null)
            {
                await _ambulance.DeleteAsync(Ambulance);
                TempData["SuccessMessage"] = $" Item remove successfully";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = $"Error delete : Item not found";
            return RedirectToAction("Index");
        }
    }
}
