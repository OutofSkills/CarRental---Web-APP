using Car_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services
{
    public interface ICarTypeRepository
    {
        Task<IEnumerable<CarTypes>> GetBodyTypesAsync();
        Task<CarTypes> GetBodyTypeByNameAsync(string typeName);
        Task SaveAsync();
        Task DeleteBodyType(int typeID);
        void InsertBodyType(CarTypes type);
        void UpdateBodyType(CarTypes type);
    }
}
