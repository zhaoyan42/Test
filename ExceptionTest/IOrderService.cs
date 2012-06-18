using System.Collections.Generic;
using System.Linq;
using ExceptionTest.Model;

namespace ExceptionTest
{
    public interface IOrderService
    {
        IEnumerable<OrdersDTO> GetAllOrders();
    }
}