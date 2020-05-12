using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coins.Models;

namespace Coins.Tests
{
  [TestClass]
  public class CoinTests
  {
    [TestMethod]
    public void SetChange_SetsChange_Double()
    {
      double change = 1.43;
      Coin.SetChange(1.43);

      double result = Coin.Change;

      Assert.AreEqual(change, result);
    }
  }
}