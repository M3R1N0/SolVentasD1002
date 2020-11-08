using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusVenta
{
    public class BusVentas
    {
        public void AgregarVenta(Venta venta)
        {
            int filasAfectadas = new DatVenta().InsertarVenta(venta);

            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrió un error al Insertar la venta");
            }
        }
    }
}
