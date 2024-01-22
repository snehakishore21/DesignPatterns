using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class SubCommand: ICommand
    {
        private double newValToSubtract;

        public SubCommand(double currValue)
        {
            this.newValToSubtract = currValue;
        }
        public double Execute(double x)
        {
            return x - newValToSubtract;
        }

        public double Undo(double x)
        {
            return x + newValToSubtract;
        }
    }
}
