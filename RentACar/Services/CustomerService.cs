using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using RentACar.Interfaces;
using RentACar.Models;

namespace RentACar.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IDatabaseContext _databaseContext;

        public CustomerService(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<Customer> GetCustomers()
        {
            var db = _databaseContext.GetDatabase();

            var _customers = db.GetCollection<Customer>("Customers");

            return _customers.Find(customer => true).ToList();
        }
        public Customer AddCustomer(Customer customer)
        {
            var db = _databaseContext.GetDatabase();

            var _customers = db.GetCollection<Customer>("Customers");
            try
            {
                _customers.InsertOneAsync(customer);
                return customer;
            }
            catch
            {
                return new Customer();
            }
        }

        public void UpdateCustomer(string customerId, Customer updateCustomer)
        {
            var db = _databaseContext.GetDatabase();

            var _customers = db.GetCollection<Customer>("Customers");

            _customers.ReplaceOneAsync(customer => customer.CustomerId == customerId, updateCustomer);
        }

        public void DeleteCustomer(string customerId)
        {
            var db = _databaseContext.GetDatabase();

            var _customers = db.GetCollection<Customer>("Customers");

            _customers.DeleteOneAsync(customer => customer.CustomerId == customerId);
        }
    }
}
