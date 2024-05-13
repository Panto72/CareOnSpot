using CareOnSpot.Models;
using CareOnSpot.Services;
using Microsoft.AspNetCore.Mvc;

namespace CareOnSpot.Controllers.Admin
{
    public class MedicalShopController : Controller
    {
        public readonly IMedicalShopService _MedicalShopService;

        public MedicalShopController(IMedicalShopService medicalShopService)
        {
            _MedicalShopService = medicalShopService;
        }

        public async Task<IActionResult> Index()
        {
            var Medicalshoplist = await _MedicalShopService.GetAllAsync();
            return View(Medicalshoplist);
        }

        public async Task<ActionResult> Details(int id)
        {
            var MedicalShop = await _MedicalShopService.FindAsync(id);
            return View(MedicalShop);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MedicalShop medicalShop)
        {
            if (ModelState.IsValid)
            {
                var result = await _MedicalShopService.InsertAsync(medicalShop);
                if (result.Id > 0)
                {
                    TempData["SuccessMessage"] = $"Medicine {result.MedicineName} save successfully";
                    return RedirectToAction("Index");
                }
                TempData["ErrorMessage"] = $"Data not save.";
            }
            return View(medicalShop);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var Medicalshop = await _MedicalShopService.FindAsync(id);
            return View(Medicalshop);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, MedicalShop medicalShop)
        {
            if (ModelState.IsValid)
            {
                var result = await _MedicalShopService.UpdateAsync(id, medicalShop);
                TempData["SuccessMessage"] = $"Medicine {result.MedicineName} update successfully";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = $"Data not save.";
            return View(medicalShop);
        }


        public async Task<IActionResult> Delete(int id)
        {
            var MedicalShop = await _MedicalShopService.FindAsync(id);
            if (MedicalShop?.Id != null)
            {
                await _MedicalShopService.DeleteAsync(MedicalShop);
                TempData["SuccessMessage"] = $" Item remove successfully";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = $"Error delete : Item not found";
            return RedirectToAction("Index");
        }
    }
}

