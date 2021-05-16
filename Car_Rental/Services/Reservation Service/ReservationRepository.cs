using Car_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services.Reservations
{
    public class ReservationRepository:IReservationRepository
    {
        private readonly CarRentalContext _context;

        public ReservationRepository(CarRentalContext context)
        {
            _context = context;
        }

        public void DeleteReservation(Reservation reservation)
        {
            _context.Reservations.Remove(reservation);
        }

        public Reservation GetReservationByID(int idReservation)
        {
            return _context.Reservations.Where(r=> r.Reservation_ID == idReservation).Include(r=>r.Car)
                                                                           .Include(r=>r.Customer).ThenInclude(c=>c.BlackList)
                                                                           .Include(r=>r.Coupon)
                                                                           .Include(r=>r.Review)
                                                                           .Include(r=>r.Status)
                                                                           .FirstOrDefault();
        }

        public async Task<IEnumerable<Reservation>> GetReservationsAsync()
        {
            return await _context.Reservations.Include(r => r.Car).Include(r => r.Customer).ThenInclude(c => c.BlackList)
                                                                  .Include(r => r.Coupon)
                                                                  .Include(r => r.Review)
                                                                  .Include(r => r.Status)
                                                                  .ToListAsync();
        }

        public void InsertReservation(Reservation reservation)
        {
           _context.Reservations.AddAsync(reservation);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateReservation(Reservation reservation)
        {
            //var existingCar = GetCarByID(car.CarID);
            //_context.Entry(existingCar).CurrentValues.SetValues(car);

            _context.Update(reservation);
        }
    }
}
