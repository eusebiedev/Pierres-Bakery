using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    private int PastryCost { get; set; }
    private static int NumberOfPastries { get; set; }
    
    public Pastry(int numberOfPastries)
    {
      NumberOfPastries = numberOfPastries;
      PastryCost = 2;
    }

      public int CalculateTotal()
      {
      int discount = NumberOfPastries/4;
      int totalCost = (NumberOfPastries - discount) * PastryCost;
      return totalCost;
    }
  }
} 