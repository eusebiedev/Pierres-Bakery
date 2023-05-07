using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery 
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("========*========*========**========**========*");
      Console.WriteLine("Welcome to Pierre's Bread & Pastry Bakery");
      Console.WriteLine("========**========**========**========**======*");
      Console.WriteLine("Our Bread is $5 a loaf, buy 2 and get one FREE!");
      Console.WriteLine("Our fine Pastries are $2 each, buy 3 and get one FREE!");
      Console.WriteLine("========**========**========**========**======*");
      Console.WriteLine("How many loaves of Bread can we get you?");
      int Bread = int.Parse(Console.ReadLine());
      Console.WriteLine("How many fine Pastries can we get you?");
      int Pastry = int.Parse(Console.ReadLine());
      Bread newBread = new Bread();
      Pastry newPastry = new Pastry();
      int orderTotal = OrderTally(Bread, Pastry);
      Console.WriteLine("========**========**========**========**======*");
      Console.WriteLine($"Thanks so much, your Order for {Bread} Bread & {Pastry} Pastries comes to: ${orderTotal}");
    }

    public static int OrderTally(int loafOrder, int pastryOrder)
    {
      int combineOrders = ((Bread.BreadOrder(loafOrder)) + (Pastry.PastryOrder( pastryOrder)));
      return combineOrders;
    } 
  }
}