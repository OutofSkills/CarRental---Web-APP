using Car_Rental.Models;
using Car_Rental.Services;
using Car_Rental.Services.CarServices;
using Car_Rental.Services.Coupons_Service;
using Car_Rental.Services.Reservations;
using Car_Rental.Services.ReservationStatus;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly ICarsRepository _carsRepo;
        private readonly ICouponsRepository _couponsRepo;
        private readonly IStatusRepository _statusesRepo;
        private readonly IReservationRepository _reservationsRepo;
        private UserManager<Customer> _userManager { get; set; }

        public ReservationsController(ICarsRepository carsRepo, IStatusRepository statusesRepo, IReservationRepository reservationsRepo, ICouponsRepository couponsRepo, UserManager<Customer> userManager)
        {
            _carsRepo = carsRepo;
            _reservationsRepo = reservationsRepo;
            _couponsRepo = couponsRepo;
            _userManager = userManager;
            _statusesRepo = statusesRepo;
        }

        [HttpGet]
        public IActionResult MakeReservation(int idCar)
        {
            var carToBook = _carsRepo.GetCarByID(idCar);
            ViewBag.carToBook = carToBook;
     
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MakeReservationAsync(Reservation reservation, int idCar)
        {
            if (ModelState.IsValid)
            {



                var coupon = _couponsRepo.GetCouponByCode(reservation.Coupon.Code);

                if (coupon != null)
                {
                    reservation.Coupon = coupon;
                }

                var carToBook = _carsRepo.GetCarByID(idCar);
                reservation.Car = carToBook;

                var customer = await _userManager.FindByNameAsync(User.Identity.Name);
                reservation.Customer = customer;

                var status = _statusesRepo.GetStatusByNameAsync("Confirmed");
                reservation.Status = status;

                var review = new Review();
                reservation.Review = review;

                _reservationsRepo.InsertReservation(reservation);
                await _reservationsRepo.SaveAsync();

                ViewBag.carToBook = carToBook;

                ViewBag.Message = "Car successfully booked";
                ViewBag.Flag = 1;

                return View();
            }

            ViewBag.Message = "Something went wrong";
            ViewBag.Flag = 0;

            return View(reservation);
        }
    }
}
