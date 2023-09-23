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
      double result = Bread.LoafCalculator(userInputForNumberOfLoaves);
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void LoafCalculator_CalculatesLoafCostNoDiscount_CostOfLoaves()
    {
      double numberOfLoaves = 2;
      double numberOfLoavesEntered = Bread.LoafCalculator(numberOfLoaves);
      Assert.AreEqual(10, numberOfLoavesEntered);
    }

    [TestMethod]
    public void LoafCalculator_CalculatesLoafCostWithDiscount_FinalCostOfLoaves()
    {
      double numberOfLoaves = 7;
      double finalPrice = Bread.LoafCalculator(numberOfLoaves);
      Assert.AreEqual(25, finalPrice);
    }
  }
}