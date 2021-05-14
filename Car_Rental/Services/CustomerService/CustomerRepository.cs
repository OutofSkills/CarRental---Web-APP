using Car_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services.CustomerService
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly CarRentalContext _context;

        public CustomerRepository(CarRentalContext context)
        {
            _context = context;
        }

        public void DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
        }

        public Customer GetCustomerByUsername(string username)
        {
            return _context.Customers.Where(c => c.UserName == username).Include(c => c.Address)
                                                                        .FirstOrDefault();
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _context.Customers.Include(c => c.Address)
                                            .ToListAsync();
        }

        public void InsertCustomer(Customer customer)
        {
            _context.Customers.AddAsync(customer);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        //NU MERGE
        public void UpdateCustomer(Customer customer)
        {
            //var existingCar = GetCarByID(car.CarID);
            //_context.Entry(existingCar).CurrentValues.SetValues(car);

            _context.Update(customer);
        }
    }
}
