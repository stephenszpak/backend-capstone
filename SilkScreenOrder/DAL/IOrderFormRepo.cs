using SilkScreenOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilkScreenOrder.DAL
{
    public interface IOrderFormRepo
    {
        IEnumerable<OrderForm> GetOrderForms();

        void AddOrderForm(OrderForm newOrderForm);

        OrderForm DeleteOrder(int orderFormId);

        OrderForm GetSingleOrder(int orderFormId);
    }
}
