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
    public  class DataTablePersonalizado
    {
        public static void Multilinea(ref DataGridView List)
        {
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            List.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);

            List.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
            styCabeceras.BackColor = System.Drawing.Color.LightSteelBlue;
            styCabeceras.ForeColor = System.Drawing.Color.Black;
            styCabeceras.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            List.ColumnHeadersDefaultCellStyle = styCabeceras;
            List.ClearSelection();

            List.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
        }

        public static void Multilinea2(ref DataGridView List)
        {
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            List.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI",12);
           

            List.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
            styCabeceras.BackColor = System.Drawing.Color.LightSteelBlue;
            styCabeceras.ForeColor = System.Drawing.Color.Black;
            styCabeceras.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            List.ColumnHeadersDefaultCellStyle = styCabeceras;
            //  List.ClearSelection();
            List.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            //List.FirstDisplayedScrollingRowIndex = List.RowCount - 1;
            //List.ClearSelection();
            //List.Rows[List.RowCount - 1].Selected = true;
        }

        public static void Leer_ArchivoExcel(ref DataGridView gridView, string FileName)
        {

            try
            {
                OleDbConnection conn = new OleDbConnection
                            ("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " +
                            Path.GetDirectoryName(FileName) +
                            "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\"");

                conn.Open();


                OleDbDataAdapter adapter = new OleDbDataAdapter
                       ("SELECT * FROM " + Path.GetFileName(FileName), conn);

                DataSet ds = new DataSet("Temp");
                adapter.Fill(ds);

                conn.Close();

                gridView.DataSource = ds;
                gridView.DataMember = "Table";

                Multilinea(ref gridView);

                gridView.Columns[0].Visible = false;
                gridView.Columns[1].Visible = false;
                gridView.Columns[2].Visible = false;
                gridView.Columns[12].Visible = false;
                gridView.Columns[13].Visible = false;
                gridView.Columns[14].Visible = false;
                gridView.Columns[15].Visible = false;
                gridView.Columns[16].Visible = false;
                gridView.Columns[17].Visible = false;
                //  gridView.Columns[18].Visible = false;

                gridView.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                gridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

