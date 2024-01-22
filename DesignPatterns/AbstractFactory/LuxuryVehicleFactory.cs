using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class LuxuryVehicleFactory : IVehicleFactory
    {
        public IVehicle GetBike()
        {
            return new Hayabuza();
        }

        public IVehicle GetCar()
        {
            return new Ferrari();
        }
    }
}
