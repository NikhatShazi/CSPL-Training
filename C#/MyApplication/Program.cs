// See https://aka.ms/new-console-template for more information
//
//Console.WriteLine("Hello, World!");
  using System;

  namespace MyApplication
  {
    class Program
    {
      static void Main(string[] args)
      {
        int myInt = 10;
        double myDouble = 5.25;
        bool boolOne = true;
        bool boolZero = false;


        Console.WriteLine(Convert.ToString(myInt));    // Convert int to string
        Console.WriteLine(Convert.ToDouble(myInt));    // Convert int to double
        Console.WriteLine(Convert.ToInt32(myDouble));  // Convert double to int
        Console.WriteLine(Convert.ToString(boolOne));   // Convert bool to string
        Console.WriteLine(Convert.ToString(boolZero));   // Convert bool to string
        }
    }
  }