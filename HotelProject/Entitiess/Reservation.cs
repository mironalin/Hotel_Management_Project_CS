using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject
{
    [Serializable]
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int ClientID { get; set; }
        public int RoomNumber { get; set; }
        // public Client Client { get; set; }
        // public Room Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set;}

        public Reservation()
        {
            CheckInDate = DateTime.Now;
            CheckOutDate = DateTime.Now;
        }

        public Reservation(int reservationID, int clientID, int roomNumber, DateTime checkInDate, DateTime checkOutDate)
        {
            ReservationID = reservationID;
            ClientID = clientID;
            RoomNumber = roomNumber;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }
    }
}
