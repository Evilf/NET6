using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.BaseClasses
{
    public class Address
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string CompleteAddress { get => $"{Street}, {City}, {State}"; }

        public Address()
        {
            State = "Česká Republika";
            City = "";
            ZipCode = "";
            Street = "";
        }

        public Address(string state, string city, string zipCode, string street)
        {
            State = state;
            City = city;
            ZipCode = zipCode;
            Street = street;
        }

        public override string ToString() =>
            $"{Street}, {City}, {State}";

    }
}
