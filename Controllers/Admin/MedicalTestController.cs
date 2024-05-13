using CareOnSpot.Models;
using CareOnSpot.Services;
using Microsoft.AspNetCore.Mvc;

namespace CareOnSpot.Controllers.Admin
{
    public class MedicalTestController : Controller
    {
        private readonly IMedicalTestService _medicalTestService;

        public MedicalTestController(IMedicalTestService medicalTestService)
        {
            _medicalTestService = medicalTestService;
        }

        public async Task<IActionResult> Index()
        {
            var MedicalTestList = await _medicalTestService.GetAllAsync();
            return View(MedicalTestList);
        }

        public async Task<ActionResult> Details(int id)
        {
            var MedicalTest = await _medicalTestService.FindAsync(id);
            return View(MedicalTest);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MedicalTest medicalTest)
        {
            if (ModelState.IsValid)
            {
                var result = await _medicalTestService.InsertAsync(medicalTest);
                if (result.Id > 0)
                {
                    TempData["SuccessMessage"] = $"Medicaltest {result.TestName} save successfully";
                    return RedirectToAction("Index");
                }
                TempData["ErrorMessage"] = $"Data not save.";
            }
            return View(medicalTest);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var MedicalTest = await _medicalTestService.FindAsync(id);
            return View(MedicalTest);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, MedicalTest medicalTest)
        {
            if (ModelState.IsValid)
            {
                var result = await _medicalTestService.UpdateAsync(id, medicalTest);
                TempData["SuccessMessage"] = $"MedicalTest {result.TestName} update successfully";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = $"Data not save.";
            return View(medicalTest);
        }


        public async Task<IActionResult> Delete(int id)
        {
            var MedicalTest = await _medicalTestService.FindAsync(id);
            if (MedicalTest?.Id != null)
            {
                await _medicalTestService.DeleteAsync(MedicalTest);
                TempData["SuccessMessage"] = $" Item remove successfully";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = $"Error delete : Item not found";
            return RedirectToAction("Index");
        }
    }
}
