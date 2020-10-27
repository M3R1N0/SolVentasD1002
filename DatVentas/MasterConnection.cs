using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVentas
{
    class MasterConnection
    {
        public static string connection = Convert.ToString(Desencryptation.checkServer());
    }
}
