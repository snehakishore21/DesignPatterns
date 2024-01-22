using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class MushroomTopping: IPizza
    {
        private IPizza _pizza;

        public MushroomTopping(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string GetDetails()
        {
            return _pizza.GetDetails() + ", with mushroom topping";
        }

        public double GetPrice()
        {
            return _pizza.GetPrice() + 20.72;
        }
    }
}
