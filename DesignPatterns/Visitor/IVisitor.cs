using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public interface IVisitor
    {
        public void VisitRoomDeluxe(RoomDeluxe room);

        public void VisitRoomSuite(RoomSuite room);

        public void VisitRoomEco(RoomEco room);
    }
}
