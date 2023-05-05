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
    public void BreadOrder_TotalForOneBread_Bread()
    {
      Bread newBread = new Bread();
      int loafOrder = 1;
      Assert.AreEqual(5, Bread.TotalBreadCost(loafOrder));
    }

  }
}