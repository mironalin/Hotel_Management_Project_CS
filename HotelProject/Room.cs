using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject
{
    internal class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public int RoomPhone { get; set; }
        public string RoomStatus { get; set; }

        public Room(int roomNumber, string roomType, int roomPhone, string roomStatus)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            RoomPhone = roomPhone;
            RoomStatus = roomStatus;
        }
    }
}
