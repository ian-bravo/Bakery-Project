using System;

namespace Bakery.Models
{
  public class Bread
  {
    public static double LoavesRequiredForFreebie = 3; 
    public static double PriceOfOneLoaf = 5;

    public Bread()
    {
      
    }
    public static double LoafCalculator(string userEnteredNumberOfLoaves)
    {
      double returnsStringAsDouble = double.Parse(userEnteredNumberOfLoaves);
      return returnsStringAsDouble;
    }

    public static double LoafCalculator(double userEnterAsDouble)
    {
      double amountOfLoavesToBeCharged = userEnterAsDouble - Math.Floor(userEnterAsDouble/LoavesRequiredForFreebie);
      double finalCostOfBread = amountOfLoavesToBeCharged * PriceOfOneLoaf;
      return finalCostOfBread;
    }
  }
}