using System;

namespace Bakery.Models
{
  public class Bread
  {

    public static int LoafCalculator(string userEnteredNumberOfLoaves)
    {
      int returnsStringAsInt = int.Parse(userEnteredNumberOfLoaves);
      return returnsStringAsInt;
    }

    public static int LoafCalculator(int userEnterAsInt)
    {
      int priceOfLoaves = userEnterAsInt * 5;
      return priceOfLoaves;
    }
  }
}