using CareOnSpot.Models;
using CareOnSpot.Services;
using Microsoft.AspNetCore.Mvc;

namespace CareOnSpot.Controllers.Admin
{
    public class LocationController : Controller
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }


        // GET: Hospital
        public async Task<IActionResult> Index()
        {
            var LocationList = await _locationService.GetAllAsync();
            return View(LocationList);
        }

        public async Task<ActionResult> Details(int id)
        {
            var Location = await _locationService.FindAsync(id);
            return View(Location);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Location location)
        {
            if (ModelState.IsValid)
            {
                var result = await _locationService.InsertAsync(location);
                if (result.Id > 0)
                {
                    TempData["success"] = $"Location name {result.LocationName} save successfully";
                    return RedirectToAction("Index");
                }
                TempData["error"] = $"Data not save.";
            }
            return View(location);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var Location = await _locationService.FindAsync(id);
            return View(Location);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, Location location)
        {
            if (ModelState.IsValid)
            {
                var result = await _locationService.UpdateAsync(id, location);
                TempData["success"] = $"Location {result.LocationName} update successfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = $"Data not save.";
            return View(location);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var Location = await _locationService.FindAsync(id);
            if (Location?.Id != null)
            {
                await _locationService.DeleteAsync(Location);
                TempData["SuccessMessage"] = $" Item remove successfully";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = $"Error delete : Item not found";
            return RedirectToAction("Index");
        }
    }
}
