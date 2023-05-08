using assessment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class AuthorisationRequiredOrderStatusStrategyTests
{
    private AuthorisationRequiredOrderStatusStrategy? _strategy;

    [TestInitialize]
    public void TestInitialize()
    {
        _strategy = new AuthorisationRequiredOrderStatusStrategy();
    }

    public AuthorisationRequiredOrderStatusStrategy? Get_strategy()
    {
        return _strategy;
    }

    [TestMethod]
    public void GetOrderrStatusTest(AuthorisationRequiredOrderStatusStrategy? _strategy)
    {
        // Arrange
        string customerName = "Honda sale";
        string vehicleMake = "Honda";
        string vehicleModel = "Civic";
        decimal repairCost = 500;
        bool isRushOrder = false;
        OrderType orderType = OrderType.Repair;
        bool isNewCustomer = false;
        bool isLargeOrder = false;

        // Act
        string orderStatus = _strategy.GetOrderStatus(customerName, vehicleMake, vehicleModel, repairCost, isRushOrder, orderType, isNewCustomer, isLargeOrder);

        // Assert
        Console.WriteLine(orderStatus);
        Assert.AreEqual("AuthorisationRired", orderStatus);
    }
}