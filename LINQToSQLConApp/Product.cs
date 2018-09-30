using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToSQLConApp
{
  class Product
  {
    [Column (IsPrimaryKey = true)]
    public int ProductID { get; set; }
    [Column]
    public string ProductName { get; set; }
    [Column]
    public decimal UnitPrice { get; set; }
    [Column]
    public int CategoryID { get; set; }

    EntityRef<Category> _cat;

    [Association(Storage = "_cat", ThisKey = "CategoryID")]

    public Category Cat
    {
      get { return _cat.Entity; }
      set { _cat.Entity = value; }
    }
  }
}
