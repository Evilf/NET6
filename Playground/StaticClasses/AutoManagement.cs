using Playground.BaseClasses;
using Playground.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.StaticClasses
{
    public static class AutoManagement
    {
        public static List<string> StolenLicencePlates = new List<string>();
        private static bool IsStolenLicencePlatesLoaded = false;

        public static bool CheckIfAutoWasStolen(Auto auto)
        {
            if (!IsStolenLicencePlatesLoaded)
                LoadStolenLicencePlates(Constants.StolenLicencePlatesFilePath);

            if (!StolenLicencePlates.Contains(auto.LicencePlate))
                return false;
            else
                return true;
        }

        public static void LoadStolenLicencePlates(string filePath)
        {
            try
            {
                StolenLicencePlates = File.ReadAllLines(filePath).ToList();
                IsStolenLicencePlatesLoaded = true;
            }
            catch (Exception ex)
            {
                IsStolenLicencePlatesLoaded = false;
            }
        }

    }
}
