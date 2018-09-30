using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToSQLConApp
{

  [Table(Name = "Categories")]
  class Category
  {
    [Column(IsPrimaryKey = true)]
    public int CategoryID { get; set; }
    [Column]
    public string CategoryName { get; set; }
    [Column]
    public string Description { get; set; }
  }
}
