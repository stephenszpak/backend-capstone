using SilkScreenOrder.DAL;
using SilkScreenOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SilkScreenOrder.Controllers
{
    public class CustomerController : ApiController
    {
        readonly ICustomerRepo _customerRepo;

        public CustomerController(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [Route("api/customer")]
        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            var showAllCustomers = _customerRepo.GetCustomers();
            return showAllCustomers;
        }

        [Route("api/customer")]
        [HttpPost]
        public void AddCustomer(Customer newCustomer)
        {
            _customerRepo.AddCustomer(newCustomer);
        }
    }
}
