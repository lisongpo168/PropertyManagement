using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCommunity.Common
{
    public static class SecurityHelper
    {
        public static bool CheckSecurityId(string appSecId)
        {
            if (Helper.DecodePassword(appSecId) == GetSecurityId())
                return true;
            return false;
        }

        public static string GetSecurityId()
        {
            return cpuId() + diskId();
        }
        //Return a hardware identifier
        private static string identifier(string wmiClass, string wmiProperty)
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                //Only get the first one
                if (result == "")
                {
                    try
                    {
                        if (mo[wmiProperty] != null)
                        {
                            result = mo[wmiProperty].ToString().Trim();
                        }
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }
        private static string cpuId()
        {
            //Uses first CPU identifier available in order of preference
            //Don't get all identifiers, as it is very time consuming
            string retVal = identifier("Win32_Processor", "UniqueId");
            if (retVal == "") //If no UniqueID, use ProcessorID
            {
                retVal = identifier("Win32_Processor", "ProcessorId");
                if (retVal == "") //If no ProcessorId, use Name
                {
                    retVal = identifier("Win32_Processor", "Name");
                    if (retVal == "") //If no Name, use Manufacturer
                    {
                        retVal = identifier("Win32_Processor", "Manufacturer");
                    }
                    //Add clock speed for extra security
                    retVal += identifier("Win32_Processor", "MaxClockSpeed");
                }
            }
            return retVal;
        }
        //Main physical hard drive ID
        private static string diskId()
        {
            return identifier("Win32_PhysicalMedia", "SerialNumber");
        }
    }
}
