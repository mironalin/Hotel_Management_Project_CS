using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entities
{
    [Serializable]
    public class Reservations
    {
        public List<Reservation> ReservationsList { get; set; }

        public Reservations()
        {
            ReservationsList = new List<Reservation>();
        }
    }
}
