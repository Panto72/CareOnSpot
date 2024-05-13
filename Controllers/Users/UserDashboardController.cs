using CareOnSpot.Models;
using CareOnSpot.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CareOnSpot.Controllers.Users
{
    [Authorize(Roles ="User")]
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

        public IActionResult OnlineConsultation()
        {
            var doctorList = _doctorService.GetAll(x=>x.Hospital, x=>x.Specialitie);
            return View(doctorList);
        }

        public IActionResult CreateApoinment()
        {
            ViewData["SpecialitieId"] = _specialitieService.Dropdown();
            ViewData["DoctorId"] = _doctorService.Dropdown();
            return View();
        }

        [HttpPost]
        public IActionResult CreateApoinment(DoctorAppointment model)
        {
            if(ModelState.IsValid)
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
