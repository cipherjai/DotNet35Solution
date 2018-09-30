using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToSQLConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      
      DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["NorthConnection"].ConnectionString);
      Table<Category> categoryTable = dataContext.GetTable<Category>();
      Table<Product> productTable = dataContext.GetTable<Product>();

      dataContext.Log = Console.Out;

      #region Get All the categories
      // Anonymous Type or Get the Full concrete
      // var result = categoryTable.Select(c => new { c.CategoryID, c.CategoryName, c.Description }).ToList();
      #endregion

      var result = categoryTable.Where(c => c.CategoryID == 1).Select(c => new { c.CategoryID, c.CategoryName, c.Description });


      #region Get All the products
      //var resultP = categoryTable.Where(c => c.CategoryID == 1).Select(c => new { c.CategoryID, c.CategoryName, c.Description });

      //var resultP = (from p in productTable sele)

      //var result = (from p in productTable
      //              join c in categoryTable
      //              on p.CategoryID equals c.CategoryID
      //              select new { p.ProductId, p.ProductName, c.CategoryName)}.ToList();

      //var resultsP = productTable.Join(categoryTable, p => p.CategoryID, c => c.CategoryID, (p,c)) => new {p.ProductId, p.ProductName, c.CategoryName}).ToList();

      var result2 = productTable.Join(categoryTable, p => p.CategoryID, c => c.CategoryID, (p, c) => new { p.ProductID, p.ProductName, p.UnitPrice, c.CategoryName }).Where(p => p.UnitPrice > 20).ToList();



      #endregion

      //var resultGroupBy = (from p in productTable
      //                     group p by p.CategoryID into grp
      //                     select new { catID = grp.Key, NoOfProds = grp.Count()}).ToList();

      //Console.WriteLine(result.GetType());
      //int ctr = 0;
      //foreach(var item in result)
      //{
      //  Console.WriteLine($"{ctr++} -- {item.Key} ----{item.Count()}");
      //}

      //var resultGroupBy1 = (from p in productTable
      //                      join c in categoryTable
      //                      on p.CategoryID equals c.CategoryID
      //                      group p by c.CategoryName).ToList();

      //foreach (var item in resultGroupBy1)
      //{
      //  // writtem class instead of the function -- need to correct it 

      //  Console.WriteLine($"{ctr++} -- {item.Key} -- {item.Count()}");
      //}


      // max unit price
      //var resultGroupBy2 = (from p in productTable
      //                      select p.UnitPrice).Max();

      //var result_mostExpensiveProduct = (from p in productTable
      //                                   where p.UnitPrice == ((from a in productTable select a.UnitPrice).Max())
      //                                   select new { p.ProductName, p.UnitPrice }).FirstOrDefault();
      //Console.WriteLine(result



      //Console.WriteLine();
      //foreach(var pp in items)
      //{
      //  Console.WriteLine();
      //}

      //var result_using_thikKey = (from p in productTable
      //              select new { ProdName = p.ProductName, CatName = p.Cat }).ToList();
    }
  }
}
