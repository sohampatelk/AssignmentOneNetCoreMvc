using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssignmentOneNetCoreMvc.Services;


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

        public IActionResult Index()
        {

            var details = await _carDetailService.GetCarReportAsync();
            // Get Car items from database
            // Put Car items into a model
            // Render view using the model
            var model = new CarViewModel()
            {
                Details = details
            };
            return View(model);

        }
    }
}