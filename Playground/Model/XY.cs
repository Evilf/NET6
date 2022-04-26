using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Model
{
    public class XY
    {

        public int X { get; set; }
        public int Y { get; set; }

        public XY(int x, int y)
        {
            X = x;
            Y = y;
        }



        public void Print()
        {
            Console.WriteLine($"X: {X} Y: {Y}");
        }

        public int CalculateArea()
        {
            return X * Y;
        }

    }
}
