using System;
using Coins.Models;

namespace Coins
{
  public class Program
  {
    public static void Main()
    {
      PromptUser();
      decimal change = GetChange();
      Coin.MakeChange();

      Console.WriteLine(change + " can be broken down into " + Coin.Quarters + " quarters, " + Coin.Dimes + " dimes, " + Coin.Nickels + " nickels, and " + Coin.Pennies + " pennies.");
    }

    public static void PromptUser()
    {
      Console.WriteLine("Enter an amount in change to see the breakdown:");
      Console.WriteLine("-----------------------------------------------");
    }

    public static decimal GetChange()
    {
      bool parsed = false;

      while (!parsed)
      {
        string userInput = Console.ReadLine();
        if (decimal.TryParse(userInput, out decimal change))
        {
          Coin.Change = change;
          parsed = true;
        }
        else
        {
          Console.WriteLine("Sorry, invalid input. Try again:");
        }
      }

      return Coin.Change;
    }
  }
}