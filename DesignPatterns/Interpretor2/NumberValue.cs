using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpretor2
{
    //acts as leaf for the composite pattern
    public class NumberValue : IExpressionInter
    {
        private int _value;

        public NumberValue(int value)
        {
            _value = value;
        }

        public int Evaluate()
        {
            return _value;
        }

        public int Evaluate(Context2 context)
        {
            return _value;
        }
    }
}
