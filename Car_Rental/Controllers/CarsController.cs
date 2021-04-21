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
        private readonly ICarsRepository _carsRepo;
        private readonly ICarCategoryRepository _categoriesRepo;
        private readonly ICarTypeRepository _typesRepo;
        private readonly ILocationsRepository _locationsRepo;

        /// <summary>
        /// Constructor that initializes the car related repositories
        /// </summary>
        /// <param name="carRepo"></param>
        /// <param name="categoriesRepo"></param>
        /// <param name="typesRepo"></param>
        /// <param name="locationsRepo"></param>
        public CarsController(ICarsRepository carRepo, ICarCategoryRepository categoriesRepo, 
                              ICarTypeRepository typesRepo, ILocationsRepository locationsRepo)
        {
            _carsRepo = carRepo;
            _categoriesRepo = categoriesRepo;
            _typesRepo = typesRepo;
            _locationsRepo = locationsRepo;
        }

        /// <summary>
        /// Returns all the cars in a Category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Listing(string id)
        {
            var cars = await _carsRepo.GetCarsAsync();

            if (!string.IsNullOrEmpty(id))
            {
                var carsInCategory = cars.Where(car => car.Category.Category_Name == id).ToList();
                var currentCategory = await _categoriesRepo.GetCategoryByIDAsync(id);

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
            var categories = await _categoriesRepo.GetCategoriesAsync();
            var bodyTypes = await _typesRepo.GetBodyTypesAsync();
            var locations = await _locationsRepo.GetLocationsAsync();

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
            var categories = await _categoriesRepo.GetCategoriesAsync();
            var bodyTypes = await _typesRepo.GetBodyTypesAsync();
            var locations = await _locationsRepo.GetLocationsAsync();

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

            var selectedCategory = await _categoriesRepo.GetCategoryByIDAsync(categSelection);
            var selectedBodyType = await _typesRepo.GetBodyTypeByNameAsync(bodySelection);

            car.Category = selectedCategory;
            /*Increment the number of cars in this category*/
            car.Category.NumberOfCars = car.Category.Cars.Count + 1;
            car.Type = selectedBodyType;

            foreach (var sel in selectedLocations)
            {
                CarLocation carLocation = new CarLocation();
                carLocation.Car = car;

                var location =  _locationsRepo.GetLocationByID(Int32.Parse(sel));
                carLocation.Location = location;

                car.CarLocations.Add(carLocation);
            }

            _carsRepo.InsertCar(car);
            await _carsRepo.SaveAsync();

            return View(car);
        }

        /// <summary>
        /// Search a car in a category with a search string passed from the Listing view
        /// </summary>
        /// <param name="searchedCarModel"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public async Task<IActionResult> Search(string searchedCarModel, string category)
        {
            var cars = await _carsRepo.GetCarsAsync();
            if (!string.IsNullOrEmpty(category))
            {
                List<Car> carsInCategory = new List<Car>();
                if (category == "All the Cars")
                {
                    ViewBag.Category_Name = "All the Cars";
                    ViewBag.Description = "Choose the best car from all the categories";

                    if (!string.IsNullOrEmpty(searchedCarModel))
                    {
                        var matchedCars = cars.Where(car => car.Model.ToLower().Contains(searchedCarModel.ToLower())).ToList();
                        return View("Listing", matchedCars);
                    }
                }
                else
                {
                    carsInCategory = cars.Where(car => car.Category.Category_Name == category).ToList();
                    var currentCategory = await _categoriesRepo.GetCategoryByIDAsync(category);

                    ViewBag.Category_Name = category;
                    ViewBag.Description = currentCategory.Details;

                    if (!string.IsNullOrEmpty(searchedCarModel))
                    {
                        var matchedCars = carsInCategory.Where(car => car.Model.ToLower().Contains(searchedCarModel.ToLower())).ToList();
                        return View("Listing", matchedCars);
                    }
                }

                return View("Listing", carsInCategory);
            }
            else
            {
                ViewBag.Category_Name = "All the Cars";
                ViewBag.Description = "Choose the best car from all the categories";

                return View("Listing", cars);
            }
        }
    }
}
