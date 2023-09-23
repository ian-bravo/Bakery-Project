using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      double data = (7/3);
      Console.WriteLine($"cost of bread {Bread.LoafCalculator(3)}");
      Console.WriteLine(Math.Round(data));
      
    }
  }
}