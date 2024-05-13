using CareOnSpot.Controllers.Admin;
using CareOnSpot.Models;
using CareOnSpot.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CareOnSpot.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
       
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login model)
        {
            if (ModelState.IsValid) 
            {
                var user = _userService.GetAll().Where(x => x.Email == model.Email).FirstOrDefault();
                if (user != null)
                {
                    bool isvalid = user.Password == model.Password;
                    if (isvalid)
                    {
                        var identiy = new ClaimsIdentity(new[]
                        {
                            new Claim(ClaimTypes.Name, user.Email),
                            new Claim (ClaimTypes.Role,user.UserType)

                        }, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identiy);
                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,principal);

                        HttpContext.Session.SetString("UserName", user.UserName);
                        HttpContext.Session.SetString("Email", user.Email);
                        HttpContext.Session.SetString("UserType", user.UserType);

                        return user.UserType switch
                        {
                            "Admin" => RedirectToAction("Index", "Dashboard"),
                            _ => RedirectToAction("Index", "UserDashboard"),
                        };
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Invalid Password";
                        return View();
                    }
                }
                else
                {
                    TempData["ErrorMessage"] = "Invalid UserName";
                    return View();
                }
            }
            return View();
            
        }

        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(User model)
        {
            if (ModelState.IsValid)
            {
                await _userService.InsertAsync(model);
                return RedirectToAction("Login");
            }
            return View();
        }
    }
}
