using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SilkScreenOrder.Models;

namespace SilkScreenOrder.DAL
{
    public class OrderFormRepo : IOrderFormRepo
    {
        readonly AppContext _context;

        public OrderFormRepo(AppContext context)
        {
            _context = context;
        }

        public void AddOrderForm(OrderForm newOrderForm)
        {
            _context.OrderForms.Add(newOrderForm);
            _context.SaveChanges();
        }

        public IEnumerable<OrderForm> GetOrderForms()
        {
            return _context.OrderForms;
        }
    }
}