using assessment;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter customer name:");
        string customerName = Console.ReadLine();

        Console.WriteLine("Enter vehicle make:");
        string vehicleMake = Console.ReadLine();

        Console.WriteLine("Enter vehicle model:");
        string vehicleModel = Console.ReadLine();

        Console.WriteLine("Enter repair cost:");
        decimal repairCost = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Is this a rush order? (true/false)");
        bool isRushOrder = bool.Parse(Console.ReadLine());

        Console.WriteLine("What is the order type? (Repair/Hire)");
        OrderType orderType = (OrderType)Enum.Parse(typeof(OrderType), Console.ReadLine(), true);

        Console.WriteLine("Is this a new customer? (true/false)");
        bool isNewCustomer = bool.Parse(Console.ReadLine());

        Console.WriteLine("Is this a large order? (true/false)");
        bool isLargeOrder = bool.Parse(Console.ReadLine());

        Decider statusDecider;

        statusDecider = new Decider();

        string orderStatus = statusDecider.Decide(customerName, vehicleMake, vehicleModel, repairCost, isRushOrder, orderType, isNewCustomer, isLargeOrder);

        Console.WriteLine("Order status: " + orderStatus);




    }

}