using Playground.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.StaticClasses
{
    public static class RandomPointGenerator
    {
        public static int Counter = 0;

        public static XY GetRandomPoint()
        {
            Counter++;

            return new XY(new Random().Next(-11, 11), new Random().Next(-11, 11));
        }
    }
}
