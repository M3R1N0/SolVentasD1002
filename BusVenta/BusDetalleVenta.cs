using BusVenta.Helpers;
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
    public class BusDetalleVenta
    {
        public static bool Agregar_DetalleVenta(DetalleVenta detalleVenta)
        {
            int filasAfectadas = new DatDetalleVenta().Insertar_DetalleVenta(detalleVenta);

            if (filasAfectadas == 0)
            {
                return false;
                throw new ApplicationException("Ocurrió un error al Insertar la venta");
            }
            return true;
        }

        public void Agregar_DetalleVentaEspera(DetalleVentaEspera detalleVentaEspera)
        {
            int filasAfectadas = new DatDetalleVenta().Insertar_DetalleVentaEspera(detalleVentaEspera);

            if (filasAfectadas == 0)
            {
                throw new ApplicationException("Ocurrió un error al Insertar la venta");
            }
        }

        public static OperationResponse Eliminar_DetalleVenta(int id)
        {
            var detalleEliminado = new DatDetalleVenta().Eliminar_DetalleVenta(id);

            if (!detalleEliminado)
            {
                return OperationResponse.Failure("Ocurrió un detalle al eliminar los datos del detalle la venta");
            }
            else
            {
                return OperationResponse.Success("Operación exitosa");
            }
        }

        public List<DetalleVenta> ListarDetalleVenta_PorCobrar(int idVenta)
        {
            DataTable dt = new DatDetalleVenta().ObtenerDetalle_VentaPendiente(idVenta);
            List<DetalleVenta> _lstDetalle = new List<DetalleVenta>();

            foreach (DataRow dr in dt.Rows)
            {
                DetalleVenta dv = new DetalleVenta();
                dv.Id = Convert.ToInt32(dr["Id_DetalleVenta"]);
                dv.IdVenta = Convert.ToInt32(dr["Venta_Id"]);
                dv.IdProducto = Convert.ToInt32(dr["Producto_Id"]);
                dv.Cantidad = Convert.ToDecimal(dr["Cantidad"]);
                dv.Precio = Convert.ToDecimal(dr["Precio"]);
                dv.TotalPago = Convert.ToDecimal(dr["Total_Pagar"]);
                dv.UnidadMedida = dr["Unidad_Medida"].ToString();
                dv.CantidaMostrada = Convert.ToDecimal(dr["Cantidad_Mostrada"]);
                dv.Estado = Convert.ToString(dr["Estado"]);
                dv.Descripcion = dr["Descripcion"].ToString();
                dv.Codigo = dr["Codigo"].ToString();
                dv.Stock = dr["Stock"].ToString();

                _lstDetalle.Add(dv);
            }

            return _lstDetalle;
        }
    }
}
