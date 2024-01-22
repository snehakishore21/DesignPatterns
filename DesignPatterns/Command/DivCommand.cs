using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class DivCommand:ICommand
    {
        private double newValToDivide;

        public DivCommand(double currValue)
        {
            this.newValToDivide = currValue;
        }
        public double Execute(double x)
        {
            return x/newValToDivide;
        }

        public double Undo(double x)
        {
            return x*newValToDivide;
        }
    }
}
