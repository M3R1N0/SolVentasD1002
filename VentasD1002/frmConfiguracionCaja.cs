using DatVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasD1002
{
    public partial class frmConfiguracionCaja : Form
    {
        public frmConfiguracionCaja()
        {
            InitializeComponent();
        }

        private void frmConfiguracionCaja_Load(object sender, EventArgs e)
        {
            DibujarCaja();
        }

        private void DibujarCaja()
        {
            try
            {
                DataTable dt = new DatBox().ObtenerTipoCaja();

                foreach (DataRow item in dt.Rows)
                {
                    Panel p1 = new Panel();
                    Panel p2 = new Panel();
                    PictureBox pb1 = new PictureBox();
                    PictureBox pb2 = new PictureBox();
                    Label lbl1 = new Label();
                    Label lbl2 = new Label();
                    Label lbl3 = new Label();
                    Label lblUsuario = new Label();
                    Panel pnlTop = new Panel();
                    Panel pnlBottom = new Panel();
                    Panel pnlSide = new Panel();

                    lbl1.Text = item["Descripcion"].ToString();
                    lbl1.Name = item["Id_Caja"].ToString();
                    lbl1.Size = new System.Drawing.Size(175, 25);
                    lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20);
                    lbl1.BackColor = Color.Transparent;
                    lbl1.AutoSize = false;
                    lbl1.ForeColor = Color.Black;
                    lbl1.Dock = DockStyle.Fill;
                    lbl1.TextAlign = ContentAlignment.MiddleCenter;

                    lblUsuario.Text = item["Nombre"].ToString();
                    lblUsuario.Dock = DockStyle.Bottom;
                    lblUsuario.AutoSize = false;
                    lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
                    lblUsuario.BackColor = Color.Transparent;
                    lblUsuario.ForeColor = Color.Black;
                    lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
                    lblUsuario.Size = new System.Drawing.Size(430, 31);

                    pnlCPrincipal.Size = new System.Drawing.Size(210, 130);
                    pnlCPrincipal.BorderStyle = BorderStyle.None;
                    p1.BackColor = Color.Transparent;

                    p2.Size = new System.Drawing.Size(210, 30);
                    p2.Dock = DockStyle.Bottom;
                    p2.BackColor = Color.Transparent;

                    lbl2.Text = item["Estado"].ToString();
                    lbl2.Size = new System.Drawing.Size(210, 30);
                    lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
                    lbl1.BackColor = Color.Transparent;
                    lbl1.AutoSize = false;
                    lbl1.ForeColor = Color.Black;
                    lbl1.Dock = DockStyle.Fill;
                    lbl1.TextAlign = ContentAlignment.MiddleCenter;

                    p2.Controls.Add(lbl2);
                    p1.Controls.Add(p2);
                   // p1.Controls.Add(lbl1);
                    p1.Controls.Add(lblUsuario);
                    pnlCPrincipal.Controls.Add(p1);
                    lblUsuario.BringToFront();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar los datos : "+ex.Message, "Configuacion de caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
