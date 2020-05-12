using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coins.Models;

namespace Coins.Tests
{
  [TestClass]
  public class CoinTests
  {
    [TestMethod]
    public void Change_UpdatesChange_Double()
    {
      double change = 1.43;
      Coin.Change = change;

      double result = Coin.Change;

      Assert.AreEqual(change, result);
    }

    [TestMethod]
    public void GetQuarters_ReturnsNumberOfQuarters_Int()
    {
      double change = 0.97;
      int quarters = 3;
      Coin.Change = change;

      int result = Coin.GetQuarters();

      Assert.AreEqual(quarters, result);
    }

    [TestMethod]
    public void GetDimes_ReturnsNumberOfDimes_Int()
    {
      double change = 0.20;
      Coin.Change = change;
      int dimes = 2;

      int result = Coin.GetDimes();

      Assert.AreEqual(dimes, result);
    }

    [TestMethod]
    public void GetNickels_ReturnsNumberOfNickels_Int()
    {
      double change = 0.20;
      Coin.Change = change;
      int nickels = 4;

      int result = Coin.GetNickels();

      Assert.AreEqual(nickels, result);
    }
  }
}