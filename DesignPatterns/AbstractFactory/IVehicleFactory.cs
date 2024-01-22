﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public interface IVehicleFactory
    {
        IVehicle GetBike();
        IVehicle GetCar();
    }
}
