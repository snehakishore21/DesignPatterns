using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class Farmhouse: IPizza
    {
        public string GetDetails()
        {
            return "Farmhouse Pizza";
        }

        public double GetPrice()
        {
            return 200.00;
        }
    }
}
