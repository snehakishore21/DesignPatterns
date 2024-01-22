using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class Proxy1 : IProxy
    {
        RealClass realClass;

        public Proxy1()
        {
            realClass = new RealClass();
        }
        public void Create(string client)
        {
            if(client == "admin")
            {
                realClass.Create(client);
            }
            else
            {
                Console.WriteLine("You are not authorized to create");
            }
        }

        public void DoSomething(string client)
        {
            if (client == "admin")
            {
                realClass.DoSomething(client);
            }
            else
            {
                Console.WriteLine("You are not authorized to create");
            }
        }

        public IProxy Get(string client)
        {
            if (client == "admin")
            {
                return realClass.Get(client);
            }
            else
            {
                throw new AccessViolationException();
            }
        }
    }
}
