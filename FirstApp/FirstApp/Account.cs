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
    private double balance;

    // Properties

    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    // ctor
    public Account()
    {
      this.name = "undefined";
      number = -999;
    }

    public Account(string name, int number, double balance)
    {
      this.name = name;
      this.number = number;
      this.balance = balance;
    }

    public override string ToString()
    {
      return $"Account {number} of {name}, balance: {balance}";
    }
  }
}
