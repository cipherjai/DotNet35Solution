using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3FeaturesConApp
{

  public delegate bool FilterDel<S>(S value);
  public static class Utilities
  {
    public static List<Employee> Filter(this List<Employee> sourceList)
    {
      List<Employee> tempList = new List<Employee>();
      foreach (Employee emp in sourceList)
      {
        if (emp.Salary >= 3000)
        {
          tempList.Add(emp);
        }
      }
      return tempList;
    }

    public static List<T> Filter<T>(this List<T> sourceList, FilterDel<T> del)
    {
      List<T> tempList = new List<T>();
      foreach (T item in sourceList)
      {
        if (del(item))
        {
          tempList.Add(item);
        }
      }
      return tempList;
    }
  }
}
