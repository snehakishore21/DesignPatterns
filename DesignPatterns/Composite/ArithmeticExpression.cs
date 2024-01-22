using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class ArithmeticExpression:IExpression
    {
        private IExpression _left;
        private IExpression _right;
        private char _operation;

        public ArithmeticExpression(IExpression left, IExpression right, char operation)
        {
            _left = left;
            _right = right;
            _operation = operation;
        }

        public int Evaluate()
        {
            switch (_operation)
            {
                case '+':
                    return _left.Evaluate() + _right.Evaluate();
                case '-':
                    return _left.Evaluate() - _right.Evaluate();
                case '*':
                    return _left.Evaluate() * _right.Evaluate();
                case '/':
                    return _left.Evaluate() / _right.Evaluate();
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
