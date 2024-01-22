using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class MulCommand: ICommand
    {
        private double newValToMul;

        public MulCommand(double currValue)
        {
            this.newValToMul = currValue;
        }
        public double Execute(double x)
        {
            return x*newValToMul;
        }

        public double Undo(double x)
        {
            return x/newValToMul;
        }
    }
}
