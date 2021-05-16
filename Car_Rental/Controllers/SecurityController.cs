using Car_Rental.Models;
using Car_Rental.Services.CustomerService;
using Microsoft.AspNetCore.Authorization;
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
        private RoleManager<Role> _roleManager { get; set; }

        private readonly ICustomerRepository _customerRepo;

        public SecurityController(UserManager<Customer> userManager, SignInManager<Customer> signInManager, RoleManager<Role> roleManager, ICustomerRepository customerRepo)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _customerRepo = customerRepo;
            _roleManager = roleManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([Bind("Email", "Password")] Customer customer, string returnUrl)
        {
            Customer user = await _userManager.FindByEmailAsync(customer.Email);

            if(user == null)
            {
                ViewBag.LoginFlag = 0;
                ViewBag.Result = "Wrong email";

                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(user.UserName, customer.Password, false, false);
            if(result.Succeeded)
            {
                ViewBag.Result = "Welcome, " + user.UserName;
                ViewBag.LoginFlag = 1;

                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("index", "home");
                }
            }
            else
            {
                ViewBag.LoginFlag = 0;
                ViewBag.Result = "Wrong password ";
            }

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
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

                    //set role
                    var roleExist = await _roleManager.RoleExistsAsync("User");
                    if(!roleExist)
                    {
                        var role = new Role();
                        role.Name = "User";
                        role.Details = "Basic user with basic attributes";

                        var roleResult =  await _roleManager.CreateAsync(role);

                        if(roleResult.Succeeded)
                        {
                            customer.Role = await _roleManager.FindByNameAsync("User");
                        }
                    }
                    else
                    {
                        customer.Role = await _roleManager.FindByNameAsync("User");
                    }

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

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Settings()
        {
           Customer customer = await _userManager.FindByNameAsync(User.Identity.Name);

           return View(customer);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ChangeSettings(Customer customer, string currPassword)
        {
            if (User.Identity.IsAuthenticated)
            {
                var customers = await _customerRepo.GetCustomersAsync();
                var matchedCustomers = customers.Where(c => c.Email == customer.Email);
                var customerToUpdate = _customerRepo.GetCustomerByUsername(User.Identity.Name);

                if (customer.Email != customerToUpdate.Email)
                   if (matchedCustomers.Count() != 0)
                   {
                        ViewBag.Message = "User with this email is already registred";
                        ViewBag.EditStatus = 0;

                        return View("Settings", customerToUpdate);
                    }

                //set new username and hashed password
                IdentityResult passwordResult = await _userManager.ChangePasswordAsync(customerToUpdate, currPassword, customer.Password);
                if(passwordResult.Succeeded)
                { 
                     customerToUpdate.Email = customer.Email;
                     customerToUpdate.NormalizedEmail = customer.Email;

                     _customerRepo.UpdateCustomer(customerToUpdate);
                     await _customerRepo.SaveAsync();

                     ViewBag.Message = "Changes saved successfully";
                     ViewBag.EditStatus = 1;

                    return View("Settings", customerToUpdate);
                }
                else
                {
                     ViewBag.Message = passwordResult.Errors.FirstOrDefault().Code;
                     ViewBag.EditStatus = 0;

                    return View("Settings", customerToUpdate);
                }
                  
            }

            //shouldn't reach this code
            return NotFound();
        }
    }
}
