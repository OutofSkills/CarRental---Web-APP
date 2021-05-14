using Car_Rental.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Controllers
{
    public class SecurityController : Controller
    {
        private UserManager<Customer> _userManager { get; set; }
        private SignInManager<Customer> _signInManager { get; set; }

       public SecurityController(UserManager<Customer> userManager, SignInManager<Customer> signInManager)
       {
            _userManager = userManager;
            _signInManager = signInManager;
       }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email", "Password")] Customer customer)
        {
            Customer user = await _userManager.FindByEmailAsync(customer.Email);
            var result = await _signInManager.PasswordSignInAsync(user.UserName, customer.Password, false, false);

            if(result.Succeeded)
            {
                ViewBag.Result = "Welcome, " + user.UserName;
                ViewBag.LoginFlag = 1;

                //return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.LoginFlag = 0;
                ViewBag.Result = "Wrong username or password ";
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Customer customer)
        {
            try
            {
                ViewBag.Flag = 0;
                ViewBag.Message = "User already registered";

                Customer user = await _userManager.FindByNameAsync(customer.UserName);
                // Customer customer = await _userManager.FindByNameAsync("admin");
                if (user == null)
                {
                    Address address = new Address();
                    address.County = Request.Form["county"].ToString();
                    address.City = Request.Form["city"].ToString();
                    address.Street = Request.Form["street"].ToString();
                    int strNumber = 0;
                    if(Int32.TryParse(Request.Form["streetNr"].ToString(), out strNumber))
                    {
                        address.Street_Number = strNumber;
                    }
                    address.Zip_Code = Request.Form["zip"].ToString(); ;

                    //set address
                    customer.Address = address;

                    //set hashed password
                    IdentityResult result = await _userManager.CreateAsync(customer, customer.Password);

                    if (result.Succeeded)
                    {
                        ViewBag.Message = "User was created";
                        ViewBag.Flag = 1;
                    }
                    else
                    {
                        ViewBag.Message = result.Errors.FirstOrDefault().Code;
                        ViewBag.Flag = 0;
                    }
                }
            }
            catch(Exception e)
            {
                ViewBag.Flag = 0;
                ViewBag.Message = e.InnerException.Message;
            }
            return View("Login");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
