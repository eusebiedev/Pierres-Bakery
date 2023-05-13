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
      Bread newBread = new Bread(0);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void CalculateTotal_TotalFor1Loaf_LoafCost()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(5, newBread.CalculateTotal());
    }

    [TestMethod]
    public void CalculateTotal_TotalFor2Loaves_LoafCost()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(10, newBread.CalculateTotal());
    }

    [TestMethod]
    public void CalculateTotal_TotalFor3Loaves_LoafCost()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(10, newBread.CalculateTotal());
    }

    [TestMethod]
    public void CalculateTotal_TotalFor4_LoafCost()
    {
      Bread newBread = new Bread(4);
      Assert.AreEqual(15, newBread.CalculateTotal());
    }

    [TestMethod]
    public void CalculateTotal_TotalFor5Loaves_LoafCost()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(20, newBread.CalculateTotal());
    }
    
    [TestMethod]
    public void CalculateTotal_TotalFor6Loaves_LoafCost()
    {
      Bread newBread = new Bread(6);
      Assert.AreEqual(20, newBread.CalculateTotal());
    }

    [TestMethod]
    public void CalculateTotal_TotalFor7Loaves_LoafCost()
    {
      Bread newBread = new Bread(7);
      Assert.AreEqual(25, newBread.CalculateTotal());
    }

    [TestMethod]
    public void CalculateTotal_TotalFor8Loaves_LoafCost()
    {
      Bread newBread = new Bread(8);
      Assert.AreEqual(30, newBread.CalculateTotal());
    }

    [TestMethod]
    public void CalculateTotal_TotalFor9Loaves_LoafCost()
    {
      Bread newBread = new Bread(9);
      Assert.AreEqual(30, newBread.CalculateTotal());
    }
    
    [TestMethod]
    public void CalculateTotal_TotalFor10Loaves_LoafCost()
    {
      Bread newBread = new Bread(10);
      Assert.AreEqual(35, newBread.CalculateTotal());
    }
    
    [TestMethod]
    public void CalculateTotal_TotalFor15Loaves_LoafCost()
    {
      Bread newBread = new Bread(15);
      Assert.AreEqual(50, newBread.CalculateTotal());
    }
  }
}