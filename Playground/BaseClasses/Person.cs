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

        public Person()
        {
            FirstName = "John";
            LastName = "Doe";
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
