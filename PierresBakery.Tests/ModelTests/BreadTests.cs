using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceofBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadOrder_TotalForOneBread_LoafCost()
    {
      Assert.AreEqual(5, Bread.BreadOrder(1));
    }

    [TestMethod]
    public void BreadOrder_TotalForTwoBread_LoafCost()
    {
      Assert.AreEqual(10, Bread.BreadOrder(2));
    }

    [TestMethod]
    public void BreadOrder_TotalForThreeBread_LoafCost()
    {
      Assert.AreEqual(10, Bread.BreadOrder(3));
    }

    [TestMethod]
    public void BreadOrder_TotalForFourBread_LoafCost()
    {
      Assert.AreEqual(15, Bread.BreadOrder(4));
    }

    [TestMethod]
    public void BreadOrder_TotalForFiveBread_LoafCost()
    {
      Assert.AreEqual(20, Bread.BreadOrder(5));
    }

    [TestMethod]
    public void BreadOrder_TotalForSixBread_LoafCost()
    {
      Assert.AreEqual(20, Bread.BreadOrder(6));
    }

    [TestMethod]
    public void BreadOrder_TotalForSevenBread_LoafCost()
    {
      Assert.AreEqual(25, Bread.BreadOrder(7));
    }
  }
}