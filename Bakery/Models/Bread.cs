using System;

namespace Bakery.Models
{
  public class Bread
  {

    public static double LoafCalculator(string userEnteredNumberOfLoaves)
    {
      double returnsStringAsDouble = double.Parse(userEnteredNumberOfLoaves);
      return returnsStringAsDouble;
    }

    public static double LoafCalculator(double userEnterAsDouble)
    {
      double priceOfLoaves = userEnterAsDouble * 5;
      return priceOfLoaves;
    }
  }
}