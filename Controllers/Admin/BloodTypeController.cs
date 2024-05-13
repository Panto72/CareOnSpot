using CareOnSpot.Models;
using CareOnSpot.Services;
using Microsoft.AspNetCore.Mvc;

namespace CareOnSpot.Controllers.Admin
{
    public class BloodTypeController : Controller
    {
        public readonly IBloodTypeService _bloodTypeService;

        public BloodTypeController (IBloodTypeService bloodTypeService)
        {
            _bloodTypeService = bloodTypeService;

        }

        // GET: Hospital
        public async Task<IActionResult> Index()
        {
            var BloodTypeList = await _bloodTypeService.GetAllAsync();
            return View(BloodTypeList);
        }

        public async Task<ActionResult> Details(int id)
        {
            var BloodType = await _bloodTypeService.FindAsync(id);
            return View(BloodType);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(BloodType bloodType)
        {
            if (ModelState.IsValid)
            {
                var result = await _bloodTypeService.InsertAsync(bloodType);
                if (result.Id > 0)
                {
                    TempData["success"] = $"BloodType {result.BloodGroup} save successfully";
                    return RedirectToAction("Index");
                }
                TempData["error"] = $"Data not save.";
            }
            return View(bloodType);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var BloodType = await _bloodTypeService.FindAsync(id);
            return View(BloodType);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, BloodType bloodType)
        {
            if (ModelState.IsValid)
            {
                var result = await _bloodTypeService.UpdateAsync(id, bloodType);
                TempData["success"] = $"Blood Type {result.BloodGroup} update successfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = $"Data not save.";
            return View(bloodType);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var BloodType = await _bloodTypeService.FindAsync(id);
            if (BloodType?.Id != null)
            {
                await _bloodTypeService.DeleteAsync(BloodType);
                TempData["SuccessMessage"] = $" Item remove successfully";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = $"Error delete : Item not found";
            return RedirectToAction("Index");
        }
    }
}
