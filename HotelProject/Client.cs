using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject
{
    internal class Client
    {
        public int ClientID {  get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }

        public Client(int clientID, string clientName, string clientAddress, string clientPhone, string clientEmail)
        {
            ClientID = clientID;
            ClientName = clientName;
            ClientAddress = clientAddress;
            ClientPhone = clientPhone;
            ClientEmail = clientEmail;
        }


    }
}
