using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public Client Client { get; set; }
        public Room Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set;}

        public Reservation()
        {
            CheckInDate = DateTime.Now;
            CheckOutDate = DateTime.Now;
        }

        public Reservation(int reservationID, Client client, Room room, DateTime checkInDate, DateTime checkOutDate)
        {
            ReservationID = reservationID;
            Client = client;
            Room = room;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }
    }
}
