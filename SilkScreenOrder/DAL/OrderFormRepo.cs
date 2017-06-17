using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SilkScreenOrder.Models;
using System.Net;

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

        public OrderForm DeleteOrder(int orderFormId)
        {
            OrderForm form = new OrderForm();
            form = _context.OrderForms.Find(orderFormId);
           
            var deleteMe = _context.OrderForms.Remove(form);
            _context.SaveChanges();
            return deleteMe;
        }

        public IEnumerable<OrderForm> GetOrderForms()
        {
            return _context.OrderForms;
        }

        public OrderForm GetSingleOrder(int orderFormId)
        {
            return _context.OrderForms.Where(x => x.OrderFormId == orderFormId).FirstOrDefault();
        }
    }
}