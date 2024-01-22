using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class RealClass: IProxy
    {
        public void Create(string client)
        {
            Console.WriteLine("Created");
        }

        public void DoSomething(string client)
        {
            Console.WriteLine("Done something");
        }

        public IProxy Get(string client)
        {
            return this;
        }
    }
}
