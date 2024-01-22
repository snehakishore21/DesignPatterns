using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public interface IAggregate
    {
        public IIterator GetIterator();

        public void Add(string o);

        public List<string> GetItems();

        public void ReverseDirection();
    }
}
