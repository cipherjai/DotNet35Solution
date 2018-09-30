using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3FeaturesConApp
{
  // Step I Class has to be Static
  public static class StringFunctions
  {
    // Step II The first argument of the method can be extended by using the keyword 'this'
    public static string Mahesh(this string value)
    {
      char[] ch = value.ToCharArray();
      StringBuilder sb = new StringBuilder();
      for (int i = ch.Length - 1; i <= 0; i--)
      {
        sb.Append(ch[i]);
      }
      return sb.ToString();
    }
  }
}
