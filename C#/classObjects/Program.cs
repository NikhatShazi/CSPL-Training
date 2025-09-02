// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace MyApplication
{
  class Car
  {
    string color = "red";
    int milage = 20;
        

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.color);
    
      Console.WriteLine(myObj.milage);
    }

  }
}