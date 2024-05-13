using Microsoft.AspNetCore.Mvc;

namespace CareOnSpot.Controllers.Admin
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
