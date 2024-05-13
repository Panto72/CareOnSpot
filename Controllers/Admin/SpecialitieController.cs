using CareOnSpot.Models;
using CareOnSpot.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareOnSpot.Controllers.Admin
{
    public class SpecialitieController : Controller
    {
        private readonly ISpecialitieService _specialitieService;

        public SpecialitieController(ISpecialitieService specialitieService)
        {
            _specialitieService = specialitieService;
        }

        // GET: SpecialitieController
        public async Task<ActionResult> Index()
        {
            var list = await _specialitieService.GetAllAsync();
            return View(list);
        }

        public async Task<ActionResult> Details(int id)
        {
            var Speciality = await _specialitieService.FindAsync(id);
            return View(Speciality);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Specialitie specialitie)
        {
            if (ModelState.IsValid)
            {
                var result = await _specialitieService.InsertAsync(specialitie);
                if (result.Id > 0)
                {
                    TempData["success"] = $"speciality name  {result.Title} save successfully";
                    return RedirectToAction("Index");
                }
                TempData["error"] = $"Data not save.";
            }
            return View(specialitie);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var speciality = await _specialitieService.FindAsync(id);
            return View(speciality);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, Specialitie specialitie)
        {
            if (ModelState.IsValid)
            {
                var result = await _specialitieService.UpdateAsync(id, specialitie);
                TempData["success"] = $"speciality {result.Title} update successfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = $"Data not save.";
            return View(specialitie);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var speciality = await _specialitieService.FindAsync(id);
            if (speciality?.Id != null)
            {
                await _specialitieService.DeleteAsync(speciality);
                TempData["SuccessMessage"] = $" Item remove successfully";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = $"Error delete : Item not found";
            return RedirectToAction("Index");
        }
    }
}
