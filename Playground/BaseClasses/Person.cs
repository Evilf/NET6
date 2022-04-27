using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.BaseClasses
{
    public class Person
    {
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
            Address = new Address();
        }

        public Person(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
    }
}
