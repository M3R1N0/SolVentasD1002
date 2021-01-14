using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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
    }
}
