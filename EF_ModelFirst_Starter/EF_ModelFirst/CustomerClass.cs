using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ModelFirst
{
    internal class CustomerClass
    {
        public static void Read()
        {
            using (var db = new SouthwindContext()) 
            {
                foreach (var customer in db.Customers)
                {
                    Console.WriteLine($"ID: {customer.CustomerId}, Contact name: {customer.ContactName}, City: {customer.City}1");
                }
            }
        }

        public static void Create(Customer newCustomer)
        {
            using (var db = new SouthwindContext())
            {
                db.Customers.Add(newCustomer);
                db.SaveChanges();
            }
        }

        public static void Update(Customer updatedCustomer)
        {
            using (var db = new SouthwindContext())
            {
                var selectedCustomer = db.Customers.Find(updatedCustomer.CustomerId);
                selectedCustomer.ContactName = updatedCustomer.ContactName;
                selectedCustomer.City = updatedCustomer.City;
                selectedCustomer.PostalCode = updatedCustomer.PostalCode;
                db.SaveChanges();
            }
        }

        public static void Delete(Customer customer) 
        {
            
        }
    }
}
