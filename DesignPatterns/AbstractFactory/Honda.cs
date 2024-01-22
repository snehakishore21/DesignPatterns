using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Honda : IVehicle
    {
        public string GetVehicleName()
        {
            return "Honda";
        }

        public string GetVehiclePrice()
        {
            return "2,00,000";
        }

        public string GetVehicleType()
        {
            return "Bike Affordable";
        }
    }
}
