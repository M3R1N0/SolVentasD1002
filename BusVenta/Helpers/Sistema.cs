using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
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

        public static string ObtenerIP()
        {
            string strIP;

            strIP = Dns.GetHostEntry(Environment.MachineName).AddressList.FirstOrDefault(
                    (i) => i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToString();

            return strIP;
        }


        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
