using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Bread testBread = new Bread();
      Console.WriteLine(testBread);
      Pastry testPastry = new Pastry();
      Console.WriteLine(testPastry);
    }
  }
}