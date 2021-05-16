using Car_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services.Coupons_Service
{
    public interface ICouponsRepository
    {
        Task<IEnumerable<Coupon>> GetCouponsAsync();
        Coupon GetCouponByCode(string code);
        Task SaveAsync();
        void DeleteCoupon(Coupon coupon);
        void InsertCoupon(Coupon coupon);
        void UpdateCoupon(Coupon coupon);
    }
}
