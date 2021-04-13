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

        public async Task DeleteCar(int carId)
        {
            var carToDelete = await _context.Cars.FindAsync(carId);
            _context.Cars.Remove(carToDelete);
        }

        public async Task<Car> GetCarByIDAsync(int carId)
        {
            return await _context.Cars.FindAsync(carId);
        }

        public async Task<IEnumerable<Car>> GetCarsAsync()
        {
            return await _context.Cars.ToListAsync();
        }

        public void InsertCar(Car car)
        {
           _context.Cars.AddAsync(car);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateCar(Car car)
        {
            _context.Cars.Update(car);
        }
    }
}
