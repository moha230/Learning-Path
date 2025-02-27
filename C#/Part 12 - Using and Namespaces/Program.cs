using System;
using OuterNamespace;
using OuterNamespace.InnerNamespace;
//directives 


namespace OuterNamespace
{
  class OuterClass
  {
    public void OuterMethod()
    {
      Console.WriteLine("This is OuterNamespace");
    }
  }
  namespace InnerNamespace
  {
    class InnerClass 
    {
      public void InnerMethod()
      {
        Console.WriteLine("This is InnerNamespace");
      }
    }
  }
}


class Program 
{
  static void Main(string[] args) 
  {
    //creating an instance of the outerClass and the object is stored in the variable outer
    OuterClass outer = new OuterClass();

    //calling the outermethod the outer vraiable holds the instance of the outerclass 
    outer.OuterMethod();


    InnerClass inner = new InnerClass();
    inner.InnerMethod();

  }
}