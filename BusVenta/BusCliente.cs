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
    public class BusCliente
    {
        public void Agregar_Cliente(Cliente c)
        {

            int filasAfectadas = new DatCliente().Insertar_Cliente(c);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrio un error al insertar");
            }
        }

        public List<Cliente> ListarClientes(string nombre)
        {
            DataTable dt = new DatCliente().ObtenerClientes(nombre);
            List<Cliente> lsCientes = new List<Cliente>();

            foreach (DataRow dr in dt.Rows)
            {
                Cliente c = new Cliente();

                c.Id = Convert.ToInt32(dr["Id_Cliente"]);
                c.NombreCompleto = dr["Nombre"].ToString();
                c.Direccion = dr["Direccion"].ToString();
                c.Ruc = dr["Ruc"].ToString();
                c.Telefono = dr["Telefono"].ToString();
                c.Clientes = dr["Cliente"].ToString();
                c.Proveedor = dr["Proveedor"].ToString();
                c.Saldo = Convert.ToDecimal(dr["Saldo"].ToString());
                c.Estado = Convert.ToBoolean(dr["Estado"].ToString());

                lsCientes.Add(c);
            }
            return lsCientes;
        }

        public void eliminar_Cliente(int id)
        {

            int filasAfectadas = new DatCliente().BorrarCliente(id);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrio un error al borrar los datos");
            }
        }

        public void Editar_Cliente(Cliente c)
        {

            int filasAfectadas = new DatCliente().ActualizarCliente(c);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrio un error al editar los datos");
            }
        }
    }
}
