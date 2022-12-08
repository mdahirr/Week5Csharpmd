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

    var groupProductsByUnitInStockQuery =
    from p in db.Products
    group p by p.SupplierId into newGroup

    select new
    {
        SupplierID = newGroup.Key,
        UnitsInStock = newGroup.Sum(c => c.UnitsInStock)
    };


    foreach (var result in groupProductsByUnitInStockQuery)
    {
        Console.WriteLine(result);
    }
    #endregion
}