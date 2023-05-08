﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    public class ConfirmedOrderStatusStrategy : IOrderStatusStrategy
    {
        public string GetOrderStatus(string customerName, string vehicleMake, string vehicleModel, decimal repairCost, bool isRushOrder, OrderType orderType, bool isNewCustomer, bool isLargeOrder)
        {
            return "Confirmed";
        }
    }
}
