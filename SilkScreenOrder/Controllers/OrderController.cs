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
    public class OrderController : ApiController
    {
        readonly IOrderRepo _orderRepo;

        public OrderController(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        [Route("api/order")]
        [HttpGet]
        public IEnumerable<Order> GetAllOrders()
        {
            var showAllOrders = _orderRepo.GetAllOrders();
            return showAllOrders;
        }

        [Route("api/order")]
        [HttpPost]
        public void AddOrder(Order newOrder)
        {
            _orderRepo.AddOrder(newOrder);
        }
    }
}
