using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    //acts as leaf for the composite pattern
    public class Number : IExpression
    {
        private int _value;

        public Number(int value)
        {
            _value = value;
        }

        public int Evaluate()
        {
            return _value;
        }
    }
}
