using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    private int LoafCost { get; set; }
    private static int NumberOfLoaves { get; set; }

    public Bread(int numberOfLoaves)
    {
      NumberOfLoaves = numberOfLoaves;
      LoafCost = 5;
    }

    public int CalculateTotal()
    {
      int discount = NumberOfLoaves/3;
      int totalCost = (NumberOfLoaves - discount) * LoafCost;
      return totalCost;
    }
  }
}