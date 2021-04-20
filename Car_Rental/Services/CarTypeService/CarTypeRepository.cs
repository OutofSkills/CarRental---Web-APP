using Car_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services
{
    public class CarTypeRepository: ICarTypeRepository
    {
        private readonly CarRentalContext _context;

        public CarTypeRepository(CarRentalContext context)
        {
            _context = context;
        }

        public async Task DeleteBodyType(int typeID)
        {
            var typeToDelete = await _context.CarTypes.FindAsync(typeID);
            _context.CarTypes.Remove(typeToDelete);
        }

        public async Task<CarTypes> GetBodyTypeByNameAsync(string typeName)
        {
            return await(from t in _context.CarTypes
                         where t.Name == typeName
                         select t).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CarTypes>> GetBodyTypesAsync()
        {
            return await _context.CarTypes.ToListAsync();
        }

        public void InsertBodyType(CarTypes type)
        {
            _context.CarTypes.AddAsync(type);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateBodyType(CarTypes type)
        {
            _context.CarTypes.Update(type);
        }
    }
}
