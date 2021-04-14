﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Car_Rental.Models;
using Car_Rental.Services.CarServices;

namespace Car_Rental.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarsRepository _carRepository;

        public CarsController(ICarsRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Listing()
        {
            return View(await _carRepository.GetCarsAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Car car)
        {
            _carRepository.InsertCar(car);
            return View();
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
