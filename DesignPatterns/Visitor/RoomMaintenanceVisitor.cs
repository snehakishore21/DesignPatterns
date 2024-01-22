using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class RoomMaintenanceVisitor : IVisitor
    {
        public void VisitRoomDeluxe(RoomDeluxe room)
        {
            Console.WriteLine("Room Deluxe maintenance");
        }

        public void VisitRoomEco(RoomEco room)
        {
            Console.WriteLine("Room Eco maintenance");
        }

        public void VisitRoomSuite(RoomSuite room)
        {
           Console.WriteLine("Room Suite maintenance");
        }
    }
}
