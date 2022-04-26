using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Model
{
    public static class XYStaticMethods
    {

        public static XY GetMaxAreaPoint(XY point1, XY point2)
        {
            if (point1.CalculateArea() > point2.CalculateArea())
                return point1;
            else
                return point2;
        }

        public static XY GetPointMoreDistantFromOrigin(XY point1, XY point2)
        {
            double point1Distance = Math.Sqrt(Math.Pow(Math.Abs(point1.X), 2) + Math.Pow(Math.Abs(point1.Y), 2));
            double point2Distance = Math.Sqrt(Math.Pow(Math.Abs(point2.X), 2) + Math.Pow(Math.Abs(point2.Y), 2));

            if(point1Distance > point2Distance)
                return point1;
            else
                return point2;
        }

    }
}
