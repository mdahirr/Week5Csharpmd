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
    //    FirstName = "BLOGG",
    //    LastName = "Joe Bloggs",
    //    University = "ToysRUs"
    //};

    //db.Spartans.Add(newSpartan);
    //db.SaveChanges();
    #endregion

    #region Deleting
    var customerToDelete = db.Spartan.Find("Philip");
    db.Spartan.Remove(customerToDelete);
    db.SaveChanges();

    var deleted = db.Spartan.Find("philip");
    if (deleted == null)
    {
        Console.WriteLine("Deleted Successfully");
    }
    #endregion
}