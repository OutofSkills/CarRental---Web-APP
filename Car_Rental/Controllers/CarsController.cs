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

        public CarsController(ICarsRepository carRepository, ICarCategoryRepository categoriesRepository, 
                              ICarTypeRepository carTypesRepository, ILocationsRepository locationsRepository)
        {
            _carRepository = carRepository;
            _categoriesRepository = categoriesRepository;
            _carTypesRepository = carTypesRepository;
            _locationsRepository = locationsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Listing()
        {
            return View(await _carRepository.GetCarsAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoriesRepository.GetCategoriesAsync();
            var bodyTypes = await _carTypesRepository.GetBodyTypesAsync();
            var locations = await _locationsRepository.GetLocationsAsync();

            List<string> categorieNames = new List<string>();
            List<string> typeNames = new List<string>();
            List<string> locationNames = new List<string>();

            /*get the existing categories name and body types name*/
            foreach (var item in categories)
                categorieNames.Add(item.Category_Name);
            foreach (var item in bodyTypes)
                typeNames.Add(item.Name);
            foreach (var item in locations)
                locationNames.Add(item.City);

            ViewBag.Category_Names = categorieNames;
            ViewBag.TypeNames = typeNames;
            ViewBag.LocationNames = locations;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(Car car)
        {
            var categories = await _categoriesRepository.GetCategoriesAsync();
            var bodyTypes = await _carTypesRepository.GetBodyTypesAsync();
            var locations = await _locationsRepository.GetLocationsAsync();

            List<string> categorieNames = new List<string>();
            List<string> typeNames = new List<string>();
            List<string> locationNames = new List<string>();

            /*get the existing categories name and body types name*/
            foreach (var item in categories)
                categorieNames.Add(item.Category_Name);
            foreach (var item in bodyTypes)
                typeNames.Add(item.Name);
            foreach (var item in locations)
                locationNames.Add(item.City);

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
        //// GET: Cars
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Cars.ToListAsync());
        //}

        //// GET: Cars/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var car = await _context.Cars
        //        .FirstOrDefaultAsync(m => m.CarID == id);
        //    if (car == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(car);
        //}

        //// GET: Cars/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Cars/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("CarID,Model,PictureURL,FuelType,Fabrication_Date,AverageScore,Acceleration,TransmisionType,ClimateControll")] Car car)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(car);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(car);
        //}

        //// GET: Cars/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var car = await _context.Cars.FindAsync(id);
        //    if (car == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(car);
        //}

        //// POST: Cars/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("CarID,Model,PictureURL,FuelType,Fabrication_Date,AverageScore,Acceleration,TransmisionType,ClimateControll")] Car car)
        //{
        //    if (id != car.CarID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(car);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CarExists(car.CarID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(car);
        //}

        //// GET: Cars/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var car = await _context.Cars
        //        .FirstOrDefaultAsync(m => m.CarID == id);
        //    if (car == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(car);
        //}

        //// POST: Cars/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var car = await _context.Cars.FindAsync(id);
        //    _context.Cars.Remove(car);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool CarExists(int id)
        //{
        //    return _context.Cars.Any(e => e.CarID == id);
        //}
    }
}
