using Car_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services.LocationService
{
    public class LocationsRepository:ILocationsRepository
    {
        private readonly CarRentalContext _context;

        public LocationsRepository(CarRentalContext context)
        {
            _context = context;
        }

        public async Task DeleteLocation(int locationID)
        {
            var locationToDelete = await _context.Cars.FindAsync(locationID);
            _context.Cars.Remove(locationToDelete);
        }

        public async Task<Location> GetLocationByIDAsync(int locationID)
        {
            return await _context.Locations.FindAsync(locationID);
        }

        public async Task<IEnumerable<Location>> GetLocationsAsync()
        {
            return await _context.Locations.ToListAsync();
        }

        public void InsertLocation(Location location)
        {
            _context.Locations.AddAsync(location);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateLocation(Location location)
        {
            _context.Locations.Update(location);
        }
    }
}
