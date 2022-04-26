using Playground.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.StaticClasses
{
    public static class CarStaticMethods
    {
        public static bool CheckIfAutoWasStolen(Auto auto)
        {
            if (auto.SPZ != "")
                return false;
            else 
                return true;
        }
    }
}
