using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    public class AuthorisationRequiredOrderStatusStrategy : IOrderStatusStrategy
    {
        public string GetOrderStatus(string customerName, string vehicleMake, string vehicleModel, decimal repairCost, bool isRushOrder, OrderType orderType, bool isNewCustomer, bool isLargeOrder)
        {
            bool isSupportedVehicle = CheckSupportedVehicle(vehicleMake, vehicleModel);
            if (!isSupportedVehicle)
            {
                return "AuthorisationRequired";
            }

            return "AuthorisationRequired";
        }

        private bool CheckSupportedVehicle(string vehicleMake, string vehicleModel)
        {
            // This method would check if the repair shop supports the given vehicle make and model and return true if it does.
            // For the purposes of this example, we'll assume the shop supports all makes and models.
            return true;
        }


    }

    public class ClosedOrderStatusStrategy : IOrderStatusStrategy
    {
        public string GetOrderStatus(string customerName, string vehicleMake, string vehicleModel, decimal repairCost, bool isRushOrder, OrderType orderType, bool isNewCustomer, bool isLargeOrder)
        {

            return "Closed";
        }
    }

}
