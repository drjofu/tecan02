//using io = System.IO;

using System;

namespace FirstApp
{
  class Program
  {
    static void Main(string[] args)
    {
      //Example1();

      Account acc1 = new Account();
      Account acc2 = new Account("Uncle Scrooge", 1, 99999999);

      acc1.Name = "Micky Mouse";

      Console.WriteLine(acc1);
      Console.WriteLine(acc2);
      Console.WriteLine(acc2.Name);
      Console.ReadLine();
    }

    private static void Example1()
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

      Console.WriteLine(Sum(3.4, 5.6));

      Console.WriteLine(Sum(10, 4.5));

      Console.WriteLine(Sum2());
      Console.WriteLine(Sum2(1, 2));
      Console.WriteLine(Sum2(1, 2, 3, 4, 5, 6));
      Console.WriteLine(Sum2(0, 1, 2, 3, 4, 5, 6, 7, 8, 9));
      Console.WriteLine(Sum2(new int[] { 13, 45, 65, 7 }));

      Console.WriteLine("f: {0}, xy: {4}", 1, 2, 3, 4, 5, 6);

      Console.WriteLine("*********************************************");

      DoSomething();
      DoSomething("learn C#");
      DoSomething("learn overloads", 15);
      DoSomething(duration: 30);
      DoSomething(duration: 40, what: "learn optional parameters");

      Console.WriteLine("*********************************************");

      DateTime now = DateTime.Now;
      Console.WriteLine(now);
      Console.WriteLine(DateTime.Today);
      Console.WriteLine($"{now:dd.MMMM yyyy}");
      Console.WriteLine($"{now:d}");
      Console.WriteLine($"{now:D}");
      Console.WriteLine($"{now:t}");
      Console.WriteLine($"{now:T}");
      Console.WriteLine($"{now:g}");
      Console.WriteLine($"{now:G}");
      Console.WriteLine(now.ToLongTimeString());
      Console.WriteLine(now.ToUniversalTime().ToUniversalTime().ToUniversalTime().ToUniversalTime().ToLocalTime());

      DateTime dt = DateTime.Parse("3.11.2004");

      TimeSpan diff = dt - now;
      TimeSpan diff2 = now - DateTime.Today;
      Console.WriteLine(now + diff2);
      TimeSpan diff3 = TimeSpan.FromDays(30);
      Console.WriteLine(now + diff3);

      Console.WriteLine();
    }

    static void DoSomething(string what = "nothing", int duration = 10)
    {
      Console.WriteLine($"Do {what} {duration} minutes");

    }

    static int Sum(int a, int b)
    {
      Console.WriteLine("hello from Sum");
      return a + b;
    }

    static double Sum(double a, double b)
    {
      return a + b;
    }

    static void Print(string text)
    {
      Console.WriteLine("Text: " + text);
      double x = 123.456;
      Console.WriteLine("with format: Text is {0}, x= {1:0.0}", text, x);
      Console.WriteLine($"My text is {text} and x has the value {x:0.0}, x²: {x * x }"); // string interpolation (C#6.0)


    }

    static int Sum2(params int[] numbers)
    {
      int sum = 0;
      foreach (int number in numbers)
      {
        sum += number;
      }

      return sum;
    }
  }
}
