using Microsoft.Win32;
using System;

namespace UniversalOfficeLibrary
{
    public class COffice
    {
        static public bool bypass_geoblock()
        {
            try
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Office\16.0\Common\ExperimentConfigs\Ecs", "CountryCode", "US");
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
