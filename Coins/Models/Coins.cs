
namespace Coins.Models
{
  public class Coin
  {
    public static double Change { get; set; }
    public static int Quarters { get; set; }
    public static int Dimes { get; set; }
    public static int Nickels { get; set; }
    public static int Pennies { get; set; }

    public static void SetChange(double change)
    {
      Change = change;
    }
  }
}