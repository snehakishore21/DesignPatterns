using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public interface IProxy
    {
        public IProxy Get(string client);

        public void Create(string client);

        public void DoSomething(string client);
    }
}
