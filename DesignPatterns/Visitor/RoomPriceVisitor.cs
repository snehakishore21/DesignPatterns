using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class RoomPriceVisitor : IVisitor
    {
        public void VisitRoomDeluxe(RoomDeluxe room)
        {
            room.Price = 1000;
        }

        public void VisitRoomEco(RoomEco room)
        {
            room.Price = 500;
        }

        public void VisitRoomSuite(RoomSuite room)
        {
            room.Price = 2000;
        }
    }
}
