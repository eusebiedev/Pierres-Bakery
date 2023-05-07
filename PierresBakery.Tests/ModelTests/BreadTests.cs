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
      Bread newBread = new Bread();
      int loafOrder = 1;
      Assert.AreEqual(5, Bread.BreadOrder(loafOrder));
    }

    [TestMethod]
    public void BreadOrder_TotalForTwoBread_LoafCost()
    { 
      Bread newBread = new Bread();
      int loafOrder = 2;
      Assert.AreEqual(10, Bread.BreadOrder(loafOrder));
    }

    [TestMethod]
    public void BreadOrder_TotalForThreeBread_LoafCost()
    { 
      Bread newBread = new Bread();
      int loafOrder = 3;
      Assert.AreEqual(10, Bread.BreadOrder(loafOrder));
    }

    [TestMethod]
    public void BreadOrder_TotalForFourBread_LoafCost()
    { 
      Bread newBread = new Bread();
      int loafOrder = 4;
      Assert.AreEqual(15, Bread.BreadOrder(loafOrder));
    }

    [TestMethod]
    public void BreadOrder_TotalForFiveBread_LoafCost()
    {
      Bread newBread = new Bread();
      int loafOrder = 5;
      Assert.AreEqual(20, Bread.BreadOrder(loafOrder));
    }

    [TestMethod]
    public void BreadOrder_TotalForSixBread_LoafCost()
    {
      Bread newBread = new Bread();
      int loafOrder = 6;
      Assert.AreEqual(20, Bread.BreadOrder(loafOrder));
    }

    [TestMethod]
    public void BreadOrder_TotalForSevenBread_LoafCost()
    {
      Bread newBread = new Bread();
      int loafOrder = 7;
      Assert.AreEqual(25, Bread.BreadOrder(loafOrder));
    }
  }
}