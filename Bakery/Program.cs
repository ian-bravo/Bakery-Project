using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("`'~-,._.,-~'``'~`-,._.,-~'``'~-,._.,-~'`");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("---------------------------");
      Console.WriteLine("We serve loaves of bread for $5 each with a special offer of 'buy 2 get 1 free'! What a steal, right?");
      Console.WriteLine("Pastries are $2 each with a special offer of 'buy 3, get 1 free', also a steal!");
      Console.WriteLine("---------------------------");
      Console.WriteLine("How many loaves of bread would you like to purchase?");
      string stringUserInputBread = Console.ReadLine();
      Console.WriteLine("How many pastries would you like to purchase?");
      string stringUserInputPastry = Console.ReadLine();
      double numberOfBreadResult = Bread.LoafCalculator(stringUserInputBread);
      double breadCost = Bread.LoafCalculator(numberOfBreadResult);
      Console.WriteLine($"The total cost for the {stringUserInputBread} loaves is: " + breadCost + " dollars.");
      double numberOfPastryResult = Pastry.PastryCalculator(stringUserInputPastry);
      double pastryCost = Pastry.PastryCalculator(numberOfPastryResult);
      Console.WriteLine($"The total cost for the {stringUserInputPastry} pastries is: " + pastryCost + " dollars.");
      double totalCost = breadCost + pastryCost;
      Console.WriteLine("The total for your baked goods is: " + totalCost + "dollars.");
    }
  }
}