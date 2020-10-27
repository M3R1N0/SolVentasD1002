using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusVenta
{
    public class BusLicencia
    {

        public Licencia Obtener_LicenciaTemporal ()
        {
            DataRow dr = new DatLicencia().ObtenerLicencia_Temporal();
            Licencia l = new Licencia();
            l.Id = Convert.ToInt32( dr["Id"] );
            l.Serial = dr["S"].ToString();
            l.FechaVencimiento = dr["F"].ToString();
            l.Estado = dr["E"].ToString();
            l.FechaActivacion = dr["FA"].ToString();
            return l;
        }

    }
}
