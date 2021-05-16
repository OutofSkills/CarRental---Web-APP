using Car_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services.Coupons_Service
{
    public class CouponsRepository: ICouponsRepository
    {
        private readonly CarRentalContext _context;

        public CouponsRepository(CarRentalContext context)
        {
            _context = context;
        }

        public void DeleteCoupon(Coupon coupon)
        {
            _context.Coupons.Remove(coupon);
        }

        public Coupon GetCouponByCode(string code)
        {
            return _context.Coupons.Where(c => c.Code == code).FirstOrDefault();
        }

        public async Task<IEnumerable<Coupon>> GetCouponsAsync()
        {
            return await _context.Coupons.ToListAsync();
        }

        public void InsertCoupon(Coupon coupon)
        {
            _context.Coupons.AddAsync(coupon);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        //NU MERGE
        public void UpdateCoupon(Coupon coupon)
        {
            //var existingCar = GetCarByID(car.CarID);
            //_context.Entry(existingCar).CurrentValues.SetValues(car);

            _context.Update(coupon);
        }
    }
}
