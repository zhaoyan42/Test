using System;

namespace ExceptionTest.Model
{
    public class OrdersDTO
    {
        public DateTime? OrderDate { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}