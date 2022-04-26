using Playground.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.StaticClasses
{
    public static class AutoStaticMethods
    {
        public static List<string> StolenLicencePlates = new List<string>();

        public static bool CheckIfAutoWasStolen(Auto auto)
        {
            LoadStolenLicencePlates(@"C:\Users\michael.vrnata\source\repos\Evilf\NET6\Playground\Data\StolenLicencePlates.txt");

            if (!StolenLicencePlates.Contains(auto.LicencePlate))
                return false;
            else
                return true;
        }

        public static void LoadStolenLicencePlates(string filePath) =>
            StolenLicencePlates = File.ReadAllLines(filePath).ToList();

    }
}
