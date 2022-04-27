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

        public void PrintOut()
        {
            Console.WriteLine($"Jméno: {FullName}");
            Console.WriteLine($"Datum narození: {BirthDay.Date}");
            Console.WriteLine($"Adresa: {Address.Street}, {Address.City}, {Address.State}");
        }
    }
}
