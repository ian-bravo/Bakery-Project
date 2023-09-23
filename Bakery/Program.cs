using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      double data = (2/3);
      Console.WriteLine($"cost of bread {Bread.LoafCalculator(2)}");
      Console.WriteLine(Math.Floor(data));
      Console.WriteLine(Math.Round(data));
      
    }
  }
}