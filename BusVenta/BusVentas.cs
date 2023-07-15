using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusVenta.Helpers;

namespace BusVenta
{
    public class BusVentas
    {
        public static int AgregarVenta(Venta venta)
        {
            return new DatVenta().InsertarVenta(venta);
           
        }

        public static OperationResponse Eliminar_Venta(int id)
        {
             var respuesta = BusDetalleVenta.Eliminar_DetalleVenta(id);

            if (respuesta.IsSuccess == EnumOperationResult.Failure)
            {
                return OperationResponse.Failure(respuesta.Message);
            }
            else
            {
                var ventaEliminada = new DatVenta().EliminarVenta(id);

                if (!ventaEliminada)
                {
                    return OperationResponse.Failure("Ocurrió un detalle al eliminar la venta, favor de revisar");
                }
                else
                {
                    return OperationResponse.Success("Operación exitosa");
                }
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

        public void Actualizar_VentaACredito(int idventa, decimal saldo, string estadoPago, decimal efectivo)
        {
            int _filasAfectadas = new DatVenta().Actualizar_CreditoPorPagar(idventa, saldo, estadoPago, efectivo);

            if (_filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrió un error al actualizar el crédito por pagar");
            }
        }

        //===================================================================================================================
        public static Respuesta ValidarTipoPrecio(string tipoVenta, Producto producto)
        {

            decimal precio = 0;
            string tipoPrecio = "";
            if (tipoVenta.Equals("MENUDEO"))
            {
                precio = producto.precioMenudeo;
                tipoPrecio = "Menudeo";
            }
            else if (tipoVenta.Equals("MEDIO MAYOREO"))
            {
                precio = producto.precioMMayoreo;
                tipoPrecio = "Medio Mayoreo";
            }
            else if (tipoVenta.Equals("MAYOREO"))
            {
                precio = producto.precioMayoreo;
                tipoPrecio = "Mayoreo";
            }

            if (precio == 0)
            {
                string mensaje = "El producto: " + producto.Descripcion + " no cuenta con precio " + tipoPrecio;
                return new Respuesta(0, "Precio no Disponible", mensaje);
            }
            else
            {
                return new Respuesta(1);
            }
        }

        public static void ValidarProducto(ref Producto producto, ref decimal precio, ref decimal _totalUnidades, ref string unidad, string tipoVenta)
        {

            try
            {
                producto.stock = (producto.stock.Equals("ILIMITADO") || string.IsNullOrEmpty(producto.stock)) ? "123456" : producto.stock;

                if (tipoVenta.Equals("MAYOREO"))
                {
                    //unidad = lsTipoPresentacion.Where(x => x.Id.Equals(tipoPresentacion)).Select(x => x.Descripcion).FirstOrDefault();
                    unidad = DatCatGenerico.ObtenerPresentacion(producto.IdTipoPresentacion).Descripcion;
                    precio = producto.precioMayoreo;
                    _totalUnidades = Convert.ToDecimal(producto.TotalUnidades);
                }

                if (tipoVenta.Equals("MEDIO MAYOREO"))
                {
                    //precio = lstProducto.Select(x => x.precioMMayoreo).FirstOrDefault();
                    precio = producto.precioMMayoreo;

                    if (producto.stock != "123456")
                    {
                        _totalUnidades = 1;
                    }

                    unidad = DatCatGenerico.Obtener_Presentacion_Abv(producto.PresentacionMenudeo);

                }

                if (tipoVenta.Equals("MENUDEO"))
                {
                    //precio = lstProducto.Select(x => x.precioMenudeo).FirstOrDefault();
                    precio = producto.precioMenudeo;

                    if (producto.stock != "123456")
                    {
                        _totalUnidades = 1;
                    }
                    unidad = DatCatGenerico.Obtener_Presentacion_Abv(producto.PresentacionMenudeo);
                }
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error al validar el producto : " + ex.Message);
            }
        }

        public static List<Venta> ObtenerDetalleCierre(DateTime fechaInicio)
        {
            List<Venta> lstVenta = new List<Venta>();

            List<CatalogoGenerico> lst = DatOpenCloseBox.ObtenerCajas_PorFecha(fechaInicio);

            foreach (CatalogoGenerico item in lst)
            {

            }


            return lstVenta;
        }

        //public static OperationResponse AgregarVentaInicial(Venta v)
        //{

        //}

    }

}
