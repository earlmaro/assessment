using assessment;

public class DeciderTests
{
        private AuthorisationRequiredOrderStatusStrategy _strategy;
        private Decider _decideStatus;

        [SetUp]
        public void Setup()
        {
            _strategy = new AuthorisationRequiredOrderStatusStrategy();
            _decideStatus = new Decider();
        }

        [Test]
        public void GetOrderStatus_ReturnsAuthorisationRequired_ForLargeRepairOrder()
        {
        // Arrange
        string customerName = "John Smith";
        string vehicleMake = "Honda";
        string vehicleModel = "Civic";
        decimal repairCost = 500;
        bool isRushOrder = false;
        OrderType orderType = OrderType.Repair;
        bool isNewCustomer = false;
        bool isLargeOrder = true;

        // Act
        string orderStatus = _decideStatus.Decide(customerName, vehicleMake, vehicleModel, repairCost, isRushOrder, orderType, isNewCustomer, isLargeOrder);

        // Assert
        Assert.That(orderStatus, Is.EqualTo("AuthorisationRequired"));
        }

    [Test]
    public void GetOrderStatus_ReturnsClosed_ForNewCustomerLargeRepairOrder()
    {
        // Arrange
        string customerName = "John Smith";
        string vehicleMake = "Honda";
        string vehicleModel = "Civic";
        decimal repairCost = 500;
        bool isRushOrder = false;
        OrderType orderType = OrderType.Repair;
        bool isNewCustomer = true;
        bool isLargeOrder = true;

        // Act
        string orderStatus = _decideStatus.Decide(customerName, vehicleMake, vehicleModel, repairCost, isRushOrder, orderType, isNewCustomer, isLargeOrder);

        // Assert
        Assert.That(orderStatus, Is.EqualTo("Closed"));
    }

    [Test]
    public void GetOrderStatus_ReturnsClosed_ForLargeRushHireOrder()
    {
        // Arrange
        string customerName = "John Smith";
        string vehicleMake = "Range";
        string vehicleModel = "Civic";
        decimal repairCost = 500;
        bool isRushOrder = true;
        OrderType orderType = OrderType.Hire;
        bool isNewCustomer = true;
        bool isLargeOrder = true;

        // Act
        string orderStatus = _decideStatus.Decide(customerName, vehicleMake, vehicleModel, repairCost, isRushOrder, orderType, isNewCustomer, isLargeOrder);

        // Assert
        Assert.That(orderStatus, Is.EqualTo("Closed"));
    }
    [Test]
    public void GetOrderStatus_ReturnsAuthorisationRequired_ForNewCustomerRushedOrder()
    {
        // Arrange
        string customerName = "John Smith";
        string vehicleMake = "Toyota";
        string vehicleModel = "Civic";
        decimal repairCost = 500;
        bool isRushOrder = true;
        OrderType orderType = OrderType.Hire;
        bool isNewCustomer = true;
        bool isLargeOrder = false;

        // Act
        string orderStatus = _decideStatus.Decide(customerName, vehicleMake, vehicleModel, repairCost, isRushOrder, orderType, isNewCustomer, isLargeOrder);

        // Assert
        Assert.That(orderStatus, Is.EqualTo("AuthorisationRequired"));
    }

    [Test]
    public void GetOrderStatus_ReturnsConfirmed_ForOtherOrder()
    {
        // Arrange
        string customerName = "John Doe";
        string vehicleMake = "Honda";
        string vehicleModel = "Civic";
        decimal repairCost = 500;
        bool isRushOrder = false;
        OrderType orderType = OrderType.Hire;
        bool isNewCustomer = true;
        bool isLargeOrder = false;

        // Act
        string orderStatus = _decideStatus.Decide(customerName, vehicleMake, vehicleModel, repairCost, isRushOrder, orderType, isNewCustomer, isLargeOrder);

        // Assert
        Assert.That(orderStatus, Is.EqualTo("Confirmed"));
    }
}
