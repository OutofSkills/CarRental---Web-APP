using Car_Rental.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Services.CustomerService
{
    public interface ICustomerRepository 
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Customer GetCustomerByUsername(string username);
        Task SaveAsync();
        void DeleteCustomer(Customer customer);
        void InsertCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
    }
}
