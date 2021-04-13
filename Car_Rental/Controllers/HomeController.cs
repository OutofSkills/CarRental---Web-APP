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

        private readonly ICarsRepository _cars;

        public HomeController(ICarsRepository cars)
        {
            _cars = cars;
        }

        public async Task<IActionResult> Index()
        {
            var homeCarList = await _cars.GetCarsAsync();

            int[] id = { 1, 2, 3, 4 };
            homeCarList.Where(car => car.CarID == id[0] ||
                                     car.CarID == id[1] ||
                                     car.CarID == id[2] ||
                                     car.CarID == id[3]).ToList();

            return View(homeCarList);
        }
    }
}
