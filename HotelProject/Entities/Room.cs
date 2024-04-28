using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public string RoomPhone { get; set; }
        public string RoomStatus { get; set; }

        public Room() { }

        public Room(int roomNumber, string roomType, string roomPhone, string roomStatus) : this()
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            RoomPhone = roomPhone;
            RoomStatus = roomStatus;
        }
    }
}
