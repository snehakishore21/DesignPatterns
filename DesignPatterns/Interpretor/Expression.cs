using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpretor
{
    public class LowerExpression:IExpressionInterpretor
    {
        public string Interpret(Context context)
        {
            return context.Input.ToLower();
        }
    }

    public class UpperExpression : IExpressionInterpretor
    {
        public string Interpret(Context context)
        {
            return context.Input.ToUpper();
        }
    }
}
