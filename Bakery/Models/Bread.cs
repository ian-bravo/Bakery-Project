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
  }
}