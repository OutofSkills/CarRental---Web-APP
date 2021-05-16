using Car_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services.ReservationStatus
{
    public class StatusRepository : IStatusRepository
    {
        private readonly CarRentalContext _context;

        public StatusRepository(CarRentalContext context)
        {
            _context = context;
        }

        public void DeleteStatus(Status status)
        {
            _context.Statuses.Remove(status);
        }

        public async Task<IEnumerable<Status>> GetStatusesAsync()
        {
            return await _context.Statuses.ToListAsync();
        }

        public Status GetStatusByNameAsync(string name)
        {
            return _context.Statuses.Where(s=>s.Name == name).FirstOrDefault();
        }

        public void InsertStatus(Status status)
        {
            _context.Statuses.Add(status);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateStatus(Status status)
        {
            _context.Statuses.Update(status);
        }
    }
}
