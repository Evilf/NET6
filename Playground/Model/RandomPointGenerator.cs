using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Model
{
    public static class RandomPointGenerator
    {
        public static XY GetRandomPoint()
        {
            return new XY(new Random().Next(-11, 11), new Random().Next(-11, 11));
        }
    }
}
