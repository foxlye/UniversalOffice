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
                RegistryKey rg_key = Registry.CurrentUser.CreateSubKey(@"HKCU\Software\Microsoft\Office\16.0\Common\ExperimentConfigs\Ecs");
                rg_key.SetValue("CountryCode", "std::wstring|US");
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }



    }
}
