using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public interface IPizza
    {
        public string GetDetails();
        public double GetPrice();
    }
}
