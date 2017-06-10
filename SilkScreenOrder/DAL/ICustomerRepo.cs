using SilkScreenOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilkScreenOrder.DAL
{
    public interface ICustomerRepo
    {
        Customer GetCustomerById(int customerId);

        IEnumerable<Customer> GetCustomers();

        void AddCustomer(Customer customer);
    }
}
