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
    public class BusCatGenerico
    {
        public void AgregarCategoria(string c, string pordefecto)
        {
            int resultado = new DatCatGenerico().InsertarCatalogo(c,pordefecto);
            if (resultado != 1 )
            {
                throw new ApplicationException("Ocurrió un error, contacte la administrador");
            }
        }
        
        public List<CatalogoGenerico> ListarCatProducto()
        {
            DataTable dt = new DatCatGenerico().MostrarCategorias();
            List<CatalogoGenerico> lsCat = new List<CatalogoGenerico>();

            foreach (DataRow dataRow in dt.Rows)
            {
                CatalogoGenerico c = new CatalogoGenerico();

                c.Id = Convert.ToInt32(dataRow["Id"]);
                c.Nombre = dataRow["Nombre"].ToString();
                c.Descripcion = dataRow["Por_Defecto"].ToString();
                lsCat.Add(c);
            }

            return lsCat;
        }

        public static OperationResponse AgregarCategoriasGenericas(CatalogoGenerico c , EnumTipoCatalogo TIPO_CATALOGO)
        {
            int valor = 0;
            switch (TIPO_CATALOGO)
            {
                case EnumTipoCatalogo.CATEGORIA:
                    valor = (Int32)EnumTipoCatalogo.CATEGORIA;
                    break;
                case EnumTipoCatalogo.PRESENTACION:
                    valor = (Int32)EnumTipoCatalogo.PRESENTACION;
                    break;
                case EnumTipoCatalogo.PROVEEDOR:
                    valor = (Int32)EnumTipoCatalogo.PROVEEDOR;
                    break;
                default:
                    valor = (Int32)EnumTipoCatalogo.MARCA;
                    break;
            }

            int resultado = new DatCatGenerico().InsertarDatosCatalago(c, valor);
            if (resultado != 1)
            {
               return OperationResponse.Failure("Ocurrió un detalle al dar de alta la categoria, contacte al administrador");
            }
            else
            {
                return OperationResponse.Success("Datos guardados correctamente");
            }
        }

        public void Agregar_TipoUsuario(CatalogoGenerico c)
        {
            int filasAfectadas = new DatCatGenerico().Insertar_TipoUsuario(c);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrio un error al insertar");
            }
        }

 
    }
}
