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
        Task<Car> GetCarByIDAsync(int carId);
        Task SaveAsync();
        Task DeleteCar(int carId);
        void InsertCar(Car car);
        void UpdateCar(Car car);
    }
}
