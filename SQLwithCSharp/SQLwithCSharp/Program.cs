using SQLWithCSharp;
using System.Data.SqlClient;

var customers = new List<Customer>();

using (var connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))

{
    connection.Open();
    #region read

    //using (var readCommand = new SqlCommand("SELECT * FROM Customers", connection))
    //{
    //SqlDataReader sqlReader = readCommand.ExecuteReader();



    //while (sqlReader.Read())
    //{
    //    var customer = new Customer
    //    {
    //        CustomerID = sqlReader["CustomerId"].ToString(),
    //        ContactName = sqlReader["ContactName"].ToString(),
    //        CompanyName = sqlReader["CompanyName"].ToString(),
    //        City = sqlReader["City"].ToString(),
    //        ContactTitle = sqlReader["ContactTitle"].ToString()
    //    };
    //    customers.Add(customer);
    //}



    //foreach (var customer in customers)
    //{
    //    Console.WriteLine(
    //        $"Customer {customer.FullName} " +
    //        $"has ID {customer.CustomerID} " +
    //        $"and lives in {customer.City}");
    //}



    //sqlReader.Close();
    #endregion
    //var newCustomer = new Customer
    //{
    //    CustomerID = "MO",
    //    ContactName = "Mohammed Dahir",
    //    City = "Birmingham",
    //    CompanyName = "Sparta Global"
    //};

    //string sqlUpdateString = $"UPDATE CUSTOMERS " +
    //    $"SET City = 'Berlin' " +
    //    $"WHERE CustomerID = 'MO'";



    //int updated = 0;
    //using (var updateCommand = new SqlCommand(sqlUpdateString, connection))
    //{
    //    updated = updateCommand.ExecuteNonQuery();
    //}

    string sqlDeleteString = $"DELETE CUSTOMERS " +
        $"DELETE CUSTOMER = 'MO' ";

    int deleted = 0;
    using (var deleteCommand = new SqlCommand(sqlDeleteString, connection))
    {
        deleted = deleteCommand.ExecuteNonQuery();
    }

}