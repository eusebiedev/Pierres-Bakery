using System;
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
      int Discount = 5;
      if (loafOrder  == 1)
      {
        SubTotal = (loafOrder * LoafCost);
      }
      else if (loafOrder == 2)
      {
        SubTotal = (loafOrder * LoafCost);
      }
      else if (loafOrder == 3)
      {
        SubTotal = (loafOrder * LoafCost) - (Discount);
      }
      else if (loafOrder == 4)
      {
        SubTotal = (loafOrder * LoafCost) - (Discount);
      }
      else if (loafOrder == 5)
      {
        SubTotal = (loafOrder * LoafCost) - (Discount);
      }
      else if (loafOrder == 6)
      { 
      SubTotal = (loafOrder * LoafCost) - (Discount * 2);
      }
      else if (loafOrder == 7)
      { 
        SubTotal = (loafOrder * LoafCost) - (Discount * 2);
      }
      else if (loafOrder >= 3)
      {
        SubTotal = (loafOrder * LoafCost) - (Discount * 2);
      }
      else
      {
        SubTotal = 0; //Not sure what to close on "else"
      }
      return SubTotal;
    } 
  }
}

