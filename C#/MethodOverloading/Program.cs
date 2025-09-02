// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace MyApplication
{
  class Program
  {
    static int PlusMethod(int x, int y)
    {
      return x + y;
    }

    static double PlusMethod(double x, double y)
    {
      return x + y;
    }
    
    static string PlusMethod(string x, string y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      int myNum1 = PlusMethod(8, 5);
      double myNum2 = PlusMethod(4.3, 6.26);
      string myNum3 = PlusMethod("Nikhat ", "Shazi");
      
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
      Console.WriteLine("string: " + myNum3);
      
    }  
  }
}
