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
    public class BusTicket
    {
        public void Agregar_Ticket(Ticket t)
        {
            int filasAfectadas = new DatTikect().Insertar_Ticket(t);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrio un error al insertar");
            }
        }

        public void Editar_FormatoTicket(Ticket t, Empresa e)
        {
            int filasAfectadas = new DatTikect().Editar_FormatoTicket(t, e);
            if (filasAfectadas != 2)
            {
                throw new ApplicationException("Ocurrio un error al editar los datos");
            }
        }
    }
}
