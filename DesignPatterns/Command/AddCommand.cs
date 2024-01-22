using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class AddCommand : ICommand
    {
        private double newValToAdd;

        public AddCommand(double currValue)
        {
            this.newValToAdd = currValue;
        }
        public double Execute(double x)
        {
            return newValToAdd + x;
        }

        public double Undo(double x)
        {
            return newValToAdd - x;
        }
    }
}
