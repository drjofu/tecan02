using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
  class Account
  {
    // Fields
    private string name;
    private int number;
    //private double balance;

    // Properties

    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public int Number
    {
      get { return number; }
    }

    public double Balance { get; /*private set;*/ } = 0;

    private static int counter = 1000;
    public static int Counter
    {
      get { return counter; }
    }

    // ctor
    public Account()
    {
      this.name = "undefined";
      number = counter++;
      Balance = 1;
    }

    public Account(string name, double balance)
    {
      this.name = name;
      this.number = counter++;
      this.Balance = balance;
    }

    static Account()
    {

    }

    public override string ToString()
    {
      //this.Balance = 123;
      return $"Account {number} of {name}, balance: {Balance}";
    }
  }
}
