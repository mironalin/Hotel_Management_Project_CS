using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entities
{
    [Serializable]
    public class Rooms
    {
        public List<Room> RoomsList { get; set; }

        public Rooms()
        {
            RoomsList = new List<Room>();
        }

    }
}
