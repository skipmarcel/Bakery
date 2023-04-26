using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{

[TestClass]
  public class BreadTests
  {

    [TestMethod]
public void GetTotalPrice_ReturnsCorrectTotalPriceForOneLoafOfBread()
{
    // Arrange
    decimal pricePerLoaf = 5.0m;
    int numLoaves = 1;
    BreadDeal breadDeal = new BreadDeal(pricePerLoaf, numLoaves);

    // Act
    decimal totalPrice = breadDeal.GetTotalPrice();

    // Assert
    Assert.AreEqual(pricePerLoaf, totalPrice);
}

[TestMethod]
public void GetTotalPrice_ReturnsCorrectTotalPriceForTwoLoavesOfBread()
{
    // Arrange
    decimal pricePerLoaf = 5.0m;
    int numLoaves = 2;
    BreadDeal breadDeal = new BreadDeal(pricePerLoaf, numLoaves);

    // Act
    decimal totalPrice = breadDeal.GetTotalPrice();

    // Assert
    Assert.AreEqual(pricePerLoaf * 2, totalPrice);
}

[TestMethod]
public void GetTotalPrice_ReturnsCorrectTotalPriceForSevenLoavesOfBread()
{
    // Arrange
    decimal pricePerLoaf = 5.0m;
    int numLoaves = 7;
    BreadDeal breadDeal = new BreadDeal(pricePerLoaf, numLoaves);

    // Act
    decimal totalPrice = breadDeal.GetTotalPrice();

    // Assert
    Assert.AreEqual(pricePerLoaf * 5, totalPrice);
}

[TestMethod]
public void GetTotalPastryPrice_ShouldReturnCorrectPrice_WhenNumPastriesIs4()
{
     // Arrange
     decimal pricePerPastry = 2.0M;
     int numPastries = 4;
     decimal expectedPrice = 6.0M;
     PastryDeal pastryDeal = new PastryDeal(pricePerPastry, numPastries);

     // Act
     decimal actualPrice = pastryDeal.GetTotalPastryPrice();

     // Assert
     Assert.AreEqual(expectedPrice, actualPrice);
}

  }

}
