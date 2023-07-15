using EntVenta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVentas
{
   public class DatUser
    {
        public static string AUX_CONEXION;

        public DataTable getUsers(User u)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("EXEC sp_Mostrar_Usuario '" + u.Usuario + "' , '"+u.Contraseña+"'", conn);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception )
                {
                    conn.Close();
                   // throw ex;
                }
                return dt;
            }
        }

        public  int AddUser(User u)
        {
            using (SqlConnection conn  = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_insertar_usuario", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@nombre",u.Nombre);
                    sc.Parameters.AddWithValue("@apellidos", u.Apellidos);
                    sc.Parameters.AddWithValue("@localidad",u.Direccion);
                    sc.Parameters.AddWithValue("@foto", u.Foto);
                    sc.Parameters.AddWithValue("@nombre_foto", u.NombreFoto);
                    sc.Parameters.AddWithValue("@usuario",u.Usuario);
                    sc.Parameters.AddWithValue("@contrasenia",u.Contraseña);
                    sc.Parameters.AddWithValue("@correo",u.Correo);
                    sc.Parameters.AddWithValue("@rol",u.IdRol);
                    sc.Parameters.AddWithValue("@estado", true);
                    resultado = sc.ExecuteNonQuery();
                    conn.Close();
                    return resultado;
                }                               
                catch (Exception ex)            
                {
                    conn.Close();
                    throw ex;
                }
            }
        }

        public int DeleteUser(User u)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("UPDATE  tb_Usuario  SET  Estado = 0 WHERE Id_Usuario = '"+u.Id+"'", conn);
                    resultado = sc.ExecuteNonQuery();
                    conn.Close();
                    return resultado;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw ex;
                }
            }
        }
        
        public int EditUser(User u)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    int resultado = 0;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("sp_editar_usuario", conn);
                    sc.CommandType = CommandType.StoredProcedure;
                    sc.Parameters.AddWithValue("@idusuario", u.Id);
                    sc.Parameters.AddWithValue("@nombre", u.Nombre);
                    sc.Parameters.AddWithValue("@apellidos", u.Apellidos);
                    sc.Parameters.AddWithValue("@localidad", u.Direccion);
                    sc.Parameters.AddWithValue("@foto", u.Foto);
                    sc.Parameters.AddWithValue("@nombre_foto", u.NombreFoto);
                    sc.Parameters.AddWithValue("@usuario", u.Usuario);
                    sc.Parameters.AddWithValue("@contrasenia", u.Contraseña);
                    sc.Parameters.AddWithValue("@correo", u.Correo);
                    sc.Parameters.AddWithValue("@rol", u.IdRol);
                    sc.Parameters.AddWithValue("@estado", true);
                    resultado = sc.ExecuteNonQuery();
                    conn.Close();
                    return resultado;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw ex;
                }
            }
        }

        public string ShowPremission(string user)
        {
            using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
            {
                try
                {
                    string resultado;
                    conn.Open();
                    SqlCommand sc = new SqlCommand("SELECT  TU.Nombre AS Rol FROM tb_Usuario U INNER JOIN Cat_Tipo_Usuario TU ON TU.Id_Rol = U.Rol_Id  WHERE U.Usuario='" + user + "' AND U.Estado = 1", conn);
                    resultado = sc.ExecuteScalar().ToString();
                    conn.Close();
                    return resultado;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw ex;
                }
            }
        }

        public DataTable MostrarUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(MasterConnection.connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tb_Usuario", conn);
                    da.Fill(dt);
                    AUX_CONEXION = "CORRECTO";
                }
            }
            catch
            {
                AUX_CONEXION = "INCORRECTO";
            }
                return dt;
        }

        public static User Validate_UserCredentials(string username, string password)
        {
            User user = new User();
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("ValidateUser",con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Usuario",username);
                        cmd.Parameters.AddWithValue("@contraseña", password);

                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            user.Id = reader.GetInt32(0);
                            user.IdRol = reader.GetInt32(1);
                            user.Nombre = reader.GetString(2);
                            user.Apellidos = reader.GetString(3);
                            user.Direccion = reader.GetString(4);
                            user.Correo = reader.GetString(5);
                            user.Usuario = reader.GetString(6);
                            user.Contraseña = reader.GetString(7);
                        }
                    }
                    con.Close();
                }
                return user;
            }
            catch (Exception)
            {
                return new User();
            }
        }

        public static bool ReestablecerContraseña(int idUsuario, string pwd)
        {
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("UPDATE tb_Usuario SET Contrasenia = @pwd WHERE Id_Usuario = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@pwd", pwd);
                        cmd.Parameters.AddWithValue("@id", idUsuario);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ActualizarPerfilUsuario(User u)
        {
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("UPDATE tb_Usuario SET Rol_Id = @idRol WHERE Id_Usuario = @idUsuario", con))
                    {
                        cmd.Parameters.AddWithValue("@idRol", u.IdRol);
                        cmd.Parameters.AddWithValue("@idUsuario", u.Id);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static  User ObtenerUsuario(int id)
        {
            try
            {
                User user = null;
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("SELECT * FROM tb_Usuario WHERE Id_Usuario= @id",con))
                    {
                        cmd.Parameters.AddWithValue("@id",id);
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            user = new User();
                            user.Id = reader.GetInt32(0);
                            user.Nombre = reader.GetString(1);
                            user.Apellidos = reader.GetString(2);
                            user.Direccion = reader.GetString(3);
                            user.Foto = reader.GetSqlBytes(4).Buffer;
                            user.NombreFoto = reader.GetString(5);
                            user.Usuario = reader.GetString(6);
                            user.Contraseña = reader.GetString(7);
                            user.Correo = reader.GetString(8);
                            user.IdRol = reader.GetInt32(9);
                        }

                    }
                    con.Close();

                    return user;
                }
            }
            catch (Exception)
            {
                return new User();
            }
        }
    }
}
