using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public static double PastriesRequiredForFreebie = 4;
    public static double PriceOfOnePastry = 2;
    public static double PastryCalculator(string userEnteredNumberOfPastries)
    {
      double returnsStringAsDouble = double.Parse(userEnteredNumberOfPastries);
      return returnsStringAsDouble;
    }

    public static double PastryCalculator(double userEnterAsDoublePastry)
    {
      double amountOfPastriesToBeCharged = userEnterAsDoublePastry - Math.Floor(userEnterAsDoublePastry/PastriesRequiredForFreebie);
      //6 = 7 - (7/4)
      double finalCostOfPastry = amountOfPastriesToBeCharged * PriceOfOnePastry;
      //12
      return finalCostOfPastry;
    }

  }
}