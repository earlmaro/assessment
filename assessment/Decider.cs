using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    public class Decider
    {
        public string Decide(string customerName, string vehicleMake, string vehicleModel, decimal repairCost, bool isRushOrder, OrderType orderType, bool isNewCustomer, bool isLargeOrder) {
            IOrderStatusStrategy orderStatusStrategy;
            if (isLargeOrder && (orderType == OrderType.Repair) && isNewCustomer)
            {
                orderStatusStrategy = new ClosedOrderStatusStrategy();
            }
            else if (isLargeOrder && (orderType == OrderType.Hire) && isRushOrder)
            {
                orderStatusStrategy = new ClosedOrderStatusStrategy();
            }
            else if (isLargeOrder && (orderType == OrderType.Repair) && !isNewCustomer)
            {
                orderStatusStrategy = new AuthorisationRequiredOrderStatusStrategy();
            }
            else if (isRushOrder && isNewCustomer)
            {
                orderStatusStrategy = new AuthorisationRequiredOrderStatusStrategy();
            }
            else
            {
                orderStatusStrategy = new ConfirmedOrderStatusStrategy();
            }

            string orderStatus = orderStatusStrategy.GetOrderStatus(customerName, vehicleMake, vehicleModel, repairCost, isRushOrder, orderType, isNewCustomer, isLargeOrder);
            
            return orderStatus;
        }
    }
}
