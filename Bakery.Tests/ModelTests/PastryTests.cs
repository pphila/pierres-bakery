using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastyClass_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastryOrder = new Pastry("testPastry", 3);
      Assert.AreEqual(typeof(Pastry), pastryOrder.GetType());
    }

    [TestMethod]
    public void GetPastryType_String()
    {
      //Arrange
      string pastryType = "danish";
      int pastryQuantity = 3;
      Pastry pastryOrder = new Pastry(pastryType, pastryQuantity);

      //Act
      string result = pastryOrder.PastryType;

      //Assert
      Assert.AreEqual(pastryType, result);
    }
  }
}