using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3FeaturesConApp
{
  public class Employee
  {
    public int EmpNo { get; set; }
    public string EmpName { get; set; }
    public decimal Salary { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
      return $"EmpNo: {EmpNo}, EmpName: {EmpName}, Salary: {Salary} and Age: {Age}";
    }
  }
}
