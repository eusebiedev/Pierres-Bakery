using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int LoafCost { get; set; }
    public static int BreadOrder(int loafOrder)
    { 
      int LoafCost = 5;
      int SubTotal = 0;
      // int Discount = 0;
      if (loafOrder  == 1)
      {
        SubTotal = (loafOrder * LoafCost);
      }
      else if (loafOrder == 2)
        SubTotal = (loafOrder * LoafCost);
      
      return SubTotal;
    }
  }
}
