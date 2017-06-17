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
        //readonly IDesignRepo _designRepo;
        //readonly IApparelRepo _apparelRepo;
        //readonly ICustomerRepo _customerRepo;

        public OrderFormController(IOrderFormRepo orderFormRepo,IApparelRepo apparelRepo, IDesignRepo designRepo,ICustomerRepo customerRepo)
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
        public void AddOrderForm(AddOrderViewModel newOrderForm)
        {
            var newCustomer = new Customer {
                CustomerPhone = newOrderForm.CustomerPhone,
                CustomerEmail = newOrderForm.CustomerEmail,
                CustomerAddress = newOrderForm.CustomerAddress,
                CustomerName = newOrderForm.CustomerName
                
            };
            var newDesign = new Design {
                DesignFee = newOrderForm.DesignFee,
                DesignHeight = newOrderForm.DesignHeight,
                DesignWidth = newOrderForm.DesignWidth,
                AmountOfColorsOfDesign = newOrderForm.AmountOfColorsOfDesign,
                InkColorsToBeUsed = newOrderForm.InkColorsToBeUsed,
                LogoLocations = newOrderForm.LogoLocations
            };
            var newApparel = new Apparel {
                ApparelBrand = newOrderForm.ApparelBrand,
                ApparelColor = newOrderForm.ApparelColor,
                ApparelPricePerPiece = newOrderForm.ApparelPricePerPiece,
                ApparelQuantity = newOrderForm.ApparelQuantity,
                ApparelType = newOrderForm.ApparelType
            };

            var order = new OrderForm
            {
                Customer = newCustomer,
                Design = newDesign,
                Apparel = newApparel,
                AdditionalNotes = newOrderForm.AdditionalNotes,
                OrderDate = newOrderForm.OrderDate,
                OrderDueDate = newOrderForm.OrderDueDate,
                OrderNumber = newOrderForm.OrderNumber,
                SalesPerson = newOrderForm.SalesPerson,
                TotalPrice = newOrderForm.TotalPrice
            };

            //_designRepo.AddDesign(newDesign);
            //_apparelRepo.AddApparel(newApparel);
            //_customerRepo.AddCustomer(newCustomer);
            _orderFormRepo.AddOrderForm(order);

        }

        [Route("api/orderform/details/{OrderFormId}")]
        [HttpGet]
        public OrderForm GetSingleOrder(int orderformId)
        {
            var getSingleOrder = _orderFormRepo.GetSingleOrder(orderformId);
            return getSingleOrder;
        }

        [Route("api/orderform/{OrderFormId}")]
        [HttpDelete]
        public OrderForm DeleteOrder(int orderFormId)
        {
            var deleteOrder = _orderFormRepo.DeleteOrder(orderFormId);
            return deleteOrder;
        }
    }
}
