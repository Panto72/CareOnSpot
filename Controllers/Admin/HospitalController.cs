using Microsoft.AspNetCore.Mvc;
using CareOnSpot.Models;
using CareOnSpot.Services;

namespace CareOnSpot.Controllers.Admin;

public class HospitalController : Controller
{
    private readonly IHospitalService _hospitalService;

    public HospitalController(IHospitalService hospitalService)
    {
        _hospitalService = hospitalService;
    }

    // GET: Hospital
    public async Task<IActionResult> Index()
    {
        var hospitalList = await _hospitalService.GetAllAsync();
        return View(hospitalList);
    }

    public async Task<ActionResult> Details(int id)
    {
        var hospital = await _hospitalService.FindAsync(id);
        return View(hospital);
    }

    [HttpGet]
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Create(Hospital hospital)
    {
        if (ModelState.IsValid)
        {
            var result = await _hospitalService.InsertAsync(hospital);
            if (result.Id > 0)
            {
                TempData["success"] = $"Hospital {result.Name} save successfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = $"Data not save.";
        }
        return View(hospital);
    }

    [HttpGet]
    public async Task<ActionResult> Edit(int id)
    {
        var hospital = await _hospitalService.FindAsync(id);
        return View(hospital);
    }

    [HttpPost]
    public async Task<ActionResult> Edit(int id, Hospital hospital)
    {
        if (ModelState.IsValid)
        {
            var result = await _hospitalService.UpdateAsync(id, hospital);
            TempData["success"] = $"Hospital {result.Name} update successfully";
            return RedirectToAction("Index");
        }
        TempData["error"] = $"Data not save.";
        return View(hospital);
    }



}
