using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 10;
      int y = 3;
      double z = x / y;
      int rest = x % y;

      Console.WriteLine(z);
      Console.WriteLine(rest);

      if (x > 50)
      {
        Console.WriteLine("x is greater 5");
        Console.WriteLine("dito");
      }
      else
      {
        Console.WriteLine("x <= 5");
        Console.WriteLine("and so on...");
      }

      int a = 100;

      while (a < 10)
      {
        Console.WriteLine(a);
        a++;
      }

      Console.WriteLine("***********************************");

      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(i);
      }

      string[] months = { "January", "February", "March" };
      foreach (string month in months)
      {
        Console.WriteLine(month);
      }

      foreach (char c in "Hello")  // IEnumerable
      {
        Console.WriteLine(c);
      }

      string name = "Daisy";
      switch (name)
      {
        case "Micky":
          Console.WriteLine("Mouse");
          break;

        case "Donald":
        case "Louie":
        case "Daisy":
          Console.WriteLine("Duck");
          break;

        default:
          break;
      }

      Console.WriteLine("*************************");
      int s = Sum(10, 20);
      Console.WriteLine(s);

      Print("Hello world");

      Console.ReadLine();
    }

    static int Sum(int a, int b)
    {
      Console.WriteLine("hello from Sum");
      return a + b;
    }

    static void Print(string text)
    {
      Console.WriteLine("Text: " + text);
      double x = 123.456;
      Console.WriteLine("with format: Text is {0}, x= {1:0.0}", text, x);
      Console.WriteLine($"My text is {text} and x has the value {x:0.0}, x²: {x * x }"); // string interpolation (C#6.0)


    }
  }
}
