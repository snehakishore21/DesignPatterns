using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public interface IVehicle
    {
        public string GetVehicleName();

        public string GetVehiclePrice();

        public string GetVehicleType();

        public void Display()
        {
            Console.WriteLine(this.ToDisplayString());
        }

        public string ToDisplayString()
        {
            string vehicleName = GetVehicleName();
            string vehiclePrice = GetVehiclePrice();
            string vehicleType = GetVehicleType();

            string stringText = $"Vehicle Name: {vehicleName}, Vehicle Price: {vehiclePrice}, Vehicle Type: {vehicleType}";
            return stringText;
        }
    }
}
