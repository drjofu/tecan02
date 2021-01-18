using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndDelegates
{
  class Account : IComparable<Account>
  {
    // prop
    public int Number { get; set; }
    public string Name { get; set; }
    public double Balance { get; set; }

    public int CompareTo(Account other)
    {
      Account acc1 = this;
      Account acc2 = other;
      return -acc1.Name.CompareTo(acc2.Name);
      
    }

    public override string ToString()
    {
      return $"Account {Number} of {Name}, Balance: {Balance}";
    }



    // propfull
    //private int myVar;

    //public int MyProperty
    //{
    //  get { return myVar; }
    //  set { myVar = value; }
    //}

  }
}
