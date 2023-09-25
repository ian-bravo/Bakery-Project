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

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread ("4");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetUserInputBread_ReturnUserInputBread_String()
    {
      string userInputBreadNumber = "4";
      Bread newBread = new Bread(userInputBreadNumber);
      string result = newBread.UserInputBreadNumber;
      Assert.AreEqual(userInputBreadNumber, result);
    }
  }
}