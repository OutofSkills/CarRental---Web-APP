using Car_Rental.Models;
using Car_Rental.Services.CustomerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepo;

        public CustomerController(ICustomerRepository customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public IActionResult ProfileAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                var customer =  _customerRepo.GetCustomerByUsername(User.Identity.Name);
                if (customer.Address != null)
                {
                    ViewBag.Address = customer.Address;
                }
                else
                {
                    ViewBag.Address = new Address();
                }

                return View(customer);
            }

            return View("Login", "Security");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfileAsync(Customer customer, IFormFile Image, Address address)
        {
            var customerToUpdate = _customerRepo.GetCustomerByUsername(User.Identity.Name);

            if (Image != null)
            {
                if (Image.Length > 0)
                {
                    using (var target = new MemoryStream())
                    {
                        Image.CopyTo(target);
                        customerToUpdate.Image = target.ToArray();
                    }
                }
            }

            customerToUpdate.FirstName = customer.FirstName;
            customerToUpdate.LastName = customer.LastName;
            customerToUpdate.PhoneNumber = customer.PhoneNumber;
           
            customerToUpdate.Address.County = address.County;
            customerToUpdate.Address.City = address.City;
            customerToUpdate.Address.Street = address.Street;
            customerToUpdate.Address.Street_Number = address.Street_Number;
            customerToUpdate.Address.Zip_Code = address.Zip_Code;

            //check email if valid
            if (customer.UserName != customerToUpdate.UserName)
            { 
                var customers = await _customerRepo.GetCustomersAsync();

                if (customers.Where(c => c.UserName == customer.UserName).Count() == 0)
                {
                    customerToUpdate.UserName = customer.UserName;
                }
                else
                {
                    ViewBag.Message = "User with this username already exists";
                    ViewBag.EditStatus = 0;

                    ViewBag.Address = customerToUpdate.Address;

                    return View("Profile", customerToUpdate);
                }
            }

            ViewBag.Address = customerToUpdate.Address;
            ViewBag.Message = "Changes saved successfully";
            ViewBag.EditStatus = 1;

            _customerRepo.UpdateCustomer(customerToUpdate);
            await _customerRepo.SaveAsync();

            return View("Profile", customerToUpdate);
        }

        #region Tools
        public ActionResult GetImage(string username)
        {
            var customer = _customerRepo.GetCustomerByUsername(username);
            byte[] bytes = customer.Image; //Get the image from your database
            return File(bytes, "image/png"); //or "image/jpeg", depending on the format
        }
        #endregion
    }
}
