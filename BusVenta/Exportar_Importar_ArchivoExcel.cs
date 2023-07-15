using BusVenta.Helpers;
using DatVentas;
using DevExpress.XtraWaitForm;
using EntVenta;
using LinqToExcel;
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
                        System.Data.DataRow row = data.NewRow();
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
                          "; Extended Properties = 'text;HDR=Yes;FMT=Delimited(,)'; ");

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
                int row = 3;

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
                            var lst = ProductoDAL.FiltrarProductos(string.Empty);

                            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                            using (ExcelPackage excel = new ExcelPackage())
                            {
                                var workSheet = excel.Workbook.Worksheets.Add("Productos");


                                workSheet.Cells["C1:F1"].Merge = true;
                                workSheet.Cells["G1:J1"].Merge = true;
                                workSheet.Cells["C1"].Value = "DATOS PRODUCTOS MAYOREO";
                                workSheet.Cells["G1"].Value = "DATOS PRODUCTOS MENUDEO";

                                workSheet.Cells["A2"].Value = "CODIGO";
                                workSheet.Cells["B2"].Value = "DESCRIPCION";
                                workSheet.Cells["C2"].Value = "PRESENTACION";
                                workSheet.Cells["D2"].Value = "PRECIO";
                                workSheet.Cells["E2"].Value = "PRECIO MAYOREO";
                                workSheet.Cells["F2"].Value = "A PARTIR DE";

                                workSheet.Cells["G2"].Value = "PRESENTACION U.";
                                workSheet.Cells["H2"].Value = "PRECIO U.";
                                workSheet.Cells["I2"].Value = "PRECIO MAYOREO U.";
                                workSheet.Cells["J2"].Value = "A PARTIR DE U.";

                                workSheet.Cells["A2:J2"].Style.Font.Bold = true;
                                workSheet.Column(2).Width = 50;
                                workSheet.Cells["C2:J2"].AutoFitColumns();
                                workSheet.Cells["A2:J2"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                workSheet.Cells["A2:J2"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(24, 169, 190));

                                foreach (ProductoVM p in lst)
                                {
                                    workSheet.Cells["C" + row + ":F" + row].Style.Numberformat.Format = "#,##0.00";
                                    workSheet.Cells["H" + row + ":J" + row].Style.Numberformat.Format = "#,##0.00";

                                    workSheet.Cells["A" + row].Value = p.codigo;
                                    workSheet.Cells["B" + row].Value = p.Articulo;
                                    workSheet.Cells["C" + row].Value = DatCatGenerico.ObtenerPresentacion(p.idPresentacion).Nombre;
                                    workSheet.Cells["D" + row].Value = p.Precio;
                                    workSheet.Cells["E" + row].Value = p.PrecioMayoreo;
                                    workSheet.Cells["F" + row].Value = p.A_Partir_De;

                                    workSheet.Cells["G" + row].Value = DatCatGenerico.ObtenerPresentacion(p.IdPresentacionU).Nombre;
                                    workSheet.Cells["H" + row].Value = p.PrecioU;
                                    workSheet.Cells["I" + row].Value = p.PrecioMayoreoU;
                                    workSheet.Cells["J" + row].Value = p.A_Partir_DeU;

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

        public static  Respuesta ExportarHistorial_VentasCliente(int idCliente, string cliente)
        {
            Respuesta respuesta = new Respuesta(0,"","");
            try
            {
                
                SaveFileDialog saveFile = new SaveFileDialog();
                string fileName = "Historial Ventas_"+cliente.ToLowerInvariant();
                string saveFilter = "Libro de Excel (*.xlsx)";
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

                                try
                                {
                                    var logo = DatEmpresa.ObtenerLogoEmpresa();
                                    var excelImg = workSheet.Drawings.AddPicture("My Logo", logo);
                                    excelImg.SetSize(25);
                                    excelImg.SetPosition(0, 0, 0, 0);
                                }
                                catch (Exception)
                                {
                                }

                                workSheet.Cells["A1"].Value = new BusEmpresa().ObtenerEmpresa().Nombre;
                                workSheet.Cells["A1:F1"].Style.Font.Color.SetColor(Color.FromArgb(12, 45, 236));
                                workSheet.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                workSheet.Cells["A1:F1"].Style.Font.Bold = true;
                                workSheet.Cells["A1:F1"].Style.Font.Size = 20;
                                workSheet.Cells["A1:F1"].Merge = true;
                                
                                workSheet.Cells["B3"].Value = "CLAVE : ";
                                workSheet.Cells["B4"].Value = "CLIENTE : ";
                                workSheet.Cells["B5"].Value = "COMUNIDAD : ";
                                workSheet.Cells["E4"].Value = "N° VENTAS REALIZADAS : ";
                                workSheet.Cells["E5"].Value = "TOTAL COMPRADO : ";

                                workSheet.Cells["F4"].Value = dt.Rows.Count;
                                workSheet.Cells["F5"].Value = dt.AsEnumerable().Select(X => X.Field<decimal>("Monto_Total")).Sum();
                                workSheet.Cells["F5"].Style.Numberformat.Format = "$#,###.00";

                                workSheet.Cells["C3"].Value = dtDatos.Select(x => x.Clave).FirstOrDefault(); 
                                workSheet.Cells["C4"].Value = dtDatos.Select(x => x.Nombre).FirstOrDefault();
                                workSheet.Cells["C5"].Value = dtDatos.Select(x => x.Comunidad).FirstOrDefault();

                                workSheet.Cells["A3:A5"].Style.Font.Bold = true;
                                workSheet.Cells["A3:A5"].Style.Font.Size = 12;
                                workSheet.Cells["B3:B5"].Style.Font.Bold = true;
                                workSheet.Cells["B3:B5"].Style.Font.Size = 12;

                                workSheet.Cells["E3:E5"].Style.Font.Bold = true;
                                workSheet.Cells["E3:E5"].Style.Font.Size = 12;
                                workSheet.Cells["F3:F5"].Style.Font.Bold = true;
                                workSheet.Cells["F3:F5"].Style.Font.Size = 12;

                                workSheet.Cells["A7"].Value = "FECHA VENTA";
                                workSheet.Cells["B7"].Value = "FOLIO VENTA";
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

                                foreach (System.Data.DataRow dr in dt.Rows)
                                {
                                    workSheet.Cells["A" + row].Value = (dr["Fecha_Venta"]);
                                    workSheet.Cells["A" + row].Style.Numberformat.Format = "dd/MM/yyy HH:mm";

                                    workSheet.Cells["B" + row].Value = (dr["Folio"]);
                                    workSheet.Cells["C" + row].Value = (dr["Forma_Pago"]);
                                    workSheet.Cells["D" + row].Value = (dr["Estado_Pago"]);
                                    workSheet.Cells["E" + row].Value = (dr["Accion"]);
                                    workSheet.Cells["F" + row].Value = (dr["Monto_Total"]);
                                    workSheet.Cells["F" + row].Style.Numberformat.Format = "$#,##0.00";
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

        public static void ExportarExcel_Actualizacion(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
               
                SaveFileDialog saveFile = new SaveFileDialog();
                string fileName = "ActualizacionProducto_" + DateTime.Now.ToString("ddMMyyyy");
                string saveFilter = "(*.xlsx) || *.xlsx";
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
                           var lstProducto = ProductoDAL.Consultar_ProductosActualizados(fechaInicio, fechaFin);

                            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                            using (ExcelPackage excel = new ExcelPackage())
                            {
                                var workSheet = excel.Workbook.Worksheets.Add("Productos");

                                workSheet.Cells["A1"].Value = "CLAVE";
                                workSheet.Cells["B1"].Value = "PROVEEDOR";
                                workSheet.Cells["C1"].Value = "MARCA";
                                workSheet.Cells["D1"].Value = "CATEGORIA";
                                workSheet.Cells["E1"].Value = "PRESENTACION";
                                workSheet.Cells["F1"].Value = "CODIGO";
                                workSheet.Cells["G1"].Value = "ARTICULO";
                                workSheet.Cells["H1"].Value = "DETALLE";
                                workSheet.Cells["I1"].Value = "PRECIO COMPRA";
                                workSheet.Cells["J1"].Value = "PRECIO VENTA";
                                workSheet.Cells["K1"].Value = "VENTA MAYOREO";
                                workSheet.Cells["L1"].Value = "A PARTIR DE";
                                workSheet.Cells["M1"].Value = "TIPO VENTA";
                                workSheet.Cells["N1"].Value = "USA INVENTARIO";
                                workSheet.Cells["O1"].Value = "STOCK MINIMO";
                                workSheet.Cells["P1"].Value = "CADUCIDAD";
                                workSheet.Cells["Q1"].Value = "UNIDADES POR PRESENTACION";
                                workSheet.Cells["R1"].Value = "TIPO";
                                workSheet.Cells["S1"].Value = "CLAVE PRODUCTO";
                                workSheet.Cells["T1"].Value = "PESO";

                                workSheet.Cells["A1:T1"].Style.Font.Bold = true;
                               // workSheet.Column(5).Width = 50;
                                workSheet.Cells["A1:T1"].AutoFitColumns();
                                workSheet.Cells["A1:T1"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                workSheet.Cells["A1:T1"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(24, 169, 190));

                                foreach (var item in lstProducto)
                                {
                                    workSheet.Cells["A" + row].Value = item.Id ;
                                    workSheet.Cells["B" + row].Value = item.Proveedor;
                                    workSheet.Cells["C" + row].Value = item.Marca ;
                                    workSheet.Cells["D" + row].Value = item.Categoria;
                                    workSheet.Cells["E" + row].Value = item.Presentacion;
                                    workSheet.Cells["F" + row].Value = item.codigo;
                                    workSheet.Cells["G" + row].Value = item.Articulo;
                                    workSheet.Cells["H" + row].Value = item.Detalle;
                                    workSheet.Cells["I" + row].Value = string.Format("{0:N2}", item.PrecioCompra);
                                    workSheet.Cells["J" + row].Value = string.Format("{0:N2}", item.Precio);
                                    workSheet.Cells["K" + row].Value = string.Format("{0:N2}", item.PrecioMayoreo);
                                    workSheet.Cells["L" + row].Value = string.Format("{0:N2}", item.A_Partir_De);
                                    workSheet.Cells["M" + row].Value = item.TipoVenta;
                                    workSheet.Cells["N" + row].Value = item.UsaInventario;
                                    workSheet.Cells["O" + row].Value = string.Format("{0:N2}", item.StockMinimo);
                                    workSheet.Cells["P" + row].Value = item.Caducidad.ToShortDateString();
                                    workSheet.Cells["Q" + row].Value = string.Format("{0:N2}", item.UnidadesPorPresentacion);
                                    workSheet.Cells["R" + row].Value = item.Venta;
                                    workSheet.Cells["S" + row].Value = item.Clave;
                                    workSheet.Cells["T" + row].Value = string.Format("{0:N2}", item.Peso);

                                    row++;
                                }

                                FileStream fileStream = File.Create(saveFile.FileName);
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

        public static OperationResponse ReadExcel(string pathFile)
        {
            try
            {
                var lista = new List<ProductoVM>();
                int iRow=2;
                string strRange = "";
                string [] arrColumns =  { "A", "B", "C", "D", "E", "F","G","H","I","J","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
                                         ,"AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ"
                                         ,"BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BL","BM","BN","BO","BP","BQ","BR","BS","BT","BU","BV","BW","BX","BY","BZ"
                                         ,"CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CL","CM","CN","CO","CP","CQ","CR","CS","CT","CU","CV","CW","CX","CY","CZ" } ;

                #region Lectura anterior
                /*var _excel = new ExcelQueryFactory(pathFile);

                        List<Producto> _data = (from r in _excel.Worksheet("Productos")

                        let item = new Producto
                        {
                            Id = r["Id"].Cast<int>(),
                            IdCategoria = r["IdCategoria"].Cast<int>(),
                            IdTipoPresentacion = r["IdTipoPresentacion"].Cast<int>(),
                            codigo = r["codigo"].Cast<string>(),
                            Descripcion = r["Descripcion"].Cast<string>(),
                            Presentacion = r["Presentacion"].Cast<string>(),
                            seVendeA = r["seVendeA"].Cast<string>(),
                            precioMenudeo = r["precioMenudeo"].Cast<decimal>(),
                            precioMMayoreo = r["precioMMayoreo"].Cast<decimal>(),
                            APartirDe = r["APartirDe"].Cast<decimal>(),
                            precioMayoreo = r["precioMayoreo"].Cast<decimal>(),
                            usaInventario = r["usaInventario"].Cast<string>(),
                            stock = r["stock"].Cast<string>(),
                            stockMinimo = r["stockMinimo"].Cast<decimal>(),
                            Caducidad = r["Caducidad"].Cast<string>(),
                            Estado = r["Estado"].Cast<bool>(),
                            TotalUnidades = r["TotalUnidades"].Cast<decimal>(),
                            PresentacionMenudeo = r["PresentacionMenudeo"].Cast<string>(),
                        } select item).ToList();

                        return _data;*/
                #endregion

                FileInfo file = new FileInfo(pathFile);

                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (ExcelPackage excel = new ExcelPackage(file))
                {
                    ExcelWorksheet worksheet;
                    worksheet = excel.Workbook.Worksheets[0];
                    strRange = "A" + iRow.ToString();

                    var columnCount = worksheet.Dimension.End.Column;
                    var rowCount = worksheet.Dimension.End.Row;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        ProductoVM item = new ProductoVM();
                        item.Id =Convert.ToInt32( worksheet.Cells[$"A{row}"].Value);
                        item.Proveedor = worksheet.Cells[$"B{row}"].Value?.ToString().Trim();
                        item.Marca = worksheet.Cells[$"C{row}"].Value?.ToString().Trim();
                        item.Categoria = worksheet.Cells[$"D{row}"].Value?.ToString().Trim();
                        item.Presentacion = worksheet.Cells[$"E{row}"].Value?.ToString().Trim();
                        item.codigo = worksheet.Cells[$"F{row}"].Value?.ToString().Trim();
                        item.Articulo = worksheet.Cells[$"G{row}"].Value?.ToString().Trim();
                        item.Detalle = worksheet.Cells[$"H{row}"].Value?.ToString().Trim();
                        item.PrecioCompra = Convert.ToDecimal(worksheet.Cells[$"I{row}"].Value);
                        item.Precio = Convert.ToDecimal(worksheet.Cells[$"J{row}"].Value);
                        item.PrecioMayoreo = Convert.ToDecimal(worksheet.Cells[$"K{row}"].Value);
                        item.A_Partir_De = Convert.ToDecimal(worksheet.Cells[$"L{row}"].Value);
                        item.TipoVenta = worksheet.Cells[$"M{row}"].Value?.ToString().Trim();
                        item.UsaInventario =Convert.ToBoolean( worksheet.Cells[$"N{row}"].Value);
                        item.StockMinimo = Convert.ToDecimal(worksheet.Cells[$"O{row}"].Value);
                        item.Caducidad = Convert.ToDateTime(worksheet.Cells[$"P{row}"].Value);
                        item.UnidadesPorPresentacion = Convert.ToDecimal(worksheet.Cells[$"Q{row}"].Value);
                        item.Venta = worksheet.Cells[$"R{row}"].Value?.ToString().Trim();
                        item.Clave = worksheet.Cells[$"S{row}"].Value?.ToString().Trim();
                        item.Peso = Convert.ToDecimal( worksheet.Cells[$"T{row}"].Value);

                        lista.Add(item);
                    }

                }

                return OperationResponse.Success("Proceso completado", lista);
            }
            catch (Exception ex)
            {
                return OperationResponse.Failure(ex.Message);
            }
        }

    }
}
