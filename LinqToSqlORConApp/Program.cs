using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqlORConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      NorthDataContext context = new NorthDataContext();

      var result = (from c in context.Customers
                    where c.City == "London"
                    select new { c.CustomerID, c.CompanyName, c.ContactName, c.City, c.Country }).ToList();

      foreach (var item in result)
      {
        Console.WriteLine(item);
      }

      var result2 = context.CustOrderHist("ALFKI");
      foreach (var item in result2)
      {
        Console.WriteLine($"ProdName: {item.ProductName} and Total: {item.Total}");
      }

      Customer customer = new Customer { CustomerID = "AAAA", CompanyName = "Dell", ContactName = "Jai", City = "Mumbai", Country = "India" };
      context.Customers.InsertOnSubmit(customer);
      try
      {
        context.SubmitChanges();
        Console.WriteLine("New Customer Added");
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }

      #region Change and concurrency
      //var cust = context.Customers.Where(c => c.CustomerID == "AAAA").FirstOrDefault();
      //Console.WriteLine($"CustomerID: {cust.CustomerID} and city: {cust.City}");
      //cust.City = "Mumbai";
      //Console.ReadKey(true);
      //try
      //{
      //  context.SubmitChanges();
      //  Console.WriteLine("Successful Update and Submitted");

      //}
      //// Exception ChangeConflictException
      //catch(ChangeConflictException ex)
      //{
      //  Console.WriteLine(ex.Message);
      //  context.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges);
      //  context.SubmitChanges();
      //  Console.WriteLine("Rec updated from ChangeConflictException");
      //}
      //catch(Exception ex)
      //{
      //  Console.WriteLine(ex.ToString());
      //} 
      #endregion

      #region Delete Duplicates
      var cust = context.Customers.Where(c => c.CustomerID == "AAAA").FirstOrDefault();
      context.Customers.DeleteOnSubmit(cust);
      try
      {
        context.SubmitChanges();
        Console.WriteLine("Delete Submit Successful");
      }
      catch (Exception ex)
      {

        Console.WriteLine(ex.ToString());
      }
      #endregion

    }
  }
}
