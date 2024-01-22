using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpretor2
{
    public class AddExpression: IExpressionInter
    {
        private IExpressionInter _left;
        private IExpressionInter _right;

        public AddExpression(IExpressionInter left, IExpressionInter right)
        {
            _left = left;
            _right = right;
        }

        public int Evaluate(Context2 context)
        {
            return _left.Evaluate(context) + _right.Evaluate(context);
        }
    }
}
