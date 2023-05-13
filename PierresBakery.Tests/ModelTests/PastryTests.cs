using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(0);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void CalculateTotal_TotalFor1Pastry_PastryCost()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(2, newPastry.CalculateTotal());
    }

    [TestMethod]
    public void CalculateTotal_TotalFor2Pastry_PastryCost()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(4, newPastry.CalculateTotal());
    }
    
    [TestMethod]
    public void CalculateTotal_TotalFor3Pastry_PastryCost()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(6, newPastry.CalculateTotal());
    }

    [TestMethod]
    public void CalculateTotal_TotalFor4Pastry_PastryCost()
    {
      Pastry newPastry = new Pastry(4);
      Assert.AreEqual(6, newPastry.CalculateTotal());
    }

    [TestMethod]
    public void CalculateTotal_TotalFor5Pastry_PastryCost()
    {
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(8, newPastry.CalculateTotal());
    }
    
    [TestMethod]
    public void CalculateTotal_TotalFor6Pastry_PastryCost()
    {
      Pastry newPastry = new Pastry(6);
      Assert.AreEqual(10, newPastry.CalculateTotal());
    }

    [TestMethod]
    public void CalculateTotal_TotalFor7Pastry_PastryCost()
    {
      Pastry newPastry = new Pastry(7);
      Assert.AreEqual(12, newPastry.CalculateTotal());
    }

    [TestMethod]
    public void CalculateTotal_TotalFor8Pastry_PastryCost()
    {
      Pastry newPastry = new Pastry(8);
      Assert.AreEqual(12, newPastry.CalculateTotal());
    }
  }
}