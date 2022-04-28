using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.BaseClasses
{
    public class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public DateTime BirthDay { get; set; }
        public Address Address { get; set; }

        public Person()
        {
            FirstName = "John";
            LastName = "Doe";
            BirthDay = new DateTime(1900, 1, 1);
            Address = new Address();
        }

        public Person(string firstName, string lastName, DateTime birthDay, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Address = address;
        }

        public override string ToString() =>
            $"Jméno: {FullName} \nDatum narození: {BirthDay.ToShortDateString()} \nAdresa: {Address.Street}, {Address.City}, {Address.State}";
    }
}
