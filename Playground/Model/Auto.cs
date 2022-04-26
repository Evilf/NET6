using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Model
{
    public class Auto
    {
        public string SPZ { get; set; }
        public Color Color { get; set; }
        public double KilometersDriven { get; set; }
        public string CarBrand { get; set; }

        public Auto()
        {

        }

        public Auto(string sPZ, Color color, double kilometersDriven, string carBrand)
        {
            SPZ = sPZ;
            Color = color; 
            KilometersDriven = kilometersDriven;
            CarBrand = carBrand;
        }

    }
}
