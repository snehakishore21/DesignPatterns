using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class Calculator
    {
        Stack <ICommand> commands = new Stack<ICommand>();

        double currValue = 0.0;

        public double Execute(ICommand command)
        {
            currValue = command.Execute(currValue);
            commands.Push(command);
            return currValue;
        }

        public double Undo()
        {
            ICommand command = commands.Pop();
            currValue = command.Undo(currValue);
            return currValue;
        }
    }
}
