using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public interface IRoom
    {
        public double Price { get; set; }
        public void Accept(IVisitor visitor);
    }
}
