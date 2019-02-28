using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentACar.Interfaces;
using RentACar.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentACar.Controllers
{

    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        // GET: api/customers
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_customerService.GetCustomers());
        }

        // Post api/customers
        [HttpPost]
        public JsonResult Post([FromBody]Customer newCustomer)
        {
            return new JsonResult(_customerService.AddCustomer(newCustomer));
        }

        // PUT api/<controller>
        [HttpPut("{customerId}")]
        public void Put(int customerId, [FromBody]Customer updatedCustomer)
        {
            _customerService.DeleteCustomer(customerId, updatedCustomer);
        }


        [HttpDelete("{customerId}")]
        public void Delete(string customerId)
        {
            _customerService.DeleteCustomer(customerId);
        }
    }
}
