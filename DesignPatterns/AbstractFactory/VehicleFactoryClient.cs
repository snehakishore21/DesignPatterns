using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class VehicleFactoryClient
    {
        public void VehicleFactoryClientTest(IVehicleFactory vehicleFactory)
        {
            IVehicle car = vehicleFactory.GetCar();
            car.Display();

            IVehicle bike = vehicleFactory.GetBike();
            bike.Display();
        }

        public IVehicleFactory GetVehicleFactory(string range)
        {
            switch (range)
            {
                case "Luxury":
                    return new LuxuryVehicleFactory();
                case "Affordable":
                    return new AffordableVehicleFactory();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", range));
            }
        }
    }
}
