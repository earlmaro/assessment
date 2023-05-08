using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace assessment
{

    public enum OrderType
    {
        Repair,
        Hire
    }
    public interface IOrderStatusStrategy
    {
        string GetOrderStatus(string customerName, string vehicleMake, string vehicleModel, decimal repairCost, bool isRushOrder, OrderType orderType, bool isNewCustomer, bool isLargeOrder);
    }
}
