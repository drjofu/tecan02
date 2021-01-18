using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{

  // Singleton-Pattern
  class SingletonObject
  {
    private SingletonObject()
    {

    }

    private static SingletonObject theObject;

    public static SingletonObject GetInstance()
    {
      if (theObject == null) theObject = new SingletonObject();
      return theObject;
    }
  }
}
