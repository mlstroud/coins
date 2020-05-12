using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coins.Models;

namespace Coins.Tests
{
  [TestClass]
  public class CoinTests
  {
    [TestMethod]
    public void Change_UpdatesChange_decimal()
    {
      decimal change = 1.43m;
      Coin.Change = change;

      decimal result = Coin.Change;

      Assert.AreEqual(change, result);
    }

    [TestMethod]
    public void GetQuarters_ReturnsNumberOfQuarters_Int()
    {
      decimal change = 0.97m;
      int quarters = 3;
      Coin.Change = change;

      int result = Coin.GetQuarters();

      Assert.AreEqual(quarters, result);
    }

    [TestMethod]
    public void GetDimes_ReturnsNumberOfDimes_Int()
    {
      decimal change = 0.20m;
      Coin.Change = change;
      int dimes = 2;

      int result = Coin.GetDimes();

      Assert.AreEqual(dimes, result);
    }

    [TestMethod]
    public void GetNickels_ReturnsNumberOfNickels_Int()
    {
      decimal change = 0.15m;
      Coin.Change = change;
      int nickels = 3;

      int result = Coin.GetNickels();

      Assert.AreEqual(nickels, result);
    }

    [TestMethod]
    public void GetPennies_ReturnsNumberOfPennies_Int()
    {
      decimal change = 0.07m;
      Coin.Change = change;
      int pennies = 7;

      int result = Coin.GetPennies();

      Assert.AreEqual(pennies, result);
    }
  }
}