using System.Linq;
using ExceptionTest.Model;

namespace ExceptionTest
{
    public interface IOrderService
    {
        IQueryable<OrdersDTO> GetAllOrders();
    }
}