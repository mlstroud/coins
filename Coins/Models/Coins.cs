using System;
namespace Coins.Models
{
  public class Coin
  {
    public static double Change { get; set; }
    public static int Quarters { get; set; }
    public static int Dimes { get; set; }
    public static int Nickels { get; set; }
    public static int Pennies { get; set; }

    public static int GetQuarters()
    {
      int quarters = 0;
      while (Change >= .25)
      {
        quarters++;
        Change -= .25;
      }

      return quarters;
    }

    public static int GetDimes()
    {
      int dimes = 0;

      while (Change >= .1)
      {
        dimes++;
        Change -= .1;
      }

      return dimes;
    }

    public static int GetNickels()
    {
      int nickels = 0;

      while (Change >= 0.05)
      {
        Console.WriteLine(Change);
        nickels++;
        Change -= 0.05;
      }

      return nickels;
    }
  }
}