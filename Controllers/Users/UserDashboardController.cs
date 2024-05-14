using CareOnSpot.Models;
using CareOnSpot.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CareOnSpot.Controllers.Users
{
    [Authorize(Roles = "User")]
    public class UserDashboardController : Controller
    {
        private readonly IDoctorService _doctorService;
        private readonly ISpecialitieService _specialitieService;
        private readonly IDoctorAppointmentService _doctorAppointmentService;

        public UserDashboardController(IDoctorService doctorService, ISpecialitieService specialitieService, IDoctorAppointmentService doctorAppointmentService)
        {
            _doctorService = doctorService;
            _specialitieService = specialitieService;
            _doctorAppointmentService = doctorAppointmentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllSpecialitie()
        {
            var specialitieList = _specialitieService.GetAll();
            return View(specialitieList);
        }

        public IActionResult GetDoctorsBySpecialitie(int id)
        {
            var doctorList = _doctorService.GetAll(x => x.Hospital, x => x.Specialitie).Where(x => x.SpecialtyId == id).ToList();
            return View(doctorList);
        }

        [HttpGet]
        public IActionResult CreateApoinment(int id)
        {
            ViewData["DoctorId"] = _doctorService.Dropdown(id);
            return View();
        }

        [HttpPost]
        public IActionResult CreateApoinment(DoctorAppointment model)
        {
            if (ModelState.IsValid)
            {
                _doctorAppointmentService.Insert(model);
                return RedirectToAction("Index", "UserDashboard");
            }
            ViewData["SpecialitieId"] = _specialitieService.Dropdown();
            ViewData["DoctorId"] = _doctorService.Dropdown();
            return View();
        }
    }
}
