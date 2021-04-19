using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Car_Rental.Models;
using Car_Rental.Services.CarServices;
using Car_Rental.Services.CarCategoryServices;
using Car_Rental.Services;
using Car_Rental.Services.LocationService;

namespace Car_Rental.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarsRepository _carRepository;
        private readonly ICarCategoryRepository _categoriesRepository;
        private readonly ICarTypeRepository _carTypesRepository;
        private readonly ILocationsRepository _locationsRepository;

        /// <summary>
        /// Constructor that initializes the car related repositories
        /// </summary>
        /// <param name="carRepository"></param>
        /// <param name="categoriesRepository"></param>
        /// <param name="carTypesRepository"></param>
        /// <param name="locationsRepository"></param>
        public CarsController(ICarsRepository carRepository, ICarCategoryRepository categoriesRepository, 
                              ICarTypeRepository carTypesRepository, ILocationsRepository locationsRepository)
        {
            _carRepository = carRepository;
            _categoriesRepository = categoriesRepository;
            _carTypesRepository = carTypesRepository;
            _locationsRepository = locationsRepository;
        }

        /// <summary>
        /// Returns all the cars in a Category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Listing(string id)
        {
            var cars = await _carRepository.GetCarsAsync();

            if (!string.IsNullOrEmpty(id))
            {
                var carsInCategory = cars.Where(car => car.Category.Category_Name == id).ToList();
                var currentCategory = await _categoriesRepository.GetCategoryByIDAsync(id);

                ViewBag.Category_Name = id;
                ViewBag.Description = currentCategory.Details;

                return View(carsInCategory);
            }
            else
            {
                ViewBag.Category_Name = "All the Cars";
                ViewBag.Description = "Choose the best car from all the categories";

                return View(cars);
            }
        }

        /// <summary>
        /// Returns the form for creating a car
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoriesRepository.GetCategoriesAsync();
            var bodyTypes = await _carTypesRepository.GetBodyTypesAsync();
            var locations = await _locationsRepository.GetLocationsAsync();

            List<string> categorieNames = new List<string>();
            List<string> typeNames = new List<string>();

            /*get the existing categories name and body types name*/
            foreach (var item in categories)
                categorieNames.Add(item.Category_Name);
            foreach (var item in bodyTypes)
                typeNames.Add(item.Name);

            ViewBag.Category_Names = categorieNames;
            ViewBag.TypeNames = typeNames;
            ViewBag.LocationNames = locations;

            return View();
        }

        /// <summary>
        /// Gets the introduced data from the form and adds it to the database
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateAsync(Car car)
        {
            var categories = await _categoriesRepository.GetCategoriesAsync();
            var bodyTypes = await _carTypesRepository.GetBodyTypesAsync();
            var locations = await _locationsRepository.GetLocationsAsync();

            List<string> categorieNames = new List<string>();
            List<string> typeNames = new List<string>();
           
            /*get the existing categories name and body types name*/
            foreach (var item in categories)
                categorieNames.Add(item.Category_Name);
            foreach (var item in bodyTypes)
                typeNames.Add(item.Name);

            ViewBag.Category_Names = categorieNames;
            ViewBag.TypeNames = typeNames;
            ViewBag.LocationNames = locations;

            /*get selections from dropdown form*/
            string categSelection = Request.Form["Category_Name"].ToString();
            string bodySelection = Request.Form["TypeName"].ToString();
            var selectedLocations = Request.Form["AreChecked"].ToList();

            var selectedCategory = await _categoriesRepository.GetCategoryByIDAsync(categSelection);
            var selectedBodyType = await _carTypesRepository.GetBodyTypeByNameAsync(bodySelection);

            car.Category = selectedCategory;
            /*Increment the number of cars in this category*/
            car.Category.NumberOfCars += 1;
            car.Type = selectedBodyType;

            foreach (var sel in selectedLocations)
            {
                CarLocation carLocation = new CarLocation();
                carLocation.Car = car;

                var location = await _locationsRepository.GetLocationByIDAsync(Int32.Parse(sel));
                carLocation.Location = location;

                car.CarLocations.Add(carLocation);
            }

            _carRepository.InsertCar(car);
            await _carRepository.SaveAsync();

            return View(car);
        }
    }
}
