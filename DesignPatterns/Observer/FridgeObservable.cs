using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class FridgeObservable : StockObservable
    {
        public FridgeObservable()
        {
            Name = "Fridge";
        }
    }
}
