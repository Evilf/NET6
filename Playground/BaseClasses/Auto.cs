using Playground.StaticClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.BaseClasses
{
    public class Auto
    {
        public Person Owner { get; set; }
        public string LicencePlate { get; set; }
        public Color Color { get; set; }
        public double KilometersDriven { get; set; }
        public string CarBrand { get; set; }
        public bool IsAutoStolen 
        { 
            get => AutoManagement.CheckIfAutoWasStolen(this); 
        }

        public Auto()
        {
            Owner = new Person();
            LicencePlate = "";
            Color = Color.Transparent;
            KilometersDriven = 0;
            CarBrand = "";
        }

        public Auto(Person owner, string licencePlate, Color color, double kilometersDriven, string carBrand)
        {
            Owner = owner;
            LicencePlate = licencePlate;
            Color = color; 
            KilometersDriven = kilometersDriven;
            CarBrand = carBrand;
        }

    }
}
