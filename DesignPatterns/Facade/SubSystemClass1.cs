using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class SubSystemClass1
    {
        public void ChooseAccessory()
        {
           Console.WriteLine("ChooseAccessory");
        }

        public void ChooseDress()
        {
           Console.WriteLine("ChooseDress");
        }
    }
}
