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

        public void AgregarCategoriasGenericas(CatalogoGenerico c , int valor)
        {
            int resultado = new DatCatGenerico().InsertarDatosCatalago(c, valor);
            if (resultado != 1)
            {
                throw new ApplicationException("Ocurrió un error al dar de alta la categoria, contacte al administrador");
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

        public List<CatalogoGenerico> ListarTipoPresentacion()
        {
            DataTable dt = DatCatGenerico.ListarCat_TipoPresentacion();
            List<CatalogoGenerico> catalogoGenericos = new List<CatalogoGenerico>();

            foreach (DataRow dr in dt.Rows)
            {
                CatalogoGenerico c = new CatalogoGenerico();
                c.Id = Convert.ToInt32(dr["Id_TipoPresentacion"]);
                c.Nombre = dr["Nombre"].ToString();
                c.Descripcion = dr["NombreCorto"].ToString();

                catalogoGenericos.Add(c);
            }

            return catalogoGenericos;
        }

     /**   public List<CatalogoGenerico> ListarCat_TipoUsuario()
        {
            DataTable dt = new DatCatGenerico().ListarCat_TipoUsuario();
            List<CatalogoGenerico> lsTipoUsuario = new List<CatalogoGenerico>();

            foreach (DataRow dataRow in dt.Rows)
            {
                CatalogoGenerico c = new CatalogoGenerico();

                c.Id = Convert.ToInt32(dataRow["Id_Rol"]);
                c.Nombre = dataRow["Nombre"].ToString();
                c.Descripcion = dataRow["Descripcion"].ToString();
                lsTipoUsuario.Add(c);
            }
            return lsTipoUsuario;
        }*/
    }
}
