using BusVenta.Helpers;
using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusVenta
{
   public class BusUser
    {
        public List<User> getUsersList(User u)
        {
            DataTable dt = new DataTable();
            dt = new DatUser().getUsers(u);
            List<User> lstUser = new List<User>();

            foreach (DataRow dr in dt.Rows)
            {
                User user = new User();
                user.Id = Convert.ToInt32(dr["Id_Usuario"].ToString());
                user.Nombre = dr["Nombre"].ToString();
                user.Apellidos = dr["Apellidos"].ToString();
                user.Direccion = dr["Localidad"].ToString();
                user.Foto = (byte[])dr["Foto"];
                user.NombreFoto = dr["Nombre_Foto"].ToString();
                user.Usuario = dr["Usuario"].ToString();
                user.Contraseña = dr["Contrasenia"].ToString();
                user.Correo = dr["Correo"].ToString();
                user.RolID = Convert.ToInt32(dr["Rol_Id"]);
                user.Estado = Convert.ToBoolean(dr["Estado"].ToString());
                user.Rol = dr["Rol"].ToString();

                lstUser.Add(user);
            }
            return lstUser;
        }

        public List<User> ListarUsuarios()
        {
            DataTable dt = new DataTable();
            dt = new DatUser().MostrarUsuarios();
            List<User> lstUser = new List<User>();

            foreach (DataRow dr in dt.Rows)
            {
                User user = new User();
                user.Id = Convert.ToInt32(dr["Id_Usuario"].ToString());
                user.Nombre = dr["Nombre"].ToString();
                user.Apellidos = dr["Apellidos"].ToString();
                user.Direccion = dr["Localidad"].ToString();
                user.Foto = (byte[])dr["Foto"];
                user.NombreFoto = dr["Nombre_Foto"].ToString();
                user.Usuario = dr["Usuario"].ToString();
                user.Contraseña = dr["Contrasenia"].ToString();
                user.Correo = dr["Correo"].ToString();
                user.RolID = Convert.ToInt32(dr["Rol_Id"]);
                user.Estado = Convert.ToBoolean(dr["Estado"].ToString());

                lstUser.Add(user);
            }
            return lstUser;
        }

        public void AddUser(User u)//string nombre, string direccion, string usuario, string contraseña, byte[] foto, string nombreFoto, string correo, string rol, bool estado)
        {

            int filasAfectadas = new DatUser().AddUser(u);//nombre, direccion,usuario, contraseña, foto, nombreFoto, correo, rol, estado);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrio un error al insertar");
            }
        }

        public void DeleteUser(User u)
        {
            int filasAfectadas = new DatUser().DeleteUser(u);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrio un error al insertar");
            }
        }

        public void EditUser(User u)
        {
            int filasAfectadas = new DatUser().EditUser(u);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Ocurrió un error al editar");
            }
        }

        public string ShowPermision(string user)
        {
            string user1 = new DatUser().ShowPremission(user);
            return user1;
        }

        public User ObtenerUsuario(string serialPC)
        {
            DataRow dr = new DatCatGenerico().Obtener_InicioSesion(serialPC);
            User u = new User();
            u.Id = Convert.ToInt32(dr["Usuario_Id"]);
            u.Foto = (byte[])dr["Foto"];
            
            u.Rol = dr["Tipo_Usuario"].ToString();
            u.Nombre = dr["Nombre"].ToString();
            
            return u;
        }

        //=============================================================================================================

        public static bool ValidarPerfil_Usuario()
        {
            try
            {
                string serialPC = Sistema.ObenterSerialPC();
                User user = new BusUser().ObtenerUsuario(EncriptarTexto.Encriptar(serialPC));

                if (String.Equals(user.Rol,"ADMINISTRADOR", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
