using CareOnSpot.Migrations;
using CareOnSpot.Models;
using CareOnSpot.Services;
using Microsoft.AspNetCore.Mvc;

namespace CareOnSpot.Controllers.Admin
{
    public class DoctorController : Controller
    {
        private readonly IDoctorService _doctorService;
        private readonly IHospitalService _hospitalService;
        private readonly ISpecialitieService _specialitieService;

        public DoctorController(IDoctorService doctorService, IHospitalService hospitalService, ISpecialitieService specialitieService)
        {
            _doctorService = doctorService;
            _hospitalService = hospitalService;
            _specialitieService = specialitieService;
        }

        // GET: Hospital
        public async Task<IActionResult> Index()
        {
            var doctorlist = await _doctorService.GetAllAsync(x=>x.Hospital, x=>x.Specialitie);
            return View(doctorlist);
        }

        public async Task<ActionResult> Details(int id)
        {
            var Doctor = await _doctorService.FindAsync(x => x.Id == id, x => x.Specialitie);
            return View(Doctor);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewData["HospitalId"] = _hospitalService.Dropdown();
            ViewData["SpecialityId"] = _specialitieService.Dropdown();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                var result = await _doctorService.InsertAsync(doctor);
                if (result.Id > 0)
                {
                    TempData["SuccessMessage"] = $"Doctor {result.Name} save successfully";
                    return RedirectToAction("Index");
                }
                TempData["ErrorMessage"] = $"Data not save.";
            }
            ViewData["HospitalId"] = _hospitalService.Dropdown();
            ViewData["SpecialityId"] = _specialitieService.Dropdown();
            return View(doctor);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var Doctor = await _doctorService.FindAsync(id);
            return View(Doctor);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                var result = await _doctorService.UpdateAsync(id, doctor);
                TempData["SuccessMessage"] = $"Doctor {result.Name} update successfully";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = $"Data not save.";
            return View(doctor);
        }


        public async Task<IActionResult> Delete(int id)
        {
            var Doctor = await _doctorService.FindAsync(id);
            if (Doctor?.Id != null)
            {
                await _doctorService.DeleteAsync(Doctor);
                TempData["SuccessMessage"] = $" Item remove successfully";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = $"Error delete : Item not found";
            return RedirectToAction("Index");
        }

    }
}
