using Car_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services.LocationService
{
    public interface ILocationsRepository
    {
        Task<IEnumerable<Location>> GetLocationsAsync();
        Location GetLocationByID(int locationId);
        Task SaveAsync();
        Task DeleteLocation(int locationId);
        void InsertLocation(Location location);
        void UpdateLocation(Location location);
    }
}
