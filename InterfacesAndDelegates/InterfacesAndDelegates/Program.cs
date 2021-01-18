using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfacesAndDelegates
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Account> accounts = new List<Account>();
      accounts.Add(new Account() { Number = 1000, Name = "Uncle Scrooge", Balance = 99999999 }); // object initializers
      accounts.Add(new Account() { Number = 1034, Name = "Donald Duck", Balance = -2345 });
      accounts.Add(new Account() { Number = 646, Name = "Micky Mouse", Balance = 5353 });
      accounts.Add(new Account() { Number = 2222, Name = "Tick", Balance = 100.5 });
      accounts.Add(new Account() { Number = 4444, Name = "Trick", Balance = 100.8 });
      accounts.Add(new Account() { Number = 3664, Name = "Track", Balance = 100.7 });

      MyExtensionMethods.Print<Account>(accounts);
      accounts.Print();

      new int[] { 123, 245, 1, 62, 64, 43, 643 }.Print();
      "Hello".Print();

      accounts.Sort();

      // accounts.Sort(IComparer<>) as exercise

      accounts.Print();

      //Comparison<Account> callBackMethod = new Comparison<Account>(CompareByBalance);
      ////callBackMethode.Invoke()
      //accounts.Sort(callBackMethod);
      //accounts.Print();

      accounts.Sort(CompareByName);
      //accounts.Sort(new Comparison<Account>(CompareByName));

      accounts.Print();

      // anonymous Function (C# 2.0)
      accounts.Sort(delegate (Account acc1, Account  acc2)
      {
        return -acc1.Number.CompareTo(acc2.Number);
      });

      accounts.Print();

      // Lambda-Expression (C# 3.0)
      accounts.Sort((acc1, acc2) =>
      {
        return acc1.Name.CompareTo(acc2.Name);
      });
      accounts.Print();

      accounts.Sort((acc1, acc2) => acc1.Balance.CompareTo(acc2.Balance));
      accounts.Print();


      Account found = accounts.Find(acc => acc.Name == "Micky Mouse");
      Console.WriteLine("Found: " + found);

      Console.WriteLine("Account name with T");
      accounts.FindAll(acc => acc.Name.StartsWith("T")).Print();


      accounts.Where(acc => acc.Name.StartsWith("T"))
        .OrderBy(acc => acc.Balance)
        .Print();

      Console.ReadLine();
    }

    static int CompareByName(Account acc1, Account acc2)
    {
      return acc1.Name.CompareTo(acc2.Name);
    }
    static int CompareByBalance(Account acc1, Account acc2)
    {
      return acc1.Balance.CompareTo(acc2.Balance);
    }
  }
}
