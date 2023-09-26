using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercs10.Entities
{
    public class Client
    {
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public DateTime BirthDate { get; set; }
        public Client(string clientName, string clientEmail, DateTime birthDate)
        {
            ClientName = clientName;
            ClientEmail = clientEmail;
            BirthDate = birthDate;
        }

    }
}