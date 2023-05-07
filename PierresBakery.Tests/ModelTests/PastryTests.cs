using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceofPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryOrder_TotalForOnePastry_PastryCost()
    {
      Pastry newPastry = new Pastry();
      int pastryOrder = 1;
      Assert.AreEqual(2, Pastry.PastryOrder(pastryOrder));
    }
    
    [TestMethod]
    public void PastryOrder_TotalForTwoPastry_PastryCost()
    {
      Pastry newPastry = new Pastry();
      int pastryOrder = 2;
      Assert.AreEqual(4, Pastry.PastryOrder(pastryOrder));
    }

    [TestMethod]
    public void PastryOrder_TotalForThreePastry_PastryCost()
    {
      Pastry newPastry = new Pastry();
      int pastryOrder = 3;
      Assert.AreEqual(6, Pastry.PastryOrder(pastryOrder));
    }

    [TestMethod]
    public void PastryOrder_TotalForFourPastryDiscount_PastryCost()
    {
      Pastry newPastry = new Pastry();
      int pastryOrder = 4;
      Assert.AreEqual(6, Pastry.PastryOrder(pastryOrder));
    }

    [TestMethod]
    public void PastryOrder_TotalForFivePastryDiscount_PastryCost()
    {
      Pastry newPastry = new Pastry();
      int pastryOrder = 5;
      Assert.AreEqual(8, Pastry.PastryOrder(pastryOrder));
    }

    [TestMethod]
    public void PastryOrder_TotalForSixPastryDiscount_PastryCost()
    {
      Pastry newPastry = new Pastry();
      int pastryOrder = 6;
      Assert.AreEqual(10, Pastry.PastryOrder(pastryOrder));
    }

    [TestMethod]
    public void PastryOrder_TotalForSevenPastryDiscount_PastryCost()
    {
      Pastry newPastry = new Pastry();
      int pastryOrder = 7;
      Assert.AreEqual(12, Pastry.PastryOrder(pastryOrder));
    }

    [TestMethod]
    public void PastryOrder_TotalForEightPastryDiscount_PastryCost()
    {
      Pastry newPastry = new Pastry();
      int pastryOrder = 8;
      Assert.AreEqual(12, Pastry.PastryOrder(pastryOrder));
    }

    [TestMethod]
    public void PastryOrder_TotalForAnyPastry_PastryCost()
    {
      Pastry newPastry = new Pastry();
      int pastryOrder = 0; //final test for >=4 ?
      Assert.AreEqual(0, Pastry.PastryOrder(pastryOrder));
    }
  }
}