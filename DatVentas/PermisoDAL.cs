using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static EntVenta.PermisoVM;

namespace DatVentas
{
    public class PermisoDAL
    {
        public static void AgregarMenu(MenuVM menu)
        {
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("GuardarMenu",con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", menu.Id);
                        cmd.Parameters.AddWithValue("@nombre", menu.Nombre);
                        cmd.Parameters.AddWithValue("@icono", menu.Icono);

                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AgregarSubMenu(SubMenu menu)
        {
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("GuardarSubMenu", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", menu.Id);
                        cmd.Parameters.AddWithValue("@idMenu", menu.IdMenu);
                        cmd.Parameters.AddWithValue("@nombre", menu.Nombre);
                        cmd.Parameters.AddWithValue("@nombreForm", menu.NombreForm);
                        cmd.Parameters.AddWithValue("@icono", menu.Icono);

                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ListarMenu(ref ComboBox combo)
        {
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    using (var da = new SqlDataAdapter("SELECT Id, Nombre FROM Menu", con))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);

                        combo.DataSource = dt;
                        combo.ValueMember = "Id";
                        combo.DisplayMember = "Nombre";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ListarSubMenus(ref DataGridView grid)
        {
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    using (var da = new SqlDataAdapter("SELECT	M.Nombre as [MENU], SB.Nombre AS[SUB-MENU], SB.NombreFormulario AS [NOMBRE FORM] FROM SubMenu SB JOIN Menu M ON M.Id = SB.IdMenu", con))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Permiso> ListarPermiso(int idPerfil)
        {
            var lst = new List<Permiso>();
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand(@"SELECT p.Id	,p.IdSubMenu,SM.Nombre, p.Activo
                                                      FROM Permiso P
                                                      	JOIN SubMenu SM ON SM.Id = P.IdSubMenu
                                                      	JOIN Cat_Tipo_Usuario CP ON CP.Id_Rol = P.IdPerfil
                                                      WHERE CP.Id_Rol =@IdPerfil", con))
                    {
                        cmd.Parameters.AddWithValue("@IdPerfil", idPerfil);

                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Permiso sub = new Permiso();
                            sub.Id = reader.GetInt32(0);
                            sub.IdMenu = reader.GetInt32(1);
                            sub.Nombre = reader.GetString(2);
                            sub.Estado = reader.GetBoolean(3);

                            lst.Add(sub);
                        }
                    }
                    con.Close();
                }
                return  lst;
            }
            catch (Exception ex)
            {
                return new List<Permiso>();
            }
        }

        public static List<SubMenu> ListarSubMenu()
        {
            var lst = new List<SubMenu>();
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("SELECT * From SubMenu", con))
                    {
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SubMenu sub = new SubMenu();
                            sub.Id = reader.GetInt32(0);
                            sub.IdMenu = reader.GetInt32(1);
                            sub.Nombre = reader.GetString(2);
                            sub.NombreForm = reader.GetString(3);
                            //sub.Icono = reader.GetByte(4);

                            lst.Add(sub);
                        }
                    }
                    con.Close();
                }
                return lst;
            }
            catch (Exception ex)
            {
                return new List<SubMenu>();
            }
        }

        public static void GuardarConf_Permisos(int idPerfil, int idSubmenu, bool activo)
        {
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("GuardarPermiso", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdPerfil", idPerfil);
                        cmd.Parameters.AddWithValue("@IdSubMenu", idSubmenu);
                        cmd.Parameters.AddWithValue("@Activo", activo);

                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static List<Permiso> ListaPermisosMenu(int id, string modulos)
        {
            var Permiso = new List<Permiso>();
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    foreach (var item in modulos.Split(','))
                    {
                        con.Open();
                        using (var cmd = new SqlCommand("ConsultarPermisos_Menu", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@IdUsuario", id);
                            cmd.Parameters.AddWithValue("@menu", item);
                            var reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                Permiso menu = new Permiso();
                                menu.Modulo = reader.GetString(0);
                                menu.Nombre = reader.GetString(1);
                                menu.NombreForm = reader.GetString(2);
                                menu.Icono = reader.GetSqlBytes(3).Buffer;

                                Permiso.Add(menu);
                            }
                        }
                        con.Close();
                    }
                }
                return  Permiso;
            }
            catch (Exception ex)
            {
                return new List<Permiso>();
            }
        }

        public static List<Permiso> ObtenerFormsInternos(int id, string forms)
        {
            var Permiso = new List<Permiso>();
            try
            {
                using (var con = new SqlConnection(MasterConnection.connection))
                {
                    foreach (var item in forms.Split(','))
                    {
                        con.Open();
                        using (var cmd = new SqlCommand("ConsultarPermisos_FormInterno", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@IdUsuario", id);
                            cmd.Parameters.AddWithValue("@form", item);
                            var reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                Permiso menu = new Permiso();
                                menu.Modulo = reader.GetString(0);
                                menu.Nombre = reader.GetString(1);
                                menu.NombreForm = reader.GetString(2);
                                menu.Icono = reader.GetSqlBytes(3).Buffer;

                                Permiso.Add(menu);
                            }
                        }
                        con.Close();
                    }
                }
                return Permiso;
            }
            catch (Exception ex)
            {
                return new List<Permiso>();
            }
        }
    }
}
