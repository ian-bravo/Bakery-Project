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
  }
}