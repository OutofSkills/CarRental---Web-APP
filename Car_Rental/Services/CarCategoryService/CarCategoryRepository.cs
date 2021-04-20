using Car_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services.CarCategoryServices
{
    public class CarCategoryRepository : ICarCategoryRepository
    {
        private readonly CarRentalContext _context;

        public CarCategoryRepository(CarRentalContext context)
        {
            _context = context;
        }

        public async Task DeleteCategory(string categoryId)
        {
            var categoryToDelete = await _context.Categories.FindAsync(categoryId);
            _context.Categories.Remove(categoryToDelete);
        }

        public async Task<IEnumerable<CarCategory>> GetCategoriesAsync()
        {
            return await _context.Categories.Include(categ => categ.Cars).ToListAsync();
        }

        public async Task<CarCategory> GetCategoryByIDAsync(string categoryId)
        {
            return await _context.Categories.FindAsync(categoryId);
        }

        public void InsertCategory(CarCategory category)
        {
            _context.Categories.Add(category);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateCategory(CarCategory category)
        {
            _context.Categories.Update(category);
        }
    }
}
