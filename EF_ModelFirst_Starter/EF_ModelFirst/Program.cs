using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EF_ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SouthwindContext())
            {
                Customer cust = new Customer();
                cust.CustomerId = "1";
                cust.ContactName = "Mo";
                cust.City = "London";
                cust.PostalCode= "ab12cd";
            }
        }
    }
}
