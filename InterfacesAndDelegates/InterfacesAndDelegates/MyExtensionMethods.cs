using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndDelegates
{
  static class MyExtensionMethods
  {
    // Extension Method
    public static void Print<T>(this IEnumerable<T>list)
    {
      Console.WriteLine("*******************************************************");
      foreach (T element in list)
      {
        Console.WriteLine(element);
      }
      Console.WriteLine("*******************************************************");

    }
  }
}
