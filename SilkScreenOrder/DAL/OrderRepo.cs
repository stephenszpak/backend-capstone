using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SilkScreenOrder.Models;

namespace SilkScreenOrder.DAL
{
    public class OrderRepo : IOrderRepo
    {
        readonly AppContext _context;

        public OrderRepo(AppContext context)
        {
            _context = context;
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }


        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders;
        }

        public Order GetOrderById(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}