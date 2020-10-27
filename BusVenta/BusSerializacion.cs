using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusVenta
{
    public class BusSerializacion
    {
        public void Agregar_Serializacion(Serializacion s)
        {
            int filasAfectadas = new DatSerializacion().Insertar_Serializacion(s);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrio un error al insertar");
            }
        }
    }
}
