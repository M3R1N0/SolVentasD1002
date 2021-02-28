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

        public void AgregarVentaEspera(VentaEspera ventaEspera)
        {
            int filasAfectadas = new DatVenta().InsertarVentaEspera(ventaEspera);

            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrió un error al Insertar la venta");
            }
        }

        public List<VentaEspera> Listar_VentasEnEspera()
        {
            DataTable dt = new DatVenta().Obtener_VentasEnEspera();
            List<VentaEspera> lstVentas = new List<VentaEspera>();

            foreach (DataRow dr in dt.Rows)
            {
                VentaEspera v = new VentaEspera();
                v.Id = Convert.ToInt32(dr["Id"]);
                v.IdCliente = Convert.ToInt32(dr["ClienteId"]);
                v.IdUsuario = Convert.ToInt32(dr["UsuarioId"]);
                v.IdCaja = Convert.ToInt32(dr["CajaId"]);
                v.FechaVenta = Convert.ToDateTime(dr["Fecha"]);
                v.Referencia = dr["Referencia"].ToString();
                v.MontoTotal = Convert.ToDecimal (dr["MontoTotal"]);

                lstVentas.Add(v);
            }

            return lstVentas;
        }

        public  List<DetalleVentaEspera> ListarDetalle_VentaEnEspera(int idVenta)
        {
            DataTable dt = new DatDetalleVenta().ObtenerDetalle_VentaEnEspera(idVenta);
            List<DetalleVentaEspera> lstDetalle = new List<DetalleVentaEspera>();

            foreach (DataRow dr in dt.Rows)
            {
                DetalleVentaEspera detalle = new DetalleVentaEspera();
                detalle.IdPresentacion = Convert.ToInt32(dr["TipoPresentacionId"]);
                detalle.Id = Convert.ToInt32(dr["IdVenta_DetalleEspera"]);
                detalle.IdVenta = Convert.ToInt32(dr["VentaId"]);
                detalle.IdProducto = Convert.ToInt32(dr["ProductoId"]);
                detalle.Stock = dr["Stock"].ToString();
                detalle.UsaInventario = dr["UsaInventario"].ToString();
                detalle.Cantidad = Convert.ToDecimal(dr["Cantidad"]);
                detalle.UnidadMedida = dr["UnidadMedida"].ToString();
                detalle.Descripcion = Convert.ToString(dr["Producto"]);
                detalle.Precio = Convert.ToDecimal(dr["Precio"]);
                detalle.TotalPago = Convert.ToDecimal(dr["Importe"]);

                lstDetalle.Add(detalle);

            }

            return lstDetalle;
        }

        public void Eliminar_VentaEspera(int id)
        {
            int filasAfectadas = new DatVenta().EliminarVentaEspera(id);

            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrió un error al Insertar la venta");
            }
        }

        public List<Venta> Listar_VentasTotales(DateTime cierre, int idusuario, int idcaja)
        {
            DataTable dt = new DatVenta().ObtenerVenta_Total(cierre, idusuario, idcaja);
            List<Venta> lstVentas = new List<Venta>();

            foreach (DataRow dr in dt.Rows)
            {
                Venta v = new Venta();
                v.Id = Convert.ToInt32(dr["Id_Venta"]);
                v.MontoTotal = Convert.ToDecimal(dr["Monto_Total"]);
                v.FechaVenta = Convert.ToDateTime(dr["Fecha_Venta"]);
                v.FormaPago = dr["Forma_Pago"].ToString();
                v.EstadoPago = dr["Estado_Pago"].ToString();
                v.Saldo = Convert.ToDecimal(dr["Saldo"]);
                v.TipoPago = Convert.ToDecimal(dr["Saldo_EnCaja"]);

                lstVentas.Add(v);
            }

            return lstVentas;
        }

        public List<Venta> ListarVentas_PorCobrar(string buscar)
        {
            DataTable dt = new DatVenta().ObtenerVentas_PorCobrar(buscar);
            List<Venta> _lsVentas = new List<Venta>();

            foreach (DataRow dr in dt.Rows)
            {
                Venta v = new Venta();
                v.Id = Convert.ToInt32(dr["Id_Venta"]);
                v.IdCliente = Convert.ToInt32(dr["Cliente_Id"]);
                v.IdUsuario = Convert.ToInt32(dr["Usuario_Id"]);
                v.IdCaja = Convert.ToInt32(dr["Caja_Id"]);
                v.FechaVenta = Convert.ToDateTime(dr["Fecha_Venta"]);
                v.Folio = dr["Folio"].ToString();
                v.MontoTotal = Convert.ToDecimal(dr["Monto_total"]);
                v.FormaPago = dr["Forma_Pago"].ToString();
                v.Comprobante = dr["Comprobante"].ToString();
                v.FechaLiquidacion = dr["Fecha_Liquidacion"].ToString();
                v.Accion = dr["Accion"].ToString();
                v.Saldo = Convert.ToDecimal(dr["Saldo"]);
                v.TipoPago = Convert.ToDecimal(dr["Tipo_Pago"]);
                v.ReferenciaTarjeta = dr["Referencia_Tarjeta"].ToString();
                v.EstadoPago = dr["Estado_Pago"].ToString();
                v.Cliente = dr["Nombre"].ToString();

                _lsVentas.Add(v);
            }

            return _lsVentas;
        }

        public void Actualizar_VentaACredito(int idventa, decimal saldo, string estadoPago, decimal efectivo)
        {
            int _filasAfectadas = new DatVenta().Actualizar_CreditoPorPagar(idventa, saldo, estadoPago, efectivo);

            if (_filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrió un error al actualizar el crédito por pagar");
            }
        }
    }
}
