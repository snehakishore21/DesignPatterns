using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpretor2
{
    public interface IExpressionInter
    {
        public int Evaluate(Context2 context);
    }
}
