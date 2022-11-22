using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadClass_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("testBread", 2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  }
}