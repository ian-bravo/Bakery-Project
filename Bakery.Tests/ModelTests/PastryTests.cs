using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryCalculator_CalculatesTheEnteredPastries_NumberOfPastries()
    {
      string userInputForNumberOfPastries = "6";
      double result = Pastry.PastryCalculator(userInputForNumberOfPastries);
      Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void PastryCalculator_CalculatesPastryCostWithDiscount_FinalCostOfPastries()
    {
      double numberOfPastries = 7;
      double finalPricePastry = Pastry.PastryCalculator(numberOfPastries);
      Assert.AreEqual(12, finalPricePastry);
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry ("4");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  }
}