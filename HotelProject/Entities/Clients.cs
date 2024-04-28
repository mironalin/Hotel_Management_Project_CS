using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entities
{
    [Serializable]
    public class Clients
    {
        public List<Client> ClientsList { get; set; }

        public Clients()
        {
            ClientsList = new List<Client>();
        }
    }
}
