using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public static double PastriesRequiredForFreebie = 4;
    public static double PriceOfOnePastry = 1;
    public static double PastryCalculator(string userEnteredNumberOfPastries)
    {
      double returnsStringAsDouble = double.Parse(userEnteredNumberOfPastries);
      return returnsStringAsDouble;
    }

  }
}