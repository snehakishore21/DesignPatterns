using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Dezire : IVehicle
    {
        public string GetVehicleName()
        {
           return "Dezire";
        }

        public string GetVehiclePrice()
        {
            return "5,00,000";
        }

        public string GetVehicleType()
        {
            return "Car Affordable";
        }
    }
}
