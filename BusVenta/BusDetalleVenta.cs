using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusVenta
{
    public class BusDetalleVenta
    {
        public void Agregar_DetalleVenta(DetalleVenta detalleVenta)
        {
            int filasAfectadas = new DatDetalleVenta().Insertar_DetalleVenta(detalleVenta);

            if (filasAfectadas == 0)
            {
                throw new ApplicationException("Ocurrió un error al Insertar la venta");
            }
        }
    }
}
