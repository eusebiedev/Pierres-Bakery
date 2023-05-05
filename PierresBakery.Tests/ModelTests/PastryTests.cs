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
      Assert.AreEqual(2, Pastry.PastryOrder(1));
    }
    
    [TestMethod]
    public void PastryOrder_TotalForTwoPastry_PastryCost()
    {
      Assert.AreEqual(4, Pastry.PastryOrder(2));
    }

    [TestMethod]
    public void PastryOrder_TotalForThreePastry_PastryCost()
    {
      Assert.AreEqual(6, Pastry.PastryOrder(3));
    }

    [TestMethod]
    public void PastryOrder_TotalForFourPastryDiscount_PastryCost()
    {
      Assert.AreEqual(6, Pastry.PastryOrder(4));
    }

    [TestMethod]
    public void PastryOrder_TotalForFivePastryDiscount_PastryCost()
    {
      Assert.AreEqual(8, Pastry.PastryOrder(5));
    }

    [TestMethod]
    public void PastryOrder_TotalForSixPastryDiscount_PastryCost()
    {
      Assert.AreEqual(10, Pastry.PastryOrder(6));
    }

    [TestMethod]
    public void PastryOrder_TotalForSevenPastryDiscount_PastryCost()
    {
      Assert.AreEqual(12, Pastry.PastryOrder(7));
    }



  }
}