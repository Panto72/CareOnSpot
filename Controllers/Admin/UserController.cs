using CareOnSpot.Models;
using CareOnSpot.Services;
using Microsoft.AspNetCore.Mvc;

namespace CareOnSpot.Controllers.Admin
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var userList = await _userService.GetAllAsync();
            return View(userList);
        }

        public async Task<IActionResult> Details(int id)
        {
            var User = await _userService.FindAsync(id);
            return View(User);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.InsertAsync(user);
                if (result.Id > 0)
                {
                    TempData["success"] = $"User{result.UserName} Save Sucessfully";
                    return RedirectToAction("Index");
                }
                TempData["error"] = $"Darta Not Save";
            }
            return View(user);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var user = await _userService.FindAsync(id);
            return View(user);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, User user)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.UpdateAsync(id, user);
                TempData["success"] = $"User {result.UserName} update successfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = $"Data not save.";
            return View(user);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var User = await _userService.FindAsync(id);
            if (User?.Id != null)
            {
                await _userService.DeleteAsync(User);
                TempData["SuccessMessage"] = $" Item remove successfully";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = $"Error delete : Item not found";
            return RedirectToAction("Index");
        }
    }
}
