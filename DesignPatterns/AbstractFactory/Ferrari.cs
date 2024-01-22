using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Ferrari: IVehicle
    {
        public string GetVehicleName()
        {
            return "Ferrari";
        }

        public string GetVehiclePrice()
        {
           return "1,00,00,000";
        }

        public string GetVehicleType()
        {
            return "Luxury Car";
        }
    }
}
