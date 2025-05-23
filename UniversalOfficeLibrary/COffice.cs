using Microsoft.Win32;
using System;

namespace UniversalOfficeLibrary
{
    public class COffice
    {
        public COffice()
        {
            // TODO (Constructor with data for download office by Office Deployment Tool)
        }

        public void Download_office_deployment_tool()
        {
            // TODO (Download Office Deployment Tool from official MS website)
        }

        public void Download_office_by_tool()
        {
            // TODO (Initialize download office from tool)
        }

        static public bool Bypass_geoblock()
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

        static bool Bypass_not_genuine_msg()
        {
            try
            {
                // TODO
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
