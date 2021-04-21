using Car_Rental.Models;
using Car_Rental.Services.CarCategoryServices;
using Car_Rental.Services.CarServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Controllers
{
    public class CarCategoriesController : Controller
    {
        private readonly ICarCategoryRepository _categoriesRepo;

        public CarCategoriesController(ICarCategoryRepository categoryRepository)
        {
            _categoriesRepo = categoryRepository;
        }

        public async Task<IActionResult> Listing()
        {
            var categories = await _categoriesRepo.GetCategoriesAsync();

            if (categories.Count() != 0)
            {
                /*Set average price of the category*/
                foreach (var categ in categories)
                {
                    List<decimal> prices = new List<decimal>();
                    if (categ.Cars.Count() != 0)
                    {
                        foreach (var car in categ.Cars)
                        {
                            prices.Add(car.PricePerDay);
                        }
                        decimal averageCategPrice = prices.Average();
                        categ.AveragePrice = averageCategPrice;
                    }
                    else
                        categ.AveragePrice = 0;
                }
            }

           return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(CarCategory category)
        {
            if (ModelState.IsValid)
            {
                _categoriesRepo.InsertCategory(category);
                await _categoriesRepo.SaveAsync();
                return RedirectToAction(nameof(Listing));
            }

            return View();
        }
    }
}
