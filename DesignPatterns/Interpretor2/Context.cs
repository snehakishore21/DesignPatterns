using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpretor2
{
    public class Context2
    {
        public int Input { get; set; }

        public int Input2 { get; set; }

        public Context2(int input, int input2)
        {
            Input = input;
            Input2 = input2;
        }
    }
}
