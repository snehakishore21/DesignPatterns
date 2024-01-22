using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class SubSystemClass2
    {
        public void AddToCart()
        {
            Console.WriteLine("AddToCart");
        }

        public void ApplyDiscount()
        {
            Console.WriteLine("ApplyDiscount");
        }
    }
}
