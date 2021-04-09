using Car_Rental.Models;
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

        private readonly CarRentalContext _context;

        public HomeController(CarRentalContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            int[] id = { 1, 2, 3, 4 };
            var homeCarList = await _context.Cars.Where(car => car.CarID == id[0] ||
                                                               car.CarID == id[1] ||
                                                               car.CarID == id[2] ||
                                                               car.CarID == id[3]).ToListAsync();
            return View(homeCarList);
        }
    }
}
