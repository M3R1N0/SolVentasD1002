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
   public class BusProducto
    {
        public void AgregarProducto(Producto p, Kardex k)
        {
            int resultado = new DatProducto().InsertarProducto( p, k);

          //  if (resultado != 2)
            //{
              //  throw new ApplicationException("Ocurrio un error, contacte al administrador");
            //}
        }

        public List<Producto> ListarProductos(string buscar, int bandera)
        {
            DataTable dt = new DatProducto().MostrarProductos(buscar, bandera);
            List<Producto> lsProductos = new List<Producto>();

            foreach (DataRow dr in dt.Rows)
            {
                Producto p = new Producto();
                p.Id = Convert.ToInt32(dr["Id_Producto"]);
                p.Descripcion = dr["Descripcion"].ToString();
                p.Presentacion = dr["Presentacion"].ToString();
                p.usaInventario = dr["Usa_Inventario"].ToString();
                p.stock = dr["Stock"].ToString();
                p.precioMenudeo = Convert.ToDecimal(dr["Precio_Menudeo"]);
                p.precioMMayoreo = Convert.ToDecimal(dr["Precio_MMayoreo"]);
                p.Caducidad = dr["Caducidad"].ToString();
                p.codigo = dr["Codigo"].ToString();
                p.seVendeA = dr["Tipo_Venta"].ToString();
                p.APartirDe = Convert.ToDecimal(dr["A_Partir_De"].ToString());
                p.stockMinimo = Convert.ToInt32(dr["Stock_Minimo"]);
                p.precioMayoreo = Convert.ToDecimal(dr["Precio_Mayoreo"]);
                p.IdTipoPresentacion = Convert.ToInt32(dr["Presentacion_Id"]);
                p.IdCategoria = Convert.ToInt32(dr["Catalogo_Id"]);
                p.TotalUnidades = Convert.ToDecimal(dr["TotalUnidades"] is DBNull ? 0 : dr["TotalUnidades"]);
                p.PresentacionMenudeo = Convert.ToString(dr["PresentacionMenudeo"]);
                p.Estado = Convert.ToBoolean(dr["Estado"]);
                p.Peso = Convert.ToDecimal(dr["Peso"] is DBNull ? 0 : dr["Peso"]);
                lsProductos.Add(p);
            }
            return lsProductos;
        }

        public Producto ObtenerProducto(string codigo)
        {
            DataRow dr = new DatProducto().ObtenerProducto(codigo);

                Producto p = new Producto();
                p.Id = Convert.ToInt32(dr["Id_Producto"]);
                p.Descripcion = dr["Descripcion"].ToString();
                p.Presentacion = dr["Presentacion"].ToString();
                p.usaInventario = dr["Usa_Inventario"].ToString();
                p.stock = dr["Stock"].ToString();
                p.precioMenudeo = Convert.ToDecimal(dr["Precio_Menudeo"]);
                p.precioMMayoreo = Convert.ToDecimal(dr["Precio_MMayoreo"]);
                p.Caducidad = dr["Caducidad"].ToString();
                p.codigo = dr["Codigo"].ToString();
                p.seVendeA = dr["Tipo_Venta"].ToString();
                p.APartirDe = Convert.ToDecimal(dr["A_Partir_De"].ToString());
                p.stockMinimo = Convert.ToInt32(dr["Stock_Minimo"]);
                p.precioMayoreo = Convert.ToDecimal(dr["Precio_Mayoreo"]);
                p.IdTipoPresentacion = Convert.ToInt32(dr["Presentacion_Id"]);
                p.IdCategoria = Convert.ToInt32(dr["Catalogo_Id"]);
                p.TotalUnidades = Convert.ToDecimal(dr["TotalUnidades"] is DBNull ? 0 : dr["TotalUnidades"]);
                p.PresentacionMenudeo = Convert.ToString(dr["PresentacionMenudeo"]);
                p.Estado = Convert.ToBoolean(dr["Estado"]);
              p.Peso = Convert.ToDecimal(dr["Peso"] is DBNull ? 0 : dr["Peso"]);

            return p;
        }

        public Producto ObtenerProducto_A_Actualizar(string codigo)
        {
            DataRow dr = new DatProducto().ObtenerProducto_Actualizado(codigo);

            Producto p = new Producto();
            p.Id = Convert.ToInt32(dr["Id_Producto"]);
            p.Descripcion = dr["Descripcion"].ToString();
            p.Presentacion = dr["Presentacion"].ToString();
            p.usaInventario = dr["Usa_Inventario"].ToString();
            p.stock = dr["Stock"].ToString();
            p.precioMenudeo = Convert.ToDecimal(dr["Precio_Menudeo"]);
            p.precioMMayoreo = Convert.ToDecimal(dr["Precio_MMayoreo"]);
            p.Caducidad = dr["Caducidad"].ToString();
            p.codigo = dr["Codigo"].ToString();
            p.seVendeA = dr["Tipo_Venta"].ToString();
            p.APartirDe = Convert.ToDecimal(dr["A_Partir_De"].ToString());
            p.stockMinimo = Convert.ToInt32(dr["Stock_Minimo"]);
            p.precioMayoreo = Convert.ToDecimal(dr["Precio_Mayoreo"]);
            p.IdTipoPresentacion = Convert.ToInt32(dr["Presentacion_Id"]);
            p.IdCategoria = Convert.ToInt32(dr["Catalogo_Id"]);
            p.TotalUnidades = Convert.ToDecimal(dr["TotalUnidades"] is DBNull ? 0 : dr["TotalUnidades"]);
            p.PresentacionMenudeo = Convert.ToString(dr["PresentacionMenudeo"]);
            p.Estado = Convert.ToBoolean(dr["Estado"]);

            return p;
        }

        public Producto ObtenerProducto_Descripcion(string descripcion)
        {
            DataRow dr = new DatProducto().ObtenerProducto(descripcion);

            Producto p = new Producto();
            p.Id = Convert.ToInt32(dr["Id_Producto"]);
            p.Descripcion = dr["Descripcion"].ToString();
            p.Presentacion = dr["Presentacion"].ToString();
            p.usaInventario = dr["Usa_Inventario"].ToString();
            p.stock = dr["Stock"].ToString();
            p.precioMenudeo = Convert.ToDecimal(dr["Precio_Menudeo"]);
            p.precioMMayoreo = Convert.ToDecimal(dr["Precio_MMayoreo"]);
            p.Caducidad = dr["Caducidad"].ToString();
            p.codigo = dr["Codigo"].ToString();
            p.seVendeA = dr["Tipo_Venta"].ToString();
            p.APartirDe = Convert.ToDecimal(dr["A_Partir_De"].ToString());
            p.stockMinimo = Convert.ToInt32(dr["Stock_Minimo"]);
            p.precioMayoreo = Convert.ToDecimal(dr["Precio_Mayoreo"]);
            p.IdTipoPresentacion = Convert.ToInt32(dr["Presentacion_Id"]);
            p.IdCategoria = Convert.ToInt32(dr["Catalogo_Id"]);
            p.TotalUnidades = Convert.ToDecimal(dr["TotalUnidades"] is DBNull ? 0 : dr["TotalUnidades"]);
            p.PresentacionMenudeo = Convert.ToString(dr["PresentacionMenudeo"]);
            p.Estado = Convert.ToBoolean(dr["Estado"]);
            p.Peso = Convert.ToDecimal(dr["Peso"] is DBNull ? 0 : dr["Peso"]);
            return p;
        }

        public void BorrarProducto(int id)
        {
            int filasAfectadas = new DatProducto().EliminarProducto(id);

            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrió un error, contacte al Administrador");
            }
        }

        public void ActualizarProducto( Producto p)
        {
            int filasAfectadas = new DatProducto().ActualizarProducto(p);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrió un error, contacte al Administrador");
            }
        }

        public List<Producto> ListarProductos_kardex(string buscar)
        {
            DataTable dt = new DatProducto().BuscarProducto_Kardex(buscar);
            List<Producto> lsProductos = new List<Producto>();

            foreach (DataRow dr in dt.Rows)
            {
                Producto p = new Producto();
                p.Id = Convert.ToInt32(dr["Id_Producto"]);
                p.IdCategoria = Convert.ToInt32(dr["Catalogo_Id"]);
                p.IdTipoPresentacion = Convert.ToInt32(dr["Presentacion_Id"]);
                p.codigo = dr["Codigo"].ToString();
                p.Descripcion = dr["Descripcion"].ToString();
                p.Presentacion = dr["Presentacion"].ToString();
                p.seVendeA = dr["Tipo_Venta"].ToString();
                p.precioMenudeo = Convert.ToDecimal(dr["Precio_Menudeo"]);
                p.precioMMayoreo = Convert.ToDecimal(dr["Precio_MMayoreo"]);
                p.APartirDe = Convert.ToDecimal(dr["A_Partir_De"].ToString());
                p.precioMayoreo = Convert.ToDecimal(dr["Precio_Mayoreo"]);
                p.usaInventario = dr["Usa_Inventario"].ToString();
                p.stock = dr["Stock"].ToString();
                p.stockMinimo = Convert.ToInt32(dr["Stock_Minimo"]);
                p.Caducidad = dr["Caducidad"].ToString();
                p.Estado = Convert.ToBoolean( dr["Estado"].ToString());
                p.Tipo_Presentacion = dr["Tipo_Presentacion"].ToString();
                p.Tipo_Catalogo = dr["Tipo_Catalogo"].ToString();
                p.PresentacionMenudeo = Convert.ToString(dr["PresentacionMenudeo"]);

                lsProductos.Add(p);
            }
            return lsProductos;
        }

        public List<Producto> MostrarInventario()
        {
            DataTable dt = new DatProducto().Mostrar_ProductoInvetario();
            List<Producto> lsProductos = new List<Producto>();

            foreach (DataRow dr in dt.Rows)
            {
                Producto p = new Producto();
                p.usaInventario = dr["Codigo"].ToString();
                p.Descripcion = dr["Producto"].ToString();
                p.stock = dr["Stock"].ToString();
                p.stockMinimo = Convert.ToInt32(dr["Stock_Minimo"]);
                p.precioMenudeo = Convert.ToDecimal(dr["Precio_Menudeo"]);
                p.precioMMayoreo = Convert.ToDecimal(dr["Precio_MMayoreo"]);
                p.precioMayoreo = Convert.ToDecimal(dr["Precio_Mayoreo"]);

                lsProductos.Add(p);
            }
            return lsProductos;
        }

        public int Productos_Vencidos()
        {
            int cantidad = new DatProducto().MostrarNotificacion_Vencimiento();

            if (cantidad == 0)
            {
                throw new ApplicationException("Error al mostrar los productos vencidos");
            }
            return cantidad;
        }

        public void Actualizar_Stock(int idProducto, decimal cantidad)
        {
            int filasAfectadas = new DatProducto().ActualizarStock(idProducto, cantidad);

            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocuríón un error al actualizar el stock");
            }
        }

        public static Producto ObtenerProducto_PorID(int id )
        {
            DataRow dr = new DatProducto().ObtenerProductoID(id);

            Producto p = new Producto();
            p.Id = Convert.ToInt32(dr["Id_Producto"]);
            p.Descripcion = dr["Descripcion"].ToString();
            p.Presentacion = dr["Presentacion"].ToString();
            p.usaInventario = dr["Usa_Inventario"].ToString();
            p.stock = dr["Stock"].ToString();
            p.precioMenudeo = Convert.ToDecimal(dr["Precio_Menudeo"]);
            p.precioMMayoreo = Convert.ToDecimal(dr["Precio_MMayoreo"]);
            p.Caducidad = dr["Caducidad"].ToString();
            p.codigo = dr["Codigo"].ToString();
            p.seVendeA = dr["Tipo_Venta"].ToString();
            p.APartirDe = Convert.ToDecimal(dr["A_Partir_De"].ToString());
            p.stockMinimo = Convert.ToInt32(dr["Stock_Minimo"]);
            p.precioMayoreo = Convert.ToDecimal(dr["Precio_Mayoreo"]);
            p.IdTipoPresentacion = Convert.ToInt32(dr["Presentacion_Id"]);
            p.IdCategoria = Convert.ToInt32(dr["Catalogo_Id"]);
            p.TotalUnidades = Convert.ToDecimal(dr["TotalUnidades"] is DBNull ? 0 : dr["TotalUnidades"]);
            p.PresentacionMenudeo = Convert.ToString(dr["PresentacionMenudeo"]);
            p.Estado = Convert.ToBoolean(dr["Estado"]);
            p.Peso = Convert.ToDecimal(dr["Peso"] is DBNull ? 0 : dr["Peso"]);

            return p;
        }

        public List<Producto> ListarProductos_Inactivos(string buscar)
        {
            DataTable dt = new DatProducto().MostrarProductos_Inactivos(buscar);
            List<Producto> lsProductos = new List<Producto>();

            foreach (DataRow dr in dt.Rows)
            {
                Producto p = new Producto();
                p.Id = Convert.ToInt32(dr["Id_Producto"]);
                p.Descripcion = dr["Descripcion"].ToString();
                p.Presentacion = dr["Presentacion"].ToString();
                p.usaInventario = dr["Usa_Inventario"].ToString();
                p.stock = dr["Stock"].ToString();
                p.precioMenudeo = Convert.ToDecimal(dr["Precio_Menudeo"]);
                p.precioMMayoreo = Convert.ToDecimal(dr["Precio_MMayoreo"]);
                p.Caducidad = dr["Caducidad"].ToString();
                p.codigo = dr["Codigo"].ToString();
                p.seVendeA = dr["Tipo_Venta"].ToString();
                p.APartirDe = Convert.ToDecimal(dr["A_Partir_De"].ToString());
                p.stockMinimo = Convert.ToInt32(dr["Stock_Minimo"]);
                p.precioMayoreo = Convert.ToDecimal(dr["Precio_Mayoreo"]);
                p.IdTipoPresentacion = Convert.ToInt32(dr["Presentacion_Id"]);
                p.IdCategoria = Convert.ToInt32(dr["Catalogo_Id"]);
                p.TotalUnidades = Convert.ToDecimal(dr["TotalUnidades"] is DBNull ? 0 : dr["TotalUnidades"]);
                p.PresentacionMenudeo = Convert.ToString(dr["PresentacionMenudeo"]);
                p.Estado = Convert.ToBoolean(dr["Estado"]);
                p.Peso = Convert.ToDecimal(dr["Peso"] is DBNull ? 0 : dr["Peso"]);
                lsProductos.Add(p);
            }
            return lsProductos;
        }

    }
}
