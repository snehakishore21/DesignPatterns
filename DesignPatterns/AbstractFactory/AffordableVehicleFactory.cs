using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class AffordableVehicleFactory : IVehicleFactory
    {
        public IVehicle GetBike()
        {
            return new Honda();
        }

        public IVehicle GetCar()
        {
            return new Dezire();
        }
    }
}
