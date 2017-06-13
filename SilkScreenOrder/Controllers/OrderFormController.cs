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
    public class OrderFormController : ApiController
    {
        readonly IOrderFormRepo _orderFormRepo;

        public OrderFormController(IOrderFormRepo orderFormRepo)
        {
            _orderFormRepo = orderFormRepo;
        }

        [Route("api/orderform")]
        [HttpGet]
        public IEnumerable<OrderForm> GetAllOrderForms()
        {
            var showAllOrderForms = _orderFormRepo.GetOrderForms();
            return showAllOrderForms;
        }
            
        [Route("api/orderform")]
        [HttpPost]
        public void AddOrderForm(OrderForm newOrderForm)
        {
            _orderFormRepo.AddOrderForm(newOrderForm);
        }

        [Route("api/orderform/details/{OrderFormId}")]
        [HttpGet]
        public OrderForm GetSingleOrder(int orderformId)
        {
            var getSingleOrder = _orderFormRepo.GetSingleOrder(orderformId);
            return getSingleOrder;
        }
    }
}
