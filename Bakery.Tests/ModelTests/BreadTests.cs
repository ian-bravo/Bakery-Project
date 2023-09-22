using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void LoafCalculator_CalculatesTheEnteredLoaves_NumberOfLoaves()
    {
      string userInputForNumberOfLoaves = "1";
      int result = Bread.LoafCalculator(userInputForNumberOfLoaves);
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void LoafCalculator_CalculatesLoafCostNoDiscount_CostOfLoaves()
    {
      int numberOfLoaves = 2;
      int priceOfLoaves = Bread.LoafCalculator(numberOfLoaves);
      Assert.AreEqual(10, priceOfLoaves);
    }
  }
}