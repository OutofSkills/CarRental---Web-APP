using Car_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services.CarCategoryServices
{
    public interface ICarCategoryRepository
    {
        Task<IEnumerable<CarCategory>> GetCategoriesAsync();
        Task<CarCategory> GetCategoryByIDAsync(string categoryId);
        Task SaveAsync();
        Task DeleteCategory(string categoryId);
        void InsertCategory(CarCategory category);
        void UpdateCategory(CarCategory category);
    }
}
