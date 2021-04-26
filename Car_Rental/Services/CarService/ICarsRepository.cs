using Car_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services.CarServices
{
    public interface ICarsRepository
    {
        Task<IEnumerable<Car>> GetCarsAsync();
        Car GetCarByID(int carId);
        Task SaveAsync();
        void DeleteCar(Car car);
        void InsertCar(Car car);
        void UpdateCar(Car car);
    }
}
