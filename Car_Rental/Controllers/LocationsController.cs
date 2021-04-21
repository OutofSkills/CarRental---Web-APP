using Car_Rental.Models;
using Car_Rental.Services.LocationService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Controllers
{
    public class LocationsController : Controller
    {
        private readonly ILocationsRepository _locationsRepo;

        public LocationsController(ILocationsRepository locationsRepo)
        {
            _locationsRepo = locationsRepo;
        }

        public async Task<IActionResult> Listing()
        {
            return View(await _locationsRepo.GetLocationsAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(Location location)
        {
            if (ModelState.IsValid)
            {
                _locationsRepo.InsertLocation(location);
                await _locationsRepo.SaveAsync();
                return RedirectToAction(nameof(Listing));
            }
            return View(location);
        }

        public IActionResult CarsInLocation(int id)
        {
            if (id != 0)
            {
                var location =  _locationsRepo.GetLocationByID(id);
                List<Car> cars = new List<Car>();

                foreach (var l in location.CarsAtLocation)
                {
                    if (l.Location == location)
                        cars.Add(l.Car);
                }

                ViewBag.Category_Name = "All the Cars in " + location.City;
                ViewBag.Description = "Choose the best car from all the categories in " + location.City;

                return View("../Cars/Listing", cars);
            }
            return View("Not found");
        }
    }
}
