using DatVentas;
using EntVenta;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Reporting.Processing;
using Telerik.ReportViewer.WinForms;

namespace BusVenta.Helpers
{
    public class Comun
    {
        public static void TextBoxNumerico(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public static void LimpiarTextBox(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is System.Windows.Forms.TextBox)
                    ((System.Windows.Forms.TextBox)ctrl).Text = string.Empty;
                LimpiarTextBox(ctrl.Controls);
            }

        }

        public static void FormatDatatable(ref DataGridView List)
        {
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            List.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            List.AllowUserToAddRows = false;

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

        public static void StyleDatatable(ref DataGridView List)
        {
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            //List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            List.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10);
            List.AllowUserToAddRows = false;

            List.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
            //styCabeceras.BackColor = System.Drawing.Color.;
            styCabeceras.ForeColor = System.Drawing.Color.Black;
            styCabeceras.Font = new System.Drawing.Font("Century Gothic", 10, System.Drawing.FontStyle.Bold);
            List.ColumnHeadersDefaultCellStyle = styCabeceras;
            List.ClearSelection();

            List.RowsDefaultCellStyle.BackColor = Color.Lavender;
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
        }

        private static string FormatoFolio(string numero, int cantidad)
        {
            string _numero = null;
            string _cantidadCeros = null;

            _numero = numero.Trim(' ');
            _cantidadCeros = "0";

            for (int i = 1; i <= cantidad; i++)
            {
                _cantidadCeros += "0";
            }

            return _cantidadCeros.Substring(0, cantidad - numero.Length) + numero;
        }

        public static string ObtenerFolio(DESTINO_DOCUMENTO destino, int idTipoNota)
        {
            string strFolio = "";
            try
            {
                //ConfiguracionFolio cn = NotaDAL.ObtenerFolio(tipoFolio, idTipoNota);
                var lst = DatSerializacion.ObtenerTipoDocumento(DESTINO_DOCUMENTO.VENTAS.ToString());
                var cn = lst.Where(x => x.Id == idTipoNota).FirstOrDefault();
                if (cn.NumeroFin == "0")
                {
                    cn.NumeroFin = "1";
                }
                string Folio = FormatoFolio(cn.NumeroFin.ToString(), Convert.ToInt32( cn.Cantidad_Numero));
                Folio = cn.Serie + "-" + Folio;
                strFolio = Folio;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el folio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return strFolio;
        }

        public static TIPO_DOCUMENTO ObtenerTipoDocumento(string tipo)
        {
            TIPO_DOCUMENTO DOCUMENTO = TIPO_DOCUMENTO.TICKET;
            try
            {
                switch (tipo.ToUpper())
                {
                    case "TICKET":
                        DOCUMENTO = TIPO_DOCUMENTO.TICKET;
                        break;
                    default:
                        DOCUMENTO = TIPO_DOCUMENTO.REPORTE;
                        break;
                }

            }
            catch (Exception)
            {
            }
            return DOCUMENTO;
        }

        public static bool ValidateMail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        }

    }
}
