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
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }

        public Client(int clientID, string clientFirstName, string clientLastName, string clientAddress, string clientPhone, string clientEmail)
        {
            ClientID = clientID;
            ClientFirstName = clientFirstName;
            ClientLastName = clientLastName;
            ClientAddress = clientAddress;
            ClientPhone = clientPhone;
            ClientEmail = clientEmail; 
        }


    }
}
