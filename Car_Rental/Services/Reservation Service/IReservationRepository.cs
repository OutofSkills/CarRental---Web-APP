using Car_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services.Reservations
{
    public interface IReservationRepository
    {
        Task<IEnumerable<Reservation>> GetReservationsAsync();
        Reservation GetReservationByID(int idReservation);
        Task SaveAsync();
        void DeleteReservation(Reservation reservation);
        void InsertReservation(Reservation reservation);
        void UpdateReservation(Reservation reservation);
    }
}
