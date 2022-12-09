using Microsoft.EntityFrameworkCore;
using NorthwindData;
using NorthwindData.Models;

using (var db = new NorthwindContext())
{
    #region view spartans
    //foreach (var spartan in db.Spartans)
    //{
    //    Console.WriteLine(
    //        $"First name: {spartan.FirstName}. " +
    //        $"Last name: {spartan.LastName}. " +
    //        $"Completed studies at: {spartan.University}"
    //    );
    //}
    #endregion

    #region Adding Spartans
    //var newSpartan = new Spartan
    //{
    //    FirstName = "matilde",
    //    LastName = "blackmore",
    //    University = "University of Oxford"
    //};

    //db.Spartans.Add(newSpartan);
    //db.SaveChanges();
    #endregion

    #region Deleting
    //var customerToDelete = db.Spartan.Find("Philip");
    //db.Spartan.Remove(customerToDelete);
    //db.SaveChanges();

    //var deleted = db.Spartan.Find("philip");
    //if (deleted == null)
    //{
    //    Console.WriteLine("Deleted Successfully");
    //}
    #endregion

    #region LINQ query syntax  // Language INtergrated Query

    //var records =
    //from customer in db.Customers
    //select customer;



    //foreach (var row in records)
    //{
    //    Console.WriteLine(row);
    //}

    //var londonBerlinQuery1 =
    // from customer in db.Customers
    // where customer.City == "London" || customer.City == "Berlin"
    // select customer;



    //foreach (var customer in londonBerlinQuery1)
    //{
    //    Console.WriteLine(customer);
    //}

    //var londonBerlinQuery2 =
    // from customer in db.Customers
    // where customer.City == "London" || customer.City == "Berlin"
    // select new { Customer = customer.ContactName, Country = customer.Country };



    //foreach (var customer in londonBerlinQuery2)
    //{
    //    Console.WriteLine($"{customer.Customer} lives in {customer.Country}");
    //}

    //var orderProductsByUnitPrice =
    //from p in db.Products
    //orderby p.UnitPrice descending // default ascending if not specified
    //select p;



    //foreach (var product in orderProductsByUnitPrice)
    //{
    //    Console.WriteLine($"{product.ProductId} - {product.UnitPrice:C}");
    //}

    //var groupProductsByUnitInStockQuery =
    //from p in db.Products
    //group p by p.SupplierId into newGroup

    //select new
    //{
    //    SupplierID = newGroup.Key,
    //    UnitsInStock = newGroup.Sum(c => c.UnitsInStock)
    //};


    //foreach (var result in groupProductsByUnitInStockQuery)
    //{
    //    Console.WriteLine(result);
    //}
    #endregion

    #region LINQ method syntax

    //var query1 =
    //    from c in db.Customers
    //    where c.City == "London"
    //    orderby c.ContactName
    //    select c;

    //var query = db.Customers
    //    .Where(c => c.City == "London")
    //    .OrderBy(c => c.ContactName); 
    #endregion

    #region LINQ method syntax

    //var query = db.Customers
    //    .Where(c => c.City == "London" || c.City == "Berlin")
    //    .OrderBy(c => c.ContactName)
    //    .Select(c => new { Name = c.ContactName, City = c.City });

    ////Console.WriteLine(query);

    //foreach (var customer in query)
    //{
    //    Console.WriteLine(customer.Name);
    //}

    //var query3 = db.Products
    //    .OrderBy(c => c.QuantityPerUnit)
    //    .ThenByDescending(c => c.ReorderLevel);

    //foreach (var s in query3)
    //{
    //    Console.WriteLine("QPU: {0}, RL: {1}", s.QuantityPerUnit, s.ReorderLevel);
    //}

    #endregion

    #region loading and joining tables

    //var orders = db.Orders
    //    .Include(o => o.Customer)
    //    .Include(o => o.OrderDetails)
    //    .Where(o => o.Freight > 750);



    //foreach (var order in orders)
    //{
    //    if (order.Customer != null)
    //        Console.WriteLine($"Order {order.OrderId} " +
    //            $"was made by {order.Customer.ContactName} " +
    //            $"of {order.Customer.CompanyName}");

    //    foreach (var item in order.OrderDetails)
    //    {
    //        Console.WriteLine($"    Product{item.ProductId} " + $"Quantity {item.Quantity}");
    //    }

    //Phil's solution

    //foreach (var od in order.OrderDetails)
    //{
    //    Console.WriteLine($"\t Product: {od.ProductId} " + $"- Quantity {od.Quantity}");
    //}
    //}

    //var orders = db.Orders
    //    .Include(o => o.Customer)
    //    .Include(o => o.OrderDetails)
    //    .ThenInclude(od => od.Product)
    //    .Where(o => o.Freight > 750)
    //    .Select(o => o);



    //foreach (var order in orders)
    //{
    //    Console.WriteLine($"Order {order.OrderId} " +
    //            $"was made by {order.Customer.ContactName} " +
    //            $"of {order.Customer.CompanyName}");



    //    foreach (var od in order.OrderDetails)
    //    {
    //        Console.WriteLine($"\t Product: {od.ProductId} " +
    //            $"- {od.Product.ProductName} " +
    //            $"- Quantity {od.Quantity}");
    //    }
    //}
    #endregion

    #region Loading and joining tables
    #region Q 1.1 (done)


    //var customers = db.Customers
    //    .Where(c => c.City == "London" || c.City == "Paris")
    //    .Select(c => c);

    //foreach (var item in customers)
    //{
    //    Console.WriteLine(
    //        $"customerid: {item.CustomerId} " +
    //        $"company name: {item.CompanyName} " +
    //        $"address: {item.Address} " +
    //        $"city: {item.City} " +
    //        $"postalcode: {item.PostalCode} " +
    //        $"country: {item.Country} "
    //        );
    //}
    #endregion
    #region Q 1.2 (done)

    //var products = db.Products
    //    .Where(p => p.QuantityPerUnit.Contains("bottles"))
    //    .Select(p => p);

    //foreach (var item in products)
    //{
    //    Console.WriteLine($"ProductName: {item.ProductName} " +
    //        $"QuantityPerUnit: {item.QuantityPerUnit}");
    //}
    #endregion
    #region Q 1.3 (done)
    //var products = db.Products
    //    .Where(p => p.QuantityPerUnit.Contains("bottles"))
    //    .Include(p => p.Supplier);
    ////.Select(p => p);

    //foreach (var item in products)
    //{
    //    Console.WriteLine($"ProductName: {item.ProductName} " +
    //        $"QuantityPerUnit: {item.QuantityPerUnit} " +
    //        $"Company name: {item.Supplier.CompanyName} " +
    //        $"Country: {item.Supplier.Country}");
    //}
    #endregion
    #region Q 1.4

    //var categories = db.Categories
    //    .Include(c => c.Products)
    //    .Where(c => c.) 
    #endregion
    #region Q 1.5 (done)
    //var employees = db.Employees
    //   .Where(e => e.Country.Contains("UK"));

    //foreach (var item in employees)
    //{
    //    Console.WriteLine($"{item.TitleOfCourtesy} {item.FirstName} {item.LastName} lives in {item.City}");

    //}
    #endregion

    #region Q 1.6

    //var orders = db.Orders
    //    .Where(o => o.Freight > 100 && o.ShipCountry.Contains("USA") || o.ShipCountry.Contains("UK"));

    #endregion
    #endregion
}

#region method syntax cont
//var nums = new List<int> { 3, 7, 1, 2, 8, 3, 0, 4, 5 };
//Console.WriteLine(nums.Count(IsEven));
//var numsQuery = nums.Count(n => n % 2 == 0);
//var numsQuery2 = nums.Count(n => n % 2 != 0);
//var numsQuery3 = nums.Count(n => n <= 4);

//Console.WriteLine(numsQuery);
//Console.WriteLine(numsQuery2);
//Console.WriteLine(numsQuery3);

//List<Person> people = new List<Person>
//{
//    new Person { Name = "Fred", Age = 22 },
//    new Person { Name = "Bernard", Age = 35 },
//    new Person { Name = "Margaret", Age = 54 }
//};

//var personQuery = people.Where<Person>(p => p.Age <= 30);

//Console.WriteLine(personQuery);

//Console.WriteLine("Delegate: " + 
//    nums.Count(
//        delegate (int n) 
//        { 
//            return n % 2 == 0; 
//        }));

//static bool IsEven(int n)
//{
//    return n % 2 == 0;
//}

//static bool IsEven(int x) => x % 2 == 0;
#endregion