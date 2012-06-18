using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExceptionTest.Model;
using Repository;

namespace ExceptionTest
{
    public class OrderService : IOrderService
    {
        private static NorthWindEntities entities = new NorthWindEntities();

        public IEnumerable<OrdersDTO> GetAllOrders()
        {
            return entities.Orders.Select(order=>new OrdersDTO
                                                     {
                                                         OrderDate = order.OrderDate,
                                                         CompanyName = order.Customers.CompanyName,
                                                         FirstName = order.Employees.FirstName,
                                                         LastName = order.Employees.LastName,
                                                     });
        }
    }
}
