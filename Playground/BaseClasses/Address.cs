using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.BaseClasses
{
    public class Address
    {
        public string State { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }

        public Address()
        {
            State = "Česká Republika";
            City = "";
            PostalCode = "";
            Street = "";
        }

        public Address(string state, string city, string postalCode, string street)
        {
            State = state;
            City = city;
            PostalCode = postalCode;
            Street = street;
        }
    }
}
