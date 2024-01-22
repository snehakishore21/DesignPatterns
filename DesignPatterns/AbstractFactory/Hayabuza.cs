using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Hayabuza : IVehicle
    {
        public string GetVehicleName()
        {
            return "Hayabuza";
        }

        public string GetVehiclePrice()
        {
            return "13,00,000";
        }

        public string GetVehicleType()
        {
            return "Luxury Car";
        }
    }
}
