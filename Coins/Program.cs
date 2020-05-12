using System;
using Coins.Models;

namespace Coins
{
  public class Program
  {
    public static void Main()
    {
      PromptUser();
    }

    public static void PromptUser()
    {
      Console.WriteLine("Enter an amount in change to see the breakdown:");
      Console.WriteLine("-----------------------------------------------");
      GetChange();
    }

    public static void GetChange()
    {
      bool parsed = false;

      while (!parsed)
      {
        string userInput = Console.ReadLine();
        if (Double.TryParse(userInput, out double change))
        {
          Coin.Change = change;
          parsed = true;
        }
        else
        {
          Console.WriteLine("Sorry, invalid input. Try again:");

        }
      }
    }
  }
}