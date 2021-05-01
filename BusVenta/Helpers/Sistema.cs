using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace BusVenta.Helpers
{
    public class Sistema
    {
        public static string ObenterSerialPC()
        {
            string serialPC;
            try
            {
                ManagementObject mos = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
                serialPC = mos.Properties["SerialNumber"].Value.ToString().Trim();

                return serialPC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
