using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3FeaturesConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      #region Old Object initialization
      //Employee emp = new Employee();
      //emp.EmpNo = 101;
      //emp.EmpName = "Tintin";
      //emp.Salary = 4000.78m;
      //emp.Age = 21;
      //Console.WriteLine(emp); 
      #endregion

      #region New way of Object initialization
      //Employee emp = new Employee { EmpNo = 101, EmpName = "Donald", Salary = 3000.00m, Age = 17 };
      //Console.WriteLine(emp);
      #endregion

      #region Old Array and Collection Initialization
      //int[] intArr = new int[] { 10, 29, 21 }; 
      //List<Employee> empList = new List<Employee>();
      //empList.Add(new Employee { EmpNo = 101, EmpName = "Donald", Salary = 3000.00m, Age = 17 });
      #endregion

      #region New Collection Initialization
      List<Employee> empList = new List<Employee>()
      {
      new Employee() { EmpNo = 17, EmpName = "Jerry", Salary = 2102, Age = 16 },
      new Employee() { EmpNo = 27, EmpName = "Tom", Salary = 3100, Age = 19 },
      new Employee() { EmpNo = 21, EmpName = "Snowy", Salary = 5000, Age = 41 },
      new Employee() { EmpNo = 12, EmpName = "Tintin", Salary = 1900, Age = 17 },
      new Employee() { EmpNo = 19, EmpName = "Donald", Salary = 8000, Age = 25 },
      new Employee() { EmpNo = 20, EmpName = "Mickey", Salary = 2700, Age = 18 },
      new Employee() { EmpNo = 41, EmpName = "Mini", Salary = 7500, Age = 28 },
      new Employee() { EmpNo = 13, EmpName = "Spiderman", Salary = 9000, Age = 34 },
      new Employee() { EmpNo = 52, EmpName = "Superman", Salary = 5000, Age = 29 },
      new Employee() { EmpNo = 10, EmpName = "Batman", Salary = 4900, Age = 33 },
      new Employee() { EmpNo = 22, EmpName = "Jughead", Salary = 3000, Age = 28 },
      new Employee() { EmpNo = 11, EmpName = "Archie", Salary = 6000, Age = 26 },
      new Employee() { EmpNo = 33, EmpName = "Betty", Salary = 1500, Age = 22 },
      new Employee() { EmpNo = 56, EmpName = "Veronica", Salary = 3700, Age = 21 },
      new Employee() { EmpNo = 63, EmpName = "Reggie", Salary = 4000, Age = 30 },
      new Employee() { EmpNo = 87, EmpName = "Twoface", Salary = 8000, Age = 36 },
      new Employee() { EmpNo = 91, EmpName = "Phantom", Salary = 12000, Age = 29 },
      new Employee() { EmpNo = 81, EmpName = "Joker", Salary = 13000, Age = 39 },
      new Employee() { EmpNo = 96, EmpName = "Haddock", Salary = 7000, Age = 30 },
      new Employee() { EmpNo = 29, EmpName = "Thompson", Salary = 4000, Age = 32 }
      };
      //int ctr = 1;
      //foreach (Employee item in empList)
      //{
      //  Console.WriteLine($"{ctr++} -- {item}");
      //}
      #endregion

      #region Extension Methods
      //string name = "Donald";
      //Console.WriteLine(name);
      //Console.WriteLine(name.ToUpper());
      //Console.WriteLine(StringFunctions.Mahesh(name));
      //Console.WriteLine(name.Mahesh());
      #endregion

      int ctr = 1;

      #region Criteria was give
      //List<Employee> newEmpList = empList.Filter();
      //foreach (Employee item in newEmpList)
      //{
      //  Console.WriteLine($"{ctr++} -- {item}");
      //} 
      #endregion

      #region Criteria not give
      //List<Employee> newEmpList = empList.Filter(GetByAge);
      //foreach (Employee item in newEmpList)
      //{
      //  Console.WriteLine($"{ctr++} -- {item}");
      //}
      #endregion

      #region With Anonymous Methods
      //List<Employee> newEmpList = empList.Filter(
      //                    delegate(Employee e) 
      //                    {
      //                      return e.Age > 27 && e.Salary > 7000;
      //                      //return e.Age > 27;
      //                    });
      //foreach (Employee item in newEmpList)
      //{
      //  Console.WriteLine($"{ctr++} -- {item}");
      //}
      #endregion

      #region With Lambda Expression
      List<Employee> newEmpList = empList.Filter((Employee e) =>
                          {
                            return e.Age > 27 && e.Salary > 7000;
                            //return e.Age > 27;
                          });
      foreach (Employee item in newEmpList)
      {
        Console.WriteLine($"{ctr++} -- {item}");
      }
      #endregion

    }

    static bool GetByAge(Employee emp)
    {
      if (emp.Age > 20)
        return true;
      return false;
    }
  }
}
