using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class SubSystemClass3
    {
        public void AddAddress()
        {
            Console.WriteLine("AddAddress");
        }

        public void AddPayment()
        {
           Console.WriteLine("AddPayment");
        }

        public void ConfirmOrder()
        {
            Console.WriteLine("ConfirmOrder");
        }

        public void NotifyCustomer()
        {
           Console.WriteLine("NotifyCustomer");
        }
    }
}
