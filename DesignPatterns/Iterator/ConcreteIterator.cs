using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class ConcreteIterator : IIterator
    {
        private bool direction = true;
        private ConcreteAggregate concreteAggregate;
        private int currentIndex { get; set; } = -1;


        public ConcreteIterator(ConcreteAggregate concreteAggregate, bool direction)
        {
            this.concreteAggregate = concreteAggregate;
            this.direction = direction;
            if (!direction)
            {
                currentIndex = concreteAggregate.GetItems().Count;
            }
        }

        public bool HasNext()
        {
            if(direction)
            {
                return currentIndex < concreteAggregate.GetItems().Count;
            }
            else
            {
                return currentIndex >= 0;
            }
        }

        public string Next()
        {
            currentIndex = currentIndex + (direction ? 1 : -1);
            if (HasNext())
            {
                if (direction)
                {
                    return concreteAggregate.GetItems()[currentIndex];
                }
                else
                {
                    return concreteAggregate.GetItems()[currentIndex];
                }
            }
            return null;
        }
    }
}
