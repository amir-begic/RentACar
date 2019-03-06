using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentACar.Models;

namespace RentACar.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer AddCustomer(Customer customer);
        void UpdateCustomer(string customerId, Customer updatedCustomer);
        void DeleteCustomer(string customerId);
    }
}
