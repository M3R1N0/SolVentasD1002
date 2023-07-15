using EntVenta;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVentas
{
    public class DashBoardDAL
    {
        public static List<VentasPorPeriodo> Listar_PorPeriodo(DateTime fechaInicio, DateTime fechaFin, string periodo)
        {
            try
            {
                List<VentasPorPeriodo> lst = new List<VentasPorPeriodo>();
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    var strQuery = (fechaInicio == fechaFin) ? "sp_VentasPorPeriodo_Total" : "sp_VentasPorPeriodo";
                    con.Open();
                    using (SqlCommand command = new SqlCommand(strQuery, con))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);
                        command.Parameters.AddWithValue("@tipoFiltro", periodo);

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            VentasPorPeriodo v = new VentasPorPeriodo();
                            v.Fecha = reader.GetString(0);
                            v.Total = reader.GetDecimal(1);

                            lst.Add(v);
                        }
                    }
                    con.Close();
                }
                return  lst;
            }
            catch (Exception ex)
            {
                return new List<VentasPorPeriodo>();
            }
        }

        public static List<VentasPorPeriodo> Top10_Productos(DateTime fechaInicio, DateTime fechaFin, int rango)
        {
            try
            {
                List<VentasPorPeriodo> lst = new List<VentasPorPeriodo>();
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("[sp_TopProductos]", con))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);
                        command.Parameters.AddWithValue("@rango", rango);

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            VentasPorPeriodo v = new VentasPorPeriodo();
                            v.Fecha = reader.GetString(0);
                            v.Total = reader.GetDecimal(1);

                            lst.Add(v);
                        }
                    }
                    con.Close();
                }
                return lst;
            }
            catch (Exception ex)
            {
                return new List<VentasPorPeriodo>();
            }
        }

        public static List<DashBoard> Grafica_CLientesFrecuents(DateTime fechaInicio, DateTime fechaFin, int rango)
        {
            try
            {
                List<DashBoard> lst = new List<DashBoard>();
                using (SqlConnection con = new SqlConnection(MasterConnection.connection))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("[sp_ClientesFrecuentes]", con))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);
                        command.Parameters.AddWithValue("@rango", rango);

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            DashBoard v = new DashBoard();
                            v.TotalClientes = reader.GetInt32(0);
                            v.Nombre = reader.GetString(1);

                            lst.Add(v);
                        }
                    }
                    con.Close();
                }
                return lst;
            }
            catch (Exception ex)
            {
                return new List<DashBoard>();
            }
        }
    }
}
