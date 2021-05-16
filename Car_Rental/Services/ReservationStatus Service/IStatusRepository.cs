using Car_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services.ReservationStatus
{
    public interface IStatusRepository
    {
        Task<IEnumerable<Status>> GetStatusesAsync();
        Status GetStatusByNameAsync(string name);
        Task SaveAsync();
        void DeleteStatus(Status status);
        void InsertStatus(Status status);
        void UpdateStatus(Status status);
    }
}
