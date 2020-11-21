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
    public class BusBox
    {

        public Box showBoxBySerial(string serial)
        {
            DataRow dr = new DatBox().selectBoxBySerial(serial);
            Box b = new Box();
            b.Id = Convert.ToInt32(dr["Id_Caja"].ToString());
            b.Descripcion = dr["Descripcion"].ToString();

            return b;
        }

        public void Agregar_Caja(Box b)
        {

            int filasAfectadas = new DatBox().Insertar_Caja(b);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrio un error al insertar");
            }
        }

        public void Actualizar_ImpresoraTicket(Box b)
        {
            int filasAfectadas = new DatBox().Actualizar_ImpresoraTicket(b);

            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrió un error al actualizar los datos");
            }
        }
    }
}
