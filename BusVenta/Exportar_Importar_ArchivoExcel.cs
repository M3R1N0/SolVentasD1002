using BusVenta.Helpers;
using DatVentas;
using DevExpress.XtraWaitForm;
using EntVenta;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusVenta
{
    public static  class Exportar_Importar_ArchivoExcel
    {
        public static void Exportar(ref DataGridView gridView)
        {
            if (gridView.Rows.Count > 0)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "CSV(*.csv)|*.csv";
                string archivo = "ActualizacionProducto_" + DateTime.Now.ToString("ddMMyyyy");
                saveFile.FileName = archivo+".csv";
                bool fileError = false;

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFile.FileName))
                    {
                        try
                        {
                            File.Delete(saveFile.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No fué posible guardar los Datos : " + ex.Message);
                        }
                    }

                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = gridView.Columns.Count;
                            string strColumnNames = "";
                            string[] outputCSV = new string[gridView.Rows.Count + 1];

                            for (int i = 0; i < columnCount; i++)
                            {
                                strColumnNames += gridView.Columns[i].HeaderText.ToString() + ",";
                            }

                            outputCSV[0] += strColumnNames;

                            for (int i = 1; (i - 1) < gridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += gridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(saveFile.FileName, outputCSV, Encoding.UTF8);
                            MessageBox.Show("Datos exportados correctamente", "Operación Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error : " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para exportar");
                }
            }
        }

        public static DataTable CargarCSV(string pathFile)
        {
            DataTable data = new DataTable();
            try
            {
                string[] lines = System.IO.File.ReadAllLines(pathFile);

                if (lines.Length > 0)
                {
                    string firstLine = lines[0];
                    firstLine = firstLine.Remove(firstLine.Length - 1, 1);
                    string [] headerLabels = firstLine.Split(',');
                    foreach (var headerWord in headerLabels)
                    {
                        data.Columns.Add(new DataColumn(headerWord));
                    }

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] dataWords = lines[i].Split(',');
                        DataRow row = data.NewRow();
                        int columnIndex = 0;

                        foreach (var headerword in headerLabels)
                        {
                            row[headerword] = dataWords[columnIndex++];
                        }

                        data.Rows.Add(row);
                    }
                }



                return data;
            }
            catch (Exception ex)
            {
                return data;
                throw ex;
            }
        }

        public static DataTable Importar(string pathFile)
        {
            DataTable data = new DataTable();
            try
            {

                OleDbConnection conn = new OleDbConnection
                            ("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " +
                            Path.GetDirectoryName(pathFile) +
                            "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\"");

                conn.Open();


                OleDbDataAdapter adapter = new OleDbDataAdapter
                       ("SELECT * FROM " + Path.GetFileName(pathFile), conn);

                DataSet ds = new DataSet("Temp");
                adapter.Fill(ds);

                conn.Close();

                data = ds.Tables[0];
              

                return data;
            }
            catch (Exception ex)
            {
                return data;
                throw ex;
            }
        }

        public static void ExportarProducto()
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                string fileName = "Productos";
                string saveFilter = "CSV(*.xlsx) || *.xlsx";
                saveFile.FileName = fileName + ".xlsx";
                bool fileError = false;
                int row = 2;

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFile.FileName))
                    {
                        try
                        {
                            File.Delete(saveFile.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No fué posible guardar los Datos : " + ex.Message);
                        }
                    }

                    if (!fileError)
                    {
                        try
                        {
                            List<Producto> lst = DatProducto.ObtenerProductos();

                            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                            using (ExcelPackage excel = new ExcelPackage())
                            {
                                var workSheet = excel.Workbook.Worksheets.Add("Productos");

                                workSheet.Cells["A1"].Value = "DESCRIPCION";
                                workSheet.Cells["B1"].Value = "PRESENTACION";
                                workSheet.Cells["C1"].Value = "PRECIO MAYOREO";
                                workSheet.Cells["D1"].Value = "PRECIO MEDIO MAYOREO";
                                workSheet.Cells["E1"].Value = "A PARTIR DE";
                                workSheet.Cells["F1"].Value = "PRECIO MAYOREO";

                                workSheet.Cells["A1:F1"].Style.Font.Bold = true;
                                workSheet.Column(1).Width = 50;
                                workSheet.Cells["B1:F1"].AutoFitColumns();
                                workSheet.Cells["A1:F1"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                workSheet.Cells["A1:F1"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(24, 169, 190));

                                foreach (Producto p in lst)
                                {
                                    workSheet.Cells["C" + row + ":F" + row].Style.Numberformat.Format = "#,##0.00";

                                    workSheet.Cells["A" + row].Value = p.Descripcion;
                                    workSheet.Cells["B" + row].Value = p.Presentacion;
                                    workSheet.Cells["C" + row].Value = p.precioMenudeo;
                                    workSheet.Cells["D" + row].Value = p.precioMMayoreo;
                                    workSheet.Cells["E" + row].Value = p.APartirDe;
                                    workSheet.Cells["F" + row].Value = p.precioMayoreo;

                                    row ++;
                                }

                                FileStream fileStream = File.Create( saveFile.FileName);
                                excel.SaveAs(fileStream);
                                fileStream.Close();
                            }

                            MessageBox.Show("Datos exportados correctamente", "Operación Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error : " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para exportar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error ");
            }
        }

        public static  Respuesta ExportarHistorial_VentasCliente(int idCliente)
        {
            Respuesta respuesta = new Respuesta(0,"","");
            try
            {
                
                SaveFileDialog saveFile = new SaveFileDialog();
                string fileName = "Historial de Ventas";
                string saveFilter = "CSV(*.xlsx) || *.xlsx";
                saveFile.FileName = fileName + ".xlsx";
                bool fileError = false;
                int row = 8;

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFile.FileName))
                    {
                        try
                        {
                            File.Delete(saveFile.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                          respuesta = new Respuesta(0, "Error de nombre de archivo", "No fué posible guardar los Datos : "+ex.Message);
                         
                        }
                    }

                    if (!fileError)
                    {
                        try
                        {
                            DataTable dt = DatVenta.ListarReporteVentas_PorCliente(idCliente);

                            var dtDatos = from dr in dt.AsEnumerable()
                                          select new
                                          {
                                              Nombre = dr.Field<string>("Nombre"),
                                              Comunidad = dr.Field<string>("Direccion"),
                                              Clave = dr.Field<string>("Ruc"),
                                          };

                            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                            using (ExcelPackage excel = new ExcelPackage())
                            {
                                var workSheet = excel.Workbook.Worksheets.Add("Historial clientes");

                                workSheet.Cells["A1"].Value = "ABARROTES \" J I E L \"";
                                workSheet.Cells["A1:F1"].Style.Font.Color.SetColor(Color.FromArgb(12, 45, 236));
                                workSheet.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                workSheet.Cells["A1:F1"].Style.Font.Bold = true;
                                workSheet.Cells["A1:F1"].Style.Font.Size = 20;
                                workSheet.Cells["A1:F1"].Merge = true;
                                
                                workSheet.Cells["A3"].Value = "CLAVE : ";
                                workSheet.Cells["A4"].Value = "CLIENTE : ";
                                workSheet.Cells["A5"].Value = "COMUNIDAD : ";
                                workSheet.Cells["E4"].Value = "N° VENTAS REALIZADAS : ";
                                workSheet.Cells["E5"].Value = "TOTAL COMPRADO : ";

                                workSheet.Cells["F4"].Value = dt.Rows.Count;
                                workSheet.Cells["F5"].Value = dt.AsEnumerable().Select(X => X.Field<decimal>("Monto_Total")).Sum();
                                workSheet.Cells["F5"].Style.Numberformat.Format = "$#,###.00";

                                workSheet.Cells["B3"].Value = dtDatos.Select(x => x.Clave).FirstOrDefault(); 
                                workSheet.Cells["B4"].Value = dtDatos.Select(x => x.Nombre).FirstOrDefault();
                                workSheet.Cells["B5"].Value = dtDatos.Select(x => x.Comunidad).FirstOrDefault();

                                workSheet.Cells["A3:A5"].Style.Font.Bold = true;
                                workSheet.Cells["A3:A5"].Style.Font.Size = 12;
                                workSheet.Cells["B3:B5"].Style.Font.Bold = true;
                                workSheet.Cells["B3:B5"].Style.Font.Size = 12;

                                workSheet.Cells["E3:E5"].Style.Font.Bold = true;
                                workSheet.Cells["E3:E5"].Style.Font.Size = 12;
                                workSheet.Cells["F3:F5"].Style.Font.Bold = true;
                                workSheet.Cells["F3:F5"].Style.Font.Size = 12;

                                workSheet.Cells["A7"].Value = "FECHA VENTA";
                                workSheet.Cells["B7"].Value = "FOLIO";
                                workSheet.Cells["C7"].Value = "FORMA DE PAGO";
                                workSheet.Cells["D7"].Value = "ESTADO DE PAGO";
                                workSheet.Cells["E7"].Value = "ACCION";
                                workSheet.Cells["F7"].Value = "MONTO TOTAL";

                                workSheet.Cells["A7:F7"].Style.Font.Bold = true;
                                workSheet.Cells["B7:F7"].AutoFitColumns();
                                workSheet.Cells["A7:F7"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                workSheet.Cells["A7:F7"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(12, 45, 236));
                                workSheet.Cells["A7:F7"].Style.Font.Color.SetColor(Color.White);
                                workSheet.Column(1).Width = 20;
                                workSheet.Column(5).Width = 25;

                                foreach (DataRow dr in dt.Rows)
                                {
                                    workSheet.Cells["A" + row].Value = (dr["Fecha_Venta"]);
                                    workSheet.Cells["A" + row].Style.Numberformat.Format = "dd/MM/yyy HH:mm";

                                    workSheet.Cells["B" + row].Value = (dr["Folio"]);
                                    workSheet.Cells["C" + row].Value = (dr["Forma_Pago"]);
                                    workSheet.Cells["D" + row].Value = (dr["Estado_Pago"]);
                                    workSheet.Cells["E" + row].Value = (dr["Accion"]);
                                    workSheet.Cells["F" + row].Value = (dr["Monto_Total"]);
                                    workSheet.Cells["F" + row].Style.Numberformat.Format = "$#,###.00";
                                    row++;
                                }

                                FileStream fileStream = File.Create(saveFile.FileName);
                                excel.SaveAs(fileStream);
                                fileStream.Close();
                            }

                           respuesta = new Respuesta(1, "Operación Realizada", "Datos exportados correctamente");
                        }
                        catch (Exception ex)
                        {
                           respuesta = new Respuesta(0, "Error de exportacion", "Error : "+ex.Message);
                        }
                    }
                }
                else
                {
                    respuesta = new Respuesta(0, "Error de exportacion", "No hay datos para exportar");
                }
            }
            catch (Exception ex)
            {
                respuesta = new Respuesta(0, "Error de exportacion", "Ocurrió un error : "+ex.Message);
                MessageBox.Show(" ");
            }

            return respuesta;
        }
    }
}
