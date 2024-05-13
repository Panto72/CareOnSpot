using CareOnSpot.Models;
using CareOnSpot.Services;
using Microsoft.AspNetCore.Mvc;

namespace CareOnSpot.Controllers.Admin
{
    public class DoctorAppointmentController : Controller
    {
        private readonly IDoctorAppointmentService _doctorAppointment;
        private readonly ISpecialitieService _specialitieService;
        private readonly IDoctorService _doctorService;

        public DoctorAppointmentController(IDoctorAppointmentService doctorAppointmentService, ISpecialitieService specialitieService, IDoctorService doctorService)
        {
            _doctorAppointment = doctorAppointmentService;
            _specialitieService = specialitieService;
            _doctorService = doctorService;
        }

        public async Task<IActionResult> Index()
        {
            var doctorAppoinmentList = await _doctorAppointment.GetAllAsync();
            return View(doctorAppoinmentList);
        }

        public async Task<ActionResult> Details(int id)
        {
            var doctorAppoinment = await _doctorAppointment.FindAsync(id);
            return View(doctorAppoinment);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewData["SpecialitieId"] = _specialitieService.Dropdown();
            ViewData["DocorId"] = _doctorService.Dropdown();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(DoctorAppointment doctorAppointment)
        {
            if (ModelState.IsValid)
            {
                var result = await _doctorAppointment.InsertAsync(doctorAppointment);
                if (result.Id > 0)
                {
                    TempData["success"] = $"Doctor appoinment name  {result.FullName} save successfully";
                    return RedirectToAction("Index");
                }
                TempData["error"] = $"Data not save.";
            }
            return View(doctorAppointment);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var doctorAppoinment = await _doctorAppointment.FindAsync(id);
            return View(doctorAppoinment);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, DoctorAppointment doctorAppointment)
        {
            if (ModelState.IsValid)
            {
                var result = await _doctorAppointment.UpdateAsync(id, doctorAppointment);
                TempData["success"] = $"Appoinment {result.FullName} update successfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = $"Data not save.";
            return View(doctorAppointment);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var doctorAppoinment = await _doctorAppointment.FindAsync(id);
            if (doctorAppoinment?.Id != null)
            {
                await _doctorAppointment.DeleteAsync(doctorAppoinment);
                TempData["SuccessMessage"] = $" Item remove successfully";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = $"Error delete : Item not found";
            return RedirectToAction("Index");
        }
    }
}

