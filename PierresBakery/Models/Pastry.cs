using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryCost { get; set; }
    public static int PastryOrder(int pastryOrder)
    { 
      int PastryCost = 2;
      int PastrySubTotal = 0;
      // int Discount = 2;
      if (pastryOrder == 1)
      {
        PastrySubTotal = (pastryOrder * PastryCost);
      }
      return PastrySubTotal;
    }
  }
} 