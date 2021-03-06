﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SilkScreenOrder.Models;

namespace SilkScreenOrder.DAL
{
    public class CustomerRepo : ICustomerRepo
    {
        readonly AppContext _context;

        public CustomerRepo(AppContext context)
        {
            _context = context;
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public Customer DeleteCustomer(int customerId)
        {
            Customer customer = new Customer();
            customer = _context.Customers.Find(customerId);

            var deleteMe = _context.Customers.Remove(customer);
            _context.SaveChanges();
            return deleteMe;
        }

        public Customer GetCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers;
        }
    }
}