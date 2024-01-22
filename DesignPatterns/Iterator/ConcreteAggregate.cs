using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class ConcreteAggregate: IAggregate
    {
        private List<string> _items = new List<string>();

        private bool direction = true;
        public void Add(string o)
        {
            _items.Add(o);
        }

        public IIterator GetIterator()
        {
           return new ConcreteIterator(this, direction);
        }

        public List<string> GetItems()
        {
            return _items;
        }

        public void ReverseDirection()
        {
            direction = !direction;
        }
    }
}
