using System;

namespace Bakery.Models
{
  public class Bread
  {
    // public double LoavesRequiredForFreebie = 3;
    // public double PriceOfOneLoaf = 5;
    public static double LoavesRequiredForFreebie = 3;
    public static double PriceOfOneLoaf = 5;

    public static double LoafCalculator(string userEnteredNumberOfLoaves)
    {
      double returnsStringAsDouble = double.Parse(userEnteredNumberOfLoaves);
      return returnsStringAsDouble;
    }

    public static double LoafCalculator(double userEnterAsDouble)
    {
      double amountOfLoavesToBeCharged = userEnterAsDouble - Math.Round(userEnterAsDouble/LoavesRequiredForFreebie);
      //5 = 7 - (7/3)
      double finalCostOfBread = amountOfLoavesToBeCharged * PriceOfOneLoaf;
      return finalCostOfBread;
      // double priceOfLoaves = userEnterAsDouble * 5;
      // return priceOfLoaves;
    }
  }
}