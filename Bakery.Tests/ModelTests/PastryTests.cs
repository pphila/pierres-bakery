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

    [TestMethod]
    public void SetPastryType_String()
    {
      //Arrange
      string pastryType = "danish";
      int pastryQuantity = 3;
      Pastry pastryOrder = new Pastry(pastryType, pastryQuantity);

      //Act
      string addPastryType = "eclair";
      pastryOrder.PastryType = addPastryType;
      string result = pastryOrder.PastryType;

      //Assert
      Assert.AreEqual(addPastryType, result);
    }

    [TestMethod]
    public void GetPastryAmount_ReturnPastryQuantity_Int()
    {
      //Arrange
      string pastryType = "danish";
      int pastryQuantity = 3;
      Pastry pastryOrder = new Pastry(pastryType, pastryQuantity);

      //Act
      int result = pastryOrder.PastryQuantity;

      //Assert
      Assert.AreEqual(pastryQuantity, result);
    }

    [TestMethod]
    public void GetCalculatedPastryCost_Int()
    {
      //Arrange
      string pastryType = "danish";
      int pastryQuantity = 3;
      Pastry pastryOrder = new Pastry(pastryType, pastryQuantity);

      //Act
      int result = pastryOrder.CalculatedPastryCost(pastryQuantity);

      //Assert
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void Second_GetCalculatedPastryCost_Int()
    {
      //Arrange
      string pastryType = "cannoli";
      int pastryQuantity = 4;
      Pastry pastryOrder = new Pastry(pastryType, pastryQuantity);

      //Act
      int result = pastryOrder.CalculatedPastryCost(pastryQuantity);

      //Assert
      Assert.AreEqual(7, result);
    }
    
    [TestMethod]
    public void Third_GetCalculatedPastryCost_Int()
    {
      //Arrange
      string pastryType = "kringle";
      int pastryQuantity = 5;
      Pastry pastryOrder = new Pastry(pastryType, pastryQuantity);

      //Act
      int result = pastryOrder.CalculatedPastryCost(pastryQuantity);

      //Assert
      Assert.AreEqual(9, result);
    }
    
    [TestMethod]
    public void Fourth_GetCalculatedPastryCost_Int()
    {
      //Arrange
      string pastryType = "macaron";
      int pastryQuantity = 6;
      Pastry pastryOrder = new Pastry(pastryType, pastryQuantity);

      //Act
      int result = pastryOrder.CalculatedPastryCost(pastryQuantity);

      //Assert
      Assert.AreEqual(10, result);
    }
  }
}