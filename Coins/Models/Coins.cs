using System;
namespace Coins.Models
{
  public class Coin
  {
    public static decimal Change { get; set; }
    public static int Quarters { get; set; }
    public static int Dimes { get; set; }
    public static int Nickels { get; set; }
    public static int Pennies { get; set; }

    public static void MakeChange()
    {
      Quarters = GetQuarters();
      Dimes = GetDimes();
      Nickels = GetNickels();
      Pennies = GetPennies();
    }

    public static int GetQuarters()
    {
      int quarters = 0;

      while (Change >= 0.25m)
      {
        quarters++;
        Change -= 0.25m;
      }

      return quarters;
    }

    public static int GetDimes()
    {
      int dimes = 0;

      while (Change >= 0.10m)
      {
        dimes++;
        Change -= 0.1m;
      }

      return dimes;
    }

    public static int GetNickels()
    {
      int nickels = 0;

      while (Change >= 0.05m)
      {
        nickels++;
        Change -= 0.05m;
      }

      return nickels;
    }

    public static int GetPennies()
    {
      int pennies = 0;

      while (Change >= 0.01m)
      {
        pennies++;
        Change -= 0.01m;
      }

      return pennies;
    }
  }
}