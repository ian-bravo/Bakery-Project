using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public static double PastriesRequiredForFreebie = 4;
    public static double PriceOfOnePastry = 2;
    public string UserInputPastryNumber { get; }

    public Pastry(string userInputPastryNumber)
    {
      
    }
    public static double PastryCalculator(string userEnteredNumberOfPastries)
    {
      double returnsStringAsDouble = double.Parse(userEnteredNumberOfPastries);
      return returnsStringAsDouble;
    }

    public static double PastryCalculator(double userEnterAsDoublePastry)
    {
      double amountOfPastriesToBeCharged = userEnterAsDoublePastry - Math.Floor(userEnterAsDoublePastry/PastriesRequiredForFreebie);
      double finalCostOfPastry = amountOfPastriesToBeCharged * PriceOfOnePastry;
      return finalCostOfPastry;
    }

  }
}