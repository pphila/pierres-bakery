using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

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

    [TestMethod]
    public void SetBreadType_String()
    {
      //Arrange
      string breadType = "rye";
      int breadQuantity = 3;
      Bread breadOrder = new Bread(breadType, breadQuantity);

      //Act
      string addBreadType = "shokupan";
      breadOrder.BreadType = addBreadType;
      string result = breadOrder.BreadType;

      //Assert
      Assert.AreEqual(addBreadType, result);
    }

    [TestMethod]
    public void GetAmountOfBread_returnBreadQuantity_Int()
    {
      //Arrange
      string breadType = "baguette";
      int breadQuantity = 3;
      Bread breadOrder = new Bread(breadType, breadQuantity);

      //Act
      int result = breadOrder.BreadQuantity;

      //Assert
      Assert.AreEqual(breadQuantity, result);
    }

    [TestMethod]
    public void GetCalculatedBreadCost_Int()
    {
      //Arrange
      string breadType = "baguette";
      int breadQuantity = 7;
      Bread breadOrder = new Bread(breadType, breadQuantity);

      //Act
      int result = breadOrder.CalculatedBreadCost(breadQuantity);

      //Assert
      Assert.AreEqual(25, result);
    }
  }
}