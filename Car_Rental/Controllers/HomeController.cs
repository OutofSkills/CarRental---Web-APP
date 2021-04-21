using Car_Rental.Models;
using Car_Rental.Services.CarServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICarsRepository _carsRepo;

        public HomeController(ICarsRepository cars)
        {
            _carsRepo = cars;
        }

        public async Task<IActionResult> Index()
        {
            var carList = await _carsRepo.GetCarsAsync();

            var homeCarList = carList.Take(5);

            return View(homeCarList);
        }
    }
}
