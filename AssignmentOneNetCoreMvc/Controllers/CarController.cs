using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssignmentOneNetCoreMvc.Services;
using AssignmentOneNetCoreMvc.Models;

namespace AssignmentOneNetCoreMvc.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarDetailService _carDetailService;
        //Actions
        public CarController(ICarDetailService carDetailService)
        {
            _carDetailService = carDetailService;
        }

        public async Task<IActionResult> Index()
        {
            // Get Car items from database
            // Put Car items into a model
            // Render view using the model
            var details = await _carDetailService.GetCarReportAsync();
            
            var model = new CarViewModel()
            {
                Details = details
            };
            return View(model);

        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddDetail(CarDetail newDetail)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            var successful = await _carDetailService.AddDetailAsync(newDetail);
            if (!successful)
            {
                return BadRequest("Could not add item.");
            }
            return RedirectToAction("Index");
        }
    }
}