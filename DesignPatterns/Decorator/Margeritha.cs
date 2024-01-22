using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class Margeritha: IPizza
    {
        public string GetDetails()
        {
            return "Margeritha Pizza";
        }

        public double GetPrice()
        {
            return 150.00;
        }
    }
}
