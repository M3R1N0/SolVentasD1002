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

        public void Borrar_Serializacion(int id)
        {
            int filasAfectadas = new DatSerializacion().EliminarComprobante(id);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrio un error al intentar eliminar los datos");
            }
        }

        public void Actualizar_Serializacion(Serializacion s)
        {
            int filasAfectadas = new DatSerializacion().EditarComprobante(s);
            if (filasAfectadas == 0)
            {
                throw new ApplicationException("Ocurrio un error al intentar actualizar los datos");
            }
        }

        public void Actualizar_numeroFin(string numeroFin, int id)
        {
            int filasAfectadas =  DatSerializacion.ActualizarFolio( numeroFin, id);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrio un error al intentar actualizar los datos");
            }
        }

        public List<Serializacion> ListarComprobantes()
        {
            DataTable dt = new DatSerializacion().ObtenerComprobantes();
            List<Serializacion> lstSerializacion = new List<Serializacion>();
            foreach (DataRow dr in dt.Rows)
            {
                Serializacion s = new Serializacion();
                s.Id = Convert.ToInt32(dr["Id_Serializacion"]);
                s.Serie = dr["Serie"].ToString();
                s.Cantidad_Numero = dr["Cantidad_Numeros"].ToString();
                s.NumeroFin = dr["Numero_Fin"].ToString();
                s.Destino = dr["Destino"].ToString();
                s.Tipo_Documento = dr["Tipo_Documento"].ToString();
                s.Por_Defecto = dr["Por_Defecto"].ToString();
                s.SerieCompleta = s.Serie + '-' + s.Cantidad_Numero + s.NumeroFin;

                lstSerializacion.Add(s);
            }

            return lstSerializacion;
        }
    }
}
