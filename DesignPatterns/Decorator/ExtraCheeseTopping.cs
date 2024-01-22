using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class ExtraCheeseTopping: IPizza
    {
        private IPizza _pizza;

        public ExtraCheeseTopping(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string GetDetails()
        {
            return _pizza.GetDetails() + ", with Extra Cheese";
        }

        public double GetPrice()
        {
            return _pizza.GetPrice() + 30.72;
        }
    }
}
