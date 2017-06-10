using SilkScreenOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilkScreenOrder.DAL
{
    public interface IOrderRepo
    {
        Order GetOrderById(int orderId);

        IEnumerable<Order> GetAllOrders();

        void AddOrder(Order order);
    }
}
