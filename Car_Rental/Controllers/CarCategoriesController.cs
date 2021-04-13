using Car_Rental.Models;
using Car_Rental.Services.CarCategoryServices;
using Fluent.Infrastructure.FluentModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Controllers
{
    public class CarCategoriesController : Controller
    {
        private readonly ICarCategoryRepository _categoryRepository;

        IndexViewModel _indexView;

        public CarCategoriesController(ICarCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _indexView = new IndexViewModel();
        }

        public async Task<IActionResult> Listing()
        {
           return View(await _categoryRepository.GetCategoriesAsync());
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
                _categoryRepository.InsertCategory(category);
                await _categoryRepository.SaveAsync();
                return RedirectToAction(nameof(Listing));
            }

            return View();
        }
    }
}
