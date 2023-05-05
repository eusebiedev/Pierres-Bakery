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
      int Discount = 2;
      if (pastryOrder == 1)
      {
        PastrySubTotal = (pastryOrder * PastryCost);
      }
      else if (pastryOrder == 2)
      {
        PastrySubTotal = (pastryOrder * PastryCost);
      }
      else if (pastryOrder == 3)
      {
        PastrySubTotal = (pastryOrder * PastryCost);
      }
      else if (pastryOrder == 4)
      {
        PastrySubTotal = (pastryOrder * PastryCost) - (Discount);
      }
      else if (pastryOrder == 5)
      {
        PastrySubTotal = (pastryOrder * PastryCost) - (Discount);
      }

      return PastrySubTotal;
    }
  }
} 