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
      Bread breadOrder = new Bread("testBread", 2);
      Assert.AreEqual(typeof(Bread), breadOrder.GetType());
    }

    [TestMethod]
    public void GetBreadType_ReturnBreadType_Sting()
    {
      //Arrange
      string breadType = "rye";
      int breadQuantity = 2;
      Bread breadOrder = new Bread(breadType, breadQuantity);
      
      //Act
      string result = breadOrder.BreadType;

      //Assert
      Assert.AreEqual(breadType, result);
    }
  }
}