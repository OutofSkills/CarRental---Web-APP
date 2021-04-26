using Car_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services.CarServices
{
    public class CarsRepository:ICarsRepository
    {
        private readonly CarRentalContext _context;

        public CarsRepository(CarRentalContext context)
        {
            _context = context;
        }

        public void DeleteCar(Car car)
        {
            _context.Cars.Remove(car);
        }

        public Car GetCarByID(int carId)
        {
            return _context.Cars.Where(c=> c.CarID == carId).Include(c=>c.Category)
                                                                           .Include(c=>c.Type)
                                                                           .Include(c=>c.CarLocations).ThenInclude(c=>c.Location)
                                                                           .FirstOrDefault();
        }

        public async Task<IEnumerable<Car>> GetCarsAsync()
        {
            return await _context.Cars.Include(car => car.Type)
                                      .Include(car => car.Category)
                                      .Include(car => car.CarLocations).ThenInclude(car => car.Location)
                                      .ToListAsync();
        }

        public void InsertCar(Car car)
        {
           _context.Cars.AddAsync(car);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        //NU MERGE
        public void UpdateCar(Car car)
        {
            //var existingCar = GetCarByID(car.CarID);
            //_context.Entry(existingCar).CurrentValues.SetValues(car);

            _context.Update(car);
        }
    }
}
