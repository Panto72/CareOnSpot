using CareOnSpot.Models;
using CareOnSpot.Services;
using Microsoft.AspNetCore.Mvc;

namespace CareOnSpot.Controllers.Admin
{
    public class BloodDonationController : Controller
    {
        public readonly IBloodDonationService _bloodDonationService;

        public BloodDonationController(IBloodDonationService bloodDonationService)
        {
            _bloodDonationService = bloodDonationService;
        }

        // GET: Hospital
        public async Task<IActionResult> Index()
        {
            var BloodDonationList = await _bloodDonationService.GetAllAsync();
            return View(BloodDonationList);
        }

        public async Task<ActionResult> Details(int id)
        {
            var BloodDonation = await _bloodDonationService.FindAsync(id);
            return View(BloodDonation);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(BloodDonation bloodDonation)
        {
            if (ModelState.IsValid)
            {
                var result = await _bloodDonationService.InsertAsync(bloodDonation);
                if (result.Id > 0)
                {
                    TempData["success"] = $"Blood donor {result.DonorName} save successfully";
                    return RedirectToAction("Index");
                }
                TempData["error"] = $"Data not save.";
            }
            return View(bloodDonation);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var BloodDonation = await _bloodDonationService.FindAsync(id);
            return View(BloodDonation);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, BloodDonation bloodDonation)
        {
            if (ModelState.IsValid)
            {
                var result = await _bloodDonationService.UpdateAsync(id, bloodDonation);
                TempData["success"] = $"Hospital {result.DonorName} update successfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = $"Data not save.";
            return View(bloodDonation);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var BloodDonation = await  _bloodDonationService.FindAsync(id);
            if (BloodDonation?.Id != null)
            {
                await _bloodDonationService.DeleteAsync(BloodDonation);
                TempData["SuccessMessage"] = $" Item remove successfully";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = $"Error delete : Item not found";
            return RedirectToAction("Index");
        }
    }
}
