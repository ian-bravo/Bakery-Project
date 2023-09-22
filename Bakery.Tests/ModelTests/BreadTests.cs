using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void LoafCalculator_CalculatesOfEnteredLoaves_NumberOfLoaves()
    {
      string userInputForNumberOfLoaves = "1";
      int result = Bread.LoafCalculator(userInputForNumberOfLoaves);
      Assert.AreEqual(1, result);
    }
  }
}